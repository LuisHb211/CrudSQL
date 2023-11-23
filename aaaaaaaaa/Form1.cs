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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAluno_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Form2>();
        }

        private void btnLivro_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Form3>();
        }

        private void btnEmprestimo_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Form4>();
        }
        private void AbrirFormNoPanel<Forms>() where Forms : Form, new()
        {
            Form formulario;
            formulario = panelConteudo.Controls.OfType<Forms>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new Forms();
                formulario.TopLevel = false;
                //formulario.FormBorderStyle = FormBorderStyle.None;
                //formulario.Dock = DockStyle.Fill;
                panelConteudo.Controls.Add(formulario);
                panelConteudo.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                if (formulario.WindowState == FormWindowState.Minimized)
                    formulario.WindowState = FormWindowState.Normal;
                formulario.BringToFront();
            }

        }
    }
}
