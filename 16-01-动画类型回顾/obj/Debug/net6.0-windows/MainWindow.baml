   M S B A M L   `   `   `  ����S  O16-01-动画类型回顾, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:_16_01_动画类型回顾_16_01_动画类型回顾  5      *    $_16_01_动画类型回顾.MainWindow   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:_16_01_动画类型回顾     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        � Title$  
MainWindow��5      $	��800��5	      $	��450��5
       � 	Resources 5      ��%     � Triggers 5      :� 5   
    :� RoutedEvent$ Button.MouseEnter��6    :� 
SourceName$	 btn��67   .[�5      �� .��5      �� .��5      W� 	 W� By 905       �� 
TargetName$	 btn��5       �� TargetProperty$ RenderTransform.Angle�5       g� Duration$ 0:0:0.5D�5      5      5      5      :� 5   
   $ Button.MouseLeave��6   $	 btn��67   .[�5      �� .��5       �� .��5!      W� $	 btn��5"      $ RenderTransform.Angle�5#      $ 0:0:0.5D�5$      5%      5&      5'      .��5)      � 	 � RowDefinitions	 5*   
   �� 5+      �� 5,      
 � ColumnDefinitions
 5.   
   �� 5/      �� 50      .+�52   
   �� -   5         ��Name$	 btn��53      $��0��54      $��0��55      $	��100��56      $��30��57      $��Button��58       J� RenderTransformOrigin$ 0.5,0.5&�59      z�5:      �� 5;      5=      A� 5>   
   $��0��5?      $��1��5@      $	��200��5A      $	��200��5B      ��5C      
� 5D       
� GradientOrigin$ 0.2,0.2&�6&   .��5E      �  � Offset$ 0Q�6#    � Color$  LightYellow��6.   � 5F      $ 1Q�6#   $	 Red��6.   5G       5J      :� 5K      $ 
MouseEnter��6   .[�5L      �� .��5M      �� .��5N      ,� $ Fill.GradientOrigin�6-   	 ,� To 0.8,0.86]   �� 5O      $! Fill.GradientStops[1].Color�6-   	 �� To 	LightPink6e   5P      5Q      5R      :� 5S      $ 
MouseLeave��6   .[�5T      �� .��5U      �� .��5V      ,� $ Fill.GradientOrigin�6-   �� 5W      $! Fill.GradientStops[1].Color�6-   5X      5Y      5Z      5\      5]      5^      