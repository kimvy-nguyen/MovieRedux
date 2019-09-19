using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRedux
{
    abstract class Movie
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public int RunTime { get; set; }
        public List<string> Scenes { get; set; }
        
        
        public Movie(string title, string category, int runTime, List<string> scenes)
        {
            this.Title = title;
            this.Category = category;
            this.RunTime = runTime;
            this.Scenes = scenes;
        }
        public override string ToString()
        {
            return $"{Title}  {Category} {RunTime}";
        }
        public virtual string PrintInfo() { 

        
        foreach(string scene in Scenes)
            {
            Console.WriteLine(scene);
            
                }
        

    }
        public virtual string PrintScenes()
        {
            List<string> Scenes = new List<string>();
            foreach (string scene in Scenes)
            {
                Console.WriteLine(scene);
            }
        }

        public abstract void Play()
        {
            //fill
        }

        internal static void PrintInfo(object p)
        {
            throw new NotImplementedException();
        }
    }
