using System;
using BehavioralPatterns;

namespace BehavioralPatterns;

public interface Mediator
{
    public void Notify(Component sender, string _event)
    {
        if(_event.ToLower() == "click")
        {
            Console.WriteLine("Mediator knows that " + sender.Name + " button has been clicked");
        }
    }
}