using System.Runtime.Serialization;

namespace Passagens
{
    [DataContract]
    public class Cliente
    {
        [DataMember]
        public string nome { get; set; }

        [DataMember]
        public string cpf { get; set; }
    }
}
