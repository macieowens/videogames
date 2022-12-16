using System;
using System.Collections.Generic;
using System.Linq;

namespace videogames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var games = new List<string>() { "tetris", "call of duty", "animal crossing", "vikings of vahalla", "stardew valley", "minecraft" };

            var sort = games.OrderBy(game => game);

            games.Sort();

            foreach(var game in sort)
            {
                Console.WriteLine(game);
            }
        }
    }
}
