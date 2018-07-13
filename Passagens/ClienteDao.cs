using System.Collections.Generic;
using System.Linq;

namespace Passagens
{
    public class ClienteDao
    {
        private static List<ClienteWS> clientes = new List<ClienteWS>();

        public void Add(ClienteWS c)
        {
            ClienteDao.clientes.Add(c);
        }

        public ClienteWS Buscar(string nome)
        {
            var resultado = ClienteDao.clientes.Where(c => c.nome.Equals(nome)).FirstOrDefault();
            return (ClienteWS)resultado;
        }
    }
}
