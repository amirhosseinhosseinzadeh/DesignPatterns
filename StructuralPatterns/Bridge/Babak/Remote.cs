using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPatterns.Bridge.Babak
{
    class Remote
    {
        private Device Device;

        internal void TogglePower() 
        {
            if (Device.IsEnabled())
                Device.Disable();
            else Device.Enable();
        }

        internal void VolumeUp(int count) 
        {
            var deviceVolume = Device.GetVolume();
            var newVolume = deviceVolume + count;

            Device.SetVolume(newVolume);
        }
        internal void VolumeDown(int count)
        {
            var deviceVolume = Device.GetVolume();
            var newVolume = deviceVolume - count;

            Device.SetVolume(newVolume);
        }

        internal void ChannelUp(int count)
        {
            var deviceChannel = Device.GetChannel();
            var newChannel = deviceChannel + count;

            Device.SetChannel(newChannel);
        }
        internal void ChannelDown(int count)
        {
            var deviceChannel = Device.GetChannel();
            var newChannel = deviceChannel - count;

            Device.SetChannel(newChannel);
        }
    }
}
