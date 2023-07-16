﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual int Age
        {
            get { return age; }
            set 
            {
                if (value >= 0)
                {
                    age = value; 
                }
            }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public override string ToString()
        {
            return $"Name: {name}, Age: {age}";
        }
    }
}
