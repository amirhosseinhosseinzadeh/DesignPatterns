namespace DesignPatterns.CreationalPatterns.AbstractFactory.Babak
{
    class WindowsFactory : GUIFactory
    {
        public Button CreateButtton() { return new WindowsButton(); }
        public Window CreateWindow() { return new WindowsWindow(); }
    }
}
