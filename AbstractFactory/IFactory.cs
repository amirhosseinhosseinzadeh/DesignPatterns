namespace DesignPatterns.AbstractFactory
{
    public interface IFactory
    {
        FactoryDataItem GetData(int id);
    }

}