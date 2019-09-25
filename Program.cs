using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRedux
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to GC Blockbuster! West Michigan's most sustainable business.");
            Console.WriteLine("Please select a Movie from the list:");

            Blockbuster block = new Blockbuster();
            block.CheckOut();

            Console.WriteLine("Watch another scene?");
            string userinfo = Console.ReadLine().Trim().ToLower();
            if (userinfo == "y")
            {
                block.CheckOut();
            }
            else if(userinfo == "n")
            {
                Console.WriteLine("Bye!");
            }
            else
            {
                Console.WriteLine("Bye!");
            }

            // Movie movie = new DVD();
            //movie.PrintScenes();
            // Console.ReadLine();
            //Movie.Play();
        }
    }
}
