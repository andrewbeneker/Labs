using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoshamboLab
{
    internal class RandomPlayer : Player
    {
        //picks and throws value at random
        public override string GenerateRoshambo()
        {
            Random randomChoice = new Random();
            int choice = randomChoice.Next(1, 3);
            switch (choice)
            {
                case 1:
                    RoshamboValue = Roshambo.Rock;
                    break;
                 case 2:
                    RoshamboValue = Roshambo.Scissors;
                    break;
                case 3:
                    RoshamboValue = Roshambo.Paper;
                    break;

            };



            return RoshamboValue.ToString();
        }
    }
}
