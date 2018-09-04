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
    public partial class frmProdutos : Form
    {
        BLL.Produto prod = new BLL.Produto();
        DAL.ProdutoDAL prodDAL = new DAL.ProdutoDAL();
        bool editar = false; //Controle de edição false=cadastra verdadeiro=atualizar

        public frmProdutos()
        {
            InitializeComponent();
        }

        private void txtSalarioFunc_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrarProd_Click(object sender, EventArgs e)
        {
            prod.Nomeproduto = txtNomeProd.Text;
            prod.Quantidade = Convert.ToInt32(txtQuantidadeProd.Text);
            prod.Preco = Convert.ToDouble(txtPrecoProd.Text);
            prod.Obs = txtObsProd.Text;

            if (editar == false)
                prodDAL.Cadastrar(prod);
            else
                prodDAL.Atualizar(prod);

            MessageBox.Show("Dados Gravados com Sucesso!");

            dgvConsultaProd.DataSource = prodDAL.ConsultarTodos();            
        }

        private void frmProdutos_Load(object sender, EventArgs e)
        {
            //Para chegar aqui cliquei duas vezes no formulario
            //Será executado ao abrir o formulario
            dgvConsultaProd.DataSource = prodDAL.ConsultarTodos();  
        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            prod.Nomeproduto = txtFiltrar.Text;
            dgvConsultaProd.DataSource = prodDAL.ConsultarPorNome(prod);
        }

        private void dgvConsultaProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLimparProd_Click(object sender, EventArgs e)
        {
            foreach (Control ctl in tabPage1.Controls)
            {
                if (ctl is TextBox || ctl is MaskedTextBox)
                {
                    ctl.Text = "";
                }
                txtNomeProd.Focus();
            }
            editar = false;
        }

        private void lblFiltrar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluirProd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir este produto?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Enviar o código do produto
                prod.Codproduto = Convert.ToInt16(dgvConsultaProd.SelectedCells[0].Value);           
                prodDAL.Excluir(prod);
                dgvConsultaProd.DataSource = prodDAL.ConsultarTodos();
            }
        }

        private void btnEditarProd_Click(object sender, EventArgs e)
        {
            //executar metodos de retorno
            if (dgvConsultaProd.RowCount > 0)
            {
                //Executar metodo de retorno dos dadoss
                prod.Codproduto = Convert.ToInt16(dgvConsultaProd.SelectedCells[0].Value);
                prod = prodDAL.RetornarDados(prod);

                //preenchendo txts
                txtNomeProd.Text = prod.Nomeproduto;
                txtObsProd.Text = prod.Obs;
                txtPrecoProd.Text = prod.Preco.ToString();
                txtQuantidadeProd.Text = prod.Quantidade.ToString();

                //redirecionando para a primeira aba
                tabControl1.SelectedTab = tabPage1;

                //editar para verdadeiro
                editar = true;
            }

        }
    }
}
