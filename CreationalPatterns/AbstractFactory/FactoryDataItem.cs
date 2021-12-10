namespace DesignPatterns.AbstractFactory
{
    public class FactoryDataItem
    {
        private object _dataItem;

        public FactoryDataItem(object dataItem) => _dataItem = dataItem; 

        public object DataItem{get{return _dataItem;}}
    }
}