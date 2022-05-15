namespace DesignPatterns.StructuralPatterns.Composite
{
    class Product : IProduct
    {
        public decimal Price { get; set; }

        public decimal GetPrice() 
        {
            return Price;
        }
    }
}
