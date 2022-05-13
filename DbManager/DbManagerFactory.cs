namespace DbManager
{
    public static class DbManagerFactory
    {
        public static DbManager CreateInstance(string connectionString)
        {
            return new DbManager(connectionString);
        }
    }
}
