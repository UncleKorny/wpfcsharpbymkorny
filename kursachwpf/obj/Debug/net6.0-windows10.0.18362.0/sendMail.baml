   M S B A M L   `   `   `  ����E  Akursachwpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:kursachwpf
kursachwpf  5   	       kursachwpf.sendMail   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:kursachwpf     5   	   -   5          � Title$  sendMail��5   	   $	��450��6   $	��800��6'    � 
ResizeMode$ NoResize=�6J    � WindowStartupLocation$ CenterScreen=�6`   .��5	      �  � RowDefinitions 5
   
   �� 5      $��1* �6   6*   �� 5      $
��0.5* �6   6,   �� 5      $��1* �6   6*   �� 5      $
��0.3* �6   6,   .+�5   
   �� $��4��6   $	��-10q�6!   $F��@C:\Users\themk\source\repos\kursachwpf\kursachwpf\images\zed.png��6.    J� OpacityMask 5      �� 5       �� Color$ Black��6"    �� Opacity$	 0.9Q�60   5      �� 5   
   
�������$ ��Свяжись с нами��6'    �� Padding$ 0q�6=   $��comic sans ms)�6I   $��50(�6d   $��Center=�6r   $��Center=�6�   6�   �� 5   
   
�������$ ��Введи своё имя��6'   $��1��6=   $��comic sans ms)�6J   $��50,0,0,0q�6e   $��24(�6w   $��Center=�6�   $
��Left=�6�   6�   �� 5   
   -   5         ��Name$ tbName��5      $��comic sans ms)�6"   $��25(�6=   $��1��6K   $	��200��6X   $��40��6d   $��	250,0,0,0q�6p   $��Center=�6�   $
��Left=�6�   6�   �� 5   
   
�������$,��&Введи своё сообщение��6'   $��2��6C   $��comic sans ms)�6P   $��20(�6k   $��12,0,0,0q�6y   $	��Top=�6�   $
��Left=�6�   6�   �� 5   
   -   5        	 ��Name$	 rtbSendMail��5      $��comic sans ms)�6+   $��16(�6F   $��2��6T   $	��450��6a   $	��140��6m   $��	151,0,0,0q�6z   $��Center=�6�   $��Center=�6�   6�   �� 5   
   -   5        
 ��Name$
 btnSend��5      $��3��6"   $	��200��6/   $��40��6;   $��Отправить��6G   $��comic sans ms)�6[   $��26(�6v   $��30,3,0,0q�6�   $	��Top=�6�   $
��Left=�6�   6�   5      5      