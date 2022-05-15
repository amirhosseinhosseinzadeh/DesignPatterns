using System;

namespace DesignPatterns.StructuralPatterns.Facade;

class MongoDb
{
    private ConnectionStatus _status = ConnectionStatus.NotConnected;

    ConnectionStatus Status 
    { 
        get
        {
            return _status;
        } 
    }

    string ConnectionString { get;set; }

    public ConnectionStatus Connect(string connectionString)
    {
        if(string.IsNullOrWhiteSpace(connectionString))
            Console.WriteLine("Trying to connect to object's connectionString");
        else 
            Console.WriteLine("Trying to connect to input's connectionString");

        _status = ConnectionStatus.Connected;

        return ConnectionStatus.Connected;
    }
}