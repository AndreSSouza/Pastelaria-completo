﻿using System;
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
    public partial class frmFuncionarios : Form
    {
        BLL.Funcionario func = new BLL.Funcionario();
        DAL.FuncionarioDAL funcDAL = new DAL.FuncionarioDAL();
        bool editar = false;

        public frmFuncionarios()
        {
            InitializeComponent();
        }

        private void btnCadastrarFunc_Click(object sender, EventArgs e)
        {
            func.Nome = txtNomeFunc.Text;
            func.Funcao = txtFuncaoFunc.Text;
            func.Salario = Convert.ToDouble(txtSalarioFunc.Text);
            func.Celular = mtxtCelularFunc.Text;            

            if (editar == false)
                funcDAL.Cadastrar(func);
            else
                funcDAL.Atualizar(func);

            MessageBox.Show("Cadastrado com Sucesso!");

            dgvConsultaFunc.DataSource = funcDAL.ConsultarTodos();

            btnLimparFunc.PerformClick();
        }

        private void btnLimparFunc_Click(object sender, EventArgs e)
        {
            foreach(Control ctl in tabPage1.Controls){
                if(ctl is TextBox || ctl is MaskedTextBox){
                    ctl.Text = "";
                }
                txtNomeFunc.Focus();
            }
        }

        private void frmFuncionarios_Load(object sender, EventArgs e)
        {
            dgvConsultaFunc.DataSource = funcDAL.ConsultarTodos();
        }

        private void dgvConsultaProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            func.Nome = txtFiltrar.Text;
            dgvConsultaFunc.DataSource = funcDAL.ConsultatPorNome(func);
        }
       

        private void btnExcluirFunc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir este funcionario?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Enviar o código do funcionario
                func.Codfuncionario = Convert.ToInt16(dgvConsultaFunc.SelectedCells[0].Value);
                funcDAL.Excluir(func);
                dgvConsultaFunc.DataSource = funcDAL.ConsultarTodos();                
            }
        }

        private void btnEditarFunc_Click(object sender, EventArgs e)
        {
            //executar metodos de retorno
            if (dgvConsultaFunc.RowCount > 0)
            {
                //Executar metodo de retorno dos dadoss
                func.Codfuncionario = Convert.ToInt16(dgvConsultaFunc.SelectedCells[0].Value);
                func = funcDAL.RetornarDados(func);

                //preenchendo txts                                 
                txtNomeFunc.Text = func.Nome;
                txtFuncaoFunc.Text = func.Funcao;
                txtSalarioFunc.Text = func.Salario.ToString();
                mtxtCelularFunc.Text = func.Celular.ToString();

                //redirecionando para a primeira aba
                tabControl1.SelectedTab = tabPage1;

                //editar para verdadeiro
                editar = true;
            }

        }

        private void dgvConsultaFunc_DoubleClick(object sender, EventArgs e)
        {

            btnEditarFunc.PerformClick();
        }    
    }
}
