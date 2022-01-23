using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using ClassLibrary.Interfaces;

namespace strategy_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            MallardDuck mallardDuck = new MallardDuck();
            RedheadDuck redheadDuck = new RedheadDuck();
            DecoyDuck decoyDuck = new DecoyDuck();
            RubberDuck rubberDuck = new RubberDuck();

            Duck[] ducks = { mallardDuck, redheadDuck, rubberDuck, decoyDuck };
            foreach (Duck d in ducks)
            {
                if (d is IQuackable)
                {
                    Console.WriteLine((d as IQuackable).Quack());
                }
                if (d is IFlyable)
                {
                    Console.WriteLine((d as IFlyable).Fly());
                }
                Console.WriteLine(d.Display());
                Console.WriteLine(d.Swim());

            }
            Console.ReadKey();
        }
    }
}
