using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingSpree.Models
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> products;

        public Person(string name, decimal money)
        {
            products = new List<Product>();
            Name = name;
            Money = money;
        }

        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                name = value;
            }
        }
        public decimal Money
        {
            get => money;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                money = value;
            }
        }

        public string AddProduct(Product product)
        {
            if (money < product.Cost)
            {
                return $"{Name} can't afford {product.Name}";
            }
            products.Add(product);
            Money -= product.Cost;
            return $"{Name} bought {product.Name}";
        }

        public override string ToString()
        {
            string productsString = products.Any()
        /*if*/  ? string.Join(", ", products.Select(n => n.Name))
      /*else*/  : "Nothing bought";
            return $"{Name} - {productsString}";
        }
    }
}
