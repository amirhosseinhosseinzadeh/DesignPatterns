using System;

namespace BehavioralPatterns.Proxy;

public class DbProxy: Db
{
    public bool Connect(string connectionString)
    {
        Console.WriteLine(connectionString);
        return true;
    }

    public bool Transaction(string command)
    {
        Console.WriteLine(command);
        return true;
    }
}