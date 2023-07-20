using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage.Models.Interfaces
{
    public interface IBuyer
    {
        public int Food { get; }
        string Name { get; }

        public void BuyFood();
    }
}
