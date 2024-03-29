﻿using System;

namespace Inheritance
{
    class Cow : Mammal
    {
        public Cow() : base("Cow", 101.5)
        {

        }
        public new void Lactate()
        {
            Console.WriteLine($"{creatureName} creates delicious creamy milk by the 2-gallon");
        }

        public override void Eat()
        {
            base.Eat();
            Console.WriteLine($"{creatureName} digests woth 8 stomachs");
        }

        public override double Sleep()
        {
            Console.WriteLine($"{creatureName} sleeps 4 hours");
            return 4.0;
        }
        public void Stampede()
        {
            Console.WriteLine("The cow stampedes your face");
        }
    }
}