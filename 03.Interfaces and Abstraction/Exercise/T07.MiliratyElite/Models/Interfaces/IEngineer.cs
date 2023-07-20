using System;
using System.Collections.Generic;
using System.Text;

namespace MiliratyElite.Models.Interfaces
{
    public interface IEngineer : ISpecialisedSoldier
    {
        IReadOnlyCollection<IRepair> Repairs { get; }
    }
}
