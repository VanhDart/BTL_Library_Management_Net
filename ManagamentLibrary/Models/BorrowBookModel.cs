using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ManagamentLibrary.Models
{
    public class BorrowBookModel()
    {
        public int BorrowId { get; set; }
        public string? MSV_BorrowBk {  get; set; }
        public string? BookId {  get; set; }
        public string? BorrowDate {  get; set; }


        private readonly string connect = "Data Source=DESKTOP-2AK902G\\MSSQLSERVER2022;Initial Catalog=a;Integrated Security=True";
        public StudentModel GetStudentInformation(string msv)
        {
            StudentModel student = null!;
            using(SqlConnection conn = new SqlConnection(connect))
            {
                conn.Open();

                string sql = "SELECT * FROM Student WHERE MSV = @MSV";
                using (SqlCommand cmd = new SqlCommand(sql,conn))
                {
                    cmd.Parameters.AddWithValue("@MSV", msv);
                    using(SqlDataReader reader = cmd.ExecuteReader()) 
                    { 
                        if (reader.Read()) //Di chuyển con trỏ đến dòng kết quả đầu tiên. Trả về true nếu có dữ liệu.
                        {
                            student = new StudentModel()
                            {
                                MSV = reader["MSV"].ToString(),
                                Name = reader["Name"].ToString(),
                                Class = reader["Class"].ToString(),
                                PhoneNumber = reader["Phone"].ToString(),
                                Email = reader["Email"].ToString()
                            };
                        }
                    }
                  
                }
            } 
            return student;
        }

        public async Task<List<BookModel>> GetBooksAsync()
        {
            List<BookModel> books = new List<BookModel>();

            using (SqlConnection conn = new SqlConnection(connect))
            {
                await conn.OpenAsync(); // Mở kết nối bất đồng bộ

                string sql = "SELECT bookId, bookName FROM NewBook";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync()) // Lấy dữ liệu bất đồng bộ
                    {
                        while (await reader.ReadAsync()) // Di chuyển con trỏ đến dòng kết quả đầu tiên
                        {
                            books.Add(new BookModel
                            {
                                Id = reader["bookId"].ToString(),
                                Name = reader["bookName"].ToString(),
                            });
                        }
                    }
                }
            }

            return books;
        }
    
        public void InsertBorrowCard()
        {
            using(SqlConnection conn = new SqlConnection(connect))
            {
                conn.Open();

                string sql = "INSERT INTO BorrowBook (MSV, BookId, BorrowDate) VALUES ( @MSV, @BookId, @BorrowDate)";
                using(SqlCommand cmd = new SqlCommand(sql,conn))
                {
                    cmd.Parameters.AddWithValue("@MSV", MSV_BorrowBk);
                    cmd.Parameters.AddWithValue("@BookId", BookId);
                    cmd.Parameters.AddWithValue("@BorrowDate", BorrowDate);

                    cmd.ExecuteNonQuery();
                }

                conn.Close();
            }
        }    
    }

}
