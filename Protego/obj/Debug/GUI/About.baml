   M S B A M L   `   `   `  ����B  >Protego, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Protego.GUIProtego.GUI  5   	       Protego.GUI.About   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Protego.GUI     5   	     � Title$  О программе��5   	   $	��530��6   $	��477��6*    � 
ResizeMode$ NoResize=�66    � Icon$* $/Protego;component/Resources/usb.ico��6L    � WindowStartupLocation$ CenterScreen=�6x   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��140 �6   �� 5       � RowDefinitions 5   
   �� 5      $	��140 �6   �� 5      .+�5   
   �� -   5         ��Name$ appIcon��5      $
��Left=�6!   $��20,0,0,0q�6<   $*��$/Protego;component/Resources/usb.png��6N   $	��104��6|   �� 5   
   -   5         ��Name$ appName��5      $��Protego - USB Security��6!   $��Center=�6B   $��0,10,0,0q�6_   $	��Top=�6q   $��Center=�6�   $��Center=�6�   $��24(�6�   $��1��6�   �� 5   
   -   5        $ 
appVersion��5      $��Версия 0.1��6$   $��1��69   $��Center=�6I   $��0,55,0,0q�6f   $	��Top=�6x   �� 5   
   -   5        $ appCopyrights��5      $)��#Copyright © Manchenkov Artyom 2015��6'   $��1��6T   $��Center=�6d   $��0,80,0,0q�6�   $	��Top=�6�   �� 5   
   -   5        $ 
appCompany��5      $��DeepSide Interactive��6$   $��1��6C   $��Center=�6S   $��	0,105,0,0q�6p   $	��Top=�6�   �� 5   
   -   5         ��Name$ appDescription��5      $��2��6*   $��10q�6>   $��1��6J   	 �� 
IsReadOnly	 . 
 �� TextWrapping$

 Wrap=�6i   $��5q�6}   " �� VerticalScrollBarVisibility$ Visible=�6�    �� TextAlignment$ Justify=�6�   5      5      