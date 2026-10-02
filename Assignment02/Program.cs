/*
* Student ID :1690704067
* Name       :Assignment02
* Section    :129D
* No.        :
* Course     : GI113 Computer Programming (GI)
*/
namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            const string MaterialName = "Copper";
            const double SmeltRate = 0.25;
            const double SalvageRate = 0.30;
            const double MaxBatch = 500;


            Console.WriteLine($" Welcome to the Forge ");

            Console.WriteLine($" => {MaterialName} Smelting {SmeltRate:P0} / Salvage {SalvageRate:P0}");
            Console.WriteLine($" => Key 'S' for Smelt (Ore -> Ingot)");
            Console.WriteLine($" => Key 'B' for Breakdown (Ingot -> Ore)");
            Console.WriteLine($" => Maximum batch size is {MaxBatch}");

            Console.Write(" => Enter your choice: ");
            string menuInput = Console.ReadLine();
            bool isMenuParsed = char.TryParse(menuInput, out char menuChoice);

            Console.Write(" => How much material do you want to process? ");
            string amountInput = Console.ReadLine();
            bool isAmountParsed = double.TryParse(amountInput, out double amount);

            bool isAmountValid = isAmountParsed && amount > 0 && amount <= MaxBatch;

            if (isMenuParsed)
            {

                 if (isMenuParsed && (menuChoice != 'S' && menuChoice != 's' && menuChoice != 'B' && menuChoice != 'b'))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($" I haven't a clue what you're talking about... do you want to Smelt copper or Breakdown ore?");
                    Console.ResetColor();
                }

                else if (!isAmountValid)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($" => Just so you know, I won't forge more than {MaxBatch} pieces a day..");
                    Console.ResetColor();
                }

                else if (isMenuParsed && (menuChoice == 'S' || menuChoice == 's'))
                {
                    double ingotAmount = amount * SmeltRate;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Trus Me I'm sure the product will come out good.");
                    Console.ResetColor();
                    Console.WriteLine($" => You have smelted {amount:F2} {MaterialName} Ore = {ingotAmount:F2} {MaterialName} Ingot.");
                }

                else if (isMenuParsed && (menuChoice == 'B' || menuChoice == 'b'))
                {
                    double oreAmount = amount / SalvageRate;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Trus Me I'm sure the product will come out good.");
                    Console.ResetColor();
                    Console.WriteLine($" => You have broken down {amount:F2} {MaterialName} Ingot = {oreAmount:F2} {MaterialName} Ore.");
                }

            }         
        }
    }
} 
