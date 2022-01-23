using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Interfaces;

namespace ClassLibrary
{
    public class RubberDuck: Duck, IQuackable
    {
        public string Quack()
        {
            return "Quack " + this.GetType();
        }
        public override string Display()
        {
            return "RubberDuck " + this.GetType();
        }
    }
}
