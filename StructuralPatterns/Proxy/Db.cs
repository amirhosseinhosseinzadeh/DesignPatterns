namespace DesignPatterns.Structural.Proxy;

public interface Db 
{
    public bool Connect(string connectionString);
    public bool Transaction(string command);
}