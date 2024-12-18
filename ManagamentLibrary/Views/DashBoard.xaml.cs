﻿using ManagamentLibrary.Controller;
using ManagamentLibrary.Views;
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

namespace ManagamentLibrary
{
    /// <summary>
    /// Interaction logic for DashBoard.xaml
    /// </summary>
    public partial class DashBoard : Window
    {
        private AddBook addBook;

        private ViewBook viewBook;

        private AddStudent addStudent;

        private ViewStudent viewStudent;

        private BorrowBook borrowBook;

        private ReturnBook returnBook;

        private DashBoardController dashBoardController;

        private Borrow_ReturnHistory borrow_ReturnHistory;
        public DashBoard()
        {
            InitializeComponent();
            addBook = new AddBook();
            viewBook = new ViewBook();
            addStudent = new AddStudent();
            viewStudent = new ViewStudent();
            borrowBook = new BorrowBook();  
            returnBook = new ReturnBook();
            dashBoardController = new DashBoardController();
            borrow_ReturnHistory = new Borrow_ReturnHistory();
            this.Closing += DashBoard_Closing;  
        
        }

        private void DashBoard_Closing(object? sender, System.ComponentModel.CancelEventArgs e)
        {
            foreach (Window window in Application.Current.Windows)
            {

                if (window != this && window.IsVisible) 
                {
                    MessageBox.Show("Please close all open pages before closing the dashboard.", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                    e.Cancel = true; 

                    return;
                }
                else
                {
                    e.Cancel = false;
                    return;
                }
            }
        }

        private void ClickExit(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Exit?", "Confirm", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {

                var openWindows = Application.Current.Windows;

                Login main = new Login();
                main.Show();

                foreach (Window window in openWindows)
                {
                    if (window != main)
                    {
                        window.Close();
                    }
                }
            }
        }


        private void ClickAddBook(object sender, RoutedEventArgs e)
        {
            dashBoardController.ShowOrActivateWindow(ref addBook);
        }

        private void ClickViewBook(object sender, RoutedEventArgs e)
        {
            dashBoardController.ShowOrActivateWindow(ref viewBook);
        }
        private void ClickViewStudent(object sender, RoutedEventArgs e)
        {
            dashBoardController.ShowOrActivateWindow(ref viewStudent);
        }
        private void ClickAddStudent(object sender, RoutedEventArgs e)
        {
            dashBoardController.ShowOrActivateWindow(ref addStudent);
        }

        private void Click_BorrowBook(object sender, RoutedEventArgs e)
        {
            dashBoardController.ShowOrActivateWindow(ref borrowBook);
        }

        private void Click_ReturnBook(object sender, RoutedEventArgs e)
        {
            dashBoardController.ShowOrActivateWindow(ref returnBook);
        }

        private void Click_Borrow_Return_History(object sender, RoutedEventArgs e)
        {
            dashBoardController.ShowOrActivateWindow(ref borrow_ReturnHistory);
        }
    }
}
