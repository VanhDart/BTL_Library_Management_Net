   M S B A M L   `   `   `  ����L  HManagamentLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:ManagamentLibrary.ViewsManagamentLibrary.Views  5   	   (    "ManagamentLibrary.Views.BorrowBook   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   U QWpfAnimatedGif, Version=2.0.0.0, Culture=neutral, PublicKeyToken=9e7cd3b544a090dc7wpfAnimatedGif"http://wpfanimatedgif.codeplex.com  5   	   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5   	   1local%clr-namespace:ManagamentLibrary.Views  5   	     � Title$  
BorrowBook��5	   	   $	��551��6   $	��723��6)   ���	#FFF29B3B.��5
      � $	��723��6   $��Center=�6   $��Center=�64   $	��534��6O   .+�5   
   �� $��Center=�6   $	��100��61   $��0,10,0,0q�6>   $	��Top=�6P   $	��703��6h   
�������
���   �6�   �� 5   
   $
��Left=�6   $	��410��6/   $��290,115,0,0q�6<   
���   �$	��Top=�6`   $	��423��6x   ���	#FF7BE1EF6�   �� 5   
   $
��Left=�6   $	��410��6/   $��
10,115,0,0q�6<   
���   �$	��Top=�6_   $	��275��6w   ���	#FFC9C9C96�   �� 5   
   $��80��6   $��
235,20,0,0q�6   $	��206��60   "  WpfAnimatedGif.ImageBehavior   AnimatedSource$. (pack://application:,,,/img/issueBook.gif��6<   $
��Fill=�6�   $
��Left=�6�   $	��Top=�6�   �� 5   
   $��Borrow Books��6   $
��Left=�6'   $��
384,47,0,0q�6B   $	��Top=�6V   ���	#FF2D95D2$��18(�6�   $
��Bold"�6�   �� 5   
   $
��Left=�6   $	��100��6+   $��
98,143,0,0q�68   $	��Top=�6L   $	��100��6d   $<��6pack://application:,,,/img/icons8-student-male-100.png��6p   �� 5   
   $��Enter Student ID��6   $
��Left=�6+   $��85,0,0,0q�6F   $��Center=�6X   $��16(�6s   �� 5   
   -   5        $��SearchStudent_MSV��5      $
��Left=�6+   $��
46,299,0,0q�6F    �� TextWrapping$
 Wrap=�6Z   $	��Top=�6n   $	��205��6�   $��16(�6�   $��25��6�   
���   �6�   �� 5   
   -   5        $��Search Student��5      $
��Left=�6F   $��
89,351,0,0q�6a   $	��Top=�6u   $	��118��6�   $��31��6�   $
��Bold"�6�   �� 5   
   -   5        $��Refresh��5      $
��Left=�69   $��
28,434,0,0q�6T   $	��Top=�6h   $��95��6�   $��32��6�   $
��Bold"�6�   �� 5   
   -   5        $
��Exit��5      $
��Left=�63   $��178,434,0,0q�6N   $	��Top=�6c   $��91��6{   $��32��6�   $
��Bold"�6�   �� 5   
   -   5        $��Txt_StudentName��5       �� 
IsReadOnly$
 True��6)   $
��Left=�6;   $��488,143,0,0q�6V   $
 Wrap=�6k   $	��Top=�6   $	��187��6�   $��14(�6�   �� 5   
   $��Student Name��6   $
��Left=�6'   $��326,139,0,0q�6B   $	��Top=�6W   $��14(�6o   �� 5   
   -   5        $��Txt_ClassName��5      $
 True��6'   $
��Left=�69   $��488,193,0,0q�6T   $
 Wrap=�6i   $	��Top=�6}   $	��187��6�   $��14(�6�   �� 5   
   $��
Class Name��6   $
��Left=�6%   $��326,189,0,0q�6@   $	��Top=�6U   $��14(�6m   �� 5   
   -   5        $��Txt_PhoneNumber��5      $
 True��6)   $
��Left=�6;   $��488,247,0,0q�6V   $
 Wrap=�6k   $	��Top=�6   $	��187��6�   $��14(�6�   �� 5   
   $��Phone Number��6   $
��Left=�6'   $��326,243,0,0q�6B   $	��Top=�6W   $��14(�6o   �� 5    
   -   5        $��Txt_EmailStudent��5       $
 True��6*   $
��Left=�6<   $��487,303,0,0q�6W   $
 Wrap=�6l   $	��Top=�6�   $	��187��6�   $��14(�6�   �� 5!   
   $��Email Student��6   $
��Left=�6(   $��325,299,0,0q�6C   $	��Top=�6X   $��14(�6p   �� 5"   
   -	   5        $��BookComboBox��5"      $
��Left=�6Y   $��487,357,0,0q�6t   $	��Top=�6�   $	��186��6�   $��14(�6�   �� 5#   
   $��	Book Name��6   $
��Left=�6$   $��325,353,0,0q�6?   $	��Top=�6T   $��14(�6l   (  "System.Windows.Controls.DatePicker  5$   
   -
   5        $��DatePicker_borrowBook��5$      $
��Left=�62   $��487,418,0,0q�6M   $	��Top=�6b   $	��187��6z   $��14(�6�   �� 5%   
   $��Book Borrow Date��6   $
��Left=�6+   $��325,414,0,0q�6F   $	��Top=�6[   $��14(�6s   �� 5&   
   -   5        $��Borrow Book��5&      $
��Left=�6>   $��580,470,0,0q�6Y   $	��Top=�6n   $��33��6�   $��93��6�   
�������$
��Bold"�6�   5'      5(      