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

            IFlyBehavior flywithwings = new FlyWithWings();
            IFlyBehavior flynoway = new FlyNoWay();
            IQuackBehavior dquack = new DQuack();
            IQuackBehavior squeak = new Squeak();
            IQuackBehavior mutequack = new MuteQuack();

            mallardDuck.setFlyBehavior(flywithwings);
            mallardDuck.setQuackBehavior(dquack);

            redheadDuck.setFlyBehavior(flywithwings);
            redheadDuck.setQuackBehavior(dquack);

            decoyDuck.setFlyBehavior(flynoway);
            decoyDuck.setQuackBehavior(mutequack);

            rubberDuck.setFlyBehavior(flynoway);
            rubberDuck.setQuackBehavior(squeak);

            Duck[] ducks = { mallardDuck, redheadDuck, decoyDuck, redheadDuck };
            foreach (Duck d in ducks)
            {
                Console.WriteLine(d.Display());
                Console.WriteLine(d.Swim());
                Console.WriteLine(d.PerformFly());
                Console.WriteLine(d.PerformQuack());
            }
            Console.ReadKey();
        }
    }
}
