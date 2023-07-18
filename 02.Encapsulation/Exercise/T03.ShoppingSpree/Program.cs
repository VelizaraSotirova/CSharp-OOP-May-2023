using ShoppingSpree.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();

            string[] nameMoneyPairs = Console.ReadLine()
                .Split(";");

            try
            {
                foreach (var item in nameMoneyPairs)
                {
                    string[] nameMoney = item
                        .Split("=");

                    Person person = new Person(nameMoney[0], decimal.Parse(nameMoney[1]));
                    people.Add(person);
                }


                string[] nameCostPairs = Console.ReadLine()
                    .Split(";");
                foreach (var item in nameCostPairs)
                {
                    string[] nameCost = item
                        .Split("=");

                    Product product = new Product(nameCost[0], decimal.Parse(nameCost[1]));
                    products.Add(product);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] personProduct = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string personName = personProduct[0];
                string productName = personProduct[1];

                Person person = people.FirstOrDefault(people => people.Name == personName);
                Product product = products.FirstOrDefault(product => product.Name == productName);

                if (person != null && product != null)
                {
                    Console.WriteLine(person.AddProduct(product));
                }
            }

            foreach (var person in people)
            {
                Console.WriteLine(person);
            }
        }
    }
}
