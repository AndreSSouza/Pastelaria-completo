using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pastelaria.BLL
{
    class Cliente
    {
        int codcliente;
        string nome;
        string telefone;
        string celular;
        string email;
        string endereco;
        string bairro;
        string cidade;
        string numero;
        string cep;
        string referencia;
        string cpf;

        public int Codcliente
        {
            get { return codcliente; }
            set { codcliente = value; }
        }        
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }
        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }
        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }
        public string Referencia
        {
            get { return referencia; }
            set { referencia = value; }
        }
        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
    }
}
