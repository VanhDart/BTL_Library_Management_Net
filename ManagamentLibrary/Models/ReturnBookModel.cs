using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ManagamentLibrary.Models
{
    public class ReturnBookModel
    {

        public int returnId { get; set; } 
        public int borrowId { get; set; } 
        public string? studentName { get; set; } 
        public string? studentID { get; set; } 
        public string? studentClass { get; set; } 
        public string? studentPhone { get; set; } 
        public string? studentEmail { get; set; } 
        public string? bookName { get; set; } 
        public string? borrowDate { get; set; } 
        public string? returnDate { get; set; }

        private readonly string connect = "Data Source=DESKTOP-2AK902G\\MSSQLSERVER2022;Initial Catalog=Library Management;Integrated Security=True";
        public void ReturnBookAndDeleteBorrowBook()
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                conn.Open();
                string sqlInsert = @"
                        INSERT INTO ReturnBook (ReturnId, BorrowId, StudentName, StudentID, StudentClass, 
                                                StudentPhone, StudentEmail, BookName, BorrowDate, ReturnDate)
                        VALUES
                            (@ReturnId, @BorrowId, @StudentName, @StudentID, @StudentClass, 
                            @StudentPhone, @StudentEmail, @BookName, @BorrowDate, @ReturnDate)";
                using (SqlCommand command = new SqlCommand(sqlInsert, conn))
                {
                    command.Parameters.AddWithValue("@ReturnId", returnId);
                    command.Parameters.AddWithValue("@BorrowId", borrowId);
                    command.Parameters.AddWithValue("@StudentName", studentName);
                    command.Parameters.AddWithValue("@StudentID", studentID);
                    command.Parameters.AddWithValue("@StudentClass", studentClass);
                    command.Parameters.AddWithValue("@StudentPhone", studentPhone);
                    command.Parameters.AddWithValue("@StudentEmail", studentEmail);
                    command.Parameters.AddWithValue("@BookName", bookName);
                    command.Parameters.AddWithValue("@BorrowDate", borrowDate);
                    command.Parameters.AddWithValue("@ReturnDate", returnDate);
                    command.ExecuteNonQuery();
                }

                string sqlDeleteBkBorrow = "DELETE FROM BorrowBook WHERE  BorrowID = @BorrowID ";

                using (SqlCommand command = new SqlCommand(sqlDeleteBkBorrow, conn))
                {
                    command.Parameters.AddWithValue("@BorrowID", borrowId);
                    command.ExecuteNonQuery();
                }

                conn.Close();
            }
        }


        public void SearchBorrowBook(string msv, DataGrid grid)
        {
            using(SqlConnection conn = new SqlConnection(connect)) 
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
                        INNER JOIN Book nb ON bb.bookId = nb.bookId
                        WHERE bb.MSV = @MSV";

                using (SqlCommand cmd = new SqlCommand(query,conn)) 
                {
                    cmd.Parameters.AddWithValue("@MSV", msv);

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
