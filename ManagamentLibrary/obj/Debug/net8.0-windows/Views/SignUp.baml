   M S B A M L   `   `   `  ����L  HManagamentLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ManagamentLibraryManagamentLibrary  5   	       ManagamentLibrary.SignUp   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:ManagamentLibrary     5   	     � WindowStyle$  SingleBorderWindow=�5   	    � 
ResizeMode$ NoResize=�6*    � Title$ SignUp��5	   	   $	��500��6   $	��349��6%   ���	#FF232423.��5
      � .+�5   
   �� -   5         ��Name$ btnArrow��5      $
��Left=�6:   $��	10,10,0,0q�6U   $	��Top=�6h   ��6�   Z� ��6�   Z� ��6�   Z� .��5      �� $*��$pack://application:,,,/img/arrow.png��6   $��25��6B   $��25��6N   5      �� 5   
   $��Center=�6   $	��100��6-   $��0,22,0,0q�6:   $	��Top=�6L   $	��100��6d   $+��%pack://application:,,,/img/signup.png��6p   �� 5   
   -   5         ��Name$ UsernameTextBox��5   C   $��Center=�5      $��	0,150,0,0q�6/    �� TextWrapping$
 Wrap=�6B   $	��Top=�6V   $	��182��6n   $��21��6z   ���	#FFACAAAA���	#FF717171$��0,0,0,1q�5   8   ��5   �   Z� 5   C   �� 5   
   $
��Left=�6   $��35��6+   $��
36,143,0,0q�67   $	��Top=�6K   $��35��6c   $)��#pack://application:,,,/img/user.png��6n   �� 5   
   $
��Left=�6   $��35��6+   $��
36,204,0,0q�67   $	��Top=�6K   $��35��6c   $,��&pack://application:,,,/img/padlock.png��6n   G� 5   
   -   5         G�Name$ PasswordTextBox��5   O   $��Center=�5      $��	0,212,0,0q�63   $	��Top=�6F   $	��182��6^   $��18��6j   ���	#FF717171$��0,0,0,1q�5   :   ��6   Z� 5   O   �� 5   
   -   5        $ VisiblePasswordTextBox��5      $��Center=�62   $��	0,212,0,0q�6O   $	��Top=�5      $	��182��6*   $��18��66   $y�	Collapsed=�6�   $��0,0,0,1q�5      ���	#FF717171��6,   Z� 6B   �� 5   
   -   5        $$ TogglePasswordVisibilityButton��5      $��Right=�69   $��
0,206,70,0q�6U   $	��Top=�5      $��30��6%   $��18��60   
���������6<   Z� ��5   M   Z� .��5      �� $.��(pack://application:,,,/img/eye_open1.png��6   $��20��6F   $��20��6Q   5      �� 5!   
   $
��Left=�6   $��35��6+   $��
36,265,0,0q�67   $	��Top=�6K   $��35��6c   $.��(pack://application:,,,/img/send-mail.png��6n   �� 5"   
   -   5        $ EmailTextBox��5$   I   $��Center=�5"      $��	0,272,0,0q�6/   $
 Wrap=�6B   $	��Top=�6V   $	��182��6n   $��21��6z   ���	#FFACAAAA���	#FF717171$��0,0,0,1q�5#   <   ��5"   �   Z� 5$   I   �� 5%   
   -   5         � Cursor$
 Hand��5%   +   $
��Next��69   $��Center=�6H   $��	0,343,0,0q�6e   $	��Top=�6x   $��34��6�   $	��182��6�   ���	#FF08D3EF6�   5'      5(      