using System.ServiceModel;

namespace Passagens
{
    [ServiceContract]
    public interface IClienteService
    {
        [OperationContract]
        void Add(ClienteWS c);

        [OperationContract]
        ClienteWS Buscar(string nome);
    }
}
