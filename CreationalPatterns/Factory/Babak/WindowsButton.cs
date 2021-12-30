namespace DesignPatterns.CreationalPatterns.Factory
{
    public class WindowsButton : IButton
    {
        public void Click() 
        {
            System.Console.WriteLine("Windows button clicked");
        }

        public void Render()
        {
            throw new System.NotImplementedException();
        }
    }
}
