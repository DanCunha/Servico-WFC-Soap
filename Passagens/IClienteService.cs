using System.ServiceModel;

namespace Passagens
{
    [ServiceContract]
    public interface IClienteService
    {
        [OperationContract]
        void Add(Cliente c);

        [OperationContract]
        Cliente Buscar(string nome);
    }
}
