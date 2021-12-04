namespace DesignPatterns.Adapter
{
    public class DviMonitor
    {
        private byte[] _inputStream;

        public void SetInput (DviStream inputStream)
        {
            _inputStream = inputStream.GetData();
        }

    }
}