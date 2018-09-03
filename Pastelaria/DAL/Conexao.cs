using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;//Precisa
using System.Data.SqlClient;//Precisa

namespace Pastelaria.DAL
{
    class Conexao
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-81NJOA4; Initial Catalog=BDPASTELARIA; Integrated Security=True;");

        public SqlConnection Conectar(){
            if (con.State == ConnectionState.Closed)
                con.Open();
            return con;            
        }

        public void Desconectar(){
            if (con.State == ConnectionState.Open)            
                con.Close();            
        }



    }
}
