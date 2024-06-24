namespace SistemaBiblioteca
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAutores = new System.Windows.Forms.Button();
            this.btnEditores = new System.Windows.Forms.Button();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.btnLivros = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnEmprestimos = new System.Windows.Forms.Button();
            this.btnReservas = new System.Windows.Forms.Button();
            this.btnFuncionarios = new System.Windows.Forms.Button();
            this.btnClose2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::SistemaBiblioteca.Properties.Resources.cross;
            this.btnClose.Location = new System.Drawing.Point(758, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAutores
            // 
            this.btnAutores.BackColor = System.Drawing.Color.Transparent;
            this.btnAutores.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAutores.FlatAppearance.BorderSize = 2;
            this.btnAutores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(73)))), ((int)(((byte)(205)))));
            this.btnAutores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutores.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutores.ForeColor = System.Drawing.Color.White;
            this.btnAutores.Location = new System.Drawing.Point(18, 134);
            this.btnAutores.Name = "btnAutores";
            this.btnAutores.Size = new System.Drawing.Size(107, 32);
            this.btnAutores.TabIndex = 1;
            this.btnAutores.Text = "Autores";
            this.btnAutores.UseVisualStyleBackColor = false;
            // 
            // btnEditores
            // 
            this.btnEditores.BackColor = System.Drawing.Color.Transparent;
            this.btnEditores.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditores.FlatAppearance.BorderSize = 2;
            this.btnEditores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(73)))), ((int)(((byte)(205)))));
            this.btnEditores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditores.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditores.ForeColor = System.Drawing.Color.White;
            this.btnEditores.Location = new System.Drawing.Point(131, 134);
            this.btnEditores.Name = "btnEditores";
            this.btnEditores.Size = new System.Drawing.Size(107, 32);
            this.btnEditores.TabIndex = 2;
            this.btnEditores.Text = "Editores";
            this.btnEditores.UseVisualStyleBackColor = false;
            // 
            // btnCategorias
            // 
            this.btnCategorias.BackColor = System.Drawing.Color.Transparent;
            this.btnCategorias.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCategorias.FlatAppearance.BorderSize = 2;
            this.btnCategorias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(73)))), ((int)(((byte)(205)))));
            this.btnCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategorias.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorias.ForeColor = System.Drawing.Color.White;
            this.btnCategorias.Location = new System.Drawing.Point(18, 172);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(107, 32);
            this.btnCategorias.TabIndex = 3;
            this.btnCategorias.Text = "Categorias";
            this.btnCategorias.UseVisualStyleBackColor = false;
            // 
            // btnLivros
            // 
            this.btnLivros.BackColor = System.Drawing.Color.Transparent;
            this.btnLivros.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLivros.FlatAppearance.BorderSize = 2;
            this.btnLivros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(73)))), ((int)(((byte)(205)))));
            this.btnLivros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLivros.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLivros.ForeColor = System.Drawing.Color.White;
            this.btnLivros.Location = new System.Drawing.Point(131, 172);
            this.btnLivros.Name = "btnLivros";
            this.btnLivros.Size = new System.Drawing.Size(107, 32);
            this.btnLivros.TabIndex = 4;
            this.btnLivros.Text = "Livros";
            this.btnLivros.UseVisualStyleBackColor = false;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.btnUsuarios.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUsuarios.FlatAppearance.BorderSize = 2;
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(73)))), ((int)(((byte)(205)))));
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Location = new System.Drawing.Point(18, 210);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(107, 32);
            this.btnUsuarios.TabIndex = 5;
            this.btnUsuarios.Text = "Usuários";
            this.btnUsuarios.UseVisualStyleBackColor = false;
            // 
            // btnEmprestimos
            // 
            this.btnEmprestimos.BackColor = System.Drawing.Color.Transparent;
            this.btnEmprestimos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEmprestimos.FlatAppearance.BorderSize = 2;
            this.btnEmprestimos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(73)))), ((int)(((byte)(205)))));
            this.btnEmprestimos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmprestimos.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnEmprestimos.ForeColor = System.Drawing.Color.White;
            this.btnEmprestimos.Location = new System.Drawing.Point(131, 210);
            this.btnEmprestimos.Name = "btnEmprestimos";
            this.btnEmprestimos.Size = new System.Drawing.Size(107, 32);
            this.btnEmprestimos.TabIndex = 6;
            this.btnEmprestimos.Text = "Empréstimos";
            this.btnEmprestimos.UseVisualStyleBackColor = false;
            // 
            // btnReservas
            // 
            this.btnReservas.BackColor = System.Drawing.Color.Transparent;
            this.btnReservas.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnReservas.FlatAppearance.BorderSize = 2;
            this.btnReservas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(73)))), ((int)(((byte)(205)))));
            this.btnReservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservas.ForeColor = System.Drawing.Color.White;
            this.btnReservas.Location = new System.Drawing.Point(18, 248);
            this.btnReservas.Name = "btnReservas";
            this.btnReservas.Size = new System.Drawing.Size(107, 32);
            this.btnReservas.TabIndex = 7;
            this.btnReservas.Text = "Reservas";
            this.btnReservas.UseVisualStyleBackColor = false;
            // 
            // btnFuncionarios
            // 
            this.btnFuncionarios.BackColor = System.Drawing.Color.Transparent;
            this.btnFuncionarios.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFuncionarios.FlatAppearance.BorderSize = 2;
            this.btnFuncionarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(73)))), ((int)(((byte)(205)))));
            this.btnFuncionarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncionarios.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnFuncionarios.ForeColor = System.Drawing.Color.White;
            this.btnFuncionarios.Location = new System.Drawing.Point(131, 248);
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.Size = new System.Drawing.Size(107, 32);
            this.btnFuncionarios.TabIndex = 8;
            this.btnFuncionarios.Text = "Funcionários";
            this.btnFuncionarios.UseVisualStyleBackColor = false;
            this.btnFuncionarios.Click += new System.EventHandler(this.btnFuncionarios_Click);
            // 
            // btnClose2
            // 
            this.btnClose2.BackColor = System.Drawing.Color.Transparent;
            this.btnClose2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClose2.FlatAppearance.BorderSize = 2;
            this.btnClose2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(73)))), ((int)(((byte)(205)))));
            this.btnClose2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose2.ForeColor = System.Drawing.Color.White;
            this.btnClose2.Location = new System.Drawing.Point(18, 286);
            this.btnClose2.Name = "btnClose2";
            this.btnClose2.Size = new System.Drawing.Size(220, 32);
            this.btnClose2.TabIndex = 9;
            this.btnClose2.Text = "Sair";
            this.btnClose2.UseVisualStyleBackColor = false;
            this.btnClose2.Click += new System.EventHandler(this.btnClose2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::SistemaBiblioteca.Properties.Resources.Biblioteca;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose2);
            this.Controls.Add(this.btnFuncionarios);
            this.Controls.Add(this.btnReservas);
            this.Controls.Add(this.btnEmprestimos);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.btnLivros);
            this.Controls.Add(this.btnCategorias);
            this.Controls.Add(this.btnEditores);
            this.Controls.Add(this.btnAutores);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saber Infinito - Biblioteca";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAutores;
        private System.Windows.Forms.Button btnEditores;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.Button btnLivros;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnEmprestimos;
        private System.Windows.Forms.Button btnReservas;
        private System.Windows.Forms.Button btnFuncionarios;
        private System.Windows.Forms.Button btnClose2;
    }
}

