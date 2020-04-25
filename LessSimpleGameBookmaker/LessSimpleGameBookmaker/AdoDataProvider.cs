using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessSimpleGameBookmaker
{
    class AdoDataProvider : IGameDataProvider, IDisposable
    {
        private IDbConnection connection;

        public AdoDataProvider()
        {
            connection = new MySql.Data.MySqlClient.MySqlConnection
            {
                ConnectionString = "server=db4free.net;uid=sevenik;pwd=7nik7nik;database=csharp_test;old guids=true;"
            };
            connection.Open();
        }

        public void Dispose()
        {
            connection.Dispose();
        }
        
        public GameStats GetStatsOfTeam(string teamName, int gameCount)
        {
            GameStats stats = new GameStats(0, 0, 0);

            string query =
                $"SELECT `Home_team_score`, `Away_team_score`,  `Teams`.`ID`^`Home_team_id` " +
                $"FROM `Games` INNER JOIN `Teams` " +
                $"ON `Games`.`Home_team_id` = `Teams`.`ID` OR `Games`.`Away_team_id` = `Teams`.`ID`" +
                $"WHERE `Teams`.`Name` = \"{teamName}\" " +
                $"ORDER BY `Games`.`Date` DESC " +
                $"LIMIT {gameCount}";
            IDbCommand command = new MySql.Data.MySqlClient.MySqlCommand(query);
            command.Connection = connection;

            IDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int homeScore = reader.GetInt32(0);
                int awayScore = reader.GetInt32(1);
                bool isHomeGame = reader.GetInt32(2) == 0;
                if (homeScore == awayScore)
                {
                    stats.Drawn++;
                } else if (homeScore > awayScore && isHomeGame 
                        || awayScore > homeScore && !isHomeGame)  
                {
                    stats.Won++;
                } else
                {
                    stats.Lost++;
                }
            }
            reader.Close();

            return stats;
        }

        public string[] GetTeamNames()
        {
            List<string> teamNames = new List<string>();

            string query = "SELECT `Name` FROM `Teams` ORDER BY `Name`";
            IDbCommand command = new MySql.Data.MySqlClient.MySqlCommand(query);
            command.Connection = connection;

            IDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                try
                {
                    teamNames.Add(reader.GetString(0));
                }
                catch
                {
                    Console.WriteLine("Failed to read data");
                }
            }
            reader.Close();

            return teamNames.ToArray();
        }
    }
}
