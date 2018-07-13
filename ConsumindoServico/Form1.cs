using ConsumindoServico.ServiceReference1;
using System;
using System.Windows.Forms;

namespace ConsumindoServico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string cpf = txtCPF.Text;

            try
            {
                ClienteServiceClient servico = new ClienteServiceClient();
                Cliente clienteCadastro = new Cliente();
                clienteCadastro.nome = nome;
                clienteCadastro.cpf = cpf;
                servico.Add(clienteCadastro);

                MessageBox.Show("Cliente cadastrado com sucesso");
            }
            catch (Exception)
            {
                // salvaria um log
            }
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;

            try
            {
                ClienteServiceClient servico = new ClienteServiceClient();
                Cliente resultado = servico.Buscar(nome);
                txtCPF.Text = resultado.cpf;
            }
            catch (Exception)
            {
                // salva um log
            }
        }
    }
}
