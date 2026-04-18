using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Modul7
{
    internal class FilmFavorite_103022400068
    {
        public string title { get; set; }
        public string genre { get; set; }
        public string director { get; set; }
        public string year { get; set; }
        public int rating { get; set; }
        public int durationMinutes { get; set; }
        public bool isWatched { get; set; }

        public static void ReadJSON()
        {
            String file = File.ReadAllText("jurnal7_1_103022400068.json");
            FilmFavorite_103022400068 filmFavorite = JsonSerializer.Deserialize<FilmFavorite_103022400068>(file);
            Console.WriteLine($"Title: {filmFavorite.title} genre: {filmFavorite.genre}" +
                $" director: {filmFavorite.director} year: {filmFavorite.year} rating {filmFavorite.rating} duration: {filmFavorite.durationMinutes} minute " +
                $"iswatchet {filmFavorite.isWatched}");

        }
    }
}
