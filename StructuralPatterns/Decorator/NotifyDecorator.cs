using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPatterns.Decorator
{
    public abstract class NotifyDecorator : INotify
    {
        private INotify _notify;

        public NotifyDecorator(INotify notify)
        {
            _notify = notify;
        }

        public virtual void Notify() 
        {
            _notify.Notify();
            Console.WriteLine("Base decorator");
        }
    }
}
