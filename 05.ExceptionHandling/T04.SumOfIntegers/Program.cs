using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Xml.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        int sum = 0;

        
        for (int i = 0; i < inputs.Length; i++) 
        {
            try
            {
                if (int.Parse(inputs[i]) is int)
                {
                    sum += int.Parse(inputs[i]);

                    Console.WriteLine($"Element '{inputs[i]}' processed - current sum: {sum}");
                    
                }
            }
            catch (FormatException fEx)
            {
                Console.WriteLine($"The element '{inputs[i]}' is in wrong format!");
                Console.WriteLine($"Element '{inputs[i]}' processed - current sum: {sum}");

            }
            catch (OverflowException oEx)
            {
                Console.WriteLine($"The element '{inputs[i]}' is out of range!");
                Console.WriteLine($"Element '{inputs[i]}' processed - current sum: {sum}");
                
            }
        }

        Console.WriteLine($"The total sum of all integers is: {sum}");
    }
}