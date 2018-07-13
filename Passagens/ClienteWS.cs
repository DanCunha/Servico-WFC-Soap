using System.Runtime.Serialization;

namespace Passagens
{
    [DataContract]
    public class ClienteWS
    {
        [DataMember]
        public string nome { get; set; }

        [DataMember]
        public string cpf { get; set; }
    }
}
