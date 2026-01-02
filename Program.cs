using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Student
    {
        public string Name;
        public int Age;
        public double Score;

        public bool IsPassed()
        {
            if (Score >= 10)
                return true;
            else
                return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();

            s1.Name = "Ali";
            s1.Age = 18;
            s1.Score = 15.5;

            Console.WriteLine("Passed: " + s1.IsPassed());

            Console.ReadKey();
        }
    }
}
