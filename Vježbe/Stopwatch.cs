using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    class Stopwatch
    {
        public readonly DateTime StartTime;
        private DateTime _stopTime;
        // This Stopwatch class is pretty simple and is meant to be initialized only once
        public Stopwatch()
        {
            StartTime = DateTime.Now;
        }

        public void Stop()
        {
            _stopTime = DateTime.Now;
        }
        public TimeSpan Elapsed()
        {
            return _stopTime - StartTime;
        }
        public string Started()
        {
            
            return StartTime.ToLongDateString();
        }
    }
}
