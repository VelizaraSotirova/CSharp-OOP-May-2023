﻿using LogForU.Core.Enums;
using LogForU.Core.IO.Interfaces;
using LogForU.Core.Layouts.Interfaces;
using LogForU.Core.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogForU.Core.Appenders
{
    public class FileAppender : Appender
    {
        public FileAppender(ILayout layout, ILogFile logFile, ReportLevel reportLevel = ReportLevel.Info)
            : base(layout, reportLevel)
        {
            LogFile = logFile;
        }

        public ILogFile LogFile { get; private set; }

        public override void AppendMessage(Messages message)
        {
            string content =
                string.Format(Layout.Format, message.CreatedTime, message.ReportLevel, message.Text) + Environment.NewLine;

            File.AppendAllText(LogFile.FullPath, content);

            MessagesAppended++;
        }

        public override string ToString()
            => $"{base.ToString()}, File size: {LogFile.Size}";
    }
}