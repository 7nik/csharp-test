using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessSimpleGameBookmaker
{
    class Program
    {
        static void Main(string[] args)
		{
			Console.WriteLine("Choose a desired source of data:\n1: Samples\n2: ADO.NET\n3: EntityFramwork");
			if (!int.TryParse(Console.ReadLine(), out int dataProviderNum) || dataProviderNum < 1 || dataProviderNum > 3)
			{
				Console.WriteLine("Wrong number!");
				Console.ReadLine();
				return;
			}
			IGameDataProvider dataProvider;
			try
			{
				switch (dataProviderNum)
				{
					case 1: dataProvider = new SampleDataProvider(); break;
					case 2: dataProvider = new AdoDataProvider(); break;
					case 3: dataProvider = new EntityDataProvider(); break;
					default: return;
				}
			}
			catch
			{
				Console.WriteLine("Failed to create a DataProvider, try later.");
				Console.ReadLine();
				return;
			}
			LessSimpleGameBookmaker bookmaker = new LessSimpleGameBookmaker(dataProvider);

			Console.WriteLine("List of available teams:");
			string[] teamNames = dataProvider.GetTeamNames();
			for (int i = 0; i < teamNames.Length; i++)
			{
				Console.WriteLine($"{i + 1} {teamNames[i]}");
			}
			Console.WriteLine();
			Console.WriteLine("Enter number of the home team: ");
			if (!int.TryParse(Console.ReadLine(), out int homeTeamNumber) || homeTeamNumber < 1 || homeTeamNumber >= teamNames.Length)
			{
				Console.WriteLine("Wrong number!");
				Console.ReadLine();
				return;
			}
			homeTeamNumber--;
			Console.WriteLine("Enter number of the away team: ");
			if (!int.TryParse(Console.ReadLine(), out int awayTeamNumber) || awayTeamNumber < 1 || awayTeamNumber >= teamNames.Length)
			{
				Console.WriteLine("Wrong number!");
				Console.ReadLine();
				return;
			}
			awayTeamNumber--;

			var odds = bookmaker.CalculatedOdds(teamNames[homeTeamNumber], teamNames[awayTeamNumber]);

			Console.WriteLine();
			//Console.WriteLine($"Match odds:\n{teamNames[homeTeamNumber]} at {win}\nDraw at {draw}\n{teamNames[awayTeamNumber]} at {lose}");
			Console.WriteLine("Match odds:\n{0} at {2:f2}\nDraw at {3:f2}\n{1} at {4:f2}", teamNames[homeTeamNumber], teamNames[awayTeamNumber], odds.Win, odds.Draw, odds.Lose);
			Console.ReadLine();
		}
    }
}
