using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodRealWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory fact = new Factory();
            var test = fact.GetPerson(PersonType.Rural);
            Console.WriteLine("factory {0}", test.GetType().Name);
            Console.ReadKey();
        }
    }
}
