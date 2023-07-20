using FoodShortage.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage.Models
{
    public class Citizen : INameable, IIdentifiable, IBirthable, IBuyer
    {
        private const int FoodIncrement = 10;
        public Citizen(string name, int age, string id, string birthdate)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthdate = birthdate;
        }


        public void BuyFood()
        {
            Food += FoodIncrement;
        }
        public int Food { get; private set; }

        public string Name { get; set; }

        public int Age { get; private set; }

        public string Birthdate { get; private set; }

        public string Id { get; private set; }
    }
}
