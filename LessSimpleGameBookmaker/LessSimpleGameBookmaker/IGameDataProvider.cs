using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessSimpleGameBookmaker
{
    public struct GameStats
    {
        public int Won;
        public int Drawn;
        public int Lost;
        public int Total => Won + Drawn + Lost;

        public GameStats(int won, int drawn, int lost)
        {
            this.Won = won;
            this.Drawn = drawn;
            this.Lost = lost;
        }
    }

    interface IGameDataProvider
    {
        string[] GetTeamNames();

        GameStats GetStatsOfTeam(string teamName, int gameCount);


    }
}
