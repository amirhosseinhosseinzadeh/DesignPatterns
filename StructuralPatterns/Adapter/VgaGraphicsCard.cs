namespace DesignPatterns.Adapter
{
    public class VgaGraphicsCard
    {
        public VgaStream GetVgaStream()
        {
            VgaStream vga = new();
            vga.SetData(new byte[] { }); // data is not important 
            return vga;
        }
    }
}