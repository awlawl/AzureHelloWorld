using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWebJob
{
    class Program
    {
        static void Main(string[] args)
        {
            string testConfigSetting = ConfigurationManager.AppSettings["TestConfigSetting"];

            if (string.IsNullOrEmpty(testConfigSetting))
            {
                Console.WriteLine("The config value was empty.");
            }
            else
            {
                Console.WriteLine("The config value is:" + testConfigSetting);
            }

            Console.WriteLine("Running here part 3."); //this is the one that you can see in the webjob logs
            Debug.WriteLine("This is a debug message.");

        }
    }
}
