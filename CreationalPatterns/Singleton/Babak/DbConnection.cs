namespace DesignPatterns.CreationalPatterns.Singleton.Babak
{
    class DbConnection
    {
        private DbConnection dbConnection;
        private DbConnection() 
        {
        }

        public DbConnection GetDbConnection() 
        {
            if (dbConnection == null)
                dbConnection = new();

            return dbConnection;
        }
    }
}
