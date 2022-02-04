namespace DesignPatterns.CreationalPatterns
{
    public class HouseDirector
    {
        public IHouse CreateModernHouse() 
        {
            var modernHouse = new ModernHouseBuilder();

            modernHouse.BuildFoundation();
            modernHouse.BuildFloor();
            modernHouse.BuildWalls();
            modernHouse.BuildCeiling();
            modernHouse.BuildDoors();
            modernHouse.BuildWindows();
            modernHouse.BuildGarden();
            modernHouse.BuildPool();

            return modernHouse.House;
        }

        public IHouse CreateWoodenHouse()
        {
            var woodenHouse = new WoodenHouseBuilder();

            woodenHouse.BuildFoundation();
            woodenHouse.BuildFloor();
            woodenHouse.BuildWalls();
            woodenHouse.BuildCeiling();
            woodenHouse.BuildDoors();
            woodenHouse.BuildWindows();
            woodenHouse.BuildGarden();
            woodenHouse.BuildPool();

            return woodenHouse.House;
        }
    }
}
