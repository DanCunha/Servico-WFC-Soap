using Passagens.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Passagens
{
    public class ClienteDao
    {
        private static List<ClienteWS> clientes = new List<ClienteWS>();
        private DataContext db = new DataContext();

        public void Add(ClienteWS c)
        {
            //ClienteDao.clientes.Add(c);
            Cliente cliente = new Cliente()
            {
                nome = c.nome,
                cpf = c.cpf
            };

            try
            {
                db.Cliente.Add(cliente);
                db.SaveChanges();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
            

        }

        public ClienteWS Buscar(string nome)
        {
            var resultado = ClienteDao.clientes.Where(c => c.nome.Equals(nome)).FirstOrDefault();
            return (ClienteWS)resultado;
        }

        public List<ClienteWS> Listar()
        {
            //var resultado = ClienteDao.clientes.ToList();

            var lista = db.Cliente.ToList();
            List<ClienteWS> listaws = new List<ClienteWS>();

            foreach (var item in lista)
            {
                ClienteWS ws = new ClienteWS()
                {
                    nome = item.nome,
                    cpf = item.cpf
                };
                listaws.Add(ws);
            }

            return listaws;
        }
    }
}
