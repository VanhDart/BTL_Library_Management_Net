   M S B A M L   `   `   `  ����L  HManagamentLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:ManagamentLibrary.ViewsManagamentLibrary.Views  5   	   (    "ManagamentLibrary.Views.ReturnBook   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   U QWpfAnimatedGif, Version=2.0.0.0, Culture=neutral, PublicKeyToken=9e7cd3b544a090dc7wpfAnimatedGif"http://wpfanimatedgif.codeplex.com  5   	   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5   	   1local%clr-namespace:ManagamentLibrary.Views  5   	     � Title$  
ReturnBook��5	   	   $	��483��6   $
��1024��6)   ���	#FFF29B3B.��5
      �� -   5         ��Name$ scrollViewer��5
      $��Hidden=�6)   .��5   
   � $	��686��6   $
��Auto��6     � RowDefinitions 5      �� 5      $
��439* �6    �� 5      $
��247* �6     � ColumnDefinitions 5      �� 5      $
��341* �6#   �� 5      $
��683* �6#   .+�5      �� ���	#FFC9C9C9$��
10,5,10,10q�6E   ��6.   Z� .��5      �� .+�5      �� $<��6pack://application:,,,/img/icons8-student-male-100.png��6   $��100,40,100,0q�6\   �� 5      $��Enter Student ID ��6   $��	58,0,60,0q�68   $��18(�6K   $��33,5,5,5q�6Y   �� 5      -   5        $��txt_SearchStudentBorrowBK��5      $��30��6?   $��
40,20,40,0q�6K   $��16(�6_   �� 5      -   5        $��Search Student��5   A   $��
70,30,70,0q�6Z   $��16(�6n   $
��Bold"�6|   $��	1,10,1,10q�6�   �� 5       �� Orientation$ 
Horizontal=�6!   $��Center=�6:   $��0,40,0,0q�6W   .+�5      �� -   5        $��Refresh��5   !   $��16(�6I   $
��Bold"�6W   $��	10,6,10,6q�6i   $��0,0,30,0q�6}   �� 5      -   5        $
��Exit��5   !   $��16(�6C   $
��Bold"�6Q   $��	25,6,25,6q�6c   $��30,0,0,0q�6w   5      5      5       &   System.Windows.Controls.DataGrid  5"      -   5        $��dataGrid_listBorrowBk��5"      $��0��6b   $��1��6o   $��
5,10,10,10q�6   ���	#FFA6A6A66�   �� 5$      -   5        $��	GroupBox1��5$      $��1��6(   $��1��65   $��
10,5,10,10q�6E   ���	#FF51E5CE$y�	Collapsed=�6p   .��5%      �� $ 
Horizontal=�6   $��Center=�66   $��Center=�6S   .+�5&      �� .+�5'      �� $��	Book Name��6    $��16(�64   �� 5(      $��Book Borrow Date��6    $��0,15,0,0q�6;   $��16(�6M   �� 5)      $��Book Return Date��6    $��0,15,0,0q�6;   $��16(�6M   5*      �� 5+      $
��Auto��6!   $	��230��6.   $��16,0,0,0q�6=   .+�5,      �� -   5        $��txt_BookName��5,   "   $��16(�66    �� 
IsReadOnly$
 True��6D   ���	#FFC9C9C96V   (  "System.Windows.Controls.DatePicker  5-      -	   5        $��datePicker_BorrowDate��5-   %   $��16(�6B   $��0,24,0,0q�6Q   ${�False��6c     5.      -
   5        $��datePicker_ReturnDate��5.   %   $��16(�6B   $��0,23,0,0q�6Q   5/      �� 50      $��Bottom=�6!   $
��Auto��6<   $	��100��6I   $��20,0,0,0q�6X   .+�51      �� -   5        $��Return��51   !   $��16(�6K   $��0,5,0,5q�6Y   $��0,0,0,14q�6k   $
��Bold"�6}   �� 52      -   5        $��Cancel��52   !   $��16(�6G   $��0,5,0,5q�6U   $
��Bold"�6g   $��0,0,0,7q�6y   53      54      55      56      57      58      