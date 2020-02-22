namespace DesignPatterns.Examples.Factory
{
    public class MySQLConnection : Connection
    {
        public override string GetConnectionString()
        {
            return "MySQL";
        }
    }
}