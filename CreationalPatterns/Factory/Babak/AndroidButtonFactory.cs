namespace DesignPatterns.CreationalPatterns.Factory
{
    public class AndroidButtonFactory : ButtonFactory
    {
        public override IButton CreateButton() => new AndroidButton();
    }
}
