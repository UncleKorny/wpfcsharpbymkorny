   M S B A M L   `   `   `  ����E  Akursachwpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:kursachwpf
kursachwpf  5   	       kursachwpf.editChampions   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:kursachwpf     5   	   -   5          � Title$+  %Изменение чемпионов��5   	   $	��450��6%   $
��1000��62    � WindowStartupLocation$ CenterScreen=�6?    � Icon$ /lolico.ico��6{    � 
ResizeMode$ NoResize=�6�   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��0.85* �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $
��1.3* �6   6,   �� 5      $
��0.3* �6   6,   �� 5      $
��0.3* �6   6,   .+�5   
   �� $��3��6   $��2��6!   $	��-40q�65   $G��AC:\Users\themk\source\repos\kursachwpf\kursachwpf\images\sett.png��6B    J� OpacityMask 5      �� 5       �� Color$ Black��6"    �� Opacity$	 0.9Q�60   5      �� 5   
   -   5        	 ��Name$	 imgMain��5      $��0��6!   $��0��6.   $��10,10,10,10q�6>   $	��275��6S   $	��435��6`   $
��Left=�6l   $	��Top=�6�   6�   �� 5   
   -   5        
 ��Name$
 tbName��5      $��1��6"   $��0��6/   $��Center=�6?   $��Right=�6Z   $	��300��6v   $��2,2,20,2q�6�   $��45��6�   $��comic sans ms)�6�   $��30(�6�   6�   �� 5   
   -   5         ��Name$ cbClass��5      $��2��6$   $��0��61   $��Right=�6A   $��Center=�6]   $	��300��6x   $��2,2,20,2q�6�   $��45��6�   $��comic sans ms)�6�   $��30(�6�   6�   �� 5   
   
�������$��1��6'   $��0��64   $
��Left=�6D   $��Center=�6_   $��Имя��6z   $��70,2,2,2q�6�    �� Padding$ 0q�6�   $��Comic sans ms)�6�   $��30(�6�   6�   �� 5   
   
�������$��2��6'   $��0��64   $
��Left=�6D   $��Center=�6_   $��
Класс��6z   $ 0q�6�   $��comic sans ms)�6�   $��30(�6�   $��45,2,2,2q�6�   6�   �� 5   
   
�������$��0��6'   $��1��64   $
��Left=�6D   $	��Top=�6_   $��История��6w   $ 0q�6�   $��comic sans ms)�6�   $��30(�6�   $��	30,10,0,0q�6�   6�   �� 5   
   -   5         ��Name$ 
rtbHistory��5      $��1��6*   $��2��6:   $��30,60,30,10q�6K   $��comic sans ms)�6`   $��16(�6{   
���   �$��2q�6�   6�   �� 5   
   -   5         ��Name$ btnEdit��5      $��2��6"   $��1��6/   $��Center=�6?   $��Right=�6Z   $	��300��6v   $��45��6�   $��comic sans ms)�6�   $��30(�6�   $��Изменить��6�   $��0,0,30,0q�6�   6�   5       5!      