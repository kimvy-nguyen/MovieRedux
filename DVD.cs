using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRedux
{
    public class DVD : Movie
    {
        public DVD(string title, string category, int runTime)
        {
            this.Title = title;
            this.Category = category;
            this.RunTime = runTime;
            Scenes = new List<string>();
        }


        //Make a method for Print Info 
        //add scenes into a list that will be stored in each movie object




        public override void Play()
        {
            Console.WriteLine("Which scene would you like to watch?");
            foreach (string scene in Scenes)
            {
                Console.WriteLine(scene);
            }

            //input = Console.ReadLine(Convert.ToInt32());
            //code out for each scene an option for the user
        }
    }
}
