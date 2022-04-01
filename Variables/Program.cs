using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string MyName = "Johnny";
            byte MyAge = 27;
            bool APet = false;
            double Shoes = 37.1;
            Console.WriteLine("My name is " + MyName);
            Console.WriteLine("I'm {0} years old", MyAge);
            Console.WriteLine("Do I have a pet?" + APet);
            Console.WriteLine("My shoes size is " + Shoes);
            Console.ReadKey();
            Console.WriteLine("IntMinValue {0}", int.MinValue);
            Console.WriteLine("IntMaxValue {0}", int.MaxValue);
        }
    }
}
