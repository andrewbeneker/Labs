using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PitFightersBC
{
    public class Weapon
    {
        public int AttackPower { get; set; }

        public WeaponType Type { get; set; }

        public Weapon (WeaponType type, int attackPower)
        {
            WeaponType weaponType = type;
            AttackPower = attackPower;
        }
        
        List<Weapon> Weapons { get; set; }
       

    }
}
