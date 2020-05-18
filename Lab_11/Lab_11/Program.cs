using System;
using System.Collections.Generic;

namespace Lab_11
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var movie = new List<Movie>();
            Categories cat;

            movie.Add(new Movie("The Invisible Man", Categories.Horrors));                    //Horrors
            movie.Add(new Movie("It Chapter Two", Categories.Horrors));                       //
            movie.Add(new Movie("Spider-Man: Into the Spider-Verse", Categories.Animated));   //Cartoons       
            movie.Add(new Movie("Frozen II", Categories.Animated));                           //
            movie.Add(new Movie("Dirty Dancing", Categories.Dramas));                         //Dramas
            movie.Add(new Movie("10 Things I Hate About You", Categories.Dramas));            //
            movie.Add(new Movie("Friends With Benefits", Categories.Dramas));                 //
            movie.Add(new Movie("Doctor Strange", Categories.Scifi));                        //Scifi
            movie.Add(new Movie("The Martian", Categories.Scifi));                           //
            movie.Add(new Movie("The Predator", Categories.Scifi));                          //10 total movies
            
            Console.WriteLine("Welcome to David's the Movie List Application!\n");

            do
            {
                Console.WriteLine("There are 10 movies in this list.");

                bool valid;
                do
                {
                    Console.WriteLine("What category are you interested in? \n(1) Horrors \n(2) Cartoons\n(3) Dramas\n(4) Scifi");
                    
                }while (!Enum.TryParse(Console.ReadLine().Trim(), out cat));

                Console.WriteLine();
                foreach (var temp in movie)
                {
                    if (temp.Category == cat)
                        Console.WriteLine(temp.Title);
                }
                Console.WriteLine("\nWould you like to continue (y/n)");
            } while (Console.ReadLine().ToLower() == "y");
        }

    }
}
