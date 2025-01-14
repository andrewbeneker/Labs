using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PitFightersBC
{
    public class Battle
    {
        public Battle(Fighter fighterOne, Fighter fighterTwo)
        {
            
        }

        public string DoBattle(Fighter fighterOne, Fighter fighterTwo)
        {
            if (fighterOne.Weapon.AttackPower > fighterTwo.Weapon.AttackPower)
            {
                Console.WriteLine($"{fighterTwo} lost {fighterOne.Weapon.AttackPower} HP");
                fighterTwo.Health = fighterTwo.Health - fighterOne.Weapon.AttackPower;
            }
            if (fighterTwo.Weapon.AttackPower > fighterOne.Weapon.AttackPower)
            {
                Console.WriteLine($"{fighterTwo} lost {fighterOne.Weapon.AttackPower} HP");
                fighterOne.Health = fighterOne.Health - fighterTwo.Weapon.AttackPower;
                
            }
            else
            {
                Console.WriteLine("Weapons clashed, both fighters weapons have been damaged!");
                fighterOne.Weapon.AttackPower = fighterOne.Weapon.AttackPower - 20;
                fighterTwo.Weapon.AttackPower = fighterTwo.Weapon.AttackPower - 19;
            }
            return $"{fighterOne.Name} has {fighterOne.Health} HP left. {fighterTwo.Name} has {fighterTwo.Health} HP left";
        }
    }
}
