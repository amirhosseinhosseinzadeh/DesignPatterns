using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPatterns.Decorator
{
    public class BaseNotify: INotify
    {
        public void Notify() 
        {
            Console.WriteLine("Notification sent throught ...");
        }
    }
}
