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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public void limparTextBox()
        {
            tbNome.Text = String.Empty;
            tbAutor.Text = String.Empty;
            tbCodigo.Text = String.Empty;
            tbEdicao.Text = String.Empty;
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            Livro objLivro = new Livro(tbNome.Text, tbAutor.Text, tbCodigo.Text, tbEdicao.Text);

            Conexao stringConexao = new Conexao();
            string con = stringConexao.ConnString();
            MySqlConnection conection = new MySqlConnection(con);
            conection.Open();

            string commandText = String.Format("INSERT INTO livros(nome, autor, codigo, edicao) " +
                "values('{0}', '{1}', '{2}', {3})", objLivro.Nome, objLivro.Autor, objLivro.Codigo, objLivro.Edicao);
            using (MySqlCommand sqlcommand = new MySqlCommand(commandText, conection))
            {
                sqlcommand.ExecuteNonQuery();
            }

            conection.Close();
            MessageBox.Show("Cadastro inserido com sucesso");
            limparTextBox();
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {

            int codigo = Convert.ToInt32(tbCodigo.Text);
            Livro objLivro = new Livro(tbNome.Text, tbAutor.Text, tbCodigo.Text, tbEdicao.Text);

            Conexao stringConexao = new Conexao();
            string con = stringConexao.ConnString();
            MySqlConnection conection = new MySqlConnection(con);
            conection.Open();

            string commandText = String.Format("update livros set nome = '{0}', autor = '{1}', edicao = '{2}' where codigo = '{3}'", objLivro.Nome, objLivro.Autor, objLivro.Edicao, codigo);
            using (MySqlCommand sqlcommand = new MySqlCommand(commandText, conection))
            {
                sqlcommand.ExecuteNonQuery();
            }

            conection.Close();
            MessageBox.Show("Cadastro atualizado com sucesso");
            limparTextBox();
        }

        private void btDeletar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(tbCodigo.Text);

            Conexao stringConexao = new Conexao();
            string con = stringConexao.ConnString();
            MySqlConnection conection = new MySqlConnection(con);
            conection.Open();

            string commandText = string.Format("delete from Livros where codigo = '{0}'", codigo);
            using (MySqlCommand sqlcommand = new MySqlCommand(commandText, conection))
            {
                sqlcommand.ExecuteNonQuery();
            }
            conection.Close();
            MessageBox.Show("Cadastro deletado com sucesso");
            limparTextBox();
        }
    }
}
