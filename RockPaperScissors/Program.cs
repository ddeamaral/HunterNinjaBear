using System;

namespace RockPaperScissors
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user for what their choices are.
            Console.WriteLine("Hi, welcome to the hunter ninja bear game.");


            // Ask a user for a choice.
            Console.WriteLine("Please enter one of the following:");
            Console.WriteLine("A) HUNTER");
            Console.WriteLine("B) BEAR");
            Console.WriteLine("C) NINJA");

            // Store that choice into a variable.
            string usersChoice = GetUsersChoice();


            // Generate a random choice for the computer.
            Random rnd = new Random();

            int computerGeneratedChoice = rnd.Next(1, 3);

            // Store that random choice in a variable.
            string computersChoice = null;

            computersChoice = ComputeChoice(computerGeneratedChoice);

            // Compute who won.
            var winner = ComputeWinner(usersChoice, computersChoice);


            // Output the result to the user.
            Console.WriteLine("The winner of the game is: " + winner);


            Console.Read();

        }

        private static string ComputeWinner(string usersChoice, string computersChoice)
        {
            string winner = "you";

            // Hunter > Bear
            if (computersChoice == "HUNTER" && usersChoice == "BEAR")
                winner = "computer";
            // Bear > Ninja
            if (computersChoice == "BEAR" && usersChoice == "NINJA")
                winner = "computer";
            // Ninja > Hunter
            if (computersChoice == "NINJA" && usersChoice == "HUNTER")
                winner = "computer";

            // Case of a tie
            if (computersChoice == usersChoice)
                winner = " the both of you";

            return winner;
        }

        private static string ComputeChoice(int computerGeneratedChoice)
        {
            string strComputersChoice;

            
            //Use the number to pick string choice.
            if (computerGeneratedChoice == 1)
            {
                strComputersChoice = "HUNTER";
            }
            else if (computerGeneratedChoice == 2)
            {
                strComputersChoice = "BEAR";
            }
            else if (computerGeneratedChoice == 3)
            {
                strComputersChoice = "NINJA";
            }
            else
            {
                throw new Exception("USER HACKED THE SYSTEM");
            }

            return strComputersChoice;
        }

        public static string GetUsersChoice()
        {
            string usersChoice = Console.ReadLine();

            
            return usersChoice;
        }
    }
}
