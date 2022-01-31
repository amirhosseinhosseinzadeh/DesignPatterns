namespace DesignPatterns.CreationalPatterns.AbstractFactory.Babak
{
    class MacFactory : GUIFactory
    {
        public Button CreateButtton() { return new MacButton(); }
        public Window CreateWindow() { return new MacWindow(); }
    }
}
