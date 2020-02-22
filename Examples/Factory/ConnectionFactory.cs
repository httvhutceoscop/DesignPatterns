namespace DesignPatterns.Examples.Factory
{
    public enum DbType
    {
        MySQL,
        SQLServer,
        Oracle
    }
    public class ConnectionFactory
    {
        public static Connection CreateConnection(DbType dbType)
        {
            Connection connection = null;
            switch(dbType)
            {
                case DbType.MySQL:
                    connection = new MySQLConnection();
                    break;
                case DbType.SQLServer:
                    connection = new SqlServerConnection();
                    break;
                case DbType.Oracle:
                    connection = new OracleConnection();
                    break;
                default:
                    break;
            }

            return connection;
        }
        
    }
}