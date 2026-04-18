using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Modul7
{
    internal class GenreDictionary_103022400040
    {
        
        public isi GenreDictionary { get; set; }
        public static void ReadJSON()
        {
            String file = File.ReadAllText("jurnal7_3_103022400040.json");
            GenreDictionary_103022400040 Genre = JsonSerializer.Deserialize<GenreDictionary_103022400040>(file);
            Console.WriteLine($"id: {Genre.GenreDictionary.GenreInfo.id}");
            Console.WriteLine($"name: {Genre.GenreDictionary.GenreInfo.name}");
            Console.WriteLine($"description: {Genre.GenreDictionary.GenreInfo.description}");
            Console.Write("popularMovies:");
        
            foreach (string movie in Genre.GenreDictionary.GenreInfo.popularMovies)
            {
                Console.Write($"- {movie}");
            }

        }
    }
    internal class isi {
        public string category { get; set; }

        public GenreInfo GenreInfo { get; set; }
    }
    internal class GenreInfo {
        public string id { get; set; }
        public string name { get; set; }

        public string description { get; set; }

        public string[] popularMovies { get; set; }
    }
}
