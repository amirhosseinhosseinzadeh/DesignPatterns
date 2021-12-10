namespace DesignPatterns.AbstractFactory
{
    public abstract class AbstractFactory : IFactory
    {
        public abstract FactoryDataItem GetData(int id);
    }
}