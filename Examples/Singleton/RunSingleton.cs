using System;

namespace DesignPatterns.Examples.Singleton
{
    public class RunSingleton
    {
        public static void Run()
        {
            Console.WriteLine("===== Singleton =====");
            Console.WriteLine("\n");

            Console.WriteLine("You wrote log file");
            Logger.Instance.WriteLog(DateTime.Now.ToString("yyyy-MM-dd HH:mm") + ": Run Singleton");

            Console.WriteLine("\n");
        }
    }
}