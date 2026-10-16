using System;
using System.Collections.Generic;
using System.Text;

namespace Gardening_Sim
{
    internal class Shop
    {
        public List<Seed> Stock { get; } = new(); //creates a list that acts as a stock for the seeds

        public Shop() //creates the shop
        {
            Stock.Add(new Tomato());
            Stock.Add(new Corn());
            Stock.Add(new Cucumber());
            Stock.Add(new Seed("Pumpkin", 10, 20, 15, 20, false));
            Stock.Add(new Seed("Glowberry", 5, 30, 25, 7, false));
            Stock.Add(new Seed("Appletree", 50, 100, 80, 200, true));
        }

        public void ShowStock() //shows the stock to the player
        {
            for (int i = 0; i < Stock.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Stock[i].Name} - {Stock[i].Cost} coins");
            }
        }

        public bool Buy(Gardener gardener, int choice)
        {
            if (choice < 1 || choice > Stock.Count)
            {
                Console.WriteLine("That is not in the shop! Try again");
                return false;
            }

            Seed seed = Stock[choice - 1];

            if (gardener.salary < seed.Cost)
            {
                Console.WriteLine("You can't afford that yet");
                return false;
            }

            gardener.salary -= seed.Cost;
            gardener.Seeds[seed] = gardener.Seeds.GetValueOrDefault(seed) + 1;
            Console.WriteLine($"You bought a {seed.Name} seed!");
            return true;
        }

        public void SellSeed(Gardener gardener)
        {
            if (gardener.Seeds.Count == 0)
            {
                Console.WriteLine("You have nothing to sell!");
                return;
            }

            var items = new List<KeyValuePair<Seed, int>>(gardener.Harvest);

            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {items[i].Key.Name} x{items[i].Value} - {items[i].Key.SellPrice} coins each");
            }

            Console.WriteLine("Which crop do you want to sell?");

            if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 1 || choice > items.Count)
            {
                Console.WriteLine("That is not one of those options");
                return;
            }

            Seed crop = items[choice - 1].Key;
            int count = items[choice - 1].Value;
            int earned = crop.SellPrice * count;

            gardener.salary += earned;
            gardener.Harvest.Remove(crop);

            Console.WriteLine($"You sold {count} {crop.Name} for {earned} coins!");


        }

    }
}
