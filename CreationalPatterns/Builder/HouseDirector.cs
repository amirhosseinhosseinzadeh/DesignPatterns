namespace DesignPatterns.CreationalPatterns
{
    public class HouseDirector
    {
        private IHouse _house;

        public HouseDirector(IHouse house) 
        {
            _house = house;
        }

        public void BuildHouse() 
        {
            _house.BuildFoundation();
            _house.BuildFloor();
            _house.BuildWalls();
            _house.BuildWindows();
            _house.BuildDoors();
            _house.BuildCeiling();
            _house.BuildGarden();
            _house.BuildPool();
        }
    }
}
