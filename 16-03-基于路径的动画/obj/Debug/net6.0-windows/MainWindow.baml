   M S B A M L   `   `   `  ����V  R16-03-基于路径的动画, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:_16_03_基于路径的动画_16_03_基于路径的动画  5      -    '_16_03_基于路径的动画.MainWindow   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:_16_03_基于路径的动画     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        � Title$  
MainWindow��5      $	��800��5	      $	��450��5
       � 	Resources 5       
  myPath E� 
StartPoint �� Point �� Point �� Size��%�   &	        B� 5   
   .��5      E� $ 10,10&�6   .��5      �� $ 350,10&�6   �� 5      $ 300,200&�6   �� 5      $ 250,300&�6   $ 50,40��6-   �� 5      $ 200,300&�6   5      5      5       � Triggers 5      :� 5   
    :� RoutedEvent$ Button.Click��6   .[�5      �� .��5      �� .��5      T�  T� PathGeometry# [  5      	 T� Source$	 X=�5      
 �� 
TargetName$	
 img��5       �� TargetProperty$ (Canvas.Left)�5        g� Duration$ 0:0:10D�5!      T� 5"      # [  5#      $	 Y=�5$      $	
 img��5%      $ (Canvas.Top)�5&      $ 0:0:10D�5'      5(      5)      5*      .��5,      �  � RowDefinitions 5-   
   �� 5.      �� 5/      $��50 �6   .+�51   
   �� .+�53      �� -   5         ��Name$	 img��54       �� Left$ 10��55      
 �� Top$ 10��56      ��57      H� 58       H� Drawing 59      � 5:       � Geometry 5;   "   � 5<   &   .��5=   *   @�  @� RadiusX$ 9Q�6:    @� RadiusY$ 4Q�6F   @� 5>   *   $ 4Q�6:   $ 9Q�6F   @� 5?   *   $ 2Q�6:   $ 2Q�6F   5@   '   
 � Pen 5B   "   >� 5C   &    >� Brush
 �  �� >� 	Thickness$ 1Q�66   5E      5G      z�5I      T� 5J       T� X$	 -10Q�6)    T� Y$	 -10Q�61   5L      F� 5N      
���   ���6   ��  �� Source# [  6C   5O      �� 5P   
   $��1��5Q      $	��100��5R      $��30��5S      $��Start��5T      5U      5V      