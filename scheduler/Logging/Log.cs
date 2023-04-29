using System;
using System.IO;
using System.Linq;
namespace scheduler.Logging
{
    public class Log
    {
        //Fields
        private static readonly DateTime CurrentDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
        private static readonly string FileName = $"{CurrentDate.ToString("M-yyyy")}.txt";
        private static readonly string Path = $"Logs\\{FileName}";

        //Functions
        private static bool NewLogCheck()
        {
            /* Checks the /Logs/ directory for the most recent log file
             * and compares against the current date. If the current date is a later month
             * a new log file is created.
            */

            var directory = new DirectoryInfo("Logs");         //Log directory assigned
            FileInfo myFile;                                   //File system information
            DateTime latestLog = new DateTime().ToLocalTime(); //DateTime variable for currentDate comparison

            //Searches the /Logs/ directory, discarding the thrown exception if empty
            try
            {
                myFile = directory.GetFiles()
                    .OrderByDescending(f => f.LastWriteTime)
                    .First();
            }
            catch (InvalidOperationException exception)
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
            if (CurrentDate.Year > latestLog.Year)
            {
                return true;
            }
            else
            {
                if (CurrentDate.Month > latestLog.Month)
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
                        using (StreamWriter sw = File.CreateText(Path))
                        {
                            sw.WriteLine($"Successful login for user: {username} at {timestamp}");
                        }
                    }
                    else
                    {
                        //Create a successful login message
                        using (StreamWriter sw = (File.AppendText(Path)))
                        {
                            sw.WriteLine($"Successful login for user: {username} at {timestamp}");
                        }
                    }
                    break;
                case false:
                    if (NewLogCheck())
                    {
                        //Create a new file with an unsuccessful login message
                        using (StreamWriter sw = File.CreateText(Path))
                        {
                            sw.WriteLine($"Unsuccessful login for user: {username} at {timestamp}");
                        }
                    }
                    else
                    {
                        //Create an unsuccessful login message
                        using (StreamWriter sw = (File.AppendText(Path)))
                        {
                            sw.WriteLine($"Unsuccessful login for user: {username} at {timestamp}");
                        }
                    }
                    break;
            }  
        }
    }
}
