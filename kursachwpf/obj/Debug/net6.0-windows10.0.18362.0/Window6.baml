   M S B A M L   `   `   `  ����E  Akursachwpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:kursachwpf
kursachwpf  5   	       kursachwpf.Window6   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:kursachwpf     5   	   -   5          � Title$/  )Восстановление пароля��5   	   $	��403��6'   $	��360��64    � WindowStartupLocation$ CenterScreen=�6W    � Icon$ /lolico.ico��6|    � 
ResizeMode$ NoResize=�6�   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��100 �6   6+   �� 5      $
��0.5* �6   6,   �� 5      $
��0.5* �6   6,   .+�5   
   �� $��3��6   $	��-10q�6!   $H��BC:\Users\themk\source\repos\kursachwpf\kursachwpf\images\vayne.png��6.    J� OpacityMask 5      �� 5       �� Color$ Black��6"    �� Opacity$	 0.9Q�60   5      �� 5   
   $/��)Восстановление пароля��6   $��30(�61   $��comic sans ms)�6?   $��5,40,0,0q�6Z    �� Padding$ 0q�6l   $	��Top=�6x   $
��Left=�6�   $��0��6�   6�   �� 5   
   -   5        	 ��Name$	 lblemail��5      $(��"Введите вашу почту��6&   $��22(�6@   $��comic sans ms)�6N   $��	73,64,0,0q�6i   $ 0q�6|   $	��Top=�6�   $
��Left=�6�   $��1��6�   6�   �� 5   
   -   5        $	 
lblnewpass��5      $,��&Введите новый пароль��6(   $y�Hidden=�6D   $��22(�6X   $��comic sans ms)�6f   $��	73,64,0,0q�6�   $ 0q�6�   $	��Top=�6�   $
��Left=�6�   $��1��6�   6�   �� 5   
   -   5        
 ��Name$
 tbemail��5      $��comic sans ms)�6#   $��15(�6>   $��1��6L   $��0q�6Y   $	��Top=�6e   $��100,100,0,0q�6}   $
��Left=�6�   $	��160��6�   $��25��6�   6�   �� 5   
   -   5        $
 	tbnewpass��5      $��comic sans ms)�6%   $��15(�6@   $y�Hidden=�6N   $��1��6b   $��0q�6o   $	��Top=�6{   $��100,100,0,0q�6�   $
��Left=�6�   $	��160��6�   $��25��6�   6�   �� 5   
   -   5         ��Name$ btnsend��5      $+��%Восстановить пароль��6"   $��comic sans ms)�6@   $��16(�6[   $��Center=�6i   $��0,10,0,0q�6�   $��2��6�   $	��Top=�6�   $��33��6�   $	��200��6�   6�   �� 5   
   -   5        $ btnsetnewpass��5      $y�Hidden=�6(   $+��%Восстановить пароль��6<   $��comic sans ms)�6Z   $��16(�6u   $��Center=�6�   $��0,10,0,0q�6�   $��2��6�   $	��Top=�6�   $��33��6�   $	��200��6�   6�   5      5      