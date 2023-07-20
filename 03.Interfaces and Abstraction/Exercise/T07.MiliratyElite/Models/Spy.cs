using MiliratyElite.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiliratyElite.Models
{
    public class Spy : Soldier, ISpy
    {
        public Spy(int id, string firstName, string lastName, int codeNumber)
            : base(id, firstName, lastName)
        {
            CodeNumber = codeNumber;
        }

        public int CodeNumber { get; private set; }

        public override string ToString()
           => base.ToString() + $"{Environment.NewLine}Code Number: {CodeNumber: f2}";
    }
}
