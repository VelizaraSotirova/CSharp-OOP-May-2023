using FoodShortage.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage.Models
{
    public class Rebel : IBuyer
    {
        private const int FoodIncrement = 5;
        public Rebel(string name, int age, string group)
        {
            Name = name;
            Age = age;
            Group = group;
        }


        public void BuyFood()
        {
            Food += FoodIncrement;
        }

        public int Food { get; private set; }
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Group { get; private set; }
    }
}
