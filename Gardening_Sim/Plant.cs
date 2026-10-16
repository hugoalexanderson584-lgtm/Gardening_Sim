using System;
using System.Collections.Generic;
using System.Text;

namespace Gardening_Sim
{
    internal class Plant
    {
        public Seed Seed { get; set; }
        public int DaysGrown { get; private set; } // private set gör så att bara Plant klassen kan ändra på denna property
        public bool WateredToday { get; private set; }

        public bool isReady => DaysGrown >= Seed.GrowthTimeDays;

        public Plant (Seed seed) //
        {
            Seed = seed;
        }

        public void Watering() //
        {
            WateredToday = true;
        }

        public void NextDay()
        {
            if (WateredToday && !isReady)
            {
                DaysGrown++;
            }
            WateredToday = false;
        }


    }
}
