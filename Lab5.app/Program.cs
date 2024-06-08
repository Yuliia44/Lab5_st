using System;
using System.Collections.Generic;
using System.Text;
using Lab5;

namespace Lab5.app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            List<Bicycle> bicycles = new List<Bicycle>();
            string continueInput;

            do
            {
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

                Bicycle bike = new Bicycle(brand, model, frameSize, wheelSize, color, isElectric, price, yearOfProduction);
                bicycles.Add(bike);

                Console.Write("Бажаєте ввести ще один велосипед? (так/ні): ");
                continueInput = Console.ReadLine().ToLower();

            } while (continueInput == "так");

            Console.WriteLine("\nІнформація про всі велосипеди:");
            foreach (var bike in bicycles)
            {
                bike.DisplayInfo();
                Console.WriteLine();
            }
        }
    }
}
