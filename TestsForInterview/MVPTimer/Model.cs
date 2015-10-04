using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPTimer
{
    class Model
    {
        public System.Diagnostics.Stopwatch watch;

        public Model()
        {
            watch = new System.Diagnostics.Stopwatch();
        }
        public TimeSpan GetSpentTime()
        {
            return watch.Elapsed;
        }
        public void StartWatch()
        {
            this.watch.Start();
            
        }
        public void StopWatch()
        {
            this.watch.Stop();
        }
        public void ResetWatch()
        {
            this.watch.Reset();
        }
    }
}
