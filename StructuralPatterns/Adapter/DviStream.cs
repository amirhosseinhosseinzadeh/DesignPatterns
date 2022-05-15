namespace DesignPatterns.Adapter
{
    public class DviStream
    {
        private byte[] _stream;

        public void SetData(byte[] data)
            => _stream = data;

        public byte[] GetData()
            => _stream;
    }
}