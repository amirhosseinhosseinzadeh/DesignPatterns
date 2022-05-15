using DesignPatterns.CreationalPatterns;

namespace DesignPatterns.CreationalPatterns
{
    public class Customer : Prototype
    {
        private Religions.Religion _religion;
        private string _name; 
        public string Name 
        {
            get => _name;
            set 
            {
                if (value.ToLower().Contains("ali"))
                    _religion = Religions.Religion.Islam;
                else _religion = Religions.Religion.Christianity;
                _name = value;
            } 
        }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public Prototype Clone() 
        {
            return new Customer()
            {
                Name = Name,
                LastName = LastName,
                PhoneNumber = PhoneNumber,
                _religion = _religion
            };
        }
    }
}
