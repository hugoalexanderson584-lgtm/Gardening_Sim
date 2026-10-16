using System;
using System.Collections.Generic;
using System.Text;

namespace Gardening_Sim
{
    internal class Gardener
    {
        public string name { get; set; }
        public int age { get; set; }
        public decimal salary { get; set; }
        public int level { get; set; }
        public int experience { get; set; }
        public int energy { get; set; }


        public Gardener(string name, int age, decimal salary, int level, int experience, int energy)  //Konstruktor
        {
            this.name = name;
            this.age = age;
            this.salary = salary;
            this.level = level;
            this.experience = experience;
            this.energy = energy;
        }



        public Dictionary<Seed, int> Seeds { get; } = new();
        public Dictionary<Seed, int> Harvest { get; } = new();
    }
}
