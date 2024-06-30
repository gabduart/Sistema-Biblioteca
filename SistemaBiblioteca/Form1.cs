using SistemaBiblioteca.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBiblioteca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClose2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            frmFuncionario form = new frmFuncionario();
            form.ShowDialog();
        }

        private void btnAutores_Click(object sender, EventArgs e)
        {
            frmAutor form = new frmAutor();
            form.ShowDialog();
        }
    }
}
