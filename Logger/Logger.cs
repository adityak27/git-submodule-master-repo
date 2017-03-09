using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class Logger
    {
        private static Logger loggerInstance = null;
        private static string filePath = null;

        // Singleton class
        private Logger(string fPath)
        {
            filePath = fPath;
        }
        public static Logger GetLogger(string filePath)
        {
            if (loggerInstance != null)
                loggerInstance = new Logger(filePath);
            return loggerInstance;
        }

        public static void LogMessage(string message)
        {
            StreamWriter sw = File.AppendText(filePath);
            sw.WriteLine(message);
        }
    }
}
