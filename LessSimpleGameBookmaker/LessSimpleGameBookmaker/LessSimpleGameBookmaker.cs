using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessSimpleGameBookmaker
{
    public struct GameOdds
    {
        public double Win;
        public double Draw;
        public double Lose;
    }

    class LessSimpleGameBookmaker
    {
        private IGameDataProvider GameDataProvider;

        public LessSimpleGameBookmaker(IGameDataProvider gameDataProvider)
        {
            GameDataProvider = gameDataProvider;
        }

        public GameOdds CalculatedOdds(string homeTeamName, string awayTeamName)
        {
            var homeTeamStats = GameDataProvider.GetStatsOfTeam(homeTeamName, 15);
            var awayTeamStats = GameDataProvider.GetStatsOfTeam(awayTeamName, 15);
            double totalGames = homeTeamStats.Total + awayTeamStats.Total;

            return new GameOdds {
                Win = totalGames / (homeTeamStats.Won + awayTeamStats.Lost),
				Draw = totalGames / (homeTeamStats.Drawn + awayTeamStats.Drawn),
				Lose = totalGames / (homeTeamStats.Lost + awayTeamStats.Won)
            };
		}
	}
}
