using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPatterns.Bridge.Babak
{
    interface Device
    {
        void Enable();
        void Disable();
        bool IsEnabled();
        void SetVolume(int volume);
        int GetVolume();
        void SetChannel(int channel);
        int GetChannel();
    }
}
