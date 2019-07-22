using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodRealWorld
{
    public class CityPerson : IPerson
    {
        public string Getname()
        {
            return "City Person";
        }
    }
}
