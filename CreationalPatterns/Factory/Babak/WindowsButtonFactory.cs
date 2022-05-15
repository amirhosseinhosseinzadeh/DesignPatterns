namespace DesignPatterns.CreationalPatterns.Factory
{
    public class WindowsButtonFactory : ButtonFactory
    {
        public override IButton CreateButton() => new WindowsButton();
    }
}
