   M S B A M L   `   `   `  ����A  =EGTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:EGTestEGTest  5   	       EGTest.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:EGTest     5   	   -   5          �Name$  Window��5   	    � Title$ EGTest��5   	   $	��450��6   $	��600��6%   $	��600��61   $	��450��6@    � 	Resources 5	      !   EGTest.DivideByTwoConverter   DivideByTwo"  EGTest.PointsToPathConverter  PointsToPath��%:   &	        &	        5
   
   6%     5   
   6&   5      .��5      � .+�5   
   �� -   5         ��Name$ canvas��5   '   $��10,10,190,10q�6   .+�5      �� -   5        $��YAxis��5       $��Y��6   6    �� 5      -   5        $��XAxis��5       $��X��6   6    �� 5      	 �� Y1$ 0��5      
���   �	 �� X1 5      ��  �� ElementName$ canvas�� �� Path$ ActualWidth� �� 	Converter# [  		 �� X2	 5      �� 
 �� RelativeSource
 �� *Self+$ X1�	 �� Y2 5      �� $ canvas��$ ActualHeight�5      �� 5      $ 0��6   
���   � 5      �� $ canvas��$ ActualHeight�# [  	 5      �� $ canvas��$ ActualWidth� 5      �� 
 �� *Self+$ Y1�5      F� 5      
���  ��$��3��6    ��5      `� 5       `� 	Converter# [ 6#   .1�5      �� $ Window��6"   $ Points�67   �� 5      $ canvas��6"   $ ActualWidth�67   �� 5       $ canvas��6"   $ ActualHeight�67   5!      z�5#      V� 5$      .~�5%      T�  T� X 6-   �� $ canvas��$ ActualWidth�# [   T� Y 5&   -   �� $ canvas��$ ActualHeight�# [  5'      5)      5*      �� 5+   
   -   5         ��Name$ Button1��5+      $
��Draw��6"   $��	0,65,55,0q�61   $	��Top=�6D   $��Right=�6\   $��76��6x   $��20��6�   6�   �� 5,   
   -   5        $ Button2��5,      $
��Draw��6"   $��
0,165,55,0q�61   $	��Top=�6E   $��Right=�6]   $��76��6y   $��20��6�   6�   �� 5-   
   -   5        $ Button3��5-      $
��Draw��6"   $��
0,265,55,0q�61   $	��Top=�6E   $��Right=�6]   $��76��6y   $��20��6�   6�   �� 5.   
   $��y = 2��6   $��0,37,0,0q�6    $	��185��62   $��28��6>   $	��Top=�6J   $��Right=�6b   $��Center=�6~   $��Center=�6�   �� 5/   
   $��y = 2 * cos(x)��6   $��	0,132,0,0q�6)   $	��185��6<   $��28��6H   $	��Top=�6T   $��Right=�6l   $��Center=�6�   $��Center=�6�   �� 50   
   $��y = 2 * tng(x)��6   $��	0,232,0,0q�6)   $	��185��6<   $��28��6H   $	��Top=�6T   $��Right=�6l   $��Center=�6�   $��Center=�6�   51      52      