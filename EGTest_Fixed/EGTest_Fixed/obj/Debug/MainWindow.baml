   M S B A M L   `   `   `  ����G  CEGTest_Fixed, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:EGTest_FixedEGTest_Fixed  5   	       EGTest_Fixed.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:EGTest_Fixed     5   	     � Title$  EGTest_Fixed��5   	   $	��450��6   $	��800��6+    � 
ResizeMode$ NoResize=�67   .��5	      �  � 	Resources 5
   
      
GrayPenKey >� Brush  SmallGridDrawing
 � Pen � Geometry  SmallGridBrush j� TileMode j� Viewport j� ViewportUnits	 �� Opacity
 L� Drawing��%�   &	        &	      7   &	 Y     7  >� 5      
 �����6%   � 5      8   " ��        � -1    � -1 -1	6Y   L� 5      $
 Tile=�6J   $ 	0 0 10 10�6Z   $ Absolute=�6o   $		 0.5Q�6�   8
   6�   5      .+�5   
   �� -   5        $��canvas��5      #��[ 6   $��
0,0,184,11q�6L    J� RenderTransformOrigin$ 0.5,0.5&�6`   $��Right=�6�   $	��600��6�   $	��400��6�   $��Bottom=�6�   .+�5      �� -   5        $��YAxis��5       $��Y��6    �� Left$	 300��6-   �� 5      -   5        $��XAxis��5       $��X��6   $	 583��6-   
 �� Top$	 174��6?   �� 5      	 �� X1$	 300��6   	 �� Y1$ 0��5      	 �� X2$	 300��5      	 �� Y2$	 400��5      
���   �5      �� 5      $ 0��6   $	 200��5      $	 600��5      $	 200��5      
���   �5      �� 5      -   5        $��GraphCanvas��5      5      �� 5   
   $��y = 2��6   $��644,0,0,360q�6    $��Center=�65   $��38��6Y   $��Bottom=�6e   $
��Left=�6�   $	��116��6�   �� 5   
   $��y = 2 * Cos(x)��6   $��644,0,0,223q�6)   $��Center=�6>   $��38��6b   $��Bottom=�6n   $
��Left=�6�   $	��116��6�   �� 5    
   $��y = 2 * Tg(x)��6   $��
644,0,0,75q�6(   $��Center=�6<   $��38��6`   $��Bottom=�6l   $
��Left=�6�   $	��116��6�   �� 5!   
   -   5         ��Name$ Button1��5!      $
��Draw��6"   $��
663,61,0,0q�61   $��75��6[   $��20��6f   $
��Left=�6r   $	��Top=�6�   �� 5"   
   -   5        $ Button2��5"      $
��Draw��6"   $��663,0,0,203q�61   $
��Left=�6\   $��75��6w   $��20��6�   $��Bottom=�6�   �� 5#   
   -   5        $ Button3��5#      $
��Draw��6"   $��
663,0,0,50q�61   $
��Left=�6[   $��75��6v   $��20��6�   $��Bottom=�6�   5$      5%      