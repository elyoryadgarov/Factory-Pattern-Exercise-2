namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter which Database you would like to connect to:");
            Console.WriteLine("SQL, Mongo or List?");
            // var dbName = Console.ReadLine();
            // var dataBase = DataAccessFactory.CreateDataAccess(dbName);
            
            string input = Console.ReadLine();
            while (true)
            {
                if (input.Any(char.IsDigit))
                {
                    Console.WriteLine("Invalid option, try again:");
                    input = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }
            var dataBase = DataAccessFactory.CreateDataAccess(input);
            dataBase.LoadData();
            dataBase.SaveData();
        }
    }
}
