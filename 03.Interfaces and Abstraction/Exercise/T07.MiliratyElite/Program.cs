using MiliratyElite.Core;
using MiliratyElite.Core.Interfaces;
using System;

namespace MiliratyElite
{
    public class Program
    {
        static void Main(string[] args)
        {
            IEngine engine = new Engine();
            engine.Run();
        }
    }
}
