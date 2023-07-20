using System;
using System.Collections.Generic;
using System.Text;

namespace MiliratyElite.Models.Interfaces
{
    public interface IPrivate : ISoldier
    {
        decimal Salary { get; }
    }
}
