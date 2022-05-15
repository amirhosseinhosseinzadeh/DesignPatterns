namespace DesignPatterns.StructuralPatterns
{
    class Json : IData
    {
        public string Name { get => "Json"; set => Name = value; }
        public string Specific { get; set; }
    }
}
