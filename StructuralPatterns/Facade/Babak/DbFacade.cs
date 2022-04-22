namespace DesignPatterns.StructuralPatterns.Facade;

class DbFacade
{
    ConnectionStatus ConnectMongoDb(string connectionString)
    {
        var mongoDb = new MongoDb();
        return mongoDb.Connect(null);
    }

    ConnectionStatus ConnectSqlDb(string connectionString)
    {
        var sqlDb = new SqlDb();
        return sqlDb.Connect(null);
    }
}