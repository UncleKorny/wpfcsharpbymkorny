   M S B A M L   `   `   `  ����E  Akursachwpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:kursachwpf
kursachwpf  5   	       kursachwpf.Window5   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:kursachwpf     5   	     � Title$  Регистрация��5   	   $	��385��6   $	��343��6*    � 
ResizeMode$ NoResize=�66    � WindowStartupLocation$ CenterScreen=�6L    � Icon$ /lolico.ico��6q   .��5	      �  � RowDefinitions 5
   
   �� 5      6   �� 5      $��40 �6   6*   �� 5      $��40 �6   6*   �� 5      $��80 �6   6*   �� 5      6   .+�5   
   �� $��5��6   $	��-10q�6!   $G��AC:\Users\themk\source\repos\kursachwpf\kursachwpf\images\yone.png��6.    J� OpacityMask 5      �� 5       �� Color$ Black��6"    �� Opacity$	 0.9Q�60   5      �� 5   
   -   5         ��Name$ lbname��5   #   
�������$��Comic Sans MS)�63   $��Регистрация��6N   $��Center=�6d   $��Center=�6�   $��40(�6�   �� 5   
   -   5        $ lblogin��5   #   
�������$��Comic Sans MS)�64   $��
Логин��6O   $
��Left=�6_   $��85,4,0,0q�6z   $��1��6�   $	��Top=�6�   $��0q�6�   $��22(�6�   �� 5   
   -   5        $ lbpass��5   #   
�������$��Comic Sans MS)�63   $��Пароль��6N   $
��Left=�6_   $��70,1,0,0q�6z   $��3��6�   $	��Top=�6�   $��0q�6�   $��22(�6�   �� 5   
   -   5        $ lbemail��5   #   
�������$��Comic sans ms)�64   $��
Почта��6O   $
��Left=�6_   $��85,1,0,0q�6z   $��2��6�   $	��Top=�6�   $��0q�6�   $��22(�6�   6�   �� 5   
   -   5        $ lbwlogin��5      $)��#Есть аккаунт? Войти��6"   $��Center=�6@   $��0,42,0,0q�6]   $��4��6o   $	��Top=�6|   ���	#FF0800FF$��Comic Sans MS)�6�   $��12(�6�   $��0q�6  �� 5   
   -   5        	 ��Name$	 tblogin��5      $��comic sans ms)�6#   $��15(�6>   $
��Left=�6L   $��	160,9,0,0q�6g   $��1��6z   
 �� TextWrapping$

 Wrap=�6�   $	��Top=�6�   $	��120��6�   $��25��6�   �� 5   
   -   5        $	 tbemail��5      $��comic sans ms)�6#   $��15(�6>   $
��Left=�6L   $��	160,5,0,0q�6g   $��2��6z   $

 Wrap=�6�   $	��Top=�6�   $	��120��6�   $��25��6�   �� 5   
   -   5        $	 tbpass��5      $��comic sans ms)�6"   $��15(�6=   $
��Left=�6K   $��3��6f   $

 Wrap=�6s   $	��Top=�6�   $	��120��6�   $��25��6�   $��	160,5,0,0q�6�   �� 5   
   -	   5        $	 tbpass2��5      $��comic sans ms)�6#   $��15(�6>   $
��Left=�6L   $��3��6g   $

 Wrap=�6t   $	��Top=�6�   $	��120��6�   $��25��6�   $��
160,37,0,0q�6�   �� 5    
   -
   5         ��Name$ btnreg��5       $��Comic Sans MS)�6!   $*��$Зарегистрироваться��6<   $
��Left=�6Y   $��	79,10,0,0q�6t   $��4��6�   $	��Top=�6�   $	��206��6�   $��30��6�   $��20(�6�   6�   �� 5!   
   -   5        $ lbpass_Copy��5!   #   
�������$��Comic Sans MS)�68   $%��Повторите пароль��6S   $
��Left=�6n   $��5,33,0,0q�6�   $��3��6�   $	��Top=�6�   $��16(�6�   $��2��6�   5#      5$      