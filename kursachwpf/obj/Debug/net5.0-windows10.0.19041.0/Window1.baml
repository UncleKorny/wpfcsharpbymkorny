   M S B A M L   `   `   `  ����E  Akursachwpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:kursachwpf
kursachwpf  5   	       kursachwpf.Window1   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:kursachwpf     5   	   D @ModernWpf, Version=0.9.4.0, Culture=neutral, PublicKeyToken=nullM IModernWpf.Controls, Version=0.9.4.0, Culture=neutral, PublicKeyToken=null,ui!http://schemas.modernwpf.com/2019   5   	   -   5        0  *ModernWpf.Controls.Primitives.WindowHelper    UseModernWindowStyle$
  True��5	   	    � Title$ Склад историй��5
   	   $	��450��6   $	��800��6,    � WindowStartupLocation$ CenterScreen=�6f    � 
ResizeMode$ NoResize=�6�   .��5      �  � RowDefinitions 5   
   �� 5      $
��407* �6   �� 5      $	��27* �6   .+�5   
   �� -   5         ��Name$ image1��5      $��Right=�6    $	��Top=�6<   $��2��6T   $
��Fill=�6e    J� OpacityMask 5      �� 5       �� Color$ Black��6"    �� Opacity$
 0.85Q�60   5      �� 5   
   -   5        	 ��Name$		 lb1��5      $��10,38,632,4q�6J   6_   �� 5   
   -   5        
 ��Name$
 textBox1��5      $
��Left=�6$   $��	10,10,0,0q�6?    �� TextWrapping$
 Wrap=�6R   $	��Top=�6f   $��90��6~   $��23��6�    �� SelectionOpacity$ 1Q�6�    �� TextAlignment$
 Left=�6�   �� 5   
   -   5         ��Name$ btnadd��5      $��+��6!   $
��Left=�6-   $��10,1,0,0q�6H   $	��Top=�6Z   $��25��6r   $��1��6}   $y�Hidden=�6�   �� 5   
   -   5        $ 	btndelete��5      $��-��6$   $
��Left=�60   $��40,1,0,0q�6K   $	��Top=�6]   $��25��6u   $��1��6�   $y�Hidden=�6�   �� 5   
   -   5        $ btnedit��5      $
��edit��6"   $
��Left=�61   $��70,1,0,0q�6L   $	��Top=�6^   $��30��6v   $��1��6�   $y�Hidden=�6�   �� 5   
   $��
173,38,0,0q�6   .��5      �� .+�5      �� -   5         ��Name$ 
textBlock1��5      $
��Wrap=�60   
�������$��	UltraBold"�6W   $��16(�6n   ��5      �� 5      $ Black��6*   $	 0.3Q�68   5       5!      5"      �� 5#   
   -	   5        $ btnauth��5#      $��
Войти��6"   $
��Left=�62   $��10,0,0,0q�6M   $��1��6_   $��Center=�6l   $	��158��6�   $y�Hidden=�6�   �� 5$   
   -
   5         ��Name$ lblname��5$      $��Nickname��6!   $��14(�64   
�������$��Comic Sans MS)�6U   $y�Hidden=�6p   $��2��6�   $
��Left=�6�   $	��Top=�6�   $��	7,380,0,0q�6�   �� 5%   
   -   5         ��Name$	 cb1��5%      $
��Left=�6    $��
105,11,0,0q�6;   $	��Top=�6O   $��92��6g   6r   5&      5'      