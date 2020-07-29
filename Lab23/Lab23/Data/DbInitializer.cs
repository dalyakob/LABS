using System;
using System.Linq;
using Lab23.Models;

namespace Lab23.Data
{
    public static class DbInitializer
    {
        public static void Initialize(MovieContext context)
        {
            context.Database.EnsureCreated();
            if (!context.Movies.Any())
            {
                context.Movies.Add(new Movie() { Title = "Superman",  Genre = GenreType.Action, Runtime = 120.20});
                context.Movies.Add(new Movie() { Title = "Spiderman", Genre = GenreType.Action, Runtime = 116.35 });
                context.Movies.Add(new Movie() { Title = "Superbad", Genre = GenreType.Comedy, Runtime = 70.50});
                context.Movies.Add(new Movie() { Title = "Bad Cop", Genre = GenreType.Comedy, Runtime = 120.20 });
                context.Movies.Add(new Movie() { Title = "Idiocracy", Genre = GenreType.Comedy, Runtime = 90.02 });
                context.Movies.Add(new Movie() { Title = "IT", Genre = GenreType.Horror, Runtime = 95.30 });
                context.Movies.Add(new Movie() { Title = "WALL-E", Genre = GenreType.Drama, Runtime = 84.10 });
                context.Movies.Add(new Movie() { Title = "Shawshank Redemption", Genre = GenreType.Horror, Runtime = 105.14 });
                context.Movies.Add(new Movie() { Title = "1917", Genre = GenreType.Drama, Runtime =  115.58});
                context.Movies.Add(new Movie() { Title = "Joker", Genre = GenreType.Drama, Runtime =  85.45});
                context.Movies.Add(new Movie() { Title = "Extraction", Genre = GenreType.Action, Runtime = 140.12 });
                context.Movies.Add(new Movie() { Title = "Jumanji", Genre = GenreType.Comedy, Runtime =  80.23});
                context.Movies.Add(new Movie() { Title = "The Hangover", Genre = GenreType.Comedy, Runtime =  98.04});
                context.Movies.Add(new Movie() { Title = "Incidious", Genre = GenreType.Horror, Runtime =  130.23});
                context.Movies.Add(new Movie() { Title = "Midway", Genre = GenreType.Drama, Runtime =  111.04});
            }
            context.SaveChanges();
        }
    }
}
