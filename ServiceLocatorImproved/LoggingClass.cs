using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ServiceLocatorImproved
{
    class LoggingClass
    {
        private StreamWriter logFile;
        public void Log(string txt)
        {
            InternalLog(txt);
        }

        public void LogFormat(string txt, params object[] p)
        {
            string message = string.Format(txt, p);
            InternalLog(message);
        }

        private void InternalLog(string txt)
        {
            if(logFile == null)
            {
                logFile = new StreamWriter("actions.log");
            }
            
            logFile.WriteLine(txt);
            logFile.Flush();
        }
    }
}
