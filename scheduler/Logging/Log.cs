using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scheduler.Logging
{
    public class Log
    {
        //Fields
        private readonly static DateTime currentDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
        private readonly static string fileName = $"{currentDate.ToString("M-yyyy")}.txt";
        private readonly static string path = $"Logs\\{fileName}";

        //Functions
        private static bool NewLogCheck()
        {
            /* Checks the /Logs/ directory for the most recent log file
             * and compares against the current date. If the current date is a later month
             * a new log file is created.
            */

            var directory = new DirectoryInfo("Logs");  //Log directory assigned
            FileInfo myFile;                            //File system information
            DateTime latestLog = new DateTime();        //DateTime variable for currentDate comparison

            //Searches the /Logs/ directory, discarding the thrown exception if empty
            try
            {
                myFile = directory.GetFiles()
                    .OrderByDescending(f => f.LastWriteTime)
                    .First();
            }
            catch (InvalidOperationException invalidOpEx)
            {
                myFile = null;
            }

            //If no files are present in the directory, true condition is met. Else, the most
            //recently created file date is assigned for comparison
            if (myFile != null )
            {
                latestLog = myFile.CreationTimeUtc;
            }
            else
            {
                return true;
            }

            //Compares the most recent log file date against the current date to determine new log creation need
            if (currentDate.Year > latestLog.Year)
            {
                return true;
            }
            else
            {
                if (currentDate.Month > latestLog.Month)
                {
                    return true;
                }
                else return false;
            }
        }

        public static void CreateLog(string username, DateTime timestamp, bool result)
        {
            //Creates the Log directory if not found
            System.IO.Directory.CreateDirectory($"..\\Debug\\Logs");

            //Determines whether to write a success of failure message
            switch (result)
            {
                case true:
                    if (NewLogCheck())
                    {
                        //Create a new file with a successful login message
                        using (StreamWriter sw = File.CreateText(path))
                        {
                            sw.WriteLine($"Successful login for user: {username} at {timestamp}");
                        }
                    }
                    else
                    {
                        //Create a successful login message
                        using (StreamWriter sw = (File.AppendText(path)))
                        {
                            sw.WriteLine($"Successful login for user: {username} at {timestamp}");
                        }
                    }
                    break;
                case false:
                    if (NewLogCheck())
                    {
                        //Create a new file with an unsuccessful login message
                        using (StreamWriter sw = File.CreateText(path))
                        {
                            sw.WriteLine($"Unsuccessful login for user: {username} at {timestamp}");
                        }
                    }
                    else
                    {
                        //Create an unsuccessful login message
                        using (StreamWriter sw = (File.AppendText(path)))
                        {
                            sw.WriteLine($"Unsuccessful login for user: {username} at {timestamp}");
                        }
                    }
                    break;
            }  
        }
    }
}
