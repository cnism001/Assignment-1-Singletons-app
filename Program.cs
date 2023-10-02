using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_Singletons_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get the instance of the Logger class in main programm
            Logger logger = Logger.GetInstance;

            // Add some messages to Logs list and display them
            logger.TextLog("System error.");
            logger.TextLog("Unauthorized access.");
            logger.TextLog("Generic system report.");

            /*Could be used to show all the log messages added to the log list
            for (int i = 0; i < .Count; i++)
            {
                Console.WriteLine(logger.Logs[i]);
            }
            */

        }
    }
}
