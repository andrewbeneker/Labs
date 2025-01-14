// See https://aka.ms/new-console-template for more information
using CarsAndUsedCarsPractice;

Console.WriteLine("Hello, World!");

UsedCar usedVolkswagen = new UsedCar("Volkwagen", "Golf", 2004, 30000, 100000);
Car newVolkswagen = new Car("Volkswagen", "GTI", 2015, 40000);
UsedCar usedBUick = new UsedCar("Buick", "GT", 2010, 15000, 120000);
Car newBuick = new Car("Buick", "Olds Wagen", 2024, 60000);
UsedCar usedVolvo = new UsedCar("Volvo", "2500", 2004, 50000, 200000);
Car newVW = new Car("Volkswagen", "Golf R", 2024, 60000);

List <Car> carsList = new List<Car>();
carsList.Add(usedVolkswagen);
carsList.Add(newVolkswagen);
carsList.Add(newBuick);
carsList.Add(usedBUick);
carsList.Add(newVW);
carsList.Add(usedVolvo);

foreach (Car car in carsList)
{
    Console.WriteLine($"{car.Model}");
}

ListCars();



