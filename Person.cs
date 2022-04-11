using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTraining
{
    internal class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hello {0} my name is {1}", to, Name);
        }
    }
}
