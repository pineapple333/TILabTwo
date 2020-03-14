using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 20;
            int tmp;
            Calculator c = new Calculator();
            {
                Timer timer = new Timer();
                tmp = c.naiveCalcFib(n);
                timer.Stop();
            }
            Console.WriteLine("Naive fibonacci: " + tmp);
            {
                Timer timer = new Timer();
                tmp = c.hashFibCalc(n);
                timer.Stop();
            }
            Console.WriteLine("Fibonacci with hash table: " + tmp);

            Console.WriteLine("Fibonacci series:");
            IEnumerable<uint> tmpFibSeries;
            {
                Timer timer;
                tmpFibSeries = c.GetFibSeries(n);
            }
            foreach(int i in tmpFibSeries)
                Console.Write(i + " ");

            Console.WriteLine("\nThe factorial of {0} = {1}", n, c.calcFactorial(n));

            Console.ReadLine();
        }
    }
}
