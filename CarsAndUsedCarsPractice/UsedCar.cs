using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CarsAndUsedCarsPractice
{
    public class UsedCar : Car
    {
        public double Mileage { get; set; }

        public UsedCar (string make, string model, int year, decimal price, double mileage)
        {
            Make = make;
            Model = model;
            Year = year;
            Price = price;
            Mileage = mileage;

        }
    }

    
}
