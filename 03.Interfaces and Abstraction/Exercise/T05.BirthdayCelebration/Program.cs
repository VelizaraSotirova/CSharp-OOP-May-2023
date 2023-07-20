using BirthdayCelebration.Models;
using BirthdayCelebration.Models.Interfaces;
using System;
using System.Collections.Generic;

namespace BorderControl
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<IBirthable> society = new List<IBirthable>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] inputInfo = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string type = inputInfo[0];
                if (type == "Citizen")
                {
                    IBirthable citizen = new Citizen(inputInfo[1], int.Parse(inputInfo[2]), inputInfo[3], inputInfo[4]);
                    society.Add(citizen);
                }
                else if (type == "Pet")
                {
                    IBirthable pet = new Pet(inputInfo[1], inputInfo[2]);
                    society.Add(pet);
                }
            } 

            string year = Console.ReadLine();

            foreach (var element in society)
            {
                if (element.Birthdate.EndsWith(year))
                {
                    Console.WriteLine(element.Birthdate);
                }
            }
        }
    }
}
