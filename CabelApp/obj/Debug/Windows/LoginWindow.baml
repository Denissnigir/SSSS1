   M S B A M L   `   `   `  ����C  ?CabelApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:CabelApp.WindowsCabelApp.Windows  5   	   "    CabelApp.Windows.LoginWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:CabelApp.Windows     5   	     � Title$  Login��5   	   $	��450��6   $	��800��6'   $	��450��66   $	��800��6C    � Icon$3 -/CabelApp;component/Resources/Photo/image.ico��6O   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��0.3* �6   �� 5      �� 5      $��0.25* �6   .+�5   
   �    SecondaryGrid#��[  6    � ColumnDefinitions 5      �� 5      $
��0.2* �6#   �� 5      .+�5      �� $=��7/CabelApp;component/Resources/Photo/Лого ТНС.jpg��6   $��5q�6O   �� 5      $��1��6   $3��-ООО «Телеком Нева Связь»��6(   $��Center=�6H   $��Center=�6c   $��22(�6�   5      � 5   
   $��1��6    5      �� 5      �� 5      .+�5       �  5!      �� 5"      $
��0.6* �6'   �� 5#      .+�5&      �� $"��Номер телефона:��6   $��Right=�63   $��20(�6O   $��0, 0, 10, 10q�6]   $��Bottom=�6s   �� 5(      -   5         ��Name$ PhoneTB��5(   6   $��35��6   $	��300��6*   $��Bottom=�6G   $��1��6b   $
��Left=�6r   $��10, 0, 0, 5q�6�   5*      � 5+      $��1��6    5,      �� 5-      $
��0.6* �6'   �� 5.      .+�51      �� $��Пароль:��6   $��Right=�6+   $��20(�6G   $��0, 0, 10, 0q�6U   $��Center=�6j   �� 52      -   5        $ 
PasswordTB��52      $��35��6.   $	��300��6:   $��1��6F   $
��Left=�6V   $��10, 0, 0, 0q�6q   53      54      � 55   
   $��2��6   #��[  6   .+�56      �� -   5        $��35��56      $	��200��6!   $��
Войти��6-   $��18(�6=   6K   58      59      5:      