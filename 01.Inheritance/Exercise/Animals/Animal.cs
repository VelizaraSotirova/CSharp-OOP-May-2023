﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public abstract class Animal
    {
        private string name;
        private int age;
        private string gender;

        public Animal(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    new ArgumentException("Invalid input");
                }
                name = value;
            }
        }
        public int Age 
        {
            get => age; 
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid operation");
                }
                age = value;
            }
        }
        public string Gender
        {
            get => gender;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    new ArgumentException("Invalid input");
                }
                gender = value;
            }
        }

        public abstract string ProduceSound();

        public override string ToString() 
            => $"{Name} {Age} {Gender}{Environment.NewLine}{ProduceSound()}";
    }
}
