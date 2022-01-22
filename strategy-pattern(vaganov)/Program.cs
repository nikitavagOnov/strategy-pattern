using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace strategy_pattern_vaganov_
{
    class Program
    {
        static void Main(string[] args)
        {
            MallardDuck mallardDuck = new MallardDuck();
            RedheadDuck redheadDuck = new RedheadDuck();

            Duck[] ducks = { mallardDuck, redheadDuck};
            foreach (Duck d in ducks)
            {
                Console.WriteLine(d.Display());
                Console.WriteLine(d.Swim());
                Console.WriteLine(d.Quack());
            }
            Console.ReadKey();
        }
    }
}
