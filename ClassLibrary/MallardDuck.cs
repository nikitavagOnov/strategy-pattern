using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Interfaces;

namespace ClassLibrary
{
    public class MallardDuck: Duck
    {
        public override string Display()
        {
            return $"{this.GetType()} {flyBehavior.GetType()} {quackBehavior.GetType()}";
        }
    }
}
