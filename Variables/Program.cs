using System;

namespace Variables
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите имя: ");
            var name = Console.ReadLine();
            Console.Write("Введите возраст: ");
            var age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ваше имя {0}, ваш возраст {1}", name, age);
            Console.Write("Ваша дата рождения: ");
            var birth = Console.ReadLine();
            Console.WriteLine("Вы родились {0}", birth);
        }
            enum Semaphore
        {   
            Red = 100,
            Yellow = 200,
            Green = 300
        }
        
    }
}
