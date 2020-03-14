using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    class Pupil
    {
        public Pupil()
        {

        }
        public Pupil(string name, List<int> marks, int age)
        {
            Name = name;
            Marks = marks;
            Age = age;
        }

        public string Name { private set; get; }
        public List<int> Marks { private set; get; }
        public int Age { private set; get; }

        public int GetAverageMark()
        {
            int sum = 0;
            foreach (int one in Marks)
                sum += one;
            return sum / Marks.Count;
        }

        public override string ToString()
        {
            string to_return = "";
            to_return += Name + "\n";
            string marks = "";
            foreach (int one in Marks)
                marks += one + " ";
            to_return += marks + "\n";
            to_return += Age + "\n";
            return to_return;
        }
    }
}
