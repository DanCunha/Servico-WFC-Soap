
using System.Collections.Generic;

namespace Passagens
{
    public class ClienteService : IClienteService
    {
        public bool Add(string nome, string cpf)
        {
            ClienteWS c = new ClienteWS();
            c.nome = nome;
            c.cpf = cpf;

            ClienteDao dao = new ClienteDao();
            dao.Add(c);

            return true;
        }

        public ClienteWS Buscar(string nome)
        {
            ClienteDao dao = new ClienteDao();
            return dao.Buscar(nome);
        }

        public List<ClienteWS> Listar()
        {
            ClienteDao dao = new ClienteDao();
            return dao.Listar();
        }
    }
}
