using FormsMySQL;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aaaaaaaaa
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        public void limparTextBox()
        {
            tbCPF.Text = String.Empty;
            tbCodigo.Text = String.Empty;
            maskedTextBox1.Text = String.Empty;
            maskedTextBox2.Text = String.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int status = 1;

            if (string.IsNullOrWhiteSpace(tbCPF.Text) || string.IsNullOrWhiteSpace(tbCodigo.Text) || !IsValidDate(maskedTextBox1.Text) || !IsValidDate(maskedTextBox2.Text))
            {
                MessageBox.Show("Preencha todos os campos corretamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ExisteEmprestimo(tbCPF.Text, tbCodigo.Text))
            {
                MessageBox.Show("Já existe um empréstimo para o mesmo CPF e código do livro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Emprestimo emprestimo = new Emprestimo(tbCPF.Text, tbCodigo.Text, DateTime.Parse(maskedTextBox1.Text), DateTime.Parse(maskedTextBox2.Text), status);

            Conexao stringConexao = new Conexao();
            string con = stringConexao.ConnString();
            MySqlConnection conection = new MySqlConnection(con);
            conection.Open();

            string commandText = String.Format("INSERT INTO emprestimo(cpf_aluno, codigo_livro, data_inicio, data_fim, id_status) " +
                "values('{0}', '{1}', '{2}', '{3}', {4})",
                 emprestimo.Cpf, emprestimo.Codigo, emprestimo.Inicio.ToString("yyyy-MM-dd"), emprestimo.Fim.ToString("yyyy-MM-dd"), status);
            using (MySqlCommand sqlcommand = new MySqlCommand(commandText, conection))
            {
                sqlcommand.ExecuteNonQuery();
            }

            conection.Close();
            MessageBox.Show("Empréstimo feito com sucesso");
            limparTextBox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Emprestimo emprestimos = new Emprestimo(tbCPF.Text, tbCodigo.Text, DateTime.Parse(maskedTextBox1.Text), DateTime.Parse(maskedTextBox2.Text));

            Conexao stringConexao = new Conexao();
            string con = stringConexao.ConnString();
            MySqlConnection conection = new MySqlConnection(con);
            conection.Open();

            string commandText = String.Format("update emprestimo set data_inicio = '{0}', data_fim = '{1}' where cpf_aluno = '{2}' and codigo_livro = '{3}'", emprestimos.Inicio.ToString("yyyy-MM-dd"), emprestimos.Fim.ToString("yyyy-MM-dd"), emprestimos.Cpf, emprestimos.Codigo);
            using (MySqlCommand sqlcommand = new MySqlCommand(commandText, conection))
            {
                sqlcommand.ExecuteNonQuery();
            }

            conection.Close();
            MessageBox.Show("Empréstimo atualizado com sucesso");
            limparTextBox();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string cpf = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["cpf_aluno"].Value);
                string codigoLivro = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["codigo_livro"].Value);
                string inicioStr = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["data_inicio"].Value);

                if (DateTime.TryParse(inicioStr, out DateTime inicio))
                {
                    Emprestimo emprestimo = new Emprestimo(cpf, codigoLivro, inicio, DateTime.Now, 1);

                    decimal valorEmprestimo = emprestimo.CalcularValorEmprestimo();

                    MessageBox.Show($"Valor do empréstimo a ser pago: R${valorEmprestimo.ToString("0.00")}");

                    emprestimo.DevolverEmprestimo(valorEmprestimo);

                    button4_Click(sender, e);

                    MessageBox.Show("Devolução realizada com sucesso");
                    limparTextBox();
                }
                else
                {
                    MessageBox.Show("Formato de data inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nenhuma linha selecionada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Conexao stringConexao = new Conexao();
            string con = stringConexao.ConnString();
            MySqlConnection conection = new MySqlConnection(con);
            conection.Open();

            DataTable dt = new DataTable();
            string commandText = "select * from emprestimo order by id_emprestimo";
            using (MySqlDataAdapter adpt = new MySqlDataAdapter(commandText, conection))
            {
                adpt.Fill(dt);
            }
            dataGridView1.DataSource = dt;
            conection.Close();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tbCPF.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
            tbCodigo.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            maskedTextBox1.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
            maskedTextBox2.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
        }

        private bool IsValidDate(string date)
        {
            DateTime result;
            return DateTime.TryParse(date, out result);
        }
        private bool ExisteEmprestimo(string cpf, string codigoLivro)
        {
            Conexao stringConexao = new Conexao();
            string con = stringConexao.ConnString();
            MySqlConnection conection = new MySqlConnection(con);
            conection.Open();

            string commandText = "SELECT COUNT(*) FROM emprestimo WHERE cpf_aluno = @cpf AND codigo_livro = @codigo";
            using (MySqlCommand sqlCommand = new MySqlCommand(commandText, conection))
            {
                sqlCommand.Parameters.AddWithValue("@cpf", cpf);
                sqlCommand.Parameters.AddWithValue("@codigo", codigoLivro);

                int count = Convert.ToInt32(sqlCommand.ExecuteScalar());
                return count > 0;
            }
        }
    }
}
