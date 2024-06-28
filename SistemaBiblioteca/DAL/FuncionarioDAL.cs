using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.DAL
{
    class FuncionarioDAL
    {
        Connection conn = new Connection();

        public void Register (BLL.Funcionario func)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"INSERT INTO Funcionarios
                                (Nome, Cargo, DataContratacao, Salario, Telefone, Email, 
                                Endereco, DataNascimento, Observacoes)

                                VALUES (@Nome, @Cargo, @DataContratacao, @Salario, @Telefone, @Email, 
                                @Endereco, @DataNascimento, @Observacoes)";
            cmd.Parameters.AddWithValue("@Nome", func.Nome);
            cmd.Parameters.AddWithValue("@Cargo", func.Cargo);
            cmd.Parameters.AddWithValue("@DataContratacao", func.DataContratacao);
            cmd.Parameters.AddWithValue("@Salario", func.Salario);
            cmd.Parameters.AddWithValue("@Telefone", func.Telefone);
            cmd.Parameters.AddWithValue("@Email", func.Email);
            cmd.Parameters.AddWithValue("@Endereco", func.Endereco);
            cmd.Parameters.AddWithValue("@DataNascimento", func.Nascimento);
            cmd.Parameters.AddWithValue("@Observacoes", func.Observacoes);

            cmd.Connection = conn.Connect();
            cmd.ExecuteNonQuery();
            conn.Disconnect();
        }

        public DataTable Consult()
        {
            SqlDataAdapter dAdapter = new SqlDataAdapter("SELECT * FROM vwFuncionario", conn.Connect());
            DataTable dTable = new DataTable();
            dAdapter.Fill(dTable);
            conn.Disconnect();
            return dTable;
        }

        public void Delete(BLL.Funcionario func)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Funcionarios SET Visible = 0 WHERE FuncionarioID = @IdFunc";
            cmd.Parameters.AddWithValue("@IdFunc", func.Idfuncionario);
            cmd.Connection = conn.Connect();
            cmd.ExecuteNonQuery();
            conn.Disconnect();
        }

        public BLL.Funcionario Return(BLL.Funcionario func)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Funcionarios WHERE FuncionarioID = @IdFunc";
            cmd.Parameters.AddWithValue("@IdFunc", func.Idfuncionario);
            cmd.Connection = conn.Connect();
            SqlDataReader dReader = cmd.ExecuteReader();
            if (dReader.Read())
            {
                func.Idfuncionario = Convert.ToInt16(dReader["FuncionarioID"]);
                func.Nome = dReader["Nome"].ToString();
                func.Cargo = dReader["Cargo"].ToString();
                func.DataContratacao = Convert.ToDateTime(dReader["DataContratacao"]);
                func.Salario = double.Parse(dReader["Salario"].ToString());
                func.Telefone = dReader["Telefone"].ToString();
                func.Email = dReader["Email"].ToString();
                func.Endereco = dReader["Endereco"].ToString();
                func.Nascimento = Convert.ToDateTime(dReader["DataNascimento"]);
                func.Observacoes = dReader["Observacoes"].ToString();
                func.Visible = Convert.ToInt16(dReader["Visible"]);
            }
            dReader.Close();
            conn.Disconnect();
            return func;
        }

        public void Update(BLL.Funcionario func)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"UPDATE Funcionarios SET
                                    Nome = @Nome,
                                    Cargo = @Cargo,
                                    DataContratacao = @Contratacao,
                                    Salario = @Salario,
                                    Telefone = @Telefone,
                                    Email = @Email,
                                    Endereco = @Endereco,
                                    DataNascimento = @Nascimento,
                                    Observacoes = @Observacoes
                                WHERE FuncionarioID = @FuncionarioID";
            cmd.Parameters.AddWithValue("@Nome", func.Nome);
            cmd.Parameters.AddWithValue("@Cargo", func.Cargo);
            cmd.Parameters.AddWithValue("@Contratacao", func.DataContratacao);
            cmd.Parameters.AddWithValue("@Salario", func.Salario);
            cmd.Parameters.AddWithValue("@Telefone", func.Telefone);
            cmd.Parameters.AddWithValue("@Email", func.Email);
            cmd.Parameters.AddWithValue("@Endereco", func.Endereco);
            cmd.Parameters.AddWithValue("@Nascimento", func.Nascimento);
            cmd.Parameters.AddWithValue("@Observacoes", func.Observacoes);
            cmd.Parameters.AddWithValue("@FuncionarioID", func.Idfuncionario);

            cmd.Connection = conn.Connect();
            cmd.ExecuteNonQuery();
            conn.Disconnect();
        }

        public DataTable Search(BLL.Funcionario func)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Funcionarios WHERE Nome LIKE @Nome AND Visible = 1", conn.Connect());
            dataAdapter.SelectCommand.Parameters.AddWithValue("@Nome", "%" + func.Nome + "%");
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            conn.Disconnect();
            return dataTable;
        }
    }
}
