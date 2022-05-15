namespace DesignPatterns.CreationalPatterns.Factory
{
    public abstract class ButtonFactory
    {
        public abstract IButton CreateButton();

        public void Render(string buttonType) 
        {
            
        }
    }
}
