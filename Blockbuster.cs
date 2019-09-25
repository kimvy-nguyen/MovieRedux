using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRedux
{
    public class Blockbuster
    {
        public Blockbuster()
        {
        }

        public void PrintMovies()
        {
            List<Movie> Movies = new List<Movie>();

            Movies.Add(new DVD("Up", "Children's Movies", 85));
            Movies.Add(new DVD("Superhero Something", "Action & Suspense", 120));
            Movies.Add(new DVD("The Conjuring", "Horror", 78));
            Movies.Add(new VHS("Chucky", "Horror", 120, 0));
            Movies.Add(new VHS("Puppy Pet Tales", "Children's Movies", 130, 0));
            Movies.Add(new VHS("Fight Club", "Action & Suspense", 100, 0));
            for (int i = 0; i < Movies.Count; i++)
            {

                Console.WriteLine($"{i + 1}. " + Movies[i].Title);
            }



        }



       public void CheckOut()
        {
            List<Movie> Movies = new List<Movie>();
            Movies.Add(new DVD("Up", "Children's Movies", 85));
            /*DVD Up = new DVD("Up", "Children's Movies", 85);
            (Up.Scenes).AddRange( "hakunamatata", "test", "ok");
            DVD Superhero = new DVD("Superhero Something", "Action & Suspense", 120);
            (Superhero.Scenes).Add("")*/
            Movies.Add(new DVD("Superhero Something", "Action & Suspense", 120));
            Movies.Add(new DVD("The Conjuring", "Horror", 78));
            Movies.Add(new VHS("Chucky", "Horror", 120, 0));
            Movies.Add(new VHS("Puppy Pet Tales", "Children's Movies", 130, 0));
            Movies.Add(new VHS("Fight Club", "Action & Suspense", 100, 0));
            PrintMovies();

            Console.WriteLine("Please select a movie you want to watch:");
            int input = Convert.ToInt32(Console.ReadLine());
            Movies[input-1].PrintInfo();

            // new DVD { "Superhero Something", "Action & Suspense", 120, "Backstory, Love Interest, The Final Fight" }
            /* Movies.Add(new DVD("The Conjuring", "Horror", 78, "The New House, The Guests, The Exorcism"));
             Movies.Add(new VHS("Chucky", "Horror", 120, "The Needles, The Wife, The Acid"));
             Movies.Add(new VHS("Puppy Pet Tales", "Children's Movies", 130, "Meet Molly, Saving Ben, Solve the Mystery"));
             Movies.Add(new VHS("Fight Club", "Action & Suspense", 100, "Brad Pritt, Edward Norton, Can You Tell I Haven't Seen It?"));*/
            if (input ==1)
            {
                Console.WriteLine("Do you want to watch the movie? Y/N");

                string input2 = Console.ReadLine().Trim().ToLower();
                if (input2 == "y")
                {
                    Console.WriteLine("Which scene of the DVD 'Up' would you like to watch? Select 1-5.");
                    int userinput = Convert.ToInt32(Console.ReadLine());
                    if (userinput == 1) { Console.WriteLine("Scene 1: The Cute Part"); }
                    else if(userinput == 2) { Console.WriteLine("Scene 2: The Sad Part"); }
                    else if(userinput == 3) { Console.WriteLine("Scene 3: Doug the Dog"); }
                    else if(userinput ==4) { Console.WriteLine("Scene 4: The Happy Part"); }
                    else if(userinput == 5) { Console.WriteLine("Scene 5: The House on The Hill"); }

                }
                else
                {
                    CheckOut();
                }
            }
            else if (input == 2)
            {
                Console.WriteLine("Do you want to watch the movie? Y/N");

                string input2 = Console.ReadLine().Trim().ToLower();
                if (input2 == "y")
                {
                    Console.WriteLine("Which scene of the DVD 'Superhero Something' would you like to watch? Select 1-5.");
                    int userinput = Convert.ToInt32(Console.ReadLine());
                    if (userinput == 1) { Console.WriteLine("Scene 1: The Backstory"); }
                    else if (userinput == 2) { Console.WriteLine("Scene 2: The Toxic Waste Contamination"); }
                    else if (userinput == 3) { Console.WriteLine("Scene 3: The Superpowers"); }
                    else if (userinput == 4) { Console.WriteLine("Scene 4: The Villain"); }
                    else if (userinput == 5) { Console.WriteLine("Scene 5: The Final Fight"); }

                }
                else
                {
                    CheckOut();
                }
            }
            else if (input == 3)
            {
                Console.WriteLine("Do you want to watch the movie? Y/N");

                string input2 = Console.ReadLine().Trim().ToLower();
                if (input2 == "y")
                {
                    Console.WriteLine("Which scene of the DVD 'The Conjuring' would you like to watch? Select 1-5.");
                    int userinput = Convert.ToInt32(Console.ReadLine());
                    if (userinput == 1) { Console.WriteLine("Scene 1: The New House"); }
                    else if (userinput == 2) { Console.WriteLine("Scene 2: The Old Guests"); }
                    else if (userinput == 3) { Console.WriteLine("Scene 3: The Bassinet"); }
                    else if (userinput == 4) { Console.WriteLine("Scene 4: The Nanny Cam"); }
                    else if (userinput == 5) { Console.WriteLine("Scene 5: The Exorcism"); }

                }
                else
                {
                    CheckOut();
                }
            }
            else if (input ==4)
            {
                Console.WriteLine("Do you want to watch the movie? Y/N");

                string input2 = Console.ReadLine().Trim().ToLower();
                if (input2 == "y")
                {
                    Console.WriteLine("Which scene of the VHS 'Chucky' would you like to watch? Select 1-5.");
                    int userinput = Convert.ToInt32(Console.ReadLine());
                    if (userinput == 1) { Console.WriteLine("Scene 1: The New House"); }
                    else if (userinput == 2) { Console.WriteLine("Scene 2: The Attic"); }
                    else if (userinput == 3) { Console.WriteLine("Scene 3: The Needles"); }
                    else if (userinput == 4) { Console.WriteLine("Scene 4: The Acid"); }
                    else if (userinput == 5) { Console.WriteLine("Scene 5: The Reincarnation"); }

                }
                else
                {
                    CheckOut();
                }
            }
            else if (input == 5)
            {
                Console.WriteLine("Do you want to watch the movie? Y/N");

                string input2 = Console.ReadLine().Trim().ToLower();
                if (input2 == "y")
                {
                    Console.WriteLine("Which scene of the VHS 'Puppy Pet Tales' would you like to watch? Select 1-5.");
                    int userinput = Convert.ToInt32(Console.ReadLine());
                    if (userinput == 1) { Console.WriteLine("Scene 1: Meet Molly"); }
                    else if (userinput == 2) { Console.WriteLine("Scene 2: A Sweet Surprise"); }
                    else if (userinput == 3) { Console.WriteLine("Scene 3: Hopscotch with Holly"); }
                    else if (userinput == 4) { Console.WriteLine("Scene 4: Solve the Problem"); }
                    else if (userinput == 5) { Console.WriteLine("Scene 5: Pizza Party!"); }

                }
                else
                {
                    CheckOut();
                }
            }
            else if (input ==6)
            {
                Console.WriteLine("Do you want to watch the movie? Y/N");

                string input2 = Console.ReadLine().Trim().ToLower();
                if (input2 == "y")
                {
                    Console.WriteLine("Which scene of the VHS 'Fight Club' would you like to watch? Select 1-5.");
                    int userinput = Convert.ToInt32(Console.ReadLine());
                    if (userinput == 1) { Console.WriteLine("Scene 1: Something about Edward Norton"); }
                    else if (userinput == 2) { Console.WriteLine("Scene 2: Brad Pitt?"); }
                    else if (userinput == 3) { Console.WriteLine("Scene 3: Punch Punch"); }
                    else if (userinput == 4) { Console.WriteLine("Scene 4: Ponch Ponch"); }
                    else if (userinput == 5) { Console.WriteLine("Scene 5: Finish Him"); }

                }
                else
                {
                    CheckOut();
                }
            }
            else
            {
                Console.WriteLine("Sorry, that input is invalid.");
                    CheckOut();
            }
            





        }
    } 
}
