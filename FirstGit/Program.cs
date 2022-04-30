using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Hello Updated");


            Console.WriteLine("Hello From gitgub");

            Console.WriteLine("Hello ME");

            Console.WriteLine("hello from featurea");
            Console.WriteLine("change in remote feature a branch");

            Student s = new Student();





            Console.ReadLine();
        }

        public class Student
        {
            public int id { get; set; }
            public int rollnumber { get; set; }
            public string name { get; set; }
            public string gender { get; set; }

        }

    }
}
