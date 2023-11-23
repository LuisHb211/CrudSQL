using FormsMySQL;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aaaaaaaaa
{
    internal class Emprestimo
    {
        private string cpf;
        private string codigo;
        private DateTime inicio;
        private DateTime fim;
        private int status;

        public string Cpf { get => cpf; set => cpf = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public DateTime Inicio { get => inicio; set => inicio = value; }
        public DateTime Fim { get => fim; set => fim = value; }
        public int Status { get => status; set => status = value; }

        public Emprestimo(string cpf, string codigo, DateTime inicio, DateTime fim, int status=0)
        {
            this.cpf = cpf;
            this.codigo = codigo;
            this.inicio = inicio;
            this.fim = fim;
            this.status = status;
        }

        public decimal CalcularValorEmprestimo()
        {
            decimal valorTotal = 0;

            TimeSpan duracaoEmprestimo = fim - inicio;

            valorTotal = 0.75m * Convert.ToDecimal(duracaoEmprestimo.Days);

            return valorTotal;
        }

        public void DevolverEmprestimo(decimal valorEmprestimo)
        {
            this.status = 0;

            Conexao stringConexao = new Conexao();
            string con = stringConexao.ConnString();

            using (MySqlConnection conection = new MySqlConnection(con))
            {
                conection.Open();

                string commandText = "UPDATE emprestimo SET id_status = 0 WHERE cpf_aluno = @cpf AND codigo_livro = @codigo";

                using (MySqlCommand sqlCommand = new MySqlCommand(commandText, conection))
                {
                    sqlCommand.Parameters.AddWithValue("@cpf", this.Cpf);
                    sqlCommand.Parameters.AddWithValue("@codigo", this.Codigo);

                    sqlCommand.ExecuteNonQuery();
                }
            }
        }
    }
}
