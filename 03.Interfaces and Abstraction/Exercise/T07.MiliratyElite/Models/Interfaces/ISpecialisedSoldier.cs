using MiliratyElite.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiliratyElite.Models.Interfaces
{
    public interface ISpecialisedSoldier : IPrivate
    {
        Corps Corps { get; }
    }
}
