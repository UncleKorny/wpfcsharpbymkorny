   M S B A M L   `   `   `  ����E  Akursachwpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:kursachwpf
kursachwpf  5   	       kursachwpf.Window4   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:kursachwpf     5   	     � Title$  Авторизация��5   	   $	��335��6   $	��373��6*    � 
ResizeMode$ NoResize=�66    � WindowStartupLocation$ CenterScreen=�6L    � Icon$ /lolico.ico��6q   .��5	      �  � RowDefinitions 5
   
   �� 5      6   �� 5      $��50 �6   6*   �� 5      $��50 �6   6*   �� 5      6   .+�5   
   �� $��4��6   $��-15,-15,-15,-15q�6!   $H��BC:\Users\themk\source\repos\kursachwpf\kursachwpf\images\senna.png��6:    J� OpacityMask 5      �� 5       �� Color$ Black��6"    �� Opacity$	 0.9Q�60   5      �� 5   
   -   5         ��Name$ lbname��5   #   
�������$��0��63   $��Авторизация��6@   $��Center=�6V   $��Center=�6s   $��Comic Sans MS)�6�   $��40(�6�   �� 5   
   -   5        $ lblogin��5   #   
�������$��1��64   $��
Логин��6A   $��85,7,0,0q�6Q   $��0q�6c   $��22(�6o   $��Comic Sans MS)�6}   $	��Top=�6�   $
��Left=�6�   �� 5   
   -   5        $ lbpass��5   #   
�������$��Пароль��63   $
��Left=�6D   $��70,6,0,0q�6_   $��2��6q   $��Comic Sans MS)�6~   $��22(�6�   $��0q�6�   $	��Top=�6�   �� 5   
   -   5        	 ��Name$	 tblogin��5      $��comic sans ms)�6#   $��15(�6>   $��1��6L   $
��Left=�6Y   $��	160,0,0,0q�6t   
 �� TextWrapping$

 Wrap=�6�   $	��120��6�   $��25��6�   G� 5   
   -   5         G�Name$ tbpass��5       G� PasswordChar$ *��6&   $��comic sans ms)�67   $��15(�6R   $��2��6`   $	��120��6m   $��25��6y   $��
160,10,0,0q�6�   $
��Left=�6�   $	��Top=�6�   �� 5   
   -   5         ��Name$ btnlogin��5      $��Comic Sans MS)�6#   $��
Войти��6>   $
��Left=�6N   $��
132,10,0,0q�6i   $��3��6}   $	��Top=�6�   $	��100��6�   $��30��6�   $��20(�6�   6�   �� 5   
   -   5        $ 
lbregister��5      $?��9Нет аккаунта? Зарегистрировать��6$   $��Center=�6M   $��0,40,0,0q�6j   $��3��6|   $	��Top=�6�   ���	#FF0800FF$��Comic Sans MS)�6�   6�   �� 5   
   -   5        $ 
lbwrecover��5      $ ��Забыли пароль?��6$   $��Center=�6=   $��0,60,0,0q�6Z   $��4��6l   $	��Top=�6y   ���	#FF0800FF$��Comic Sans MS)�6�   $��12(�6�   $��0q�6  5      5      