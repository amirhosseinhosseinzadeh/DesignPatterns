namespace DesignPatterns.StructuralPatterns
{
    class Adapter
    {
        private IData data;

        public Adapter(IData data)
        {
            this.data = data;
        }

        public IData Convert() 
        {
            if (data is XML)
                return new Json();
            else 
                return new XML();
        }

    }
}
