using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class App
    {
        public void Run()
        {
            var bat = new Bat();
            var human = new Human();
            var cow = new Cow();

            Mammal mCow = cow;

            cow.Stampede();
            ((Cow)mCow).Stampede();

            var mammals = new List<Mammal>() { bat, human, cow };

            foreach (var mammal in mammals)
            {
                DoMammalStuff(mammal);
            }
        }
        private void DoMammalStuff(Mammal mammal)
        {
            Cow asCow = mammal as Cow;

            if (asCow != null)
            {
                asCow.Stampede();
            }
            else
            {
                mammal.Ambulate();
            }
            if (mammal is Cow)
            {
                Cow cow = (Cow)mammal;
                cow.Stampede();
            }
            else
            {
                mammal.Ambulate();
            }
            mammal.Ambulate();
            var totalSleep = mammal.Sleep();
            mammal.Eat();
            totalSleep += mammal.Sleep();
            Console.WriteLine($"total hours of sleep: {totalSleep}" + "\n");
        }

    }
}
