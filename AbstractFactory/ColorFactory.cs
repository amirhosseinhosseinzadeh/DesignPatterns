using System;
using DesignPatterns.AbstractFactory.Colors;

namespace DesignPatterns.AbstractFactory
{
    public class ColorFactory : AbstractFactory
    {
        public override FactoryDataItem GetData(int id)
        {
            FactoryDataItem factoryDataItem = id switch
            {
                (int)ColorTypes.Green => new FactoryDataItem(new Green()),
                (int)ColorTypes.Red => new FactoryDataItem(new Red()),
                (int)ColorTypes.Yellow => new FactoryDataItem(new Yellow()),
                _ => throw new Exception()
            };
            return factoryDataItem;
        }
    }
}