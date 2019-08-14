using System;

namespace Inheritance
{
    class Human : Mammal
    {
        protected Human(double bodyTemp)
                : base("Human",2, bodyTemp)
        {

        }
        public Human() 
            : this(98.6)
        {
        }
        public override void Ambulate()
        {
            base.Ambulate();
        }
        public override double Sleep()
        {
            Console.WriteLine($"{creatureName} sleeps 8 hours");
            return 8.0;
        }
    }
}