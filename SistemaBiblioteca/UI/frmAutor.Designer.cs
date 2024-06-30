namespace SistemaBiblioteca.UI
{
    partial class frmAutor
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.refImageAutor = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLimparAutor = new System.Windows.Forms.Button();
            this.btnCadastrarAutor = new System.Windows.Forms.Button();
            this.txtNomeAutor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvConsultaAutor = new System.Windows.Forms.DataGridView();
            this.btnExcluirAutor = new System.Windows.Forms.Button();
            this.btnEditarAutor = new System.Windows.Forms.Button();
            this.txtConsultaAutor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaAutor)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(639, 334);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.refImageAutor);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.btnLimparAutor);
            this.tabPage1.Controls.Add(this.btnCadastrarAutor);
            this.tabPage1.Controls.Add(this.txtNomeAutor);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(631, 304);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // refImageAutor
            // 
            this.refImageAutor.AutoSize = true;
            this.refImageAutor.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.refImageAutor.Location = new System.Drawing.Point(443, 223);
            this.refImageAutor.Name = "refImageAutor";
            this.refImageAutor.Size = new System.Drawing.Size(159, 16);
            this.refImageAutor.TabIndex = 21;
            this.refImageAutor.TabStop = true;
            this.refImageAutor.Text = "Home illustrations by Storyset";
            this.refImageAutor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.refImageAutor_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaBiblioteca.Properties.Resources.Reading_glasses_cuate;
            this.pictureBox1.Location = new System.Drawing.Point(365, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // btnLimparAutor
            // 
            this.btnLimparAutor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimparAutor.BackColor = System.Drawing.Color.Transparent;
            this.btnLimparAutor.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnLimparAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparAutor.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnLimparAutor.ForeColor = System.Drawing.Color.Red;
            this.btnLimparAutor.Location = new System.Drawing.Point(384, 264);
            this.btnLimparAutor.Name = "btnLimparAutor";
            this.btnLimparAutor.Size = new System.Drawing.Size(107, 32);
            this.btnLimparAutor.TabIndex = 19;
            this.btnLimparAutor.Text = "Limpar";
            this.btnLimparAutor.UseVisualStyleBackColor = false;
            this.btnLimparAutor.Click += new System.EventHandler(this.btnLimparAutor_Click);
            this.btnLimparAutor.MouseLeave += new System.EventHandler(this.btnLimparAutor_MouseLeave);
            this.btnLimparAutor.MouseHover += new System.EventHandler(this.btnLimparAutor_MouseHover);
            // 
            // btnCadastrarAutor
            // 
            this.btnCadastrarAutor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadastrarAutor.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastrarAutor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCadastrarAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarAutor.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnCadastrarAutor.ForeColor = System.Drawing.Color.Black;
            this.btnCadastrarAutor.Location = new System.Drawing.Point(497, 264);
            this.btnCadastrarAutor.Name = "btnCadastrarAutor";
            this.btnCadastrarAutor.Size = new System.Drawing.Size(107, 32);
            this.btnCadastrarAutor.TabIndex = 18;
            this.btnCadastrarAutor.Text = "Cadastrar";
            this.btnCadastrarAutor.UseVisualStyleBackColor = false;
            this.btnCadastrarAutor.Click += new System.EventHandler(this.btnCadastrarAutor_Click);
            this.btnCadastrarAutor.MouseLeave += new System.EventHandler(this.btnCadastrarAutor_MouseLeave);
            this.btnCadastrarAutor.MouseHover += new System.EventHandler(this.btnCadastrarAutor_MouseHover);
            // 
            // txtNomeAutor
            // 
            this.txtNomeAutor.Location = new System.Drawing.Point(22, 39);
            this.txtNomeAutor.Name = "txtNomeAutor";
            this.txtNomeAutor.Size = new System.Drawing.Size(227, 24);
            this.txtNomeAutor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Autor:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvConsultaAutor);
            this.tabPage2.Controls.Add(this.btnExcluirAutor);
            this.tabPage2.Controls.Add(this.btnEditarAutor);
            this.tabPage2.Controls.Add(this.txtConsultaAutor);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(631, 304);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvConsultaAutor
            // 
            this.dgvConsultaAutor.AllowUserToAddRows = false;
            this.dgvConsultaAutor.AllowUserToDeleteRows = false;
            this.dgvConsultaAutor.AllowUserToResizeColumns = false;
            this.dgvConsultaAutor.AllowUserToResizeRows = false;
            this.dgvConsultaAutor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvConsultaAutor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvConsultaAutor.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvConsultaAutor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvConsultaAutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaAutor.Location = new System.Drawing.Point(22, 66);
            this.dgvConsultaAutor.Name = "dgvConsultaAutor";
            this.dgvConsultaAutor.Size = new System.Drawing.Size(587, 232);
            this.dgvConsultaAutor.TabIndex = 22;
            // 
            // btnExcluirAutor
            // 
            this.btnExcluirAutor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluirAutor.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluirAutor.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnExcluirAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirAutor.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnExcluirAutor.ForeColor = System.Drawing.Color.Red;
            this.btnExcluirAutor.Location = new System.Drawing.Point(502, 28);
            this.btnExcluirAutor.Name = "btnExcluirAutor";
            this.btnExcluirAutor.Size = new System.Drawing.Size(107, 32);
            this.btnExcluirAutor.TabIndex = 21;
            this.btnExcluirAutor.Text = "Excluir";
            this.btnExcluirAutor.UseVisualStyleBackColor = false;
            this.btnExcluirAutor.Click += new System.EventHandler(this.btnExcluirAutor_Click);
            this.btnExcluirAutor.MouseLeave += new System.EventHandler(this.btnExcluirAutor_MouseLeave);
            this.btnExcluirAutor.MouseHover += new System.EventHandler(this.btnExcluirAutor_MouseHover);
            // 
            // btnEditarAutor
            // 
            this.btnEditarAutor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarAutor.BackColor = System.Drawing.Color.Transparent;
            this.btnEditarAutor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEditarAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarAutor.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnEditarAutor.ForeColor = System.Drawing.Color.Black;
            this.btnEditarAutor.Location = new System.Drawing.Point(389, 28);
            this.btnEditarAutor.Name = "btnEditarAutor";
            this.btnEditarAutor.Size = new System.Drawing.Size(107, 32);
            this.btnEditarAutor.TabIndex = 20;
            this.btnEditarAutor.Text = "Editar";
            this.btnEditarAutor.UseVisualStyleBackColor = false;
            this.btnEditarAutor.Click += new System.EventHandler(this.btnEditarAutor_Click);
            this.btnEditarAutor.MouseLeave += new System.EventHandler(this.btnEditarAutor_MouseLeave);
            this.btnEditarAutor.MouseHover += new System.EventHandler(this.btnEditarAutor_MouseHover);
            // 
            // txtConsultaAutor
            // 
            this.txtConsultaAutor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConsultaAutor.Location = new System.Drawing.Point(22, 36);
            this.txtConsultaAutor.Name = "txtConsultaAutor";
            this.txtConsultaAutor.Size = new System.Drawing.Size(338, 24);
            this.txtConsultaAutor.TabIndex = 2;
            this.txtConsultaAutor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtConsultaAutor_KeyUp);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 19);
            this.label10.TabIndex = 1;
            this.label10.Text = "Pesquisar por nome:";
            // 
            // frmAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 334);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAutor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autor";
            this.Load += new System.EventHandler(this.frmAutor_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaAutor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnLimparAutor;
        private System.Windows.Forms.Button btnCadastrarAutor;
        private System.Windows.Forms.TextBox txtNomeAutor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvConsultaAutor;
        private System.Windows.Forms.Button btnExcluirAutor;
        private System.Windows.Forms.Button btnEditarAutor;
        private System.Windows.Forms.TextBox txtConsultaAutor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel refImageAutor;
    }
}