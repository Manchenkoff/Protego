   M S B A M L   `   `   `  ����B  >Protego, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Protego.GUIProtego.GUI  5   	   !    Protego.GUI.ExtensionDialog   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Protego.GUI     5   	     � Title$+  %Редактор расширений��5   	   $��414.4��6%   $	��368��64    � Icon$* $/Protego;component/Resources/add.png��6@    � 
ResizeMode$ NoResize=�6l    � WindowStartupLocation$ CenterScreen=�6�   .��5	      �  � RowDefinitions 5
   
   �� 5      $��70 �6   �� 5      �� 5      $��50 �6   .+�5   
   �� -   5         ��Name$ extensionLabel��5      $��Расширение��6(   $
��Left=�6=   $��20,0,0,0q�6X   $��Center=�6j   $��Right=�6�   $	��100��6�   $��Center=�6�   �� 5   
   -   5         ��Name$ extensionTextbox��5      $��
130,0,15,0q�6-    �� TextWrapping$
 Wrap=�6A   $��Center=�6U   $��5q�6p   �� 5   
   -   5         ��Name$ descriptionGroup��5      $��Описание��6-   $��3q�6?   $��1��6J   .��5      �� -   5        $ descriptionTextbox��5      $��3q�62   $
 Wrap=�6=   5      �� 5   
   -   5        	 ��Name$	 buttonCancel��5      $��Отмена��6'   $��Right=�68   $��0,0,15,0q�6T   $��2��6f   $��Center=�6s   $	��100��6�   $��5q�6�   
 �� IsCancel
 . 6�   �� 5   
   -   5        $	 buttonOK��5      $��Применить��6#   $��Right=�67   $��	0,0,125,0q�6S   $��2��6f   $��Center=�6s   $	��100��6�   $��5q�6�    �� 	IsDefault . 6�   5      5      