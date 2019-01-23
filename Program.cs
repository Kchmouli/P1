using System;

namespace P1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to CricketApp");
            // Declare and use a bool, char type.
            // Implement at least one loop
            // Implement at least one if or if-else branch with conditions
            // Implement a switch statement
            // Implement a simple function calculation (e.g. totalCost or hasEnough)
            // Use Console.WriteLine and Console.ReadLine
            // Use string interpolation ($"") and \n or \t

            //Cricket app
            //calculate batting average and strike rate of batsman
            //Rate and set base price for player
            //Take name, runs, notouts, innings, ballsfaced as input

            var runs = 0;
            var innings = 0;
            var notOuts = 0;
            var ballsFaced = 0;
            var name = string.Empty;
            var basePrice = 0.0m;
            var strikeRate = 0.0;
            var average = 0.0;

            while (true)
            {
                Console.WriteLine("Press q to quit or any key to continue");
                var quit = Console.ReadLine();
                if (quit == "q")
                {
                    Console.WriteLine("Thank you for using Cricket App");
                    break;
                }

                Console.WriteLine("Enter Player Name");
                name = Console.ReadLine();

                Console.WriteLine("Enter number of Innings");
                innings = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter number of Runs");
                runs = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter number of balls faced");
                ballsFaced = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter number of Not Outs");
                notOuts = Convert.ToInt32(Console.ReadLine());

                average = (Convert.ToDouble(runs) / (Convert.ToDouble(innings) - Convert.ToDouble(notOuts)));
                
                strikeRate = (Convert.ToDouble(runs) / Convert.ToDouble(ballsFaced) * 100);
                
                Console.WriteLine($"{name} played {innings} innings and scored {runs} runs with Batting " +
                $"Average of {Math.Ceiling(average * 100) / 100} and Strike Rate of " +
                $"{Math.Ceiling(strikeRate * 100) / 100}");
            }
        }
    }
}
