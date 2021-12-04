using static System.Console;
using DesignPatterns.Adapter;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Setting input for dvi Monitor!");
            VgaGraphicsCard vgaGraphicsCard= new();
            DviMonitor dviMonitor = new();
            VgaGraphicsCardAdapter vgaGraphicsCardAdapter = new(vgaGraphicsCard);
            dviMonitor.SetInput(vgaGraphicsCardAdapter.GetDviStream());
            ReadLine();
        }
    }
}
