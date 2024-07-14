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
    }
}
