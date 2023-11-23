using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aaaaaaaaa
{
    internal class Usuario
    {
        private string nome;
        private string matricula;
        private string cpf;

        public string Nome { get => nome; set => nome = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public string Cpf { get => cpf; set => cpf = value; }

        public Usuario(string nome, string matricula, string cpf) 
        {
            this.nome = nome;
            this.matricula = matricula;
            this.cpf = cpf;
        }
    }
}
