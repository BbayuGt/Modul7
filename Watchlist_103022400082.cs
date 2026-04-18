using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Modul7
{
    internal class Watchlist_103022400082
    {
        public string watchlistName { get; set; }

        public string createdBy { get; set; }

        public Movie[] movies { get; set; }
        public static void ReadJSON()
        {
            String file = File.ReadAllText("jurnal7_2_103022400082.json");
            Watchlist_103022400082 watchlist = JsonSerializer.Deserialize<Watchlist_103022400082>(file);

            Console.WriteLine($"Watchlist name : {watchlist.watchlistName}" );
            Console.WriteLine($"Created by : {watchlist.createdBy}");

            foreach (var item in watchlist.movies)
            {
                Console.WriteLine($"{item.id} {item.title} ({item.year} - {item.rating})");
            }

        }
    }
    internal class Movie
    {
        public string id { get; set; }
        public string title { get; set; }
        public int year { get; set; }
        public string genre { get; set; }
        public float rating { get; set; }
    }
}
