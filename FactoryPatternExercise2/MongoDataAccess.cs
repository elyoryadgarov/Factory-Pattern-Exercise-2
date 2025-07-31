namespace FactoryPatternExercise2;

public class MongoDataAccess : IDataAccess
{
    public void LoadData()
    {
        Console.WriteLine($"I am reading data from {base.GetType().Name}");
    }

    public void SaveData()
    {
        Console.WriteLine($"I am saving data to a {base.GetType().Name} database");
    }
}