using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTraining
{
    public class Car
    {
        public string Name;
        public string Description;

        public void Hello()
        {
            Console.WriteLine("Hello {0} and {1}", Name, Description);
        }
       
    }

}
