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
    public partial class frmFuncionario : Form
    {
        BLL.Funcionario func = new BLL.Funcionario();
        DAL.FuncionarioDAL funcDAL = new DAL.FuncionarioDAL();
        public frmFuncionario()
        {
            InitializeComponent();
        }

        public void Hover(Button button, string back, string fore)
        {
            button.BackColor = Color.FromName(back);
            button.ForeColor = Color.FromName(fore);
        }

        public void FormClear()
        {
            txtNomeFunc.Clear();
            txtCargoFunc.Clear();
            mtxtContratacaoFunc.Clear();
            txtSalarioFunc.Clear();
            txtTelefoneFunc.Clear();
            txtEmailFunc.Clear();
            txtEnderecoFunc.Clear();
            mtxtNascFunc.Clear();
            txtObservFunc.Clear();
        }

        private void frmFuncionario_Load(object sender, EventArgs e)
        {
            dgvConsultaFunc.DataSource = funcDAL.Consult();
        }

        private void btnLimparFunc_MouseHover(object sender, EventArgs e)
        {
            Hover(btnLimparFunc ,"Red", "White");
        }

        private void btnLimparFunc_MouseLeave(object sender, EventArgs e)
        {
            Hover(btnLimparFunc ,"Transparent", "Red");
        }

        private void btnCadastrarFunc_MouseHover(object sender, EventArgs e)
        {
            Hover(btnCadastrarFunc, "Black", "White");
        }

        private void btnCadastrarFunc_MouseLeave(object sender, EventArgs e)
        {
            Hover(btnCadastrarFunc, "Transparent", "Black");
        }

        private void btnEditarFunc_MouseHover(object sender, EventArgs e)
        {
            Hover(btnEditarFunc, "Black", "White");
        }

        private void btnEditarFunc_MouseLeave(object sender, EventArgs e)
        {
            Hover(btnEditarFunc, "Transparent", "Black");
        }

        private void btnExcluirFunc_MouseHover(object sender, EventArgs e)
        {
            Hover(btnExcluirFunc, "Red", "White");
        }

        private void btnExcluirFunc_MouseLeave(object sender, EventArgs e)
        {
            Hover(btnExcluirFunc, "Transparent", "Red");
        }

        private void btnLimparFunc_Click(object sender, EventArgs e)
        {
            FormClear();
        }

        private void btnCadastrarFunc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomeFunc.Text) ||
                string.IsNullOrWhiteSpace(txtCargoFunc.Text) ||
                string.IsNullOrWhiteSpace(mtxtContratacaoFunc.Text) ||
                string.IsNullOrWhiteSpace(txtSalarioFunc.Text) ||
                string.IsNullOrWhiteSpace(txtTelefoneFunc.Text) ||
                string.IsNullOrWhiteSpace(txtEmailFunc.Text) ||
                string.IsNullOrWhiteSpace(txtEnderecoFunc.Text) ||
                string.IsNullOrWhiteSpace(mtxtNascFunc.Text) ||
                string.IsNullOrWhiteSpace(txtObservFunc.Text))
            {
                MessageBox.Show("Todos os campos devem ser preenchidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!DateTime.TryParse(mtxtContratacaoFunc.Text, out DateTime dataContratacao) ||
                !DateTime.TryParse(mtxtNascFunc.Text, out DateTime dataNascimento))
            {
                MessageBox.Show("Datas inválidas!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtSalarioFunc.Text, out double salario))
            {
                MessageBox.Show("Salário inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            func.Nome = txtNomeFunc.Text;
            func.Cargo = txtCargoFunc.Text;
            func.DataContratacao = Convert.ToDateTime(mtxtContratacaoFunc.Text);
            func.Salario = double.Parse(txtSalarioFunc.Text);
            func.Telefone = txtTelefoneFunc.Text;
            func.Email = txtEmailFunc.Text;
            func.Endereco = txtEnderecoFunc.Text;
            func.Nascimento = Convert.ToDateTime(mtxtNascFunc.Text);
            func.Observacoes = txtObservFunc.Text;

            if (btnCadastrarFunc.Text == "Atualizar")
            {
                funcDAL.Update(func);
                MessageBox.Show("Dados gravados com sucesso!");

                btnCadastrarFunc.Text = "Cadastrar";
                btnCadastrarFunc.Width -= 20;
                btnCadastrarFunc.Left += 20;
                btnLimparFunc.Left += 20;

                txtNomeFunc.Focus();
            }
            else
            {
                funcDAL.Register(func);
                MessageBox.Show("Dados gravados com sucesso!");
                txtNomeFunc.Focus();
            }

            FormClear();
            dgvConsultaFunc.DataSource = funcDAL.Consult();
        }

        private void txtConsultaFunc_KeyUp(object sender, KeyEventArgs e)
        {
            func.Nome = txtConsultaFunc.Text;
            dgvConsultaFunc.DataSource = funcDAL.Search(func);
        }

        private void btnExcluirFunc_Click(object sender, EventArgs e)
        {
            if (dgvConsultaFunc.RowCount > 0)
            {
                if (MessageBox.Show("Deseja excluir permanentemente?", "Excluir",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    func.Idfuncionario = Convert.ToInt16(dgvConsultaFunc[0, dgvConsultaFunc.CurrentRow.Index].Value);
                    funcDAL.Delete(func);
                    dgvConsultaFunc.DataSource = funcDAL.Consult();
                }
            }
        }

        private void btnEditarFunc_Click(object sender, EventArgs e)
        {
            if (dgvConsultaFunc.RowCount > 0)
            {
                func.Idfuncionario = Convert.ToInt16(dgvConsultaFunc[0, dgvConsultaFunc.CurrentRow.Index].Value);
                func = funcDAL.Return(func);
                txtNomeFunc.Text = func.Nome;
                txtCargoFunc.Text = func.Cargo;
                mtxtContratacaoFunc.Text = func.DataContratacao.ToString();
                txtSalarioFunc.Text = func.Salario.ToString();
                txtTelefoneFunc.Text = func.Telefone;
                txtEmailFunc.Text = func.Email;
                txtEnderecoFunc.Text = func.Endereco;
                mtxtNascFunc.Text = func.Nascimento.ToString();
                txtObservFunc.Text = func.Observacoes;

                tabControl1.SelectedTab = tabPage1;

                btnCadastrarFunc.Text = "Atualizar";
                btnCadastrarFunc.Width += 20;
                btnCadastrarFunc.Left -= 20;
                btnLimparFunc.Left -= 20;
            }
        }

        private void btnRealocarFunc_MouseHover(object sender, EventArgs e)
        {
            Hover(btnRealocarFunc, "Black", "White");
        }

        private void btnRealocarFunc_MouseLeave(object sender, EventArgs e)
        {
            Hover(btnRealocarFunc, "Transparent", "Black");
        }
    }
}
