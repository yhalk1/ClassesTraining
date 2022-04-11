using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTraining
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Car car = new Car();
            car.Name = "Opel";
            car.Description = "Astra";
            car.Hello();

            Person person = new Person
            {
                Name = "Brave"
        };
            person.Introduce("Ivan");
        }
    
    }
}
