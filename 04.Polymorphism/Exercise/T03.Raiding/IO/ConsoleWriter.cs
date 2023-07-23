using Raiding.IO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding.IO
{
    public class ConsoleWriter : IConsoleWriter
    {
        public void WriteLine(string text)
            => Console.WriteLine(text);
    }
}
