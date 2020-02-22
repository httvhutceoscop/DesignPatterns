namespace DesignPatterns.Examples.Factory
{
    public class SqlServerConnection : Connection
    {
        public override string GetConnectionString()
        {
            return "SQL Server";
        }
    }
}