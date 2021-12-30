namespace DesignPatterns.CreationalPatterns.Factory
{
    public class AndroidButton : IButton
    {
        public void Click()
        {
            System.Console.WriteLine("Android button clicked");
        }

        public void Render()
        {
            throw new System.NotImplementedException();
        }
    }
}
