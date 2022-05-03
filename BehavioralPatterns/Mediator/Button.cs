using System;

namespace BehavioralPatterns;

public class Button: Component
{
    public Button(Mediator dialog = null):base(dialog)
    {
    }

    public new void Click()
    {
        Console.WriteLine("Button "+ Name +" clicked");

        _dialog.Notify(this, "Click");
    }

    public new void KeyPress()
    {
        _dialog.Notify(this, "KeyPress");
    }
}