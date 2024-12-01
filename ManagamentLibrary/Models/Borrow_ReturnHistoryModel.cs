using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ManagamentLibrary.Models
{
    public class Borrow_ReturnHistoryModel
    {
        private readonly string connect = "Data Source=DESKTOP-2AK902G\\MSSQLSERVER2022;Initial Catalog=a;Integrated Security=True";
        public void ReturnHistory(DataGrid grid )
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                conn.Open();

                string sql = "SELECT * FROM ReturnBook";
                using(SqlCommand cmd = new SqlCommand(sql,conn)) 
                {
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);
                    grid.ItemsSource = dt.DefaultView;
                }
            }
        }

        public void BorrowHistory(DataGrid grid)
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                conn.Open();
                string query = @"
                        SELECT 
                            bb.BorrowID, 
                            s.Name AS StudentName, 
                            s.MSV AS StudentId,
                            s.Class, 
                            s.Phone, 
                            s.Email, 
                            nb.bookName AS BookName, 
                            bb.BorrowDate
                        FROM BorrowBook bb
                        INNER JOIN Student s ON bb.MSV = s.MSV
                        INNER JOIN NewBook nb ON bb.bookId = nb.bookId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    grid.ItemsSource = dataTable.DefaultView;
                }
                conn.Close();
            }
        }
    }
}
