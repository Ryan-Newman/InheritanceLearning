using System;

namespace Inheritance
{
    abstract class Mammal
    {
        protected readonly int legs = 4;// readonly can only be set a maximum of 2 times
        protected readonly string creatureName;
        protected readonly double internalTemperature;

        protected Mammal(string creatureName, double internalTemperature)
        {
            this.creatureName = creatureName;
            this.internalTemperature = internalTemperature;

        }
        protected Mammal(string creatureName, int legs, double internalTemperature)
        {
            this.creatureName = creatureName;
            this.legs = legs;
            this.internalTemperature = internalTemperature;

        }

        public virtual void Eat()
        {
            Console.WriteLine($"{creatureName} eat");
        }
        public virtual void Gestate()
        {
            Console.WriteLine($"{creatureName} gestate");
        }
        public void Lactate()
        {
            Console.WriteLine($"{creatureName} lactact");
        }
        public virtual void Ambulate()
        {
            Console.WriteLine($"{creatureName} Ambulating on {legs} legs");
        }
        public abstract double Sleep();

    }
}