using System;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;

Console.WriteLine("Welcome to Circle Stuff");
Console.WriteLine();

bool isValidDouble = false;
double radius = 0;

while (isValidDouble == false)
{
    Console.WriteLine("Please enter the value of the radius.");
    try
    {


        radius = double.Parse(Console.ReadLine());
        isValidDouble = true;
      

    }

    catch
    {
        Console.WriteLine("Error. Please enter only a number to represent the radius");
        continue;
    }
}
Console.WriteLine();
Console.WriteLine("Thank you.");
Console.WriteLine();

Circle.Circle userCircle = new Circle.Circle(radius);

double circleDiameter = userCircle.CalculateDiameter(radius);

Console.WriteLine($"The diameter is {circleDiameter.ToString()}");

double circleArea = userCircle.CalculateArea(radius);

Console.WriteLine($"The area of the circle is {circleArea}");

double circleCircumference = userCircle.CalculateCircumference(radius);

Console.WriteLine($"The circumference of the circle is {circleCircumference}");

bool keepGoing = true;

while (keepGoing == true)
{
    Console.WriteLine("Would you like to make the circle grow? y/n");
    string userAnswer = Console.ReadLine();

    if (userAnswer == "y")
    {
        userCircle.Grow();
        Console.WriteLine($"Your circle now has a radius of {radius} and the diameter is {circleDiameter}");
    }

    else
    {
        Console.WriteLine("Thank you for playing circles.");
        keepGoing = false;
    }


}