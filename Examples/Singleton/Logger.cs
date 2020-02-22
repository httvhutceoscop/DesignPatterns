using System;
using System.IO;

namespace DesignPatterns.Examples.Singleton
{
    public sealed class Logger
    {
        /// <summary>
        /// thread-safety variable
        /// </summary>
        /// <returns></returns>
        private static readonly Object lockObject = new Object();
        private static Logger instance = null;
        private string filePath = string.Empty;

        Logger()
        {
            Configure();
        }

        public static Logger Instance
        {
            get
            {
                // implement simple thread-safety
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new Logger();
                    }
                }

                return instance;
            }
        }

        /// <summary>
        /// Configure the log file
        /// </summary>
        private void Configure()
        {
            this.filePath = @"C:\Users\vietnguyen\Google Drive\Transcosmos\DesignPattern\DesignPatterns\tmp\log.txt";
        }

        /// <summary>
        /// Write message to log file
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public bool WriteLog(string message)
        {
            bool isOk = false;
            try
            {
                using (FileStream fileStream = new FileStream(this.filePath, FileMode.Append, FileAccess.Write))
                {
                    if (fileStream != null)
                    {
                        using (StreamWriter sw = new StreamWriter(fileStream))
                        {
                            sw.WriteLine(message);
                            sw.Close();
                            isOk = true;
                        }
                    }
                }
            }
            catch (System.Exception)
            {
                isOk = false;
            }

            return isOk;
        }
    }
}
