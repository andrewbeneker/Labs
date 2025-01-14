using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PitFightersBC
{
    public class Fighter
    {
        public string Name { get; set; }
        public int Health { get; set; }

        public Weapon Weapon { get; set; }

        List <Fighter> FighterList { get; set; } = new List<Fighter>();

        public Fighter(string name, int health, Weapon weapon)
        {
            this.Name = name;
            this.Health = health;
            this.Weapon = weapon;
        }

        
    }
}
