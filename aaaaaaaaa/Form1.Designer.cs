namespace aaaaaaaaa
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelCabecalho = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnEmprestimo = new System.Windows.Forms.Button();
            this.btnLivro = new System.Windows.Forms.Button();
            this.btnAluno = new System.Windows.Forms.Button();
            this.panelConteudo = new System.Windows.Forms.Panel();
            this.panelCabecalho.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCabecalho
            // 
            this.panelCabecalho.BackColor = System.Drawing.Color.Goldenrod;
            this.panelCabecalho.Controls.Add(this.label1);
            this.panelCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecalho.Location = new System.Drawing.Point(0, 0);
            this.panelCabecalho.Name = "panelCabecalho";
            this.panelCabecalho.Size = new System.Drawing.Size(800, 59);
            this.panelCabecalho.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(40, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gerenciamento da biblioteca";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.panelMenu.Controls.Add(this.btnEmprestimo);
            this.panelMenu.Controls.Add(this.btnLivro);
            this.panelMenu.Controls.Add(this.btnAluno);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 59);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(136, 391);
            this.panelMenu.TabIndex = 2;
            // 
            // btnEmprestimo
            // 
            this.btnEmprestimo.FlatAppearance.BorderSize = 0;
            this.btnEmprestimo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnEmprestimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmprestimo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmprestimo.ForeColor = System.Drawing.Color.White;
            this.btnEmprestimo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmprestimo.Location = new System.Drawing.Point(6, 222);
            this.btnEmprestimo.Name = "btnEmprestimo";
            this.btnEmprestimo.Size = new System.Drawing.Size(130, 39);
            this.btnEmprestimo.TabIndex = 0;
            this.btnEmprestimo.Text = "Empréstimo";
            this.btnEmprestimo.UseVisualStyleBackColor = true;
            this.btnEmprestimo.Click += new System.EventHandler(this.btnEmprestimo_Click);
            // 
            // btnLivro
            // 
            this.btnLivro.FlatAppearance.BorderSize = 0;
            this.btnLivro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnLivro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLivro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLivro.ForeColor = System.Drawing.Color.White;
            this.btnLivro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLivro.Location = new System.Drawing.Point(3, 153);
            this.btnLivro.Name = "btnLivro";
            this.btnLivro.Size = new System.Drawing.Size(130, 39);
            this.btnLivro.TabIndex = 0;
            this.btnLivro.Text = "Livro";
            this.btnLivro.UseVisualStyleBackColor = true;
            this.btnLivro.Click += new System.EventHandler(this.btnLivro_Click);
            // 
            // btnAluno
            // 
            this.btnAluno.FlatAppearance.BorderSize = 0;
            this.btnAluno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAluno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAluno.ForeColor = System.Drawing.Color.White;
            this.btnAluno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAluno.Location = new System.Drawing.Point(3, 84);
            this.btnAluno.Name = "btnAluno";
            this.btnAluno.Size = new System.Drawing.Size(130, 39);
            this.btnAluno.TabIndex = 0;
            this.btnAluno.Text = "Aluno";
            this.btnAluno.UseVisualStyleBackColor = true;
            this.btnAluno.Click += new System.EventHandler(this.btnAluno_Click);
            // 
            // panelConteudo
            // 
            this.panelConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConteudo.Location = new System.Drawing.Point(136, 59);
            this.panelConteudo.Name = "panelConteudo";
            this.panelConteudo.Size = new System.Drawing.Size(664, 391);
            this.panelConteudo.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelConteudo);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelCabecalho);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelCabecalho.ResumeLayout(false);
            this.panelCabecalho.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCabecalho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnEmprestimo;
        private System.Windows.Forms.Button btnLivro;
        private System.Windows.Forms.Button btnAluno;
        private System.Windows.Forms.Panel panelConteudo;
    }
}

