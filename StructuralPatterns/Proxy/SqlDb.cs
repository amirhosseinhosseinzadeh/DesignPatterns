namespace DesignPatterns.Structural.Proxy;

public class SqlDb: Db
{
    public bool Connect(string connectionString)
    {
        return true;        
    }

    public bool Transaction(string command)
    {
        return true;
    }
}