using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBiblioteca.UI
{
    public partial class frmAutor : Form
    {
        BLL.Autor auth = new BLL.Autor();
        DAL.AutorDAL authDAL = new DAL.AutorDAL();

        public frmAutor()
        {
            InitializeComponent();
        }

        public void VisitLink()
        {
            refImageAutor.LinkVisited = true;
            System.Diagnostics.Process.Start("https://storyset.com/home");
        }

        public void Hover(Button button, string back, string fore)
        {
            button.BackColor = Color.FromName(back);
            button.ForeColor = Color.FromName(fore);
        }

        public void FormClear()
        {
            txtNomeAutor.Clear();
        }

        private void refImageAutor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível abrir o link que foi clicado.");
            }
        }

        private void btnCadastrarAutor_MouseHover(object sender, EventArgs e)
        {
            Hover(btnCadastrarAutor, "Black", "White");
        }

        private void btnCadastrarAutor_MouseLeave(object sender, EventArgs e)
        {
            Hover(btnCadastrarAutor, "Transparent", "Black");
        }

        private void btnLimparAutor_MouseHover(object sender, EventArgs e)
        {
            Hover(btnLimparAutor, "Red", "White");
        }

        private void btnLimparAutor_MouseLeave(object sender, EventArgs e)
        {
            Hover(btnLimparAutor, "Transparent", "Red");
        }

        private void btnExcluirAutor_MouseHover(object sender, EventArgs e)
        {
            Hover(btnExcluirAutor, "Red", "White");
        }

        private void btnExcluirAutor_MouseLeave(object sender, EventArgs e)
        {
            Hover(btnExcluirAutor, "Transparent", "Red");
        }

        private void btnEditarAutor_MouseHover(object sender, EventArgs e)
        {
            Hover(btnEditarAutor, "Black", "White");
        }

        private void btnEditarAutor_MouseLeave(object sender, EventArgs e)
        {
            Hover(btnEditarAutor, "Trasnparent", "Black");
        }

        private void frmAutor_Load(object sender, EventArgs e)
        {
            dgvConsultaAutor.DataSource = authDAL.Consult();
        }

        private void btnLimparAutor_Click(object sender, EventArgs e)
        {
            FormClear();
            txtNomeAutor.Focus();
        }

        private void btnCadastrarAutor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomeAutor.Text))
            {
                MessageBox.Show("Todos os campos devem ser preenchidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            auth.NomeAutor = txtNomeAutor.Text;

            if (btnCadastrarAutor.Text == "Atualizar")
            {
                authDAL.Update(auth);
                MessageBox.Show("Dados gravados com sucesso!");

                btnCadastrarAutor.Text = "Cadastrar";
                btnCadastrarAutor.Width -= 20;
                btnCadastrarAutor.Left += 20;
                btnLimparAutor.Left += 20;

                txtNomeAutor.Focus();
            } 
            else
            {
                authDAL.Rgister(auth);
                MessageBox.Show("Dados gravados com sucesso!");
                txtNomeAutor.Focus();
            }

            FormClear();
            dgvConsultaAutor.DataSource = authDAL.Consult();
        }

        private void btnExcluirAutor_Click(object sender, EventArgs e)
        {
            if (dgvConsultaAutor.RowCount > 0)
            {
                if (MessageBox.Show("Deseja excluir o autor permanentemente?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    auth.IdAutor = Convert.ToInt16(dgvConsultaAutor[0, dgvConsultaAutor.CurrentRow.Index].Value);
                    authDAL.Delete(auth);
                    dgvConsultaAutor.DataSource = authDAL.Consult();
                }
            }
        }

        private void txtConsultaAutor_KeyUp(object sender, KeyEventArgs e)
        {
            auth.NomeAutor = txtConsultaAutor.Text;
            dgvConsultaAutor.DataSource = authDAL.Search(auth);
        }

        private void btnEditarAutor_Click(object sender, EventArgs e)
        {
            if (dgvConsultaAutor.RowCount > 0)
            {
                auth.IdAutor = Convert.ToInt16(dgvConsultaAutor[0, dgvConsultaAutor.CurrentRow.Index].Value);
                auth = authDAL.Return(auth);
                txtNomeAutor.Text = auth.NomeAutor;

                tabControl1.SelectedTab = tabPage1;

                btnCadastrarAutor.Text = "Atualizar";
                btnCadastrarAutor.Width += 20;
                btnCadastrarAutor.Left -= 20;
                btnLimparAutor.Left -= 20;
            }
        }
    }
}
