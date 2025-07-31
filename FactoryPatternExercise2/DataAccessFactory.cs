namespace FactoryPatternExercise2;

public static class DataAccessFactory
{
    public static IDataAccess CreateDataAccess(string databaseType)
    {
        switch (databaseType.ToLower())
        {
            case "sql" :
                return new SQLDataAccess();
            case "list" :
                return new ListDataAccess();
            case "mongo" :
                return new MongoDataAccess();
            default:
                Console.WriteLine("Unknown database type: " + databaseType);
                return null;
        }
    }
}