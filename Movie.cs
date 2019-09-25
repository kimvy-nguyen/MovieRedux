using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRedux
{
    public abstract class Movie
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public int RunTime { get; set; }
        public List<string> Scenes { get; set; }


        
        public override string ToString()
        {
            return $"{Title}  {Category} {RunTime}";
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine(this);
        }
        public void PrintScenes()
        {
            //List<string> Scenes = new List<string>();
            foreach (string scene in Scenes)
            {
                for(int i = 0; i <Scenes.Count; i++)
                {
                    Console.WriteLine($"{i}.");
                    //eventually increment index to align w user input starting @1
                }

                Console.Write(scene);
            }
        }

        public abstract void Play();
        
         
        

    }
}
