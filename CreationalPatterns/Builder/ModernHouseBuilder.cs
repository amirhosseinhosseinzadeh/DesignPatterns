namespace DesignPatterns.CreationalPatterns
{
    internal class ModernHouseBuilder : IBuilder
    {
        public IHouse House { get; set; }

        internal ModernHouseBuilder()
        {
            House = new ModernHouse();
        }

        public void BuildWalls()
        {
            House.WallType = "Modern";
        }

        public void BuildFloor() { }
        public void BuildFoundation() { }
        public void BuildDoors() { }
        public void BuildWindows() { }
        public void BuildCeiling() { }
        public void BuildGarden() { }
        public void BuildPool() { }
    }
}
