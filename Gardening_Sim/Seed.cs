using System;
using System.Collections.Generic;
using System.Text;

namespace Gardening_Sim
{
    internal class Seed
    {
        public string Name { get; set; }
        public int GrowthTimeDays { get; set; }
        public int Cost { get; set; }
        public int SellPrice { get; set; }
        public int WaterNeed { get; set; }       // waterings needed per day
        public bool Regrows { get; set; }

        public Seed(string name, int growthTimeDays, int cost, int sellPrice, int waterNeed, bool regrows)
        {
            Name = name;

            GrowthTimeDays = growthTimeDays;

            Cost = cost;

            SellPrice = sellPrice;

            WaterNeed = waterNeed;

            Regrows = regrows;

        }
    }
}
