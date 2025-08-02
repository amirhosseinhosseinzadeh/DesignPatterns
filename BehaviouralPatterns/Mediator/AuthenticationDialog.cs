using System;

namespace BehavioralPatterns;

public class AuthenticatoinDialog : Mediator
{
    private Component _component1;

    public AuthenticatoinDialog(Component component)
    {
        component.SetMediator(this);
    }

    public void Notify(Component component, string _event)
    {
        if(_event.ToLower() == "click")
        {
            Console.WriteLine("Mediator knows that button "+ component.Name + " has been clicked.");
        }
    }
}