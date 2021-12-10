namespace DesignPatterns.Adapter
{
    public class VgaGraphicsCardAdapter
    {
        private VgaGraphicsCard _vgaGraphicsCard;

        public VgaGraphicsCardAdapter(VgaGraphicsCard vgaGraphicsCard)
        {
            _vgaGraphicsCard = vgaGraphicsCard;
        }

        public DviStream GetDviStream()
        {
            byte[] vgaData = _vgaGraphicsCard.GetVgaStream().GetData();
            //Process and convert vga to dvi data
            byte[] dviData = ConvetFromVgaToDvi(vgaData);
            DviStream dviStream = new();
            dviStream.SetData(dviData);
            return dviStream;
        }

        private byte[] ConvetFromVgaToDvi(byte[] input)
        {
            System.Console.WriteLine("convert vag video to dvi video");
            return new byte[] { };
        }
    }
}