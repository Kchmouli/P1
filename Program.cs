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
            var rating = 0.0;

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

                if (average >= 40)
                {
                    rating += 2;
                }
                else if (average < 40 && average >= 30)
                {
                    rating += 1.75;
                }
                else if (average < 30 && average >= 25)
                {
                    rating += 1.5;
                }
                else if (average < 25)
                {
                    rating += 1;
                }

                if (strikeRate >= 200)
                {
                    rating += 2;
                }
                else if (strikeRate >= 150 && strikeRate < 200)
                {
                    rating += 1.5;
                }
                else if (strikeRate >= 100 && strikeRate < 150)
                {
                    rating += 1;
                }
                else if (strikeRate < 100)
                {
                    rating += 0;
                }

                if (runs >= 1000)
                {
                    rating += 1;
                }
                else
                {
                    rating += 0;
                }

                switch (Convert.ToInt32(rating))
                {
                    case 5:
                        basePrice = 200000m;
                        break;
                    case 4:
                        basePrice = 100000m;
                        break;
                    case 3:
                        basePrice = 75000m;
                        break;
                    case 2:
                        basePrice = 500000m;
                        break;
                    case 1:
                        basePrice = 200000m;
                        break;
                    default:
                        Console.WriteLine("No base price for player with rating 0");
                        break;
                }

                // Console.WriteLine($"{name} played {innings} innings and scored {runs} runs with Batting " +
                // $"Average of {Math.Ceiling(average * 100) / 100} and Strike Rate of " +
                // $"{Math.Ceiling(strikeRate * 100) / 100} with rating of {rating} "
                // + $"and base Price of {basePrice}");

                Console.WriteLine($"Player Name: {name}");
                Console.WriteLine($"Innings: {innings}");
                Console.WriteLine($"Runs Scored: {runs}");
                Console.WriteLine($"Batting Average: {Math.Ceiling(average * 100) / 100}");
                Console.WriteLine($"Strike Rate: {Math.Ceiling(strikeRate * 100) / 100}");
                Console.WriteLine($"Player Rating: {rating}");
                Console.WriteLine($"Base Price: {basePrice}");

                Console.WriteLine($"{name} scored {runs} with average {Math.Ceiling(average * 100) / 100}"
                +"and strike rate {Math.Ceiling(strikeRate * 100) / 100}"
                +$"\n{name} has rating of {rating}");

            }
        }
    }
}
