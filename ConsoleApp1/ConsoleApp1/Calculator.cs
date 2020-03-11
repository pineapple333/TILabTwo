using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1
{
    public class Calculator
    {
        // a simple way to calculate Fibonacci number
        public int naiveCalcFib(int n)
        {
            if ((n == 0) | (n == 1))
                return n;
            else
                return naiveCalcFib(n - 1) + naiveCalcFib(n - 2);
        }

        // calculating Fibonacci number using a dictionary
        public int hashFibCalc(int n)
        {
            Dictionary<int, int> hash = new Dictionary<int, int>();
            return Fib(n, hash);

        }

        public int Fib(int i, Dictionary<int, int> hash)
        {
            if (i <= 0)
                return 0;
            if (i < 2)
                return 1;

            if (hash.ContainsKey(i))
            {
                return hash[i];
            }
            else
            {
                int val = Fib(i - 1, hash) + Fib(i - 2, hash);
                hash.Add(i, val);
                return val;
            }
        }

        public int calcFactorial(int n)
        {
            if (n == 1)
                return 1;
            return n * calcFactorial(n - 1);
        }

    }
}
