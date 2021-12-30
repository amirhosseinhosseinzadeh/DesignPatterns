using System;

namespace DesignPatterns.CreationalPatterns.Factory
{
    public class ButtonFactory
    {
        public IButton CreateButton(string buttonType)
            => buttonType.ToLower() switch
            {
                "windows" => new WindowsButton(),
                "android" => new AndroidButton(),
                _ => throw new ArgumentException()
            };

        // Note that, despite its name, the creator's primary
        // responsibility isn't creating products. It usually
        // contains some core business logic that relies on product
        // objects returned by the factory method. Subclasses can
        // indirectly change that business logic by overriding the
        // factory method and returning a different type of product
        // from it.
        public void Render(string buttonType) 
        {
            //Some business logic after the creation of the button
            var button = CreateButton(buttonType);
            button.Render();
        }
    }
}
