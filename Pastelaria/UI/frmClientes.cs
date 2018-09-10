using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pastelaria.UI
{
    public partial class frmClientes : Form
    {
        BLL.Cliente cli = new BLL.Cliente();
        DAL.ClienteDAL cliDAL = new DAL.ClienteDAL();
        bool editar = false;

        public frmClientes()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblTelefoneCliente_Click(object sender, EventArgs e)
        {

        }

        private void lblBairroCliente_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnCadastrarCli_Click(object sender, EventArgs e)
        {
            //Enviar Valores para a classe DLL
            cli.Bairro = txtBairroCliente.Text;
            cli.Celular = mtxtCelularCliente.Text;
            cli.Cep = txtEmailCliente.Text;
            cli.Cidade = txtEnderecoCliente.Text;
            cli.Cpf = mtxtCpfCliente.Text;
            cli.Email = txtEmailCliente.Text;
            cli.Endereco = txtEnderecoCliente.Text;
            cli.Nome = txtNomeCliente.Text;
            cli.Numero = txtNumeroCliente.Text;
            cli.Referencia = txtReferenciaCliente.Text;
            cli.Telefone = mtxtTelefoneCliente.Text;

            //Executar método de cadastro DAL
            if (editar == false)
                cliDAL.Cadastrar(cli);
            else
                cliDAL.Atualizar(cli);

            //Mensagem de confirmação
            MessageBox.Show("Dados Gravados com Sucesso");

            btnLimparCli.PerformClick();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            //Para chegar aqui cliquei duas vezes no formulario
            //Será executado ao abrir o formulario
            dgvConsultaCli.DataSource = cliDAL.ConsultarTodos();
        }

        private void btnLimparCli_Click(object sender, EventArgs e)
        {
            foreach (Control ctl in tabPage1.Controls)
            {
                if (ctl is TextBox || ctl is MaskedTextBox)
                {
                    ctl.Text = "";
                }
                txtNomeCliente.Focus();
            }
        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            cli.Nome = txtFiltrar.Text;
            dgvConsultaCli.DataSource = cliDAL.ConsultarPorNome(cli);
        }

        private void btnExcluirCli_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir este cliente?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            
            cli.Codcliente = Convert.ToInt16(dgvConsultaCli.SelectedCells[0].Value);
            cliDAL.Excluir(cli);
            dgvConsultaCli.DataSource = cliDAL.ConsultarTodos();
        }

        private void btnEditarCli_Click(object sender, EventArgs e)
        {
            //executar metodos de retorno
            if (dgvConsultaCli.RowCount > 0)
            {
                //Executar metodo de retorno dos dadoss
                cli.Codcliente = Convert.ToInt16(dgvConsultaCli.SelectedCells[0].Value);
                cli = cliDAL.RetornarDados(cli);

                //preenchendo txts
                txtNomeCliente.Text = cli.Nome;
                mtxtTelefoneCliente.Text = cli.Telefone;
                mtxtCelularCliente.Text = cli.Celular;
                txtEnderecoCliente.Text = cli.Endereco;
                txtNumeroCliente.Text = cli.Numero;
                txtBairroCliente.Text = cli.Bairro;
                txtCidadeCliente.Text = cli.Cidade;
                mtxtCpfCliente.Text = cli.Cpf;
                mtxtCep.Text = cli.Cep;
                txtEmailCliente.Text = cli.Email;
                txtReferenciaCliente.Text = cli.Referencia;                

                //redirecionando para a primeira aba
                tabControl1.SelectedTab = tabPage1;

                //editar para verdadeiro
                editar = true;
            }
        }
    }
}
