using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessSimpleGameBookmaker
{
    class EntityDataProvider : IGameDataProvider
    {
        private csharp_testEntities context;

        public EntityDataProvider()
        {
            context = new csharp_testEntities();
        }

        public GameStats GetStatsOfTeam(string teamName, int gameCount)
        {
            GameStats stats = new GameStats(0, 0, 0);
            Team team = context.Teams.FirstOrDefault(t => t.Name == teamName);
            var games = team.HomeGames
                .Concat(team.AwayGames)
                .OrderByDescending(game => game.Date)
                .Take(gameCount);
            foreach (var game in games)
            {
                if (game.HomeTeamScore == game.AwayTeamScore)
                {
                    stats.Drawn++;
                }
                else if (game.HomeTeamScore > game.AwayTeamScore && game.HomeTeam == team
                      || game.AwayTeamScore > game.HomeTeamScore && game.AwayTeam == team)
                {
                    stats.Won++;
                }
                else
                {
                    stats.Lost++;
                }
            }
            return stats;
        }

        public string[] GetTeamNames()
        {
            return context.Teams
                .Select(team => team.Name)
                .OrderBy(name => name)
                .ToArray();
        }
    }
}
