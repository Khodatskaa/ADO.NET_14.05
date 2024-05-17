using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_14._05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ChampionshipContext())
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                var standings = new[]
                {
                    new ChampionshipModel { CommandName = "Team A", TeamCity = "City A", NumberOfVictories = 10, NumberOfLesions = 5, NumberOfDraws = 3 },
                    new ChampionshipModel { CommandName = "Team B", TeamCity = "City B", NumberOfVictories = 8, NumberOfLesions = 7, NumberOfDraws = 3 },
                    new ChampionshipModel { CommandName = "Team C", TeamCity = "City C", NumberOfVictories = 12, NumberOfLesions = 4, NumberOfDraws = 2 }
                };

                context.Standings.AddRange(standings);
                context.SaveChanges();

                var allStandings = context.Standings.ToList();

                foreach (var standing in allStandings)
                {
                    Console.WriteLine($"Command: {standing.CommandName}, City: {standing.TeamCity}, Victories: {standing.NumberOfVictories}, Lesions: {standing.NumberOfLesions}, Draws: {standing.NumberOfDraws}");
                }
            }
        }
    }
}
