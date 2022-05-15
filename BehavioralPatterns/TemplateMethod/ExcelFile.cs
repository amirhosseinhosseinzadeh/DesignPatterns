namespace DesignPatterns.TemplateMethod
{
    public class ExcelFile : DataProcessor
    {
        // public void ReadProcessAndSaveData()
        // {
        //     ReadFile();
        //     ProcessData();
        //     SaveToDb();
        // }

        public override void ReadFile()
        {
            System.Console.WriteLine("Excel read file");
        }

        public override  void ProcessData()
        {
            System.Console.WriteLine("Excel process data");
        }

        // public void SaveToDb()
        // {
        //     System.Console.WriteLine("save to db");
        // }
    }
}