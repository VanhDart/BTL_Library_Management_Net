   M S B A M L   `   `   `  ����L  HManagamentLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:ManagamentLibrary.ViewsManagamentLibrary.Views  5   	   2    ,ManagamentLibrary.Views.Borrow_ReturnHistory   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:ManagamentLibrary.Views     5   	     � Title$  Borrow_ReturnHistory��5   	   $	��450��6&   $	��800��63   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��41* �6   �� 5      $
��176* �6   �� 5      $	��43* �6   �� 5      $
��174* �6    � ColumnDefinitions 5   
   �� 5      .+�5   
   �� $��Borrowed Books��6   $��Center=�6)   $��Center=�6F   $��16(�6a   $
��Bold"�6o   ���	#FF00A0FF6�   &   System.Windows.Controls.DataGrid  5   
   -   5        $��dataGrid_BorrowBook��5      $��1��6.   $��	20,0,20,0q�6<   $   HorizontalScrollBarVisibility$
 Auto=�6O   "   VerticalScrollBarVisibility$
 Auto=�6t   �� 5   
   $��Returned Books��6   $��2��6)   $��Center=�67   $��Center=�6T   $��16(�6o   $
��Bold"�6}   ���	#FF00A0FF6�     5   
   -   5        $��dataGrid_ReturnedBook��5      $��3��60   $��	20,0,20,0q�6>   $
 Auto=�6Q   $
 Auto=�6v   5      5      