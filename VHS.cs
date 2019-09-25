using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRedux
{
    public class VHS : Movie
    {
        public int CurrentTime { get; set; }

        public VHS(string title, string category, int runTime, int CurrentTime/*, string[] Scenes*/)
        {
            this.Title = title;
            this.Category = category;
            this.RunTime = runTime;
            this.CurrentTime = CurrentTime;
            //this.Scenes = Scenes;
            
        }

       

        



        public override void Play()
        {
            this.CurrentTime = CurrentTime;
            for(int i = CurrentTime; i < RunTime; i++)
            {
                CurrentTime++;
            }
            //plays scene at current time and then increments current time

        }

        public void Rewind()
        {
            CurrentTime = 0;
        }


    }
}