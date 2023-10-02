using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_Singletons_app
{
    

    //Singleton class
    class Logger
    {
        //private static variable for singular instance of class Logger, since there can'be be more
        //than one instance of the  Singleton pattern class 
        static private Logger GetInstance;

        //Private constructor, preventing instantiation from outside of Logger class, creates new Logs list when Instance is
        //first instantiated
        private Logger()
        {
            Logs = new List<string>();
        }

        //Method,returning singular instance of Logger class, creating instance if it didn't exist and then
        //returning it or returning existing instance
        public static Logger GetInstance()
        {


            if (GetInstance == null)
            {
                GetInstance = new Logger();
            }
            return GetInstance;

        }
        // List Logs, storing the logged messages, set to private to prevent changes done from outside of Logger class
        public List<string> Logs { get; private set; }

        // Public method TextLog,adds the string to the Logs list
        public void TextLog(string message)
        {
            Logs.Add(message);
            Console.WriteLine(message);
        }

    }

}
