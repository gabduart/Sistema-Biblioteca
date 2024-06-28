using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.BLL
{
    class Funcionario
    {
        private int idfuncionario;
        private string nome;
        private string cargo;
        private DateTime datacontratacao;
        private double salario;
        private string telefone;
        private string email;
        private string endereco;
        private DateTime nascimento;
        private string observacoes;
        private int visible;

        public int Idfuncionario { get => idfuncionario; set => idfuncionario = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public DateTime DataContratacao { get => datacontratacao; set => datacontratacao = value; }
        public double Salario { get => salario; set => salario = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Email { get => email; set => email = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public DateTime Nascimento { get => nascimento; set => nascimento = value; }
        public string Observacoes { get => observacoes; set => observacoes = value; }
        public int Visible { get => visible; set => visible = value; }
    }
}
