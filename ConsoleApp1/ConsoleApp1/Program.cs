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
            int n = 10;
            Calculator c = new Calculator();

            Console.WriteLine(c.naiveCalcFib(n));
            Console.WriteLine(c.hashFibCalc(n));

            uint ord1 = 0, ord2 = 0, ord3 = 0;
            IEnumerable<uint> FibSeries = Enumerable.Range(1, n).Select(a =>
            {
                ord1 = a == 1 ? 0 : ord2;
                ord2 = a == 1 ? 1 : ord3;
                ord3 = a == 1 ? 0 : ord1 + ord2;
                return ord3;
            });

            foreach(int i in FibSeries)
                Console.Write(i + " ");
            Console.WriteLine("\n" + c.calcFactorial(10));
            Console.ReadKey();
        }
    }
}
