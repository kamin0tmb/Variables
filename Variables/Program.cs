using System;

namespace Variables
{
    class Program
    {
        public static void Main(string[] args)
        {
            string MyName = "Johnny";
            byte MyAge = 27;
            bool APet = false;
            double Shoes = 37.1;
            Console.WriteLine("My name is " + MyName);
            Console.WriteLine("I'm {0} years old", MyAge);
            Console.WriteLine("Do I have a pet?" + APet);
            Console.WriteLine("My shoes size is " + Shoes);
            Console.WriteLine("IntMinValue {0}", int.MinValue);
            Console.WriteLine("IntMaxValue {0}", int.MaxValue);
            Semaphore MyFavoriteCollor;
            MyFavoriteCollor = Semaphore.Green;
            Console.WriteLine(MyFavoriteCollor);
            Console.ReadKey();
            Console.WriteLine("\t Привет, \nмир!");
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            byte age = (byte)int.Parse(Console.ReadLine());
            Console.WriteLine("Your name is {0} and age is {1} ", name, age);
            Console.ReadKey();
            Console.WriteLine("What is your favorite collor ? ");
            Semaphore color = (Semaphore) int.Parse(Console.ReadLine());
            Console.WriteLine("Your favorite color is {0}", color);
            Console.WriteLine("Your name");
            var name1 = Console.ReadLine();
            Console.WriteLine("Your age");
            var age1 = checked((byte)int.Parse(Console.ReadLine()));
            Console.WriteLine("Your name is {0} and age is {1} ", name1, age1);
            Console.WriteLine("Your color");
            Console.Write("What is your favorite color? ");
            var color1 = (Semaphore)int.Parse(Console.ReadLine());
            Console.WriteLine("Your favorite color is {0}", color1);
        }
            enum Semaphore
        {   
            Red = 100,
            Yellow = 200,
            Green = 300
        }
        
    }
}
