using ManagamentLibrary.Controller;
using ManagamentLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ManagamentLibrary.Views
{
    /// <summary>
    /// Interaction logic for BorrowBook.xaml
    /// </summary>
    public partial class BorrowBook : Window
    {
        BorrowBookController _controller;
        private string? MsvStudent_Borrow;
        private string? IdBook_Borrow;
        public BorrowBook()
        {
            _controller = new BorrowBookController();
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            this.Loaded += Window_Loaded; // Đăng ký sự kiện Loaded
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            List<BookModel> books = await _controller.GetBooksAsync();

            if (books != null && books.Count > 0)
            {
                BookComboBox.ItemsSource = books;
                BookComboBox.DisplayMemberPath = "Name"; // Hiển thị thuộc tính Name
                BookComboBox.SelectedValuePath = "Id";  // Giá trị trả về là Id
            }
            else
            {
                MessageBox.Show("Không có sách nào!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void SearchStudent_Click(object sender, RoutedEventArgs e)
        {
            string msv = SearchStudent_MSV.Text;
            if (msv != null)
            {
                StudentModel student = _controller.GetStudentInFo(msv);
                if (student != null)
                {
                    MsvStudent_Borrow = student.MSV;
                    Txt_StudentName.Text = student.Name;
                    Txt_ClassName.Text = student.Class;
                    Txt_PhoneNumber.Text = student.PhoneNumber;
                    Txt_EmailStudent.Text = student.Email;
                }
                else
                {
                    MessageBox.Show("Sinh viên không tồn tại! ", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Nhập MSV Muốn Tìm","Error",MessageBoxButton.OK,MessageBoxImage.Error);
            }
        }

        // khi chọn item khác thì sẽ gán lại giá trị value
        private void BookComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(BookComboBox.SelectedValue != null)
            {
                IdBook_Borrow = (string)BookComboBox.SelectedValue;
            }
        }

        private void btn_BorrowBook(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Txt_StudentName.Text) ||
                    string.IsNullOrEmpty(Txt_ClassName.Text) ||
                    string.IsNullOrEmpty(Txt_PhoneNumber.Text) ||
                    string.IsNullOrEmpty(Txt_EmailStudent.Text) ||
                    BookComboBox.SelectedItem == null ||  // Kiểm tra nếu không có sách nào được chọn
                    DatePicker_borrowBook.SelectedDate == null) // Kiểm tra nếu chưa chọn ngày)
                {
                    MessageBox.Show("Vui lòng điền đủ thông tin", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    var borrowBk = new BorrowBookModel()
                    {
                        MSV_BorrowBk = MsvStudent_Borrow,
                        BookId = IdBook_Borrow,
                        BorrowDate = DatePicker_borrowBook.Text
                    };
                    _controller.InsertBorrowCard(borrowBk);
                    MessageBox.Show("Mượn sách thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK,MessageBoxImage.Error);
            }
        }

        public void Refresh_Click(object sender, RoutedEventArgs e)
        {
            SearchStudent_MSV.Clear();
            Txt_StudentName.Clear();
            Txt_ClassName.Clear();
            Txt_PhoneNumber.Clear();
            Txt_EmailStudent.Clear();
            BookComboBox.SelectedItem = null;
            DatePicker_borrowBook.SelectedDate = null;
        }

        public void Exit_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit the book borrowing function?", "Confirm", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                this.Close();
            }
        }
    }
}
