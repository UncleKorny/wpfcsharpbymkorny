   M S B A M L   `   `   `  ����E  Akursachwpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:kursachwpf
kursachwpf  5   	       kursachwpf.Window5   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:kursachwpf     5   	     � Title$  Регистрация��5   	   $	��335��6   $	��373��6*    � 
ResizeMode$ NoResize=�66    � WindowStartupLocation$ CenterScreen=�6L   .��5	      �  � RowDefinitions 5
   
   �� 5      6   �� 5      $��40 �6   6*   �� 5      $��60 �6   6*   �� 5      6   .+�5   
   �� -   5         ��Name$ lbname��5      $��Регистрация��6    $��Center=�66   $��Center=�6S   $��20(�6n   �� 5   
   -   5        $ lblogin��5      $��
Логин��6!   $
��Left=�61   $��10,6,0,0q�6L   $��1��6^   $	��Top=�6k   $��16(�6�   �� 5   
   -   5         ��Name$ tblogin��5      $
��Left=�6#   $��
161,15,0,0q�6>   $��1��6R    �� TextWrapping$
 Wrap=�6_   $	��Top=�6s   $	��120��6�   �� 5   
   -   5        $ tbpass��5      $
��Left=�6"   $��2��6=   $
 Wrap=�6J   $	��Top=�6^   $	��120��6v   $��
161,10,0,0q�6�   �� 5   
   -   5        $ lbpass��5      $��Пароль��6    $
��Left=�61   $��10,1,0,0q�6L   $��2��6^   $	��Top=�6k   $��16(�6�   �� 5   
   -   5         ��Name$ btnreg��5      $*��$Зарегистрироваться��6!   $
��Left=�6>   $��	79,10,0,0q�6Y   $��3��6l   $	��Top=�6y   $	��206��6�   $��30��6�   $��20(�6�   6�   �� 5   
   -   5        $ lbwlogin��5      $)��#Есть аккаунт? Войти��6"   $��Center=�6@   $��0,40,0,0q�6]   $��3��6o   $	��Top=�6|   ���	#FF0800FF$��Comic Sans MS)�6�   6�   �� 5   
   -   5        $ tbpass2��5      $
��Left=�6#   $��2��6>   $
 Wrap=�6K   $	��Top=�6_   $	��120��6w   $��
161,37,0,0q�6�   �� 5   
   -	   5        $ lbpass_Copy��5      $%��Повторите пароль��6%   $
��Left=�6@   $��	10,28,0,0q�6[   $��2��6n   $	��Top=�6{   $��16(�6�   $��2��6�   5      5      