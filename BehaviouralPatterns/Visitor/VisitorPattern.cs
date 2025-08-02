using System.IO;
using ProtoBuf;
using Newtonsoft.Json;
using System.Text;

namespace DesignPatterns.Visitor
{
    public interface IMarshalVisitor<TShiftResult>
    {
        TShiftResult Visit<TMarshalObject>(TMarshalObject model) where TMarshalObject : IMarshalSupport;
    }
    public class JsonSerializer : IMarshalVisitor<string>
    {
        public string Visit<TMarshalObject>(TMarshalObject model) where TMarshalObject : IMarshalSupport
        {
            try
            {
                var serializaionResult = JsonConvert.SerializeObject(model);
                return serializaionResult;
            }
            catch
            {
                //log
                throw;
            }
        }
    }
    public class ProtobufSerializer : IMarshalVisitor<byte[]>
    {
        public byte[] Visit<TMarshalObject>(TMarshalObject model) where TMarshalObject : IMarshalSupport
        {
            try
            {
                using MemoryStream ms = new();
                Serializer.Serialize(ms, model);
                return ms.ToArray();
            }
            catch
            {
                //log
                throw;
            }
        }
    }
    public class Utf8Encoder : IMarshalVisitor<byte[]>
    {
        public byte[] Visit<TMarshalObject>(TMarshalObject model) where TMarshalObject : IMarshalSupport
        {
            try
            {
                var content = Encoding.UTF8.GetBytes(model.ToString());
                return content;
            }
            catch
            {
                //log
                throw;
            }
        }
    }
    public interface IMarshalSupport
    {
        // Acceptor
        T Shift<T>(IMarshalVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }
    }
    [ProtoContract]
    public record User : IMarshalSupport
    {
        [ProtoMember(1)]
        public string Name { get; set; }
        [ProtoMember(2)]
        public string LastName { get; set; }
        [ProtoMember(3)]
        public int Age { get; set; }
        public T Shift<T>(IMarshalVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }
    }
}
