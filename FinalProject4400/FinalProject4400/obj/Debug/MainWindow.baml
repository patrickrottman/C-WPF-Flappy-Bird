   M S B A M L   `   `   `  ����K  GFinalProject4400, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:FinalProject4400FinalProject4400  5   	   !    FinalProject4400.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:FinalProject4400     5   	   -   5          � Title$  Flappy Bird��5   	   $	��600��6   $	��800��6*    � 
ResizeMode$ NoResize=�6M   .��5	      � -   5        $��mainGrid��5	       � RowDefinitions 5
   
   �� 5      $��21 �6   �� 5      $
��547* �6   .+�5   
   �� -   5        $��	rectangle��5      ���	#FFF4F4F5$
��Left=�66   $	��690��6Q   $��-102,-53,-92,-65.333q�6^   $��2��6|   
���   �$	��Top=�6�   $	��988��6�   �� 5   
   -   5        $��gameArea��5      
�������$��0,0,0,-0.333q�63   $��2��6I   .+�5      �� -   5         ��Name$ 
flappyText��5      $	��413��6,   
�����_� �� Left$ 51��6P   $
��Wrap=�6a   $��200px(�6u   $	��827��6�   �� 6�   $�F��6�   �� 6�   $�LAPPY��6�   6�   �� 5      -   5        $��birdText��5      $	��413��6(   
����d�$	 181��6R   $
��Wrap=�6d   $��200px(�6x   $	��827��6�   
 �� Top$	 288��6�   �� 6�   $
�BIRD��6�   6�   5      �� 5   
   -   5        $��start��5      $
��30px(�6   $��Start!��6.   $��260,221,264,257.667q�6?   $��1��6\   6i   �� 5   
   -   5        $��close��5   %   $y�Hidden=�6   $
��30px(�62   $��Close��6B   $��260,221,264,257.667q�6R   $��1��6o   6|   �� 5   
   $
��25px(�6   $��Score: ��6    $
��Left=�62   $	��Top=�6M   $	��101��6e   $	��120��6r   $��2��6~   �� 5   
   -	   5         ��Name$ score��5       $
��25px(�6   $��0��6/   $
��Left=�6;   $	��Top=�6V   $	��101��6n   $��81��6{   $��75,0,0,0q�6�   $��2��6�   5      5      