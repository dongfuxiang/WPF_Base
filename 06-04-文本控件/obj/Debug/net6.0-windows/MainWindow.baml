   M S B A M L   `   `   `  ����M  I06-04-文本控件, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:_06_04_文本控件_06_04_文本控件  5      $    _06_04_文本控件.MainWindow   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:_06_04_文本控件     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        � Title$  
MainWindow��5      $	��800��5	      $	��450��5
      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      $	��100 �6   �� 5      $	��100 �6   .+�5   
   �� -   5         ��Name$ tbInfo��5       �� AcceptsReturn$
 True��5      
����ح� �� 	MaxLength$
 1500��5       �� MaxLines$ 6��5      $	��123��5!       �� TextWrapping$
 Wrap=�5"      " �� VerticalScrollBarVisibility$
 Auto=�5#      �� 5$   
   $��1��6    �� Orientation$ Vertical=�6"   .+�5&      �� $��Show Text：��6   �� 5'      -   5        	 ��Name$	 txbShow��5'      5(      ]� 5)   
   $��2��6   .+�5*      �� $��Center=�6   $
��Left=�63   $��PassWord：��6I   �� 5+      -   5        $��10q�5,      $��Center=�5-      $��Show PassWord��5/      $��Right=�50      G� 51      -   5        
 G�Name$
 
pdPassWord��51      $��10q�6.   $��Center=�6:   53      54      55      