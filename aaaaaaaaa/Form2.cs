using FormsMySQL;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace aaaaaaaaa
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void limparTextBox()
        {
            tbNome.Text = String.Empty;
            tbMatricula.Text = String.Empty;
            tbCPF.Text = String.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario objAluno = new Usuario(tbNome.Text, tbMatricula.Text, tbCPF.Text);

            Conexao stringConexao = new Conexao();
            string con = stringConexao.ConnString();
            MySqlConnection conection = new MySqlConnection(con);
            conection.Open();

            string commandText = String.Format("INSERT INTO alunos(nome, matricula, cpf) " +
                "values('{0}', '{1}', '{2}')", objAluno.Nome, objAluno.Matricula, objAluno.Cpf);
            using (MySqlCommand sqlcommand = new MySqlCommand(commandText, conection))
            {
                sqlcommand.ExecuteNonQuery();
            }

            conection.Close();
            MessageBox.Show("Cadastro inserido com sucesso");
            limparTextBox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cpf = tbCPF.Text;
            Usuario objAluno = new Usuario(tbNome.Text, tbMatricula.Text, tbCPF.Text);

            Conexao stringConexao = new Conexao();
            string con = stringConexao.ConnString();
            MySqlConnection conection = new MySqlConnection(con);
            conection.Open();

            string commandText = String.Format("update alunos set cpf = '{0}', nome = '{1}' where cpf = '{2}'", objAluno.Cpf, objAluno.Nome, cpf);
            using (MySqlCommand sqlcommand = new MySqlCommand(commandText, conection))
            {
                sqlcommand.ExecuteNonQuery();
            }

            conection.Close();
            MessageBox.Show("Cadastro atualizado com sucesso");
            limparTextBox();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string cpf = tbCPF.Text;

            Conexao stringConexao = new Conexao();
            string con = stringConexao.ConnString();
            MySqlConnection conection = new MySqlConnection(con);
            conection.Open();

            string commandText = string.Format("delete from alunos where cpf = '{0}'", cpf);
            using (MySqlCommand sqlcommand = new MySqlCommand(commandText, conection))
            {
                sqlcommand.ExecuteNonQuery();
            }

            conection.Close();
            MessageBox.Show("Cadastro excluido com sucesso");
            limparTextBox();
        }

        private void button4_Click(object sender, EventArgs e)
        {
              
        }
    }
}



