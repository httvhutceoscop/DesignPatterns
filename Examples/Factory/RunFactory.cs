using System;

namespace DesignPatterns.Examples.Factory
{
    public class RunFactory
    {
        public static void Run()
        {
            Console.WriteLine("===== Factory =====");
            Console.WriteLine("\n");

            var connection = ConnectionFactory.CreateConnection(DbType.Oracle);
            var connectionString = connection.GetConnectionString();

            Console.WriteLine("You're connecting with " + connection.GetConnectionString());
            Console.WriteLine("\n");
        }
    }
}