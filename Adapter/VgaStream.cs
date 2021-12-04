namespace DesignPatterns.Adapter
{
    public class VgaStream
    {
        private byte[] _stream;

        public void SetData(byte[] data)
            => _stream = data;

        public byte[] GetData()
            => _stream;
    }
}