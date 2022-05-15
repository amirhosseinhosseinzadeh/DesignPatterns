namespace DesignPatterns.CreationalPatterns
{
    public interface IBuilder
    {
        IHouse House { get; set; }
        void BuildWalls();
        void BuildFloor();
        void BuildFoundation();
        void BuildDoors();
        void BuildWindows();
        void BuildCeiling();
        void BuildGarden();
        void BuildPool();
    }
}
