using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPatterns.Bridge.Babak
{
    class Radio : Device
    {
        private bool enable;
        private int channel;
        private int volume;

        public void Disable() => enable = false;

        public void Enable() => enable = true;

        public int GetChannel() => channel;

        public int GetVolume() => volume;

        public bool IsEnabled() => enable;

        public void SetChannel(int channel) => channel = this.channel;

        public void SetVolume(int volume) => volume = this.volume;
    }
}
