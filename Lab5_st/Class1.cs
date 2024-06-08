using System;

namespace Lab5
{
    public class Bicycle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int FrameSize { get; set; }
        public int WheelSize { get; set; }
        public string Color { get; set; }
        public bool IsElectric { get; set; }
        public decimal Price { get; set; }
        public const decimal DiscountPercentage = 10.0m;
        public int YearOfProduction { get; set; }  

        public Bicycle(string brand, string model, int frameSize, int wheelSize, string color, bool isElectric, decimal price, int yearOfProduction)
        {
            Brand = brand;
            Model = model;
            FrameSize = frameSize;
            WheelSize = wheelSize;
            Color = color;
            IsElectric = isElectric;
            Price = price;
            YearOfProduction = yearOfProduction;
        }

        public void DisplayInfo()
        {
            string electricStatus = IsElectric ? "Так" : "Ні";
            Console.WriteLine($"Бренд: {Brand}");
            Console.WriteLine($"Модель: {Model}");
            Console.WriteLine($"Розмір рами: {FrameSize}");
            Console.WriteLine($"Розмір колеса: {WheelSize}");
            Console.WriteLine($"Колір: {Color}");
            Console.WriteLine($"Електричний: {electricStatus}");
            Console.WriteLine($"Ціна: {Price:F2}");
            Console.WriteLine($"Знижка: {DiscountPercentage}%");
            Console.WriteLine($"Ціна зі знижкою: {CalculateDiscountedPrice():F2}");
            Console.WriteLine($"Рік виробництва: {YearOfProduction}"); 
        }

        public decimal CalculateDiscountedPrice()
        {
            decimal discountAmount = Price * (DiscountPercentage / 100);
            return Price - discountAmount;
        }
    }
}
