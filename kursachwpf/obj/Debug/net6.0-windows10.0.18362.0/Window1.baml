   M S B A M L   `   `   `  ����E  Akursachwpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:kursachwpf
kursachwpf  5   	       kursachwpf.Window1   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:kursachwpf     5   	   0ui!http://schemas.modernwpf.com/2019     5   	   -   5          � Title$  Склад историй��5	   	   $	��450��6   $	��800��6,    � WindowStartupLocation$ CenterScreen=�6f    � 
ResizeMode$ NoResize=�6�    � Icon$ /lolico.ico��6�   .��5
      �  � RowDefinitions 5   
   �� 5      $	��35* �6   �� 5      $
��405* �6   �� 5      $	��30* �6    � ColumnDefinitions 5   
   �� 5      $��200px �6   6/   �� 5      $��* �6   6+   .+�5   
   �� -   5         ��Name$ image1��5      $
��Left=�6    $	��Top=�6;   $
��Fill=�6S   $	��800��6b   $	��434��6n   $��2��6{   $��3��6�    J� OpacityMask 5      �� 5       �� Color$ Black��6"   	 �� Opacity$
	 0.85Q�60   5      �� 5   
   -   5        
 ��Name$	
 lb1��5      $��1��6   $��0��6,   $��5,3,3,3q�6g   6x   �� 5   
   -   5         ��Name$ textBox1��5      $��comic sans ms)�6$   $��15(�6?   $��0��6M   $��0��6Z   $
��Left=�6j   $��5,5,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��100��6�   $��25��6�    �� SelectionOpacity$ 1Q�6�    �� TextAlignment$
 Left=�6  �� 5   
   -   5         ��Name$ btnadd��5      $��2��6!   $��0��6.   $��+��6>   $y�Hidden=�6_   $��25��6s   $��24(�6   $��Unispace)�6�   $��Normal&�6�   $��0q�6�   $��center=�6�   $��center=�6�   $��LeftToRight=�6
  $��Disabled=�6&  $��1,1,1,1q�6Z  $��25��6t  $
��Left=�6  $	��Top=�6�   J� RenderTransformOrigin$ 0.5,0.5&�6�  $��5,0,0,0q�6�  $��2��6�  �� 5   
   -   5        $ 	btndelete��5      $��2��6$   $��0��61   $��-��6A   $��35,0,0,0q�6M   $y�Hidden=�6w   $��20(�6�   $��Unispace)�6�   $��25��6�   $��25��6�   $
��Left=�6�   $	��Top=�6�   �� 5   
   -   5        $ btnedit��5      $��2��6"   $��0��6/   $
��edit��6?   $��65,0,0,0q�6N   $��35��6`   $��25��6k   $y�Hidden=�6w   $��Unispace)�6�   $��2��6�   $��1,1,1,1q�6�   $	��Top=�6�   $
��Left=�6�   6�   �� 5   
   -   5         ��Name$	 cb1��5      $��comic sans ms)�6    $��0��6;   $��0��6H   $��	110,5,0,0q�6X   $��87��6�   $��25��6�   $	��Top=�6�   $
��Left=�6�   �� 5   
   $��5,5,5,5q�6   $��1��6(   $��1��68   .��5       �� .+�5!      �� -	   5         ��Name$ 
textBlock1��5!      $
��Wrap=�60   
�������$��	UltraBold"�6W   $��16(�6n   ��5"      �� 5#      $ Black��6*   $		 0.3Q�68   5%      5&      5'      �� 5(   
   -
   5        $ btnauth��5(      $��2��6"   $��0��6/   $��
Войти��6?   $��5,0,0,0q�6O   $	��192��6`   $y�Visible=�6�   $��25��6�   $��11(�6�   $
��Bold"�6�   $
��Left=�6�   $	��Top=�6�   �� 5)   
   -   5         ��Name$ lblname��5)      $��2��6!   $��0��6.   $��Nickname��6>   $��14(�6Q   
�������$��Comic Sans MS)�6r   $y�Hidden=�6�   $
��Left=�6�   $��Center=�6�   $��5,0,0,0q�6�   $��20��6�   $��0q�6�   $��63��6   5*      5+      