using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Core.Interfaces;
using WildFarm.Factories;
using WildFarm.Factories.Interfaces;
using WildFarm.IO;
using WildFarm.IO.Interfaces;
using WildFarm.Models.Interfaces;

namespace WildFarm.Core
{
    public class Engine : IEngine
    {
        private IWriter writer;
        private IReader reader;

        private IFoodFactory foodFactory;
        private IAnimalFactory animalFactory;

        private ICollection<IAnimal> animals;   

        public Engine(IReader reader, IWriter writer, IFoodFactory foodFactory, IAnimalFactory animalFactory)
        {
            this.writer = writer;
            this.reader = reader;
            this.foodFactory = foodFactory;
            this.animalFactory = animalFactory;

            animals = new List<IAnimal>();  
        }

        public void Run()
        {
            string command;
            while ((command = reader.ReadLine()) != "End")
            {
                IAnimal animal = CreateAnimal(command);
                IFood food = CreateFood();
                writer.WriteLine(animal.ProduceSound());

                try
                {
                    animal.Eat(food);
                }
                catch (Exception ex)
                {
                    writer.WriteLine(ex.Message);
                }

                animals.Add(animal);
            }

            foreach (var animal in animals)
            {
                writer.WriteLine(animal.ToString());
            }
        }

        private IAnimal CreateAnimal(string command)
        {
            string[] animalTokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            IAnimal animal = animalFactory.CreateAnimal(animalTokens);
            return animal;
        }

        private IFood CreateFood()
        {
            string[] foodTokens = reader.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string foodType = foodTokens[0];
            int foodQuantity = int.Parse(foodTokens[1]);

            IFood food = foodFactory.CreateFood(foodType, foodQuantity);
            return food;
        }
    }
}
