using MiliratyElite.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiliratyElite.Models
{
    public class Repair : IRepair
    {
        public Repair(string name, int hoursWorked)
        {
            Name = name;
            this.HoursWorked = hoursWorked;
        }

        public string Name { get; private set; }

        public int HoursWorked { get; private set; }

        public override string ToString()
            => $"Part Name: {Name} Hours Worked: {HoursWorked}";
    }
}
