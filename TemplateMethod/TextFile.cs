namespace DesignPatterns.TemplateMethod
{
    public class TextFile : DataProcessor
    {
        // public void ReadProcessAndSaveData()
        // {
        //     ReadFile();
        //     ProcessData();
        //     SaveToDb();
        // }
        
        public override void ReadFile()
        {
            System.Console.WriteLine("Text read file");
        }

        public override void ProcessData()
        {
            System.Console.WriteLine("Text process data");
        }

        // public void SaveToDb()
        // {
        //     System.Console.WriteLine("save to db");
        // }
    }
}