using System;
using System.Collections.Generic;
using System.Text;

namespace MiliratyElite.Models.Interfaces
{
    public interface ISpy : ISoldier
    {
        int CodeNumber { get; }
    }
}
