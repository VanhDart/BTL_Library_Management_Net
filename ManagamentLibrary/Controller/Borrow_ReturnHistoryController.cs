using ManagamentLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ManagamentLibrary.Controller
{
    public class Borrow_ReturnHistoryController
    {
        Borrow_ReturnHistoryModel model;
        public Borrow_ReturnHistoryController()
        {
            model = new Borrow_ReturnHistoryModel();
        }
        public void ReturnHistory(DataGrid grid)
        {
            model.ReturnHistory(grid);
        }
        public void BorrowHistory(DataGrid grid)
        {
            model.BorrowHistory(grid);
        }
    }
}
