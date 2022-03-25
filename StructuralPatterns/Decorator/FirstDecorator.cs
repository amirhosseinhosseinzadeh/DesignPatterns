using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPatterns.Decorator
{
    public class FirstDecorator : NotifyDecorator
    {
        private INotify _notify;

        public FirstDecorator(INotify notify) : base(notify)
        {
            _notify = notify;
        }

        public override void Notify() 
        {
            _notify.Notify();
            Console.WriteLine("First decorator");
        }
    }
}
