using ManagamentLibrary.Controller;
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
    /// Interaction logic for Borrow_ReturnHistory.xaml
    /// </summary>
    public partial class Borrow_ReturnHistory : Window
    {
        private readonly Borrow_ReturnHistoryController _controller;
        public Borrow_ReturnHistory()
        {
            _controller = new Borrow_ReturnHistoryController();
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            this.Loaded += Borrow_ReturnHistory_Load;
        }

        private void Borrow_ReturnHistory_Load(object sender, EventArgs e)
        {
            _controller.ReturnHistory(dataGrid_ReturnedBook);
            _controller.BorrowHistory(dataGrid_BorrowBook);
        }
    }
}
