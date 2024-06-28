namespace SistemaBiblioteca.UI
{
    partial class frmFuncionario
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
            this.btnLimparFunc = new System.Windows.Forms.Button();
            this.btnCadastrarFunc = new System.Windows.Forms.Button();
            this.txtObservFunc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.mtxtNascFunc = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEnderecoFunc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmailFunc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelefoneFunc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSalarioFunc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mtxtContratacaoFunc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCargoFunc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeFunc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvConsultaFunc = new System.Windows.Forms.DataGridView();
            this.btnExcluirFunc = new System.Windows.Forms.Button();
            this.btnEditarFunc = new System.Windows.Forms.Button();
            this.txtConsultaFunc = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvConsultaExFunc = new System.Windows.Forms.DataGridView();
            this.btnRealocarFunc = new System.Windows.Forms.Button();
            this.txtExFunc = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaFunc)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaExFunc)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(639, 334);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnLimparFunc);
            this.tabPage1.Controls.Add(this.btnCadastrarFunc);
            this.tabPage1.Controls.Add(this.txtObservFunc);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.mtxtNascFunc);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txtEnderecoFunc);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtEmailFunc);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtTelefoneFunc);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtSalarioFunc);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.mtxtContratacaoFunc);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtCargoFunc);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtNomeFunc);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(631, 304);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnLimparFunc
            // 
            this.btnLimparFunc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimparFunc.BackColor = System.Drawing.Color.Transparent;
            this.btnLimparFunc.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnLimparFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparFunc.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnLimparFunc.ForeColor = System.Drawing.Color.Red;
            this.btnLimparFunc.Location = new System.Drawing.Point(386, 264);
            this.btnLimparFunc.Name = "btnLimparFunc";
            this.btnLimparFunc.Size = new System.Drawing.Size(107, 32);
            this.btnLimparFunc.TabIndex = 19;
            this.btnLimparFunc.Text = "Limpar";
            this.btnLimparFunc.UseVisualStyleBackColor = false;
            this.btnLimparFunc.Click += new System.EventHandler(this.btnLimparFunc_Click);
            this.btnLimparFunc.MouseLeave += new System.EventHandler(this.btnLimparFunc_MouseLeave);
            this.btnLimparFunc.MouseHover += new System.EventHandler(this.btnLimparFunc_MouseHover);
            // 
            // btnCadastrarFunc
            // 
            this.btnCadastrarFunc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadastrarFunc.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastrarFunc.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCadastrarFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarFunc.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnCadastrarFunc.ForeColor = System.Drawing.Color.Black;
            this.btnCadastrarFunc.Location = new System.Drawing.Point(499, 264);
            this.btnCadastrarFunc.Name = "btnCadastrarFunc";
            this.btnCadastrarFunc.Size = new System.Drawing.Size(107, 32);
            this.btnCadastrarFunc.TabIndex = 18;
            this.btnCadastrarFunc.Text = "Cadastrar";
            this.btnCadastrarFunc.UseVisualStyleBackColor = false;
            this.btnCadastrarFunc.Click += new System.EventHandler(this.btnCadastrarFunc_Click);
            this.btnCadastrarFunc.MouseLeave += new System.EventHandler(this.btnCadastrarFunc_MouseLeave);
            this.btnCadastrarFunc.MouseHover += new System.EventHandler(this.btnCadastrarFunc_MouseHover);
            // 
            // txtObservFunc
            // 
            this.txtObservFunc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObservFunc.Location = new System.Drawing.Point(432, 39);
            this.txtObservFunc.Multiline = true;
            this.txtObservFunc.Name = "txtObservFunc";
            this.txtObservFunc.Size = new System.Drawing.Size(174, 185);
            this.txtObservFunc.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(428, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 19);
            this.label9.TabIndex = 16;
            this.label9.Text = "Observações:";
            // 
            // mtxtNascFunc
            // 
            this.mtxtNascFunc.Location = new System.Drawing.Point(227, 200);
            this.mtxtNascFunc.Mask = "00/00/0000";
            this.mtxtNascFunc.Name = "mtxtNascFunc";
            this.mtxtNascFunc.Size = new System.Drawing.Size(174, 24);
            this.mtxtNascFunc.TabIndex = 15;
            this.mtxtNascFunc.ValidatingType = typeof(System.DateTime);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(223, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 19);
            this.label8.TabIndex = 14;
            this.label8.Text = "Data de Nascimento:";
            // 
            // txtEnderecoFunc
            // 
            this.txtEnderecoFunc.Location = new System.Drawing.Point(227, 147);
            this.txtEnderecoFunc.Name = "txtEnderecoFunc";
            this.txtEnderecoFunc.Size = new System.Drawing.Size(174, 24);
            this.txtEnderecoFunc.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(223, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Endereço:";
            // 
            // txtEmailFunc
            // 
            this.txtEmailFunc.Location = new System.Drawing.Point(227, 93);
            this.txtEmailFunc.Name = "txtEmailFunc";
            this.txtEmailFunc.Size = new System.Drawing.Size(174, 24);
            this.txtEmailFunc.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(223, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Email:";
            // 
            // txtTelefoneFunc
            // 
            this.txtTelefoneFunc.Location = new System.Drawing.Point(227, 39);
            this.txtTelefoneFunc.Name = "txtTelefoneFunc";
            this.txtTelefoneFunc.Size = new System.Drawing.Size(174, 24);
            this.txtTelefoneFunc.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(223, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telefone:";
            // 
            // txtSalarioFunc
            // 
            this.txtSalarioFunc.Location = new System.Drawing.Point(22, 200);
            this.txtSalarioFunc.Name = "txtSalarioFunc";
            this.txtSalarioFunc.Size = new System.Drawing.Size(174, 24);
            this.txtSalarioFunc.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Salário:";
            // 
            // mtxtContratacaoFunc
            // 
            this.mtxtContratacaoFunc.Location = new System.Drawing.Point(22, 147);
            this.mtxtContratacaoFunc.Mask = "00/00/0000";
            this.mtxtContratacaoFunc.Name = "mtxtContratacaoFunc";
            this.mtxtContratacaoFunc.Size = new System.Drawing.Size(174, 24);
            this.mtxtContratacaoFunc.TabIndex = 5;
            this.mtxtContratacaoFunc.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data de Contratação:";
            // 
            // txtCargoFunc
            // 
            this.txtCargoFunc.Location = new System.Drawing.Point(22, 93);
            this.txtCargoFunc.Name = "txtCargoFunc";
            this.txtCargoFunc.Size = new System.Drawing.Size(174, 24);
            this.txtCargoFunc.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cargo:";
            // 
            // txtNomeFunc
            // 
            this.txtNomeFunc.Location = new System.Drawing.Point(22, 39);
            this.txtNomeFunc.Name = "txtNomeFunc";
            this.txtNomeFunc.Size = new System.Drawing.Size(174, 24);
            this.txtNomeFunc.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvConsultaFunc);
            this.tabPage2.Controls.Add(this.btnExcluirFunc);
            this.tabPage2.Controls.Add(this.btnEditarFunc);
            this.tabPage2.Controls.Add(this.txtConsultaFunc);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(631, 304);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvConsultaFunc
            // 
            this.dgvConsultaFunc.AllowUserToAddRows = false;
            this.dgvConsultaFunc.AllowUserToDeleteRows = false;
            this.dgvConsultaFunc.AllowUserToResizeColumns = false;
            this.dgvConsultaFunc.AllowUserToResizeRows = false;
            this.dgvConsultaFunc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvConsultaFunc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvConsultaFunc.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvConsultaFunc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvConsultaFunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaFunc.Location = new System.Drawing.Point(22, 66);
            this.dgvConsultaFunc.Name = "dgvConsultaFunc";
            this.dgvConsultaFunc.Size = new System.Drawing.Size(587, 232);
            this.dgvConsultaFunc.TabIndex = 22;
            // 
            // btnExcluirFunc
            // 
            this.btnExcluirFunc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluirFunc.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluirFunc.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnExcluirFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirFunc.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnExcluirFunc.ForeColor = System.Drawing.Color.Red;
            this.btnExcluirFunc.Location = new System.Drawing.Point(502, 28);
            this.btnExcluirFunc.Name = "btnExcluirFunc";
            this.btnExcluirFunc.Size = new System.Drawing.Size(107, 32);
            this.btnExcluirFunc.TabIndex = 21;
            this.btnExcluirFunc.Text = "Excluir";
            this.btnExcluirFunc.UseVisualStyleBackColor = false;
            this.btnExcluirFunc.Click += new System.EventHandler(this.btnExcluirFunc_Click);
            this.btnExcluirFunc.MouseLeave += new System.EventHandler(this.btnExcluirFunc_MouseLeave);
            this.btnExcluirFunc.MouseHover += new System.EventHandler(this.btnExcluirFunc_MouseHover);
            // 
            // btnEditarFunc
            // 
            this.btnEditarFunc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarFunc.BackColor = System.Drawing.Color.Transparent;
            this.btnEditarFunc.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEditarFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarFunc.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnEditarFunc.ForeColor = System.Drawing.Color.Black;
            this.btnEditarFunc.Location = new System.Drawing.Point(389, 28);
            this.btnEditarFunc.Name = "btnEditarFunc";
            this.btnEditarFunc.Size = new System.Drawing.Size(107, 32);
            this.btnEditarFunc.TabIndex = 20;
            this.btnEditarFunc.Text = "Editar";
            this.btnEditarFunc.UseVisualStyleBackColor = false;
            this.btnEditarFunc.Click += new System.EventHandler(this.btnEditarFunc_Click);
            this.btnEditarFunc.MouseLeave += new System.EventHandler(this.btnEditarFunc_MouseLeave);
            this.btnEditarFunc.MouseHover += new System.EventHandler(this.btnEditarFunc_MouseHover);
            // 
            // txtConsultaFunc
            // 
            this.txtConsultaFunc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConsultaFunc.Location = new System.Drawing.Point(22, 36);
            this.txtConsultaFunc.Name = "txtConsultaFunc";
            this.txtConsultaFunc.Size = new System.Drawing.Size(338, 24);
            this.txtConsultaFunc.TabIndex = 2;
            this.txtConsultaFunc.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtConsultaFunc_KeyUp);
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
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvConsultaExFunc);
            this.tabPage3.Controls.Add(this.btnRealocarFunc);
            this.tabPage3.Controls.Add(this.txtExFunc);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(631, 304);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ex - Funcionários";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvConsultaExFunc
            // 
            this.dgvConsultaExFunc.AllowUserToAddRows = false;
            this.dgvConsultaExFunc.AllowUserToDeleteRows = false;
            this.dgvConsultaExFunc.AllowUserToResizeColumns = false;
            this.dgvConsultaExFunc.AllowUserToResizeRows = false;
            this.dgvConsultaExFunc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvConsultaExFunc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvConsultaExFunc.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvConsultaExFunc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvConsultaExFunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaExFunc.Location = new System.Drawing.Point(24, 63);
            this.dgvConsultaExFunc.Name = "dgvConsultaExFunc";
            this.dgvConsultaExFunc.Size = new System.Drawing.Size(587, 232);
            this.dgvConsultaExFunc.TabIndex = 27;
            // 
            // btnRealocarFunc
            // 
            this.btnRealocarFunc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRealocarFunc.BackColor = System.Drawing.Color.Transparent;
            this.btnRealocarFunc.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRealocarFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRealocarFunc.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnRealocarFunc.ForeColor = System.Drawing.Color.Black;
            this.btnRealocarFunc.Location = new System.Drawing.Point(504, 25);
            this.btnRealocarFunc.Name = "btnRealocarFunc";
            this.btnRealocarFunc.Size = new System.Drawing.Size(107, 32);
            this.btnRealocarFunc.TabIndex = 26;
            this.btnRealocarFunc.Text = "Realocar";
            this.btnRealocarFunc.UseVisualStyleBackColor = false;
            this.btnRealocarFunc.MouseLeave += new System.EventHandler(this.btnRealocarFunc_MouseLeave);
            this.btnRealocarFunc.MouseHover += new System.EventHandler(this.btnRealocarFunc_MouseHover);
            // 
            // txtExFunc
            // 
            this.txtExFunc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExFunc.Location = new System.Drawing.Point(24, 33);
            this.txtExFunc.Name = "txtExFunc";
            this.txtExFunc.Size = new System.Drawing.Size(338, 24);
            this.txtExFunc.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 19);
            this.label11.TabIndex = 23;
            this.label11.Text = "Pesquisar por nome:";
            // 
            // frmFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 334);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionário";
            this.Load += new System.EventHandler(this.frmFuncionario_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaFunc)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaExFunc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnExcluirFunc;
        private System.Windows.Forms.Button btnEditarFunc;
        private System.Windows.Forms.TextBox txtConsultaFunc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvConsultaFunc;
        private System.Windows.Forms.Button btnLimparFunc;
        private System.Windows.Forms.Button btnCadastrarFunc;
        private System.Windows.Forms.TextBox txtObservFunc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox mtxtNascFunc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEnderecoFunc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmailFunc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTelefoneFunc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSalarioFunc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtxtContratacaoFunc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCargoFunc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeFunc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvConsultaExFunc;
        private System.Windows.Forms.Button btnRealocarFunc;
        private System.Windows.Forms.TextBox txtExFunc;
        private System.Windows.Forms.Label label11;
    }
}