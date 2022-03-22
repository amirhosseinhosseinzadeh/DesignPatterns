using System.Collections.Generic;

namespace DesignPatterns.StructuralPatterns.Composite
{
    public class Box : IProduct
    {
        private List<IProduct> children = new List<IProduct>();

        public void Add(IProduct product) 
        {
            children.Add(product);
        }

        public void Remove(IProduct product) 
        {
            children.Remove(product);
        }

        public decimal GetPrice() 
        {
            decimal returnValue = 0;

            foreach (var child in children)
                returnValue += child.GetPrice();
            
            return returnValue;
        }
    }
}
