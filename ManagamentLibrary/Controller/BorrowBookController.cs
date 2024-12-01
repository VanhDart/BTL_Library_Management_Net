using ManagamentLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ManagamentLibrary.Controller
{
    public class BorrowBookController
    {
        BorrowBookModel _borrowBookModel;
        public BorrowBookController() 
        {
            _borrowBookModel = new BorrowBookModel();
        }
        public StudentModel GetStudentInFo(string msv)
        {
            return _borrowBookModel.GetStudentInformation(msv);
        }

        public async Task<List<BookModel>> GetBooksAsync()
        {
            return await _borrowBookModel.GetBooksAsync();
        }

        public void InsertBorrowCard(BorrowBookModel borrowBook) 
        {
            _borrowBookModel = new BorrowBookModel()
            {
                MSV_BorrowBk = borrowBook.MSV_BorrowBk,
                BookId = borrowBook.BookId,
                BorrowDate = borrowBook.BorrowDate,

            };

            _borrowBookModel.InsertBorrowCard();
        }
    }
}
