using Raiding.IO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding.IO
{
    public class ConsoleReader : IConsoleReader
    {
        public string ReadLine()
            => Console.ReadLine();
    }
}
