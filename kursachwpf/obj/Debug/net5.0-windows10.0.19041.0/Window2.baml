   M S B A M L   `   `   `  ����E  Akursachwpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:kursachwpf
kursachwpf  5   	       kursachwpf.Window2   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:kursachwpf     5   	   -   5          � Title$+  %Добавление чемпиона��5   	   $	��237��6%   $	��351��62    � WindowStartupLocation$ CenterScreen=�6>    � 
ResizeMode$ NoResize=�6c   .��5	      �  � ColumnDefinitions 5
   
   �� 5      6!   �� 5      6!    � RowDefinitions 5   
   �� 5      $��50 �6   6*   �� 5      $��40 �6   6*   �� 5      $��50 �6   6*   �� 5      $��30 �6   6*   �� 5      $��50 �6   6*   .+�5   
   �� -   5        $��Добавить��5      $	��Top=�6;   $��24��6S   $��4��6_   $��	26,1,62,0q�6l   �� 5   
   -   5         ��Name$ btnaddimage��5      $-��'Добавить изображение��6&   $
��Left=�6E   $��26��6`   $	��138��6l   $��3��6�   $��0��6�   $��28,0,0,4q�6�   �� 5   
   -   5         ��Name$ labl1��5      $�� ��6   
�������$��10(�6=   $��3��6K   $��1��6X   $
��Left=�6h   $��Center=�6�   $��2,0,0,0q�6�   �� 5   
   $,��&Введите имя чемпиона��6   $��Center=�61   $��Center=�6N   $	��131��6i   $��21,0,0,0q�6u   �� 5   
   $*��$Введите его историю��6   $	��126��6/   $��center=�6;   $��Center=�6X   $��1��6s   $��30,0,0,0q�6�   �� 5   
   -   5         ��Name$ tbname��5      $��19��6F   $��center=�6R   $��1��6m   $��0,0,50,0q�6}   �� 5   
   -   5         ��Name$
 rtb1��5      $��1��6$   $��1��64   $��0,0,10,0q�6A   . �5      /� .T�5      J� .*�6   .*�5      �� $� ��6   5      5       5!      �� 5"   
   -   5        $ lbclass��5"      $!��Выберите класс��6!   $
��Left=�6:   $��61,0,0,0q�6U   $��2��6g   $��Center=�6t   �� 5#   
   -   5        $ tbclass��5#      $��1��6#   $
��Left=�63   $��2��6N   	 �� TextWrapping$
	 Wrap=�6[   $��Center=�6o   $	��120��6�   $y�Hidden=�6�   �� 5$   
   -	   5        
 ��Name$	
 cb1��5$      $��1��6    $
��Left=�60   $��2,16,0,0q�6K   $��2��6]   $	��Top=�6j   $	��120��6�   5%      5&      