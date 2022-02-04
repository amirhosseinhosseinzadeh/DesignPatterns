namespace DesignPatterns.CreationalPatterns
{
    public class HouseDirector
    {
        public IHouse CreateModernHouse() 
        {
            var modernHouse = new ModernHouse();

            modernHouse.BuildFoundation();
            modernHouse.BuildFloor();
            modernHouse.BuildWalls();
            modernHouse.BuildCeiling();
            modernHouse.BuildDoors();
            modernHouse.BuildWindows();
            modernHouse.BuildGarden();
            modernHouse.BuildPool();

            return modernHouse;
        }

        public IHouse CreateWoodenHouse()
        {
            var woodenHouse = new WoodenHouse();

            woodenHouse.BuildFoundation();
            woodenHouse.BuildFloor();
            woodenHouse.BuildWalls();
            woodenHouse.BuildCeiling();
            woodenHouse.BuildDoors();
            woodenHouse.BuildWindows();
            woodenHouse.BuildGarden();
            woodenHouse.BuildPool();

            return woodenHouse;
        }
    }
}
