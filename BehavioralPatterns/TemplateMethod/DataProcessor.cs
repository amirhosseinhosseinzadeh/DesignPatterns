namespace DesignPatterns.TemplateMethod
{
    public abstract class DataProcessor
    {
        public void ReadProcessAndSaveData()
        {
            ReadFile(); // compiler error 
            ProcessData(); // compiler error 
            SaveToDb();
        }

        public abstract void ReadFile();

        public abstract void ProcessData();

        public void SaveToDb()
        {
            System.Console.WriteLine("Save to db");
        }
    }
}