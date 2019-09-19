using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRedux
{
    public class DVD : Movie
    {
        public void Play()
        {
            Console.WriteLine("Which scene would you like to watch?");
            foreach (string scene in Scenes)
            {
                Console.WriteLine(scene);
            }
            //code out for each scene an option for the user
        }
    }
}
