using System;
using Telephony.Models;
using Telephony.Models.Interfaces;

namespace Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] urls = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            ICalling phone;

            foreach (var number in phoneNumbers)
            {
                if (number.Length == 10)
                {
                    phone = new Smartphone();
                }
                else
                {
                    phone = new StationaryPhone();
                }

                try
                {
                    Console.WriteLine(phone.Call(number));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            IBrowsing browsing = new Smartphone();

            foreach (var url in urls)
            {
                try
                {
                    Console.WriteLine(browsing.Browse(url));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
