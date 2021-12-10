using static System.Console;
using DesignPatterns.AbstractFactory;
using DesignPatterns.AbstractFactory.Colors;
using DesignPatterns.AbstractFactory.Shapes;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory shapeFactory = new ShapeFactory();
            ColorFactory colorFactory = new ColorFactory();

            Circle circle  = shapeFactory.GetData((int)ShapeTypes.Circle).DataItem as Circle;
            circle.GetInfo();

            Red red  = colorFactory.GetData((int)ColorTypes.Red).DataItem as Red;
            red.GetInfo();
        }
    }
}
