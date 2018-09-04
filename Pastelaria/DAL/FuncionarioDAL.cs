using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;//Importante
using System.Data.SqlClient;//Importante

namespace Pastelaria.DAL
{
    class FuncionarioDAL
    {
        Conexao con = new Conexao();

        public void Cadastrar(BLL.Funcionario func)
        {
            SqlCommand cmd = new SqlCommand(@"INSERT INTO FUNCIONARIO (NOME, FUNCAO, SALARIO, CELULAR) VALUES (@NOME, @FUNCAO, @SALARIO, @CELULAR)");

            cmd.Connection = con.Conectar();
            cmd.Parameters.AddWithValue("@NOME",func.Nome);
            cmd.Parameters.AddWithValue("@FUNCAO",func.Funcao);
            cmd.Parameters.AddWithValue("@SALARIO",func.Salario);
            cmd.Parameters.AddWithValue("@CELULAR",func.Celular);

            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        public void Atualizar(BLL.Funcionario func)
        {
            SqlCommand cmd = new SqlCommand(@"UPDATE FUNCIONARIO SET NOME = @NOME, FUNCAO = @FUNCAO, SALARIO = @SALARIO, CELULAR =  @CELULAR WHERE CODFUNCIONARIO = @CODFUNCIONARIO");

            cmd.Connection = con.Conectar();

            cmd.Parameters.AddWithValue("@CODFUNCIONARIO", func.Codfuncionario);
            cmd.Parameters.AddWithValue("@NOME", func.Nome);
            cmd.Parameters.AddWithValue("@FUNCAO", func.Funcao);
            cmd.Parameters.AddWithValue("@SALARIO", func.Salario);
            cmd.Parameters.AddWithValue("@CELULAR", func.Celular);

            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        public DataTable ConsultarTodos()
        {
            SqlDataAdapter da = new SqlDataAdapter(@"SELECT CODFUNCIONARIO [Código], NOME Nome, FUNCAO [Função], SALARIO [Salário], CELULAR Celular FROM FUNCIONARIO ORDER BY Nome", con.Conectar());
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Desconectar();
            return dt;
        }

        public DataTable ConsultatPorNome(BLL.Funcionario func)
        {
            SqlDataAdapter da = new SqlDataAdapter(@"SELECT CODFUNCIONARIO [Código], NOME Nome, FUNCAO [Função], SALARIO [Salário], CELULAR Celular FROM FUNCIONARIO WHERE Nome LIKE @Nome ORDER BY Nome", con.Conectar());
            da.SelectCommand.Parameters.AddWithValue("@Nome", func.Nome + "%");
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Desconectar();
            return dt;
        }

        public void Excluir(BLL.Funcionario func)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM FUNCIONARIO WHERE CODFUNCIONARIO = @CODFUNCIONARIO");
            cmd.Connection = con.Conectar();
            cmd.Parameters.AddWithValue("@CODFUNCIONARIO", func.Codfuncionario);
            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        public BLL.Funcionario RetornarDados(BLL.Funcionario func)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM FUNCIONARIO WHERE CODFUNCIONARIO = @CODFUNCIONARIO");
            cmd.Connection = con.Conectar();
            cmd.Parameters.AddWithValue("@CODFUNCIONARIO", func.Codfuncionario);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                func.Codfuncionario = Convert.ToInt16(dr["CODFUNCIONARIO"]);
                func.Nome = dr["NOME"].ToString();
                func.Salario = Convert.ToDouble(dr["SALARIO"]);
                func.Funcao = dr["FUNCAO"].ToString();
                func.Celular = dr["CELULAR"].ToString();
            }

            dr.Close();
            con.Desconectar();
            return func;

        }

    }
}
