using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pastelaria.BLL
{
    class Funcionario
    {
        int codfuncionario;

        public int Codfuncionario
        {
            get { return codfuncionario; }
            set { codfuncionario = value; }
        }

        string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        string funcao;

        public string Funcao
        {
            get { return funcao; }
            set { funcao = value; }
        }
        double salario;

        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }
        string celular;

        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }


    }
}
