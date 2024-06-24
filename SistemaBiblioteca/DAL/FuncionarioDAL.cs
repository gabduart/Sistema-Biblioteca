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
            SqlDataAdapter dAdapter = new SqlDataAdapter("SELECT * FROM Funcionarios", conn.Connect());
            DataTable dTable = new DataTable();
            dAdapter.Fill(dTable);
            conn.Disconnect();
            return dTable;
        }

        public void Delete(BLL.Funcionario func)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM Funcionarios WHERE FuncionarioID = @IdFunc";
            cmd.Parameters.AddWithValue("@IdFunc", func.Idfuncionario);
            cmd.Connection = conn.Connect();
            cmd.ExecuteNonQuery();
            conn.Disconnect();
        }
        /*
         * a continuar:
        public BLL.Funcionario Return (BLL.Funcionario func)
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
                func.Email = dReader["Email"].
            }*/
        }
    }
}
