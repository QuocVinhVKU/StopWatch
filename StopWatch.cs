using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch
{
    public class StopWatch
    {
        private DateTime startTime;
        private DateTime endTime;

        public DateTime StartTime
        {
            get { return startTime; }
        }

        public DateTime EndTime
        {
            get { return endTime; }
        }

        public StopWatch()
        {
            startTime = DateTime.Now;
            endTime = startTime;
        }

        public void Start()
        {
            startTime = DateTime.Now;
        }

        public void Stop()
        {
            endTime = DateTime.Now;
        }

        public int GetElapsedTime()
        {
            TimeSpan elapsedTime = endTime - startTime;
            return (int)elapsedTime.TotalMilliseconds;
        }
    }

}
