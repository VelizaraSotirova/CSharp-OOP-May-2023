using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models.Foods
{
    public abstract class Food : IFood
    {
        protected Food(int foodQuantity)
        {
            FoodQuantity = foodQuantity;
        }

        public int FoodQuantity { get; private set; }
    }
}
