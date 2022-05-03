namespace BehavioralPatterns.Proxy;

public interface Db 
{
    public bool Connect(string connectionString);
    public bool Transaction(string command);
}