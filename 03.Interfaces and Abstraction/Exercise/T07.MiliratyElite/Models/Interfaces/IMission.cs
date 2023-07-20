using MiliratyElite.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiliratyElite.Models.Interfaces
{
    public interface IMission
    {
        string CodeName { get; }
        State State { get; }
        void CompleteMission();
    }
}
