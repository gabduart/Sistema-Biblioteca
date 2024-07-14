using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.DAL
{
    class EditoresDAL
    {
        Connection conn = new Connection();

        public void Register(BLL.Editores ed)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"INSERT INTO Editores (Nome) VALUES (@Nome)";
            cmd.Parameters.AddWithValue("@Nome", ed.NomeEditor);

            cmd.Connection = conn.Connect();
            cmd.ExecuteNonQuery();
            conn.Disconnect();
        }

        public DataTable Consult()
        {
            SqlDataAdapter dAdapter = new SqlDataAdapter("SELECT * FROM Editores", conn.Connect());
            DataTable dTable = new DataTable();
            dAdapter.Fill(dTable);
            conn.Disconnect();
            return dTable;
        }

        public void Delete(BLL.Editores ed)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"DELETE FROM Editores WHERE EditorID = @EditorID";
            cmd.Parameters.AddWithValue("@EditorID", ed.EditorId);
            cmd.Connection = conn.Connect();
            cmd.ExecuteNonQuery();
            conn.Disconnect();
        }

        public DataTable Search(BLL.Editores ed)
        {
            SqlDataAdapter dAdapter = new SqlDataAdapter("SELECT * FROM Editores WHERE Nome LIKE @Nome", conn.Connect());
            dAdapter.SelectCommand.Parameters.AddWithValue("@Nome", "%" + ed.NomeEditor + "%");
            DataTable dTable = new DataTable();
            dAdapter.Fill(dTable);
            conn.Disconnect();
            return dTable;
        }

        public BLL.Editores Return(BLL.Editores ed)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"SELECT * FROM Editores WHERE EditorID = @EditorID";
            cmd.Parameters.AddWithValue("@EditorID", ed.EditorId);
            cmd.Connection = conn.Connect();
            SqlDataReader dReader = cmd.ExecuteReader();
            if (dReader.Read())
            {
                ed.EditorId = Convert.ToInt16(dReader["EditorID"]);
                ed.NomeEditor = dReader["Nome"].ToString();
            }
            dReader.Close();
            conn.Disconnect();
            return ed;
        }

        public void Update(BLL.Editores ed)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"UPDATE Editores SET
                                    Nome = @Nome
                                WHERE EditorID = @EditorID";
            cmd.Parameters.AddWithValue("@Nome", ed.NomeEditor);
            cmd.Parameters.AddWithValue("@EditorID", ed.EditorId);
            cmd.Connection = conn.Connect();
            cmd.ExecuteNonQuery();
            conn.Disconnect();
        }
    }
}
