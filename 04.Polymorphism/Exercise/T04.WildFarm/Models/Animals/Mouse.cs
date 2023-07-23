using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals
{
    public class Mouse : Mammal
    {
        public double MouseWeightMultiplier = 0.10;
        public Mouse(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
        }

        protected override double WeightMultiplier => MouseWeightMultiplier;

        protected override IReadOnlyCollection<Type> PrefferedFoodTypes 
            => new HashSet<Type> { typeof(Vegetable), typeof(Fruit) };

        public override string ProduceSound() => "Squeak";

        public override string ToString()
        {
            return base.ToString() + $"{Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
