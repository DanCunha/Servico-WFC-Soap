
namespace Passagens
{
    public class ClienteService : IClienteService
    {
        public void Add(ClienteWS c)
        {
            ClienteDao dao = new ClienteDao();
            dao.Add(c);
        }

        public ClienteWS Buscar(string nome)
        {
            ClienteDao dao = new ClienteDao();
            return dao.Buscar(nome);
        }
    }
}
