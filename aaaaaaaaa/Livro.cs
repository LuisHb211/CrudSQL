using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aaaaaaaaa
{
    internal class Livro
    {
        private string nome;
        private string autor;
        private string codigo;
        private string edicao;

        public string Nome { get => nome; set => nome = value; }
        public string Autor { get => autor; set => autor = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Edicao { get => edicao; set => edicao = value; }


        public Livro(string nome, string autor, string codigo, string edicao) 
        {
            this.nome = nome;
            this.autor = autor;
            this.codigo = codigo;
            this.edicao = edicao;
        }
    }
}
