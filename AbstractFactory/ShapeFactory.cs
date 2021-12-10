using System;
using DesignPatterns.AbstractFactory.Shapes;

namespace DesignPatterns.AbstractFactory
{
    public class ShapeFactory : AbstractFactory
    {
        public override FactoryDataItem GetData(int id)
        {
            FactoryDataItem factoryDataItem = id switch
            {
                (int)ShapeTypes.Circle => new FactoryDataItem(new Circle()) ,
                (int)ShapeTypes.Rectangle => new FactoryDataItem(new Rectangle()),
                (int)ShapeTypes.Square => new FactoryDataItem(new Square()),
                _ => throw new Exception()
            };
            return factoryDataItem;
        }
    }
}