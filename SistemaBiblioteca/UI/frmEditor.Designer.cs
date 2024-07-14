namespace SistemaBiblioteca.UI
{
    partial class frmEditor
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
            this.refImageEditor = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLimparEditor = new System.Windows.Forms.Button();
            this.btnCadastrarEditor = new System.Windows.Forms.Button();
            this.txtNomeEditor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvConsultaEditor = new System.Windows.Forms.DataGridView();
            this.btnExcluirEditor = new System.Windows.Forms.Button();
            this.btnEditarEditor = new System.Windows.Forms.Button();
            this.txtConsultaEditor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaEditor)).BeginInit();
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
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.refImageEditor);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.btnLimparEditor);
            this.tabPage1.Controls.Add(this.btnCadastrarEditor);
            this.tabPage1.Controls.Add(this.txtNomeEditor);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(631, 304);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // refImageEditor
            // 
            this.refImageEditor.AutoSize = true;
            this.refImageEditor.BackColor = System.Drawing.Color.Transparent;
            this.refImageEditor.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.refImageEditor.Location = new System.Drawing.Point(443, 223);
            this.refImageEditor.Name = "refImageEditor";
            this.refImageEditor.Size = new System.Drawing.Size(159, 16);
            this.refImageEditor.TabIndex = 21;
            this.refImageEditor.TabStop = true;
            this.refImageEditor.Text = "Home illustrations by Storyset";
            this.refImageEditor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.refImageEditor_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaBiblioteca.Properties.Resources.Editing_body_text_amico;
            this.pictureBox1.Location = new System.Drawing.Point(365, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // btnLimparEditor
            // 
            this.btnLimparEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimparEditor.BackColor = System.Drawing.Color.Transparent;
            this.btnLimparEditor.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnLimparEditor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparEditor.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnLimparEditor.ForeColor = System.Drawing.Color.Red;
            this.btnLimparEditor.Location = new System.Drawing.Point(384, 264);
            this.btnLimparEditor.Name = "btnLimparEditor";
            this.btnLimparEditor.Size = new System.Drawing.Size(107, 32);
            this.btnLimparEditor.TabIndex = 19;
            this.btnLimparEditor.Text = "Limpar";
            this.btnLimparEditor.UseVisualStyleBackColor = false;
            this.btnLimparEditor.Click += new System.EventHandler(this.btnLimparEditor_Click);
            this.btnLimparEditor.MouseLeave += new System.EventHandler(this.btnLimparEditor_MouseLeave);
            this.btnLimparEditor.MouseHover += new System.EventHandler(this.btnLimparEditor_MouseHover);
            // 
            // btnCadastrarEditor
            // 
            this.btnCadastrarEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadastrarEditor.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastrarEditor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCadastrarEditor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarEditor.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnCadastrarEditor.ForeColor = System.Drawing.Color.Black;
            this.btnCadastrarEditor.Location = new System.Drawing.Point(497, 264);
            this.btnCadastrarEditor.Name = "btnCadastrarEditor";
            this.btnCadastrarEditor.Size = new System.Drawing.Size(107, 32);
            this.btnCadastrarEditor.TabIndex = 18;
            this.btnCadastrarEditor.Text = "Cadastrar";
            this.btnCadastrarEditor.UseVisualStyleBackColor = false;
            this.btnCadastrarEditor.Click += new System.EventHandler(this.btnCadastrarEditor_Click);
            this.btnCadastrarEditor.MouseLeave += new System.EventHandler(this.btnCadastrarEditor_MouseLeave);
            this.btnCadastrarEditor.MouseHover += new System.EventHandler(this.btnCadastrarEditor_MouseHover);
            // 
            // txtNomeEditor
            // 
            this.txtNomeEditor.Location = new System.Drawing.Point(22, 39);
            this.txtNomeEditor.Name = "txtNomeEditor";
            this.txtNomeEditor.Size = new System.Drawing.Size(227, 24);
            this.txtNomeEditor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Editor:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvConsultaEditor);
            this.tabPage2.Controls.Add(this.btnExcluirEditor);
            this.tabPage2.Controls.Add(this.btnEditarEditor);
            this.tabPage2.Controls.Add(this.txtConsultaEditor);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(631, 304);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvConsultaEditor
            // 
            this.dgvConsultaEditor.AllowUserToAddRows = false;
            this.dgvConsultaEditor.AllowUserToDeleteRows = false;
            this.dgvConsultaEditor.AllowUserToResizeColumns = false;
            this.dgvConsultaEditor.AllowUserToResizeRows = false;
            this.dgvConsultaEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvConsultaEditor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvConsultaEditor.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvConsultaEditor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvConsultaEditor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaEditor.Location = new System.Drawing.Point(22, 66);
            this.dgvConsultaEditor.Name = "dgvConsultaEditor";
            this.dgvConsultaEditor.Size = new System.Drawing.Size(587, 232);
            this.dgvConsultaEditor.TabIndex = 22;
            // 
            // btnExcluirEditor
            // 
            this.btnExcluirEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluirEditor.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluirEditor.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnExcluirEditor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirEditor.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnExcluirEditor.ForeColor = System.Drawing.Color.Red;
            this.btnExcluirEditor.Location = new System.Drawing.Point(502, 28);
            this.btnExcluirEditor.Name = "btnExcluirEditor";
            this.btnExcluirEditor.Size = new System.Drawing.Size(107, 32);
            this.btnExcluirEditor.TabIndex = 21;
            this.btnExcluirEditor.Text = "Excluir";
            this.btnExcluirEditor.UseVisualStyleBackColor = false;
            this.btnExcluirEditor.Click += new System.EventHandler(this.btnExcluirEditor_Click);
            this.btnExcluirEditor.MouseLeave += new System.EventHandler(this.btnExcluirEditor_MouseLeave);
            this.btnExcluirEditor.MouseHover += new System.EventHandler(this.btnExcluirEditor_MouseHover);
            // 
            // btnEditarEditor
            // 
            this.btnEditarEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarEditor.BackColor = System.Drawing.Color.Transparent;
            this.btnEditarEditor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEditarEditor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarEditor.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnEditarEditor.ForeColor = System.Drawing.Color.Black;
            this.btnEditarEditor.Location = new System.Drawing.Point(389, 28);
            this.btnEditarEditor.Name = "btnEditarEditor";
            this.btnEditarEditor.Size = new System.Drawing.Size(107, 32);
            this.btnEditarEditor.TabIndex = 20;
            this.btnEditarEditor.Text = "Editar";
            this.btnEditarEditor.UseVisualStyleBackColor = false;
            this.btnEditarEditor.Click += new System.EventHandler(this.btnEditarEditor_Click);
            this.btnEditarEditor.MouseLeave += new System.EventHandler(this.btnEditarEditor_MouseLeave);
            this.btnEditarEditor.MouseHover += new System.EventHandler(this.btnEditarEditor_MouseHover);
            // 
            // txtConsultaEditor
            // 
            this.txtConsultaEditor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConsultaEditor.Location = new System.Drawing.Point(22, 36);
            this.txtConsultaEditor.Name = "txtConsultaEditor";
            this.txtConsultaEditor.Size = new System.Drawing.Size(338, 24);
            this.txtConsultaEditor.TabIndex = 2;
            this.txtConsultaEditor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtConsultaEditor_KeyUp);
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
            // frmEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 334);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor";
            this.Load += new System.EventHandler(this.frmEditor_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaEditor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.LinkLabel refImageEditor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLimparEditor;
        private System.Windows.Forms.Button btnCadastrarEditor;
        private System.Windows.Forms.TextBox txtNomeEditor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvConsultaEditor;
        private System.Windows.Forms.Button btnExcluirEditor;
        private System.Windows.Forms.Button btnEditarEditor;
        private System.Windows.Forms.TextBox txtConsultaEditor;
        private System.Windows.Forms.Label label10;
    }
}