   M S B A M L   `   `   `  ����V  R19-01-绑定到数据对象, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:_19_01_绑定到数据对象_19_01_绑定到数据对象  5   	   -    '_19_01_绑定到数据对象.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   <local*clr-namespace:_19_01_绑定到数据对象     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � Title$  
MainWindow��5   	   $	��300��5   	   $	��400��5	   	    � 	Resources 5       �� 
TargetType �� Property �� Value��%J  '��       '�� �     �� 5   
   " ��6   .�5      ��  � ��$ 15(�6)   �� 5       � ��$ 
10,20,5,10q�6'   �� 5       � ��$ Right=�64   5      �� 5   
   " ��6   .�5      ��  � ��$ 15(�6)   �� 5       � ��$ 	5,10,5,10q�6'   �� 5       � ��$ Center=�69   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5       � ColumnDefinitions 5   
   �� 5       $
��auto �6   �� 5!      .+�5$   
   �� $��0��6   $��0��5%      $��User Name：��5&      �� 5'   
   $��1��6   $��0��5(      $��User Password：��5)      �� 5+   
   $��0��6   $��1��5,      ��5-      ��  �� Path$ UserName��� 5.   
   $��1��6   $��1��5/      ��50      �� $ Password��� 51   
   -   5        $��2��51      $��2��52      $��80��53      $	�� 30��54      $��Login��55      56      57      58      