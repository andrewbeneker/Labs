using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsAndUsedCarsPractice
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }

        public Car ()
        {
            Make = "default";
            Model = "default";
            Year = 0;
            Price = 0;
        }
        public Car (string make, string model, int year, decimal price)
        {
            Make = make;
            Model = model;
            Year = year;
            Price = price;
        }

        public List <Car> Cars { get; set; } = new List <Car> ();

        public string ToString()
        {
            return $"Make: {Make} Model: {Model} Model Year: {Year} Price: ${Price}";
        }

        public string ListCars(List <Car> cars)
        {
            for (int i = 0; i <= 6 ; i++)
            {
                Console.WriteLine($"{i} {ToString()}");
            }
            return "Here's your car list.";
        }
    }
}
