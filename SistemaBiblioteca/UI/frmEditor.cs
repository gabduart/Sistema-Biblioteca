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
    public partial class frmEditor : Form
    {
        BLL.Editores ed = new BLL.Editores();
        DAL.EditoresDAL edDAL = new DAL.EditoresDAL();

        public frmEditor()
        {
            InitializeComponent();
        }

        private void frmEditor_Load(object sender, EventArgs e)
        {
            dgvConsultaEditor.DataSource = edDAL.Consult();
        }

        public void VisitLink()
        {
            refImageEditor.LinkVisited = true;
            System.Diagnostics.Process.Start("https://storyset.com/home");
        }

        public void Hover(Button button, string back, string fore)
        {
            button.BackColor = Color.FromName(back);
            button.ForeColor = Color.FromName(fore);
        }

        public void FormClear()
        {
            txtNomeEditor.Clear();
        }

        private void btnCadastrarEditor_MouseHover(object sender, EventArgs e)
        {
            Hover(btnCadastrarEditor, "Black", "White");
        }

        private void btnCadastrarEditor_MouseLeave(object sender, EventArgs e)
        {
            Hover(btnCadastrarEditor, "Transparent", "Black");
        }

        private void refImageEditor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void btnLimparEditor_MouseHover(object sender, EventArgs e)
        {
            Hover(btnLimparEditor, "Red", "White");
        }

        private void btnLimparEditor_MouseLeave(object sender, EventArgs e)
        {
            Hover(btnLimparEditor, "Transparent", "Red");
        }

        private void btnExcluirEditor_MouseHover(object sender, EventArgs e)
        {
            Hover(btnExcluirEditor, "Red", "White");
        }

        private void btnExcluirEditor_MouseLeave(object sender, EventArgs e)
        {
            Hover(btnExcluirEditor, "Transparent", "Red");
        }

        private void btnEditarEditor_MouseHover(object sender, EventArgs e)
        {
            Hover(btnEditarEditor, "Black", "White");
        }

        private void btnEditarEditor_MouseLeave(object sender, EventArgs e)
        {
            Hover(btnEditarEditor, "Transparent", "Black");
        }

        private void btnLimparEditor_Click(object sender, EventArgs e)
        {
            FormClear();
            txtNomeEditor.Focus();
        }

        private void btnCadastrarEditor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomeEditor.Text))
            {
                MessageBox.Show("Todos os campos devem ser preenchidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ed.NomeEditor = txtNomeEditor.Text;

            if(btnCadastrarEditor.Text == "Atualizar")
            {
                edDAL.Update(ed);
                MessageBox.Show("Dados gravados com sucesso!");

                btnCadastrarEditor.Text = "Cadastrar";
                btnCadastrarEditor.Width -= 20;
                btnCadastrarEditor.Left += 20;
                btnLimparEditor.Left += 20;

                txtNomeEditor.Focus();
            } 
            else
            {
                edDAL.Register(ed);
                MessageBox.Show("Dados gravados com sucesso!");
                txtNomeEditor.Focus();
            }

            FormClear();
            dgvConsultaEditor.DataSource = edDAL.Consult();
        }

        private void btnExcluirEditor_Click(object sender, EventArgs e)
        {
            if(dgvConsultaEditor.RowCount > 0)
            {
                if(MessageBox.Show("Deseja excluir o editor permanentemente?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ed.EditorId = Convert.ToInt16(dgvConsultaEditor[0, dgvConsultaEditor.CurrentRow.Index].Value);
                    edDAL.Delete(ed);
                    dgvConsultaEditor.DataSource = edDAL.Consult();
                }
            }
        }

        private void txtConsultaEditor_KeyUp(object sender, KeyEventArgs e)
        {
            ed.NomeEditor = txtConsultaEditor.Text;
            dgvConsultaEditor.DataSource = edDAL.Search(ed);
        }

        private void btnEditarEditor_Click(object sender, EventArgs e)
        {
            if(dgvConsultaEditor.RowCount > 0)
            {
                ed.EditorId = Convert.ToInt16(dgvConsultaEditor[0, dgvConsultaEditor.CurrentRow.Index].Value);
                ed = edDAL.Return(ed);
                txtNomeEditor.Text = ed.NomeEditor;

                tabControl1.SelectedTab = tabPage1;

                btnCadastrarEditor.Text = "Atualizar";
                btnCadastrarEditor.Width += 20;
                btnCadastrarEditor.Left -= 20;
                btnLimparEditor.Left -= 20;
            }
        }
    }
}
