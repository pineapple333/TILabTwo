using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Grouper
    {
        public static List<List<int>> Group(int[] array)
        {
            List<int> odd_list;
            List<int> even_list;
            List<List<int>> output = new List<List<int>>();

            MyForeach(array);

            odd_list = array.Where(x => x % 2 == 0).ToList();
            even_list = array.Where(x => x % 2 == 1).ToList();

            MyForeach(odd_list.ToArray());
            MyForeach(even_list.ToArray());

            output.Add(odd_list);
            output.Add(even_list);

            return output;
        }

        private static void MyForeach(int[] mlist)
        {
            foreach (int one in mlist)
                Console.Write("{0} ", one);
            Console.WriteLine();
        }
    }
}
