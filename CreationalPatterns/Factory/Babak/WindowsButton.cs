namespace DesignPatterns.CreationalPatterns.Factory
{
    class WindowsButton : IButton
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
