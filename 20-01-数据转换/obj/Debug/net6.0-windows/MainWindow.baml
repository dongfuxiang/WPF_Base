   M S B A M L   `   `   `  ����M  I20-01-数据转换, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:_20_01_数据转换.Converter_20_01_数据转换.Converter  5   	   9!clr-namespace:_20_01_数据转换_20_01_数据转换  5   	   $    _20_01_数据转换.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   ;cvt+clr-namespace:_20_01_数据转换.Converter     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   3local!clr-namespace:_20_01_数据转换     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � Title$  
MainWindow��5   	   $	��800��5	   	   $	��450��5
   	    � 	Resources 5      0  *_20_01_数据转换.Converter.TopConverter   TopConverter2  ,_20_01_数据转换.Converter.ImageConverter  ImageConverter:  4_20_01_数据转换.Converter.TextBoxBorderConverter  TextBoxBorderConverter��%W   &	        &	      &	 &       5   
   6     5   
   6     5   
   6%   5      .��5      � .+�5   
   ]� $��20q�6   $	��Top=�6    .+�5      �� $��UnitCost：��6   $
��Left=�6(   �� 5      $��Right=�5      ��5      �� *
UnitCost+ �� 	Converter# [ ��5      �� *
UnitCost+ �� StringFormat$ {0:C}���� 5      $��Bottom=�6   .+�5      �� -   5        $��rect1��5      
 �� Top$	 100��5      $	��100��5      $��50��5      
���  ��5      �� 5      $	��100��5      $��50��5       
����  � 5      ��  �� ElementName$ rect1�� �� Path$ (Canvas.Top)�# [  5!      �� 5"      $	 100��6    �� Right$	 200��5#      $	��100��5$      $	��100��5%      ��5&      �� # [ 5'      5(      5)      5*      