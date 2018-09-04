using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;//Precisa
using System.Data.SqlClient;//Precisa

namespace Pastelaria.DAL
{
    class ClienteDAL
    {
        //Teremos os metedos de acesso ao BD (Cadastro, Consulta, Alteração e Exclusão)
        Conexao con = new Conexao();

        //Cadastrar Cliente
        public void Cadastrar(BLL.Cliente cli){
            SqlCommand cmd = new SqlCommand(@"INSERT INTO CLIENTE (NOME, TELEFONE, CELULAR, EMAIL, ENDERECO, BAIRRO, CIDADE, NUMERO, CEP, REFERENCIA, CPF) VALUES (@NOME, @TELEFONE, @CELULAR, @EMAIL, @ENDERECO, @BAIRRO, @CIDADE, @NUMERO, @CEP, @REFERENCIA, @CPF)");//Passando Comando SQL

            cmd.Connection = con.Conectar();//Abrindo Conexao

            //Referindo parametros
            cmd.Parameters.AddWithValue("@NOME", cli.Nome);
            cmd.Parameters.AddWithValue("@TELEFONE", cli.Telefone);
            cmd.Parameters.AddWithValue("@CELULAR", cli.Celular);
            cmd.Parameters.AddWithValue("@EMAIL", cli.Email);
            cmd.Parameters.AddWithValue("@ENDERECO", cli.Endereco);
            cmd.Parameters.AddWithValue("@BAIRRO", cli.Bairro);
            cmd.Parameters.AddWithValue("@CIDADE", cli.Cidade);
            cmd.Parameters.AddWithValue("@NUMERO", cli.Numero);
            cmd.Parameters.AddWithValue("@CEP", cli.Cep);
            cmd.Parameters.AddWithValue("@REFERENCIA", cli.Referencia);
            cmd.Parameters.AddWithValue("@CPF", cli.Cpf);

            cmd.ExecuteNonQuery();//Executando Comando
            con.Desconectar();//Fechando Conexao
        }

        //public void Atualizar(BLL.Produto prod)
        //{
        //    SqlCommand cmd = new SqlCommand(@"UPDATE PRODUTO SET NOMEPRODUTO = @NOMEPRODUTO, QUANTIDADE = @QUANTIDADE, PRECO = @PRECO, OBS =  @OBS WHERE CODPRODUTO = @CODPRODUTO");

        //    cmd.Connection = con.Conectar();

        //    cmd.Parameters.AddWithValue("@NOME", cli.Nome);
        //    cmd.Parameters.AddWithValue("@TELEFONE", cli.Telefone);
        //    cmd.Parameters.AddWithValue("@CELULAR", cli.Celular);
        //    cmd.Parameters.AddWithValue("@EMAIL", cli.Email);
        //    cmd.Parameters.AddWithValue("@ENDERECO", cli.Endereco);
        //    cmd.Parameters.AddWithValue("@BAIRRO", cli.Bairro);
        //    cmd.Parameters.AddWithValue("@CIDADE", cli.Cidade);
        //    cmd.Parameters.AddWithValue("@NUMERO", cli.Numero);
        //    cmd.Parameters.AddWithValue("@CEP", cli.Cep);
        //    cmd.Parameters.AddWithValue("@REFERENCIA", cli.Referencia);
        //    cmd.Parameters.AddWithValue("@CPF", cli.Cpf);

        //    cmd.ExecuteNonQuery();
        //    con.Desconectar();
        //}

        public DataTable ConsultarTodos()
        {
            SqlDataAdapter da = new SqlDataAdapter(@"SELECT CODCLIENTE [Código], NOME Nome, TELEFONE Telefone, CELULAR Celular, EMAIL [E-mail], ENDERECO [Endereço], CIDADE Cidade, NUMERO [Número], CEP, REFERENCIA [Referência], CPF FROM CLIENTE ORDER BY Nome", con.Conectar());
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Desconectar();
            return dt;
        }

        public DataTable ConsultarPorNome(BLL.Cliente cli)
        {
            SqlDataAdapter da = new SqlDataAdapter(@"SELECT CODCLIENTE [Código], NOME Nome, TELEFONE Telefone, CELULAR Celular, EMAIL [E-mail], ENDERECO [Endereço], CIDADE Cidade, NUMERO [Número], CEP, REFERENCIA [Referência], CPF FROM CLIENTE WHERE Nome LIKE @NOME ORDER BY Nome", con.Conectar());
            da.SelectCommand.Parameters.AddWithValue("Nome", cli.Nome + "%");
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Desconectar();
            return dt;
        }

        public void Excluir(BLL.Cliente cli)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM CLIENTE WHERE CODCLIENTE = @CODCLIENTE");
            cmd.Connection = con.Conectar();
            cmd.Parameters.AddWithValue("@CODCLIENTE", cli.Codcliente);
            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

    }
}
