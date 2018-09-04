using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Pastelaria.DAL
{
    class ProdutoDAL
    {
        Conexao con = new Conexao();

        public void Cadastrar(BLL.Produto prod)
        {
            SqlCommand cmd = new SqlCommand(@"INSERT INTO PRODUTO (NOMEPRODUTO, QUANTIDADE, PRECO, OBS) VALUES (@NOMEPRODUTO, @QUANTIDADE, @PRECO, @OBS)");

            cmd.Connection = con.Conectar();

            cmd.Parameters.AddWithValue("@NOMEPRODUTO", prod.Nomeproduto);
            cmd.Parameters.AddWithValue("@QUANTIDADE", prod.Quantidade);
            cmd.Parameters.AddWithValue("@PRECO", prod.Preco);
            cmd.Parameters.AddWithValue("@OBS", prod.Obs);

            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        public void Atualizar(BLL.Produto prod)
        {
            SqlCommand cmd = new SqlCommand(@"UPDATE PRODUTO SET NOMEPRODUTO = @NOMEPRODUTO, QUANTIDADE = @QUANTIDADE, PRECO = @PRECO, OBS =  @OBS WHERE CODPRODUTO = @CODPRODUTO");

            cmd.Connection = con.Conectar();

            cmd.Parameters.AddWithValue("@CODPRODUTO", prod.Codproduto);
            cmd.Parameters.AddWithValue("@NOMEPRODUTO", prod.Nomeproduto);
            cmd.Parameters.AddWithValue("@QUANTIDADE", prod.Quantidade);
            cmd.Parameters.AddWithValue("@PRECO", prod.Preco);
            cmd.Parameters.AddWithValue("@OBS", prod.Obs);

            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        public DataTable ConsultarTodos()
        {
            SqlDataAdapter da = new SqlDataAdapter(@"SELECT CODPRODUTO AS [Codígo], NOMEPRODUTO AS Produto, QUANTIDADE AS Quantidade, PRECO AS Preço, OBS AS [Observãção] FROM PRODUTO ORDER BY NOMEPRODUTO", con.Conectar());//Passando comando sql
            DataTable dt = new DataTable(); //criando o data table
            da.Fill(dt);//Preenchendo data table
            con.Desconectar(); //fecha conexao
            return dt; //retorna
        }

        public DataTable ConsultarPorNome(BLL.Produto prod)
        {
            SqlDataAdapter da = new SqlDataAdapter(@"SELECT CODPRODUTO AS [Codígo], NOMEPRODUTO AS Produto, QUANTIDADE AS Quantidade, PRECO AS Preço, OBS AS [Observãção] FROM PRODUTO WHERE NOMEPRODUTO LIKE @NOMEPRODUTO ORDER BY NOMEPRODUTO", con.Conectar());//Passando comando sql
            da.SelectCommand.Parameters.AddWithValue("@NOMEPRODUTO", prod.Nomeproduto + "%");
            DataTable dt = new DataTable(); //criando o data table
            da.Fill(dt);//Preenchendo data table
            con.Desconectar(); //fecha conexao
            return dt; //retorna
        }

        public void Excluir(BLL.Produto prod)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM PRODUTO WHERE CODPRODUTO = @CODPRODUTO");
            cmd.Connection = con.Conectar();
            cmd.Parameters.AddWithValue("@CODPRODUTO", prod.Codproduto);
            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        public BLL.Produto RetornarDados(BLL.Produto prod)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM PRODUTO WHERE CODPRODUTO = @CODPRODUTO");
            cmd.Connection = con.Conectar();
            cmd.Parameters.AddWithValue("@CODPRODUTO", prod.Codproduto);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                prod.Codproduto = Convert.ToInt16(dr["CODPRODUTO"]);
                prod.Nomeproduto = dr["NOMEPRODUTO"].ToString();
                prod.Quantidade = Convert.ToInt16(dr["QUANTIDADE"]);
                prod.Preco = Convert.ToDouble(dr["PRECO"]);
                prod.Obs = dr["OBS"].ToString();
            }

            dr.Close();
            con.Desconectar();
            return prod;

        }        


    }
}
