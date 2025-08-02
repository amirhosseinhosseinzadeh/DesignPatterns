using BehavioralPatterns;

namespace BehavioralPatterns;

public abstract class Component
{
    protected Mediator _dialog;

    public string Name { get;set; }

    public Component(Mediator dialog = null)
    {
        _dialog = dialog;
    }

    public void SetMediator(Mediator dialog)
    {
        _dialog = dialog;
    }

    public void Click()
    {
        
    }

    public void KeyPress()
    {
        
    }
}