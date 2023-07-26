using LogForU.Core.Appenders.Interfaces;
using LogForU.Core.Enums;
using LogForU.Core.IO.Interfaces;
using LogForU.Core.Layouts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogForU.ConsoleApp.Factories.Interfaces
{
    public interface IAppenderFactory
    {
        IAppender CreateAppender(string type, ILayout layout, ReportLevel reportLevel, ILogFile logFile = null);
    }
}
