namespace DesignPatterns.CreationalPatterns
{
    public interface IBuilder
    {
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
