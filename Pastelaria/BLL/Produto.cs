using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pastelaria.BLL
{
    class Produto
    {
        private int codproduto;
        private string nomeproduto;
        private int quantidade;
        private double preco;
        private string obs;

        public int Codproduto
        {
            get { return codproduto; }
            set { codproduto = value; }
        }

        public string Nomeproduto
        {
            get { return nomeproduto; }
            set { nomeproduto = value; }
        }
        

        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }
        

        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }
        

        public string Obs
        {
            get { return obs; }
            set { obs = value; }
        }

        



    }
}
