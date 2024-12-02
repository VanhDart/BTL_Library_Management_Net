using ManagamentLibrary.Controller;
using ManagamentLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ManagamentLibrary.Views
{
    /// <summary>
    /// Interaction logic for ReturnBook.xaml
    /// </summary>
    public partial class ReturnBook : Window
    {
        private readonly ReturnBookController _returnBookController;

        private ReturnBookModel _returnBookModel;

        public ReturnBook()
        {
            _returnBookController = new ReturnBookController();
            _returnBookModel  = new ReturnBookModel();
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void Click_SearchStudentBorrowBK(object sender, RoutedEventArgs e)
        {
            GroupBox1.Visibility = Visibility.Hidden;
            scrollViewer.VerticalScrollBarVisibility = ScrollBarVisibility.Disabled;
            string msv = txt_SearchStudentBorrowBK.Text;
            if (string.IsNullOrEmpty(msv))
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            else
            {
                _returnBookController.SearchBorrowBook(msv, dataGrid_listBorrowBk);
            }
        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dataGrid_listBorrowBk.SelectedItem is DataRowView currentRow) 
            {
                string? BorrowId = currentRow["BorrowID"].ToString();
                string? StudentName = currentRow["StudentName"].ToString();
                string? StudentId = currentRow["StudentId"].ToString();
                string? Class = currentRow["Class"].ToString();
                string? Phone = currentRow["Phone"].ToString();
                string? Email = currentRow["Email"].ToString();
                string? bookId = currentRow["bookId"].ToString();
                string? bkName = currentRow["BookName"].ToString();
                string? BorrowDate = currentRow["BorrowDate"].ToString();

                txt_BookName.Text = bkName;
                datePicker_BorrowDate.Text = BorrowDate;

               
                ScrollViewer scrollViewer = (ScrollViewer)this.FindName("scrollViewer");
                if (scrollViewer != null)
                {
                    scrollViewer.ScrollToVerticalOffset(scrollViewer.ExtentHeight);
                }
                
                _returnBookModel = new ReturnBookModel()
                {
                    returnId = Convert.ToInt32(BorrowId),
                    borrowId = Convert.ToInt32(BorrowId),
                    studentName = StudentName,
                    studentID = StudentId,
                    studentClass = Class,
                    studentEmail = Email,
                    studentPhone = Phone,
                    bookId = bookId,
                    bookName = bkName,
                    borrowDate = BorrowDate,
                };

            }
            GroupBox1.Visibility = Visibility.Visible;
            scrollViewer.VerticalScrollBarVisibility = ScrollBarVisibility.Auto;
        }

        private void Click_Cancel(object sender, RoutedEventArgs e)
        {
            GroupBox1.Visibility = Visibility.Hidden;
            scrollViewer.VerticalScrollBarVisibility = ScrollBarVisibility.Disabled;
        }

        private void Click_Refresh(object sender, RoutedEventArgs e)
        {
            DataTable booksTable = new DataTable();
            dataGrid_listBorrowBk.ItemsSource = booksTable.DefaultView;
            booksTable.Clear();
            txt_SearchStudentBorrowBK.Clear();
        }

        private void Click_ReturnBook(object sender, RoutedEventArgs e)
        {
            try
            {
                if (datePicker_ReturnDate.SelectedDate != null)
                {
                    string? ReturnDate = datePicker_ReturnDate.Text;
                    _returnBookModel.returnDate = ReturnDate;
                    _returnBookController.ReturnBook(_returnBookModel);
                    MessageBox.Show("Trả sách thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                    string msv = txt_SearchStudentBorrowBK.Text;
                    _returnBookController.SearchBorrowBook(msv, dataGrid_listBorrowBk);
                    ClearInfo();
                }
                else
                {
                    MessageBox.Show("Chọn ngày trả", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }

        private void Click_Exit(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Exit?", "Confirm", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                this.Close();
            }
        }

        private void ClearInfo()
        {
            txt_BookName.Clear();
            datePicker_BorrowDate.SelectedDate = null;
            datePicker_ReturnDate.SelectedDate = null;
        }
    }
}
