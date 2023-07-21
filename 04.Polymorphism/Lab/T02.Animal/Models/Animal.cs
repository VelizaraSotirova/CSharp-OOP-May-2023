using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Animals.Models
{
    public class Animal
    {
        public Animal(string name, string favouriteFood)
        {
            Name = name;
            FavouriteFood = favouriteFood;
        }

        public string Name { get; private set; }
        public string FavouriteFood { get; private set; }

        public virtual string ExplainSelf()
            => $"I am {this.Name} and my favourite food is {this.FavouriteFood}";
    }
}
