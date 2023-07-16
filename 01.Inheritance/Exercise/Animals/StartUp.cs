using System;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string animalType;

            while ((animalType = Console.ReadLine()) != "Beast!")
            {
                string[] animalInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                try
                {
                    switch (animalType)
                    {
                        case "Dog":
                            Dog dog = new Dog(animalInfo[0], int.Parse(animalInfo[1]), animalInfo[2]);
                            Console.WriteLine(animalType);
                            Console.WriteLine(dog.ToString());
                            break;
                        case "Cat":
                            Cat cat = new Cat(animalInfo[0], int.Parse(animalInfo[1]), animalInfo[2]);
                            Console.WriteLine(animalType);
                            Console.WriteLine(cat.ToString());
                            break;
                        case "Frog":
                            Frog frog = new Frog(animalInfo[0], int.Parse(animalInfo[1]), animalInfo[2]);
                            Console.WriteLine(animalType);
                            Console.WriteLine(frog.ToString());
                            break;
                        case "Kitten":
                            Kitten kitten = new Kitten(animalInfo[0], int.Parse(animalInfo[1]));
                            Console.WriteLine(animalType);
                            Console.WriteLine(kitten.ToString());
                            break;
                        case "Tomcat":
                            Tomcat tomcat = new Tomcat(animalInfo[0], int.Parse(animalInfo[1]));
                            Console.WriteLine(animalType);
                            Console.WriteLine(tomcat.ToString());
                            break;
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
