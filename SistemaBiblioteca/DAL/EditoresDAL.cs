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
    }
}
