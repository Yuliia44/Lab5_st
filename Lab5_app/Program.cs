using System;
using System.Text;
using Lab5_st;

namespace BicycleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Створення масиву об'єктів Bicycle
            Bicycle[] bicycles = new Bicycle[3];

            for (int i = 0; i < bicycles.Length; i++)
            {
                // введення даних для кожного екземпляра
                Console.Write("Введіть бренд велосипеда: ");
                string brand = Console.ReadLine();

                Console.Write("Введіть модель велосипеда: ");
                string model = Console.ReadLine();

                Console.Write("Введіть розмір рами: ");
                int frameSize = int.Parse(Console.ReadLine());

                Console.Write("Введіть розмір колеса: ");
                int wheelSize = int.Parse(Console.ReadLine());

                Console.Write("Введіть колір велосипеда: ");
                string color = Console.ReadLine();

                Console.Write("Велосипед електричний (так/ні): ");
                bool isElectric = Console.ReadLine().ToLower() == "так";

                Console.Write("Введіть ціну велосипеда: ");
                decimal price = decimal.Parse(Console.ReadLine());

                Console.Write("Введіть рік виробництва велосипеда: ");
                int yearOfProduction = int.Parse(Console.ReadLine());

                // створення об'єкта класу Bicycle
                bicycles[i] = new Bicycle(brand, model, frameSize, wheelSize, color, isElectric, price, yearOfProduction);
            }

            // виведення результатів для всіх об'єктів масиву на екран
            Console.WriteLine("\nІнформація про всі велосипеди:");
            foreach (var bike in bicycles)
            {
                bike.DisplayInfo();
                Console.WriteLine();
            }
        }
    }
}
