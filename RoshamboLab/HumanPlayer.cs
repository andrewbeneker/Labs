using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoshamboLab
{
    internal class HumanPlayer : Player
    {
        //allows the user to select and throw a value
        //upon creating instance of this class, allow user to input their name
        public override string GenerateRoshambo()
        {
            Console.WriteLine("Please choose rock, paper or scissors");
            string humanChoice = Console.ReadLine().ToLower().Trim();
            
            bool isValid = false;

            while (isValid == false)
            {
                if (humanChoice == "rock" || humanChoice == "paper" || humanChoice == "scissors")
                {
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Why are you doing this? Please enter rock, paper or scissors. You know the rules!");
                    humanChoice = Console.ReadLine().ToLower().Trim();
                }
            }

            switch (humanChoice)
            {
                case "rock":
                    RoshamboValue = Roshambo.Rock;
                    break;
                case "paper":
                    RoshamboValue = Roshambo.Paper;
                    break;
                case "scissors":
                    RoshamboValue = Roshambo.Scissors;
                    break;

            };
            return RoshamboValue.ToString();
        }

        private bool validateSelection()
        {
            return true;
        }


    }
}
