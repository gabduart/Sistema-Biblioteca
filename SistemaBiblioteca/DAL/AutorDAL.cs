using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.DAL
{
    class AutorDAL
    {
        Connection conn = new Connection();

        public void Rgister(BLL.Autor auth)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"INSERT INTO Autores (Nome) VALUES (@Nome)";
            cmd.Parameters.AddWithValue("@Nome", auth.NomeAutor);

            cmd.Connection = conn.Connect();
            cmd.ExecuteNonQuery();
            conn.Disconnect();
        }

        public DataTable Consult()
        {
            SqlDataAdapter dAdapter = new SqlDataAdapter(@"SELECT * FROM Autores;", conn.Connect());
            DataTable dTable = new DataTable();
            dAdapter.Fill(dTable);
            conn.Disconnect();
            return dTable;
        }

        public void Delete(BLL.Autor auth)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"DELETE FROM Autores WHERE AutorID = @AutorID";
            cmd.Parameters.AddWithValue("@AutorID", auth.IdAutor);
            cmd.Connection = conn.Connect();
            cmd.ExecuteNonQuery();
            conn.Disconnect();
        }

        public DataTable Search(BLL.Autor auth)
        {
            SqlDataAdapter dAdapter = new SqlDataAdapter(@"SELECT * FROM Autores WHERE Nome LIKE @Nome", conn.Connect());
            dAdapter.SelectCommand.Parameters.AddWithValue("@Nome", "%" + auth.NomeAutor + "%");
            DataTable dTable = new DataTable();
            dAdapter.Fill(dTable);
            conn.Disconnect();
            return dTable;
        }

        public BLL.Autor Return(BLL.Autor auth)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"SELECT * FROM Autores WHERE AutorID = @AutorID";
            cmd.Parameters.AddWithValue("@AutorID", auth.IdAutor);
            cmd.Connection = conn.Connect();
            SqlDataReader dReader = cmd.ExecuteReader();
            if (dReader.Read())
            {
                auth.IdAutor = Convert.ToInt16(dReader["AutorID"]);
                auth.NomeAutor = dReader["Nome"].ToString();
            }
            dReader.Close();
            conn.Disconnect();
            return auth;
        }

        public void Update(BLL.Autor auth)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"UPDATE Autores SET
                                    Nome = @Nome
                                WHERE AutorID = @AutorID";
            cmd.Parameters.AddWithValue("@Nome", auth.NomeAutor);
            cmd.Parameters.AddWithValue("@AutorID", auth.IdAutor);
            cmd.Connection = conn.Connect();
            cmd.ExecuteNonQuery();
            conn.Disconnect();
        }
    }
}
