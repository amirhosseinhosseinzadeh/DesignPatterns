namespace DesignPatterns.CreationalPatterns.Factory
{
    public class WindowsButtonFactory : ButtonFactory
    {
        public WindowsButton CreateButton() => new WindowsButton();
    }
}
