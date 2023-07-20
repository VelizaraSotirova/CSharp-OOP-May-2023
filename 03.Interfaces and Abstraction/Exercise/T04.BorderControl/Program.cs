using BorderControl.Models.Interfaces;
using System;
using System.Collections.Generic;

namespace BorderControl
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<IIdentifiable> society = new List<IIdentifiable>();

            string input;
            while((input = Console.ReadLine()) != "End")
            {
                string[] inputInfo = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (inputInfo.Length == 3)
                {
                    IIdentifiable citizens = new Citizens(inputInfo[0], int.Parse(inputInfo[1]), inputInfo[2]);
                    society.Add(citizens);
                }
                else
                {
                    IIdentifiable robots = new Robots(inputInfo[0], inputInfo[1]);
                    society.Add(robots);
                }
            }

            int fakeIds = int.Parse(Console.ReadLine());
            foreach (var element in society)
            {
                if (element.Id.EndsWith(fakeIds.ToString()))
                {
                    Console.WriteLine(element.Id);
                }
            }
        }
    }
}
