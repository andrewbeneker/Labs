using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoshamboLab
{
    internal class RockPlayer : Player
    {
        //always throws rock
        public override string GenerateRoshambo()
        {
          RoshamboValue = Roshambo.Rock;
            return RoshamboValue.ToString();
        }
    }
}
