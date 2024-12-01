using ManagamentLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ManagamentLibrary.Controller
{
    public class ReturnBookController
    {
        private ReturnBookModel _modelReturnBook;
        public ReturnBookController() 
        {
            _modelReturnBook = new ReturnBookModel();
        }
        public void SearchBorrowBook(string msv, DataGrid grid)
        {
            _modelReturnBook.SearchBorrowBook(msv, grid);
        }

        public void ReturnBook(ReturnBookModel returnBook)
        {
            _modelReturnBook = new ReturnBookModel()
            {
                returnId = returnBook.returnId,
                borrowId = returnBook.borrowId,
                studentName = returnBook.studentName,
                studentID = returnBook.studentID,
                studentClass = returnBook.studentClass,
                studentEmail = returnBook.studentEmail,
                studentPhone = returnBook.studentPhone,
                bookName = returnBook.bookName,
                borrowDate = returnBook.borrowDate,
                returnDate = returnBook.returnDate,
            };
            _modelReturnBook.ReturnBookAndDeleteBorrowBook();
        }
    }
}
