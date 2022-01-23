using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Interfaces;

namespace ClassLibrary
{
    public class RedheadDuck: Duck, IQuackable, IFlyable
    {
        public string Quack()
        {
            return "Quack " + this.GetType();
        }
        public string Fly()
        {
            return "Fly " + this.GetType();
        }
        public override string Display()
        {
            return "Display " + this.GetType();
        }
    }
}
