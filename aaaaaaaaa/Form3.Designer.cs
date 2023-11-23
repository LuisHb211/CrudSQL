namespace aaaaaaaaa
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbAutor = new System.Windows.Forms.TextBox();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbEdicao = new System.Windows.Forms.TextBox();
            this.btGravar = new System.Windows.Forms.Button();
            this.btAtualizar = new System.Windows.Forms.Button();
            this.btDeletar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(275, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Livro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(91, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(91, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Autor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(91, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Codigo:";
            // 
            // tbNome
            // 
            this.tbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNome.Location = new System.Drawing.Point(215, 80);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(230, 26);
            this.tbNome.TabIndex = 1;
            // 
            // tbAutor
            // 
            this.tbAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAutor.Location = new System.Drawing.Point(215, 135);
            this.tbAutor.Name = "tbAutor";
            this.tbAutor.Size = new System.Drawing.Size(230, 26);
            this.tbAutor.TabIndex = 1;
            // 
            // tbCodigo
            // 
            this.tbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodigo.Location = new System.Drawing.Point(215, 189);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(230, 26);
            this.tbCodigo.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(91, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Edição:";
            // 
            // tbEdicao
            // 
            this.tbEdicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEdicao.Location = new System.Drawing.Point(215, 237);
            this.tbEdicao.Name = "tbEdicao";
            this.tbEdicao.Size = new System.Drawing.Size(230, 26);
            this.tbEdicao.TabIndex = 1;
            // 
            // btGravar
            // 
            this.btGravar.Location = new System.Drawing.Point(86, 317);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(75, 23);
            this.btGravar.TabIndex = 5;
            this.btGravar.Text = "Gravar";
            this.btGravar.UseVisualStyleBackColor = true;
            this.btGravar.Click += new System.EventHandler(this.btGravar_Click);
            // 
            // btAtualizar
            // 
            this.btAtualizar.Location = new System.Drawing.Point(215, 317);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btAtualizar.TabIndex = 6;
            this.btAtualizar.Text = "Atualizar";
            this.btAtualizar.UseVisualStyleBackColor = true;
            this.btAtualizar.Click += new System.EventHandler(this.btAtualizar_Click);
            // 
            // btDeletar
            // 
            this.btDeletar.Location = new System.Drawing.Point(344, 317);
            this.btDeletar.Name = "btDeletar";
            this.btDeletar.Size = new System.Drawing.Size(75, 23);
            this.btDeletar.TabIndex = 7;
            this.btDeletar.Text = "Deletar";
            this.btDeletar.UseVisualStyleBackColor = true;
            this.btDeletar.Click += new System.EventHandler(this.btDeletar_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 342);
            this.Controls.Add(this.btDeletar);
            this.Controls.Add(this.btAtualizar);
            this.Controls.Add(this.btGravar);
            this.Controls.Add(this.tbEdicao);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.tbAutor);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbAutor;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbEdicao;
        private System.Windows.Forms.Button btGravar;
        private System.Windows.Forms.Button btAtualizar;
        private System.Windows.Forms.Button btDeletar;
    }
}