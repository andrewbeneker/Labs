// See https://aka.ms/new-console-template for more information
using PitFightersBC;

Console.WriteLine("Hello, World!");

Weapon sword = new Weapon()
{
    AttackPower = 25,
    Type = WeaponType.Sword,

};

Fighter snakeMan = new Fighter()
{
    Name = "Snake Man",
    Health = 100,
    Weapon = sword,

};





Console.ReadKey();