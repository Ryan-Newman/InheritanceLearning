using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Inheritance
{

    class Program
    {
        static void Main(string[] args)
        {
            42.Ambulate();

            new App().Run();
        }
      
    }
    static class Util
    {
        public static void Ambulate(this int i)
        {
            Console.WriteLine($"{i} ambulates with swagger");

        }
    }
}