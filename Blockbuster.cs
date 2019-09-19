using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRedux
{
    public class Blockbuster
    {
        public List<Movie> GetMovies(List<Movie> Movies)
        {
            
            Movies.Add(new DVD("Up", "Children's Movies", 85, "The Cute Part,The Sad Part,The Happy Part"));
            Movies.Add(new DVD("Superhero Something", "Action & Suspense", 120, "Backstory, Love Interest, The Final Fight"));
            Movies.Add(new DVD("The Conjuring", "Horror", 78, "The New House, The Guests, The Exorcism"));
            Movies.Add(new VHS("Chucky", "Horror", 120, "The Needles, The Wife, The Acid"));
            Movies.Add(new VHS("Puppy Pet Tales", "Children's Movies", 130, "Meet Molly, Saving Ben, Solve the Mystery"));
            Movies.Add(new VHS("Fight Club", "Action & Suspense", 100, "Brad Pritt, Edward Norton, Can You Tell I Haven't Seen It?"));
            return Movies;
        }

        public void PrintMovies()
        {
            for (int i = 0; i < Movies.Count; i++)
            {

                Console.WriteLine($"{i + 1}. " + Movies[i]);
            }



        }
        public void CheckOut()
        {
            PrintMovies();
            Console.WriteLine("Which movie would you like to checkout?");
            int input = Console.ReadLine(Convert.ToInt16());

            Movie.PrintInfo(Movies[input]);

        }
    } 
}
