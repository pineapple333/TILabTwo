using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Timer
    {

        private Stopwatch _sw;
        public Timer()
        {
            _sw = new Stopwatch();
            _sw.Start();
        }

        ~Timer()
        {
            Stop();
        }

        public void Stop()
        {
            _sw.Stop();
            Console.WriteLine("Elapsed= {0} miliseconds", _sw.Elapsed);
        }
    }
}
