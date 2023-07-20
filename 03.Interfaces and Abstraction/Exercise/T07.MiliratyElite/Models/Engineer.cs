using MiliratyElite.Enums;
using MiliratyElite.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiliratyElite.Models
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        public Engineer(int id, string firstName, string lastName, decimal salary, Corps corps, IReadOnlyCollection<IRepair> repairs)
            : base(id, firstName, lastName, salary, corps)
        {
            this.Repairs = repairs;
        }

        public IReadOnlyCollection<IRepair> Repairs { get; private set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Repairs:");
            foreach (var currRepair in Repairs)
            {
                sb.AppendLine($"  {currRepair.ToString()}");
            }
            return sb.ToString().TrimEnd();

        }
    }
}
