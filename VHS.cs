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

        public VHS(string title, string category, int runTime, List<string> scenes, int CurrentTime)
        {
            this.Title = title;
            this.Category = category;
            this.RunTime = runTime;
            this.Scenes = scenes;
            this.CurrentTime = CurrentTime;
        }
        public override void Play()
        {
            //plays scene at current time and then increments current time
        }

        public void Rewind()
        {
            CurrentTime = 0;
        }


    }
}