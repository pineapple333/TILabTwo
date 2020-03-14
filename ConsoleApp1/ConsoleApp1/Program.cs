using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Models;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int n;
            Console.WriteLine("For Fibonacci number and series: ");
            n = getUserInput();
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
                Timer timer = new Timer();
                tmpFibSeries = c.GetFibSeries(n);
                timer.Stop();
            }
            foreach(int i in tmpFibSeries)
                Console.Write(i + " ");

            Console.WriteLine("\nThe factorial of {0} = {1}", n, c.calcFactorial(n));

            // the number of pupils
            int number_of_pupils = 10;
            List<Pupil> pupils = new ModelGenerator().GenerateMany(number_of_pupils);

            // sort by age
            pupils = pupils.OrderByDescending(o => o.Age).ToList();
            PrintPupils(pupils);

            Console.WriteLine("Group by average mark: ");

            var pupilGroups = from phone in pupils
                              group phone by phone.AverageMark;

            foreach (IGrouping<int, Pupil> g in pupilGroups)
            {
                Console.WriteLine(g.Key);
                foreach (var t in g)
                    Console.WriteLine("Name: " + t.Name + " age: " + t.Age);
                Console.WriteLine();
            }

            Console.WriteLine("Separate odd and even: ");
            n = getUserInput();
            List<int> my_list = new List<int>();
            Random r = new Random();
            foreach (int one in Enumerable.Range(0, n))
                my_list.Add(r.Next(0, n));

            int[] tmp_array = my_list.ToArray();
            List<List<int>> output = Grouper.Group(tmp_array);

            Console.ReadLine();
        }

        private static void PrintPupils(List<Pupil> pupils)
        {
            foreach(Pupil one in pupils)
                Console.Write(one);
        }

        private static int getUserInput()
        {
            int n;
            while (true)
            {
                Console.WriteLine("Your number is : ");
                if (int.TryParse(Console.ReadLine(), out n))
                    return n;
                else
                    Console.WriteLine("Nan");
            }
        }
    }
}
