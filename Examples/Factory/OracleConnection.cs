namespace DesignPatterns.Examples.Factory
{
    public class OracleConnection : Connection
    {
        public OracleConnection()
        {

        }

        public override string GetConnectionString()
        {
            return "Oracle";
        }
    }
}