using System.Security.Cryptography.X509Certificates;

namespace Gardening_Sim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gardener gardener = new Gardener ( "Jörgen", 25, 25.99m, 0, 0, 200 );

            bool Isrunning = true;

            Shop seedShop = new Shop();

            while (Isrunning == true)
            {
                Console.WriteLine("Welcome to the gardening sim! 1. Plant  2. Water  3. Harvest  4. Shop  5. Sleep  6.Quit");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Which seed would you like to plant? 1. Tomato  2. Corn  3. Cucumber:");
                        int input = int.Parse(Console.ReadLine());
                        if (int.TryParse(Console.ReadLine(), out input) && input == 1)
                        {
                            Console.WriteLine("Which seed would you like to plant? 1. Tomato  2. Corn  3. Cucumber");
                            if (input == 1)
                            {
                                var seed = new Seed("Tomato", 10, 7, 5, 2, true);
                                var plant = new Plant(seed);

                                plant.Watering();
                                plant.NextDay();
                                Console.WriteLine(plant.DaysGrown);

                            }

                            if (input == 2)
                            {
                                var seed = new Seed("Corn", 1, 5, 3, 2, true);
                                var plant = new Plant(seed);

                                plant.Watering();
                                plant.NextDay();
                                Console.WriteLine(plant.DaysGrown);
                            }

                            if (input == 3)
                            {
                                var seed = new Seed("Cucumber", 3, 7, 5, 3, true);
                                var plant = new Plant(seed);

                                plant.Watering();
                                plant.NextDay();
                                Console.WriteLine(plant.DaysGrown);
                            }
                        }
                        break;

                    case "2":
                        Console.WriteLine("Which plant do you want to water?");
                        input = int.Parse(Console.ReadLine());
                        if (input == 2)
                        {
                            Console.WriteLine($"");
                        }
                        break;

                    case "3":
                        Console.WriteLine("Which plant would you like to harvest?");
                        input = int.Parse(Console.ReadLine());
                        if (input == 3)
                        {
                            Console.WriteLine($"");
                        }
                        break;

                    case "4":
                        seedShop.ShowStock();
                        Console.WriteLine("Welcome to the seed shop! 1.purchase seeds  2. sell crops");
                        string shopChoice = Console.ReadLine();
                        
                        if (shopChoice == "1")
                        {
                            seedShop.ShowStock();
                            Console.WriteLine("Which seed do you want to buy?");
                            if (int.TryParse(Console.ReadLine(), out int buyChoice))
                            {
                                seedShop.Buy(gardener, buyChoice);
                            }
                        }

                        else if (shopChoice == "2")
                        {
                            seedShop.SellSeed(gardener);
                        }
                        break;


                }
            }
        }
    }
}
