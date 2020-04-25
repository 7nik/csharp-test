using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessSimpleGameBookmaker
{
    class SampleDataProvider : IGameDataProvider
	{
		public struct SimpleGameRecord
		{
			public string HomeTeamName;
			public string AwayTeamName;
			public int HomeTeamPoints;
			public int AwayTeamPoints;
			public DateTime GameDate;

			public SimpleGameRecord(string homeTeamName, string awayTeamName, int homeTeamPoints, int awayTeamPoints, DateTime gameDate)
			{
				HomeTeamName = homeTeamName;
				AwayTeamName = awayTeamName;
				HomeTeamPoints = homeTeamPoints;
				AwayTeamPoints = awayTeamPoints;
				GameDate = gameDate;
			}
		}

		private static SimpleGameRecord[] SampleRecords = {
			new SimpleGameRecord("Green-eyed taxi", "Young boys team", 0, 6, new DateTime(2000, 8, 1)),
			new SimpleGameRecord("Young boys team", "Tall dwarfs", 9, 11, new DateTime(2008, 1, 17)),
			new SimpleGameRecord("Underestimated Football Octopuses", "Sleepy reptiloids", 10, 1, new DateTime(2006, 1, 6)),
			new SimpleGameRecord("Sleepy reptiloids", "Underestimated Football Octopuses", 8, 11, new DateTime(2010, 7, 17)),
			new SimpleGameRecord("Old women-destroyers", "Clone troopers", 2, 1, new DateTime(2004, 2, 8)),
			new SimpleGameRecord("Clone troopers", "Ninjas of love", 0, 4, new DateTime(2002, 8, 2)),
			new SimpleGameRecord("Fuji-san & Co", "Trojan horse", 2, 2, new DateTime(2007, 3, 26)),
			new SimpleGameRecord("Old women-destroyers", "Clone troopers", 0, 0, new DateTime(2000, 1, 16)),
			new SimpleGameRecord("Green-eyed taxi", "Underestimated Football Octopuses", 6, 14, new DateTime(2010, 5, 8)),
			new SimpleGameRecord("Ninjas of love", "Sleepy reptiloids", 3, 8, new DateTime(2002, 7, 18)),
			new SimpleGameRecord("Green-eyed taxi", "Fuji-san & Co", 0, 10, new DateTime(2000, 1, 22)),
			new SimpleGameRecord("Green-eyed taxi", "Underestimated Football Octopuses", 3, 12, new DateTime(2001, 2, 24)),
			new SimpleGameRecord("Young boys team", "Clone troopers", 0, 8, new DateTime(2000, 12, 1)),
			new SimpleGameRecord("Tall dwarfs", "Fuji-san & Co", 6, 1, new DateTime(2001, 1, 17)),
			new SimpleGameRecord("Ninjas of love", "Green-eyed taxi", 4, 0, new DateTime(2006, 3, 6)),
			new SimpleGameRecord("Sleepy reptiloids", "Fuji-san & Co", 12, 5, new DateTime(2000, 9, 11)),
			new SimpleGameRecord("Green-eyed taxi", "Sleepy reptiloids", 0, 1, new DateTime(2004, 4, 1)),
			new SimpleGameRecord("Ninjas of love", "Green-eyed taxi", 6, 3, new DateTime(2001, 8, 4)),
			new SimpleGameRecord("Ninjas of love", "Trojan horse", 6, 2, new DateTime(2002, 1, 19)),
			new SimpleGameRecord("Clone troopers", "Trojan horse", 13, 2, new DateTime(2002, 11, 4)),
			new SimpleGameRecord("Clone troopers", "Trojan horse", 3, 7, new DateTime(2001, 6, 1)),
			new SimpleGameRecord("Old women-destroyers", "Underestimated Football Octopuses", 5, 7, new DateTime(2000, 12, 3)),
			new SimpleGameRecord("Trojan horse", "Clone troopers", 10, 1, new DateTime(2009, 11, 18)),
			new SimpleGameRecord("Tall dwarfs", "Old women-destroyers", 1, 5, new DateTime(2001, 10, 9)),
			new SimpleGameRecord("Old women-destroyers", "Underestimated Football Octopuses", 9, 6, new DateTime(2016, 4, 5)),
			new SimpleGameRecord("Underestimated Football Octopuses", "Ninjas of love", 12, 10, new DateTime(2000, 7, 3)),
			new SimpleGameRecord("Fuji-san & Co", "Tall dwarfs", 12, 1, new DateTime(2000, 7, 1)),
			new SimpleGameRecord("Green-eyed taxi", "Clone troopers", 6, 6, new DateTime(2001, 3, 19)),
			new SimpleGameRecord("Ninjas of love", "Sleepy reptiloids", 14, 4, new DateTime(2001, 5, 25)),
			new SimpleGameRecord("Ninjas of love", "Sleepy reptiloids", 2, 4, new DateTime(2000, 7, 2)),
			new SimpleGameRecord("Old women-destroyers", "Clone troopers", 8, 5, new DateTime(2017, 3, 22)),
			new SimpleGameRecord("Old women-destroyers", "Tall dwarfs", 10, 6, new DateTime(2014, 3, 13)),
			new SimpleGameRecord("Green-eyed taxi", "Old women-destroyers", 0, 3, new DateTime(2000, 1, 1)),
			new SimpleGameRecord("Fuji-san & Co", "Clone troopers", 6, 1, new DateTime(2000, 8, 8)),
			new SimpleGameRecord("Trojan horse", "Green-eyed taxi", 4, 4, new DateTime(2003, 8, 1)),
			new SimpleGameRecord("Green-eyed taxi", "Trojan horse", 5, 7, new DateTime(2005, 1, 20)),
			new SimpleGameRecord("Tall dwarfs", "Fuji-san & Co", 2, 4, new DateTime(2016, 9, 16)),
			new SimpleGameRecord("Clone troopers", "Tall dwarfs", 12, 12, new DateTime(2000, 4, 23)),
			new SimpleGameRecord("Clone troopers", "Young boys team", 4, 10, new DateTime(2016, 7, 2)),
			new SimpleGameRecord("Sleepy reptiloids", "Underestimated Football Octopuses", 0, 1, new DateTime(2003, 8, 2)),
			new SimpleGameRecord("Old women-destroyers", "Sleepy reptiloids", 14, 11, new DateTime(2000, 9, 13)),
			new SimpleGameRecord("Underestimated Football Octopuses", "Tall dwarfs", 2, 3, new DateTime(2006, 1, 3)),
			new SimpleGameRecord("Green-eyed taxi", "Old women-destroyers", 1, 6, new DateTime(2013, 1, 25)),
			new SimpleGameRecord("Trojan horse", "Fuji-san & Co", 12, 3, new DateTime(2000, 2, 19)),
			new SimpleGameRecord("Underestimated Football Octopuses", "Young boys team", 4, 0, new DateTime(2016, 2, 7)),
			new SimpleGameRecord("Young boys team", "Fuji-san & Co", 9, 0, new DateTime(2000, 4, 2)),
			new SimpleGameRecord("Sleepy reptiloids", "Old women-destroyers", 13, 2, new DateTime(2011, 1, 13)),
			new SimpleGameRecord("Sleepy reptiloids", "Tall dwarfs", 3, 3, new DateTime(2000, 1, 1)),
			new SimpleGameRecord("Young boys team", "Clone troopers", 11, 8, new DateTime(2016, 11, 23)),
			new SimpleGameRecord("Trojan horse", "Clone troopers", 5, 1, new DateTime(2004, 1, 27)),
			new SimpleGameRecord("Tall dwarfs", "Old women-destroyers", 4, 11, new DateTime(2014, 2, 16)),
			new SimpleGameRecord("Clone troopers", "Old women-destroyers", 5, 1, new DateTime(2016, 10, 9)),
			new SimpleGameRecord("Tall dwarfs", "Fuji-san & Co", 1, 8, new DateTime(2000, 3, 19)),
			new SimpleGameRecord("Sleepy reptiloids", "Old women-destroyers", 0, 9, new DateTime(2006, 5, 1)),
			new SimpleGameRecord("Fuji-san & Co", "Sleepy reptiloids", 5, 2, new DateTime(2001, 1, 2)),
			new SimpleGameRecord("Green-eyed taxi", "Tall dwarfs", 7, 10, new DateTime(2004, 2, 1)),
			new SimpleGameRecord("Old women-destroyers", "Sleepy reptiloids", 0, 10, new DateTime(2000, 10, 1)),
			new SimpleGameRecord("Young boys team", "Green-eyed taxi", 0, 13, new DateTime(2007, 1, 9)),
			new SimpleGameRecord("Fuji-san & Co", "Young boys team", 9, 0, new DateTime(2002, 3, 8)),
			new SimpleGameRecord("Green-eyed taxi", "Clone troopers", 5, 0, new DateTime(2006, 5, 2)),
			new SimpleGameRecord("Sleepy reptiloids", "Fuji-san & Co", 4, 7, new DateTime(2011, 1, 21)),
			new SimpleGameRecord("Underestimated Football Octopuses", "Green-eyed taxi", 6, 4, new DateTime(2000, 4, 10)),
			new SimpleGameRecord("Old women-destroyers", "Clone troopers", 4, 1, new DateTime(2001, 5, 1)),
			new SimpleGameRecord("Sleepy reptiloids", "Old women-destroyers", 4, 2, new DateTime(2000, 1, 7)),
			new SimpleGameRecord("Trojan horse", "Clone troopers", 12, 4, new DateTime(2000, 2, 8)),
			new SimpleGameRecord("Sleepy reptiloids", "Underestimated Football Octopuses", 8, 4, new DateTime(2014, 10, 5)),
			new SimpleGameRecord("Tall dwarfs", "Sleepy reptiloids", 8, 7, new DateTime(2004, 1, 1)),
			new SimpleGameRecord("Clone troopers", "Green-eyed taxi", 7, 4, new DateTime(2013, 12, 13)),
			new SimpleGameRecord("Underestimated Football Octopuses", "Ninjas of love", 0, 1, new DateTime(2000, 5, 7)),
			new SimpleGameRecord("Sleepy reptiloids", "Tall dwarfs", 13, 9, new DateTime(2000, 2, 16)),
			new SimpleGameRecord("Green-eyed taxi", "Clone troopers", 2, 3, new DateTime(2006, 4, 13)),
			new SimpleGameRecord("Clone troopers", "Sleepy reptiloids", 10, 3, new DateTime(2016, 9, 28)),
			new SimpleGameRecord("Clone troopers", "Old women-destroyers", 4, 8, new DateTime(2000, 2, 14)),
			new SimpleGameRecord("Tall dwarfs", "Underestimated Football Octopuses", 0, 7, new DateTime(2014, 9, 13)),
			new SimpleGameRecord("Fuji-san & Co", "Tall dwarfs", 1, 0, new DateTime(2008, 6, 1)),
			new SimpleGameRecord("Clone troopers", "Fuji-san & Co", 2, 10, new DateTime(2019, 9, 3)),
			new SimpleGameRecord("Old women-destroyers", "Green-eyed taxi", 11, 2, new DateTime(2009, 1, 5)),
			new SimpleGameRecord("Underestimated Football Octopuses", "Ninjas of love", 4, 2, new DateTime(2000, 2, 13)),
			new SimpleGameRecord("Trojan horse", "Fuji-san & Co", 5, 0, new DateTime(2000, 1, 1)),
			new SimpleGameRecord("Green-eyed taxi", "Sleepy reptiloids", 4, 4, new DateTime(2015, 2, 5)),
			new SimpleGameRecord("Green-eyed taxi", "Fuji-san & Co", 0, 0, new DateTime(2000, 12, 1)),
			new SimpleGameRecord("Tall dwarfs", "Young boys team", 5, 9, new DateTime(2002, 4, 12)),
			new SimpleGameRecord("Underestimated Football Octopuses", "Old women-destroyers", 2, 5, new DateTime(2003, 2, 4)),
			new SimpleGameRecord("Ninjas of love", "Young boys team", 0, 1, new DateTime(2012, 6, 17)),
			new SimpleGameRecord("Green-eyed taxi", "Underestimated Football Octopuses", 6, 5, new DateTime(2013, 9, 4)),
			new SimpleGameRecord("Trojan horse", "Fuji-san & Co", 10, 5, new DateTime(2009, 5, 3)),
			new SimpleGameRecord("Old women-destroyers", "Fuji-san & Co", 14, 4, new DateTime(2002, 1, 9)),
			new SimpleGameRecord("Sleepy reptiloids", "Old women-destroyers", 3, 1, new DateTime(2001, 5, 1)),
			new SimpleGameRecord("Sleepy reptiloids", "Old women-destroyers", 3, 11, new DateTime(2006, 12, 1)),
			new SimpleGameRecord("Trojan horse", "Underestimated Football Octopuses", 2, 0, new DateTime(2008, 9, 15)),
			new SimpleGameRecord("Sleepy reptiloids", "Green-eyed taxi", 2, 0, new DateTime(2000, 3, 16)),
			new SimpleGameRecord("Ninjas of love", "Fuji-san & Co", 14, 13, new DateTime(2011, 5, 1)),
			new SimpleGameRecord("Fuji-san & Co", "Clone troopers", 1, 0, new DateTime(2003, 1, 22)),
			new SimpleGameRecord("Sleepy reptiloids", "Young boys team", 2, 2, new DateTime(2012, 3, 2)),
			new SimpleGameRecord("Underestimated Football Octopuses", "Old women-destroyers", 7, 9, new DateTime(2004, 2, 1)),
			new SimpleGameRecord("Old women-destroyers", "Young boys team", 0, 5, new DateTime(2002, 7, 8)),
			new SimpleGameRecord("Green-eyed taxi", "Young boys team", 0, 2, new DateTime(2010, 7, 6)),
			new SimpleGameRecord("Ninjas of love", "Clone troopers", 12, 5, new DateTime(2000, 10, 23)),
			new SimpleGameRecord("Clone troopers", "Green-eyed taxi", 6, 8, new DateTime(2005, 1, 20)),
			new SimpleGameRecord("Green-eyed taxi", "Tall dwarfs", 0, 3, new DateTime(2006, 6, 23))
		};

		public SimpleGameRecord[] GetLastGamesOfTeam(string teamName, int count)
		{
			return SampleRecords
				.Where(rec => rec.HomeTeamName == teamName || rec.AwayTeamName == teamName)
				.OrderByDescending(rec => rec.GameDate)
				.Take(count)
				.ToArray();
		}

        public GameStats GetStatsOfTeam(string teamName, int gameCount)
		{
			return GetLastGamesOfTeam(teamName, gameCount).Aggregate(new GameStats(0, 0, 0), (stats, rec) => {
				if (rec.HomeTeamPoints == rec.AwayTeamPoints)
				{
					stats.Drawn++;
				}
				else if (
					   rec.HomeTeamName == teamName && rec.HomeTeamPoints > rec.AwayTeamPoints
					|| rec.AwayTeamName == teamName && rec.HomeTeamPoints < rec.AwayTeamPoints
				)
				{
					stats.Won++;
				}
				else
				{
					stats.Lost++;
				}
				return stats;
			});
		}

        public string[] GetTeamNames()
		{
			return SampleRecords
				.Select(rec => rec.HomeTeamName)
				.Concat(SampleRecords.Select(rec => rec.AwayTeamName))
				.Distinct()
				.OrderBy(name => name)
				.ToArray();
		}
    }
}
