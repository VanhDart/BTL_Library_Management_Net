using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using System.Data;
using System.Windows.Controls;

namespace ManagamentLibrary.Models
{
    public class BookModel
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public string? Author { get; set; }
        public string? Publication { get; set; }
        public string? PurchaseDate { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }

        private readonly string connect = "Data Source=DESKTOP-2AK902G\\MSSQLSERVER2022;Initial Catalog=Library Management;Integrated Security=True";

        public void LoadData(DataGrid grid)
        {
            using (SqlConnection con = new SqlConnection(connect))
            {
                con.Open(); 

                SqlCommand cmd = new SqlCommand("SELECT * FROM Book", con);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                adapter.Fill(dt);
                grid.ItemsSource = dt.DefaultView; 
                con.Close();
            }
        }

        public void InsertBook()
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                conn.Open();

                string sqlQueryNewBK = "INSERT INTO Book (bookName, bookAuthor, bkPulication, bookDate, bookPrice, bkQuantity) VALUES (@bookName, @bookAuthor, @bkPulication, @bookDate, @bookPrice, @bkQuantity)";

                using (SqlCommand command = new SqlCommand(sqlQueryNewBK, conn))
                {
                    command.Parameters.AddWithValue("@bookName", Name);
                    command.Parameters.AddWithValue("@bookAuthor", Author);
                    command.Parameters.AddWithValue("@bkPulication", Publication);
                    command.Parameters.AddWithValue("@bookDate", PurchaseDate);
                    command.Parameters.AddWithValue("@bookPrice", Price);
                    command.Parameters.AddWithValue("@bkQuantity", Quantity);

                    command.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        public void UpdateBook()
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                conn.Open();

                string sqlQueryNewBK = @"
                                        UPDATE Book SET bookName = @bookName ,bookAuthor = @bookAuthor ,bkPulication = @bkPulication ,bookDate = @bookDate ,bookPrice = @bookPrice ,bkQuantity = @bkQuantity WHERE bookId = @bookId; ";

                using (SqlCommand command = new SqlCommand(sqlQueryNewBK, conn))
                {
                    command.Parameters.AddWithValue("@bookId", Id);
                    command.Parameters.AddWithValue("@bookName", Name);
                    command.Parameters.AddWithValue("@bookAuthor", Author);
                    command.Parameters.AddWithValue("@bkPulication", Publication);
                    command.Parameters.AddWithValue("@bookDate", PurchaseDate);
                    command.Parameters.AddWithValue("@bookPrice", Price);
                    command.Parameters.AddWithValue("@bkQuantity", Quantity);
                    command.ExecuteNonQuery();
                } 
                conn.Close();
            }
        }

        public void DeleteBook()
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                conn.Open();

                string sqlQueryNewBK = @"DELETE FROM BorrowBook WHERE bookId = @bookId;
                                            DELETE FROM ReturnBook WHERE BookId = @bookId;
                                            DELETE FROM Book WHERE bookId = @bookId;";

                using (SqlCommand command = new SqlCommand(sqlQueryNewBK, conn))
                {
                    command.Parameters.AddWithValue("@bookid", Id);

                    command.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        public void SearchBook(TextBox search, DataGrid grid)
        {
            if (!string.IsNullOrEmpty(search.Text))
            {
                using (SqlConnection con = new SqlConnection(connect))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM Book WHERE bookName LIKE @searchText OR bookId LIKE @searchText", con);
                    cmd.Parameters.AddWithValue("@searchText", "%" + search.Text + "%"); 
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    adapter.Fill(dt); 
                    grid.ItemsSource = dt.DefaultView;

                    con.Close();
                }
            }
            else
            {
                LoadData(grid);
            }
        }
    }
}
