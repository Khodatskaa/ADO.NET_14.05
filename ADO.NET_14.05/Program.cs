using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_14._05
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var context = new GameContext())
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                var games = new[]
                {
                    new Game { Name = "Game 1", Studio = "Studio A", Style = "Style1", ReleaseDate = new DateTime(2020, 1, 1) },
                    new Game { Name = "Game 2", Studio = "Studio B", Style = "Style2", ReleaseDate = new DateTime(2021, 5, 20) },
                    new Game { Name = "Game 3", Studio = "Studio C", Style = "Style3", ReleaseDate = new DateTime(2019, 8, 15) }
                };

                context.Games.AddRange(games);
                context.SaveChanges();

                var allGames = context.Games.ToList();

                foreach (var game in allGames)
                {
                    Console.WriteLine($"Name: {game.Name}, Studio: {game.Studio}, Style: {game.Style}, Release Date: {game.ReleaseDate.ToShortDateString()}");
                }
            }
        }
    }
}
