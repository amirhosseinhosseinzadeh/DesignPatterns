namespace DesignPatterns.CreationalPatterns
{
    public class Logger
    {
        // A field from current object
        private static Logger _logger;
        public static Logger Instance
        {
            get
            {
                if(_logger == null)
                {
                    _logger = new();
                }
                return _logger;
            }
        }

        // make constructor private
        private Logger()
        { }
    }
}