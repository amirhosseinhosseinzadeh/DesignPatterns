using DesignPatterns.Visitor;
using static System.Console;
namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var marshalObject = new User()
            {
                Age = 40,
                LastName = "Doe",
                Name = "John"
            };
            var protobufSerialized = marshalObject.Shift(new ProtobufSerializer());
            var jsonSerialized = marshalObject.Shift(new JsonSerializer());
            var utf8Encoded = marshalObject.Shift(new Utf8Encoder());
            WriteLine("Completed!");
            ReadLine();
        }
    }
}
