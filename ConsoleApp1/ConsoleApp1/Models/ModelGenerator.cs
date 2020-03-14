using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    class ModelGenerator
    {
        private Random  _rnd    =   new Random();
        private int _numOfNames = Enum.GetNames(typeof(Names)).Length;
        private enum Names 
        { 
            Juliet, 
            Anton,
            Emma,
        	Noah, 
            Olivia,
            William,
            Ava,
            James, 
            Isabella,
            Oliver, 
            Sophia,
            Benjamin, 
            Charlotte,
            Elijah, 
            Mia,
            Lucas, 
            Amelia,
            Mason, 
            Harper,
            Logan, 
            Evelyn
        }
        public ModelGenerator()
        {
        }
        public List<Pupil> GenerateMany(int number)
        {
            List<Pupil> pupils = new List<Pupil>();
            foreach (int one in Enumerable.Range(0, number))
                pupils.Add(GenerateOne());
            return pupils;
        }
        private Pupil GenerateOne()
        {
            // the number of marks per pupil
            int n_marks = 10;
            int tmp = _rnd.Next(0, Enum.GetNames(typeof(Names)).Length);
            string name = Enum.GetName(typeof(Names), tmp);
            List<int> marks = GetMarks(n_marks);
            int age = _rnd.Next(10, 17);
            return new Pupil(name, marks, age);
        }

        private List<int> GetMarks(int n)
        {
            List<int> marks = new List<int>();
            foreach (int one in Enumerable.Range(0, n))
                marks.Add(_rnd.Next(1, 6));

            return marks;
        }
    }
}
