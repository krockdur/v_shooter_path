   M S B A M L   `   `   `  ����I  Ev_shooter_path, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:v_shooter_pathv_shooter_path  5   	       v_shooter_path.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:v_shooter_path     5   	     � Title$  
MainWindow��5   	   $	��768��6   $
��1024��6)   $��ArcadeClassic)�66   $��16(�6Q   .��5      �  � RowDefinitions 5   
   �� 5      �� 5      $��600px �6   �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      $��900px �6    .+�5   
   � $��0��6   $��1��6    5      �� 5      $��* �6    �� 5      $
��30px �6    �� 5      $
��30px �6    �� 5      $��* �6     5      �� 5      �� 5       �� 5!      �� 5"      �� 5#      .+�5&      �� -   5        $��
Btn_NewSet��5&      $��1��6@   $��1��6M   $��5q�6]   .��6i   	New set6r   �� 5'      -   5        $��Btn_OpenSet��5'      $��1��6B   $��2��6O   $��5q�6_   .��6k   
Open set6u   �� 5(      -   5        $��Btn_SaveSet��5(      $��1��6B   $��3��6O   $��5q�6_   .��6j   
Export set6v   �� 5+      -   5        $��
Btn_NewLvl��5+      $��2��6@   $��1��6M   $��5q�6]   .��6i   	New level6t   �� 5,      -   5        $��Btn_OpenLvl��5,      $��2��6B   $��2��6O   $��5q�6_   .��6k   
Open level6w   �� 5-      -   5        $��Btn_SaveLvl��5-      $��2��6B   $��3��6O   $��5q�6_   .��6k   Export level6y   5/      �� 52   
    �� Orientation$ Vertical=�6   $��1��6,   $��0��69   .+�54      �� $��14(�6   Select an object :6:   �� 56      -   5        $��Cb_entities_selection��56       �� 
IsEditable$ False��64   .@�58      �� .��59      �� $ 
Horizontal=�6!   .+�5:      �� ���#f2f0e5$��25��64   $��25��6?   �� 5;      $��50��6$    �� TextAlignment$ Center=�6/   $��Center=�6F   A6d   5<      5=      �� 5?      .��5@      �� $ 
Horizontal=�6!   .+�5A      �� ���#b8b5b9$��25��63   $��25��6>   �� 5B      $��50��6$   $ Center=�6/   $��Center=�6F   B6d   5C      5D      �� 5F      .��5G      �� $ 
Horizontal=�6!   .+�5H      �� ���#868188$��25��63   $��25��6>   �� 5I      $��50��6$   $ Center=�6/   $��Center=�6F   C6d   5J      5K      �� 5M      .��5N      �� $ 
Horizontal=�6!   .+�5O      �� ���#646365$��25��63   $��25��6>   �� 5P      $��50��6$   $ Center=�6/   $��Center=�6F   D6d   5Q      5R      �� 5T      .��5U      �� $ 
Horizontal=�6!   .+�5V      �� ���#45444f$��25��63   $��25��6>   �� 5W      $��50��6$   $ Center=�6/   $��Center=�6F   E6d   5X      5Y      �� 5[      .��5\      �� $ 
Horizontal=�6!   .+�5]      �� ���#3a3858$��25��63   $��25��6>   �� 5^      $��50��6$   $ Center=�6/   $��Center=�6F   F6d   5_      5`      �� 5b      .��5c      �� $ 
Horizontal=�6!   .+�5d      �� ���#212123$��25��63   $��25��6>   �� 5e      $��50��6$   $ Center=�6/   $��Center=�6F   G6d   5f      5g      �� 5i      .��5j      �� $ 
Horizontal=�6!   .+�5k      �� ���#352b42$��25��63   $��25��6>   �� 5l      $��50��6$   $ Center=�6/   $��Center=�6F   H6d   5m      5n      �� 5p      .��5q      �� $ 
Horizontal=�6!   .+�5r      �� ���#43436a$��25��63   $��25��6>   �� 5s      $��50��6$   $ Center=�6/   $��Center=�6F   I6d   5t      5u      �� 5w      .��5x      �� $ 
Horizontal=�6!   .+�5y      �� ���#4b80ca$��25��63   $��25��6>   �� 5z      $��50��6$   $ Center=�6/   $��Center=�6F   J6d   5{      5|      �� 5~      .��5      �� $ 
Horizontal=�6!   .+�5�      �� ���#68c2d3$��25��63   $��25��6>   �� 5�      $��50��6$   $ Center=�6/   $��Center=�6F   K6d   5�      5�      �� 5�      .��5�      �� $ 
Horizontal=�6!   .+�5�      �� ���#a2dcc7$��25��63   $��25��6>   �� 5�      $��50��6$   $ Center=�6/   $��Center=�6F   L6d   5�      5�      �� 5�      .��5�      �� $ 
Horizontal=�6!   .+�5�      �� ���#ede19e$��25��63   $��25��6>   �� 5�      $��50��6$   $ Center=�6/   $��Center=�6F   M6d   5�      5�      �� 5�      .��5�      �� $ 
Horizontal=�6!   .+�5�      �� ���#d3a068$��25��63   $��25��6>   �� 5�      $��50��6$   $ Center=�6/   $��Center=�6F   N6d   5�      5�      �� 5�      .��5�      �� $ 
Horizontal=�6!   .+�5�      �� ���#b45252$��25��63   $��25��6>   �� 5�      $��50��6$   $ Center=�6/   $��Center=�6F   O6d   5�      5�      �� 5�      .��5�      �� $ 
Horizontal=�6!   .+�5�      �� ���#6a536e$��25��63   $��25��6>   �� 5�      $��50��6$   $ Center=�6/   $��Center=�6F   P6d   5�      5�      �� 5�      .��5�      �� $ 
Horizontal=�6!   .+�5�      �� ���#4b4158$��25��63   $��25��6>   �� 5�      $��50��6$   $ Center=�6/   $��Center=�6F   Q6d   5�      5�      �� 5�      .��5�      �� $ 
Horizontal=�6!   .+�5�      �� ���#80493a$��25��63   $��25��6>   �� 5�      $��50��6$   $ Center=�6/   $��Center=�6F   R6d   5�      5�      �� 5�      .��5�      �� $ 
Horizontal=�6!   .+�5�      �� ���#a77b5b$��25��63   $��25��6>   �� 5�      $��50��6$   $ Center=�6/   $��Center=�6F   S6d   5�      5�      �� 5�      .��5�      �� $ 
Horizontal=�6!   .+�5�      �� ���#e5ceb4$��25��63   $��25��6>   �� 5�      $��50��6$   $ Center=�6/   $��Center=�6F   T6d   5�      5�      �� 5�      .��5�      �� $ 
Horizontal=�6!   .+�5�      �� ���#c2d368$��25��63   $��25��6>   �� 5�      $��50��6$   $ Center=�6/   $��Center=�6F   U6d   5�      5�      �� 5�      .��5�      �� $ 
Horizontal=�6!   .+�5�      �� ���#8ab060$��25��63   $��25��6>   �� 5�      $��50��6$   $ Center=�6/   $��Center=�6F   V6d   5�      5�      �� 5�      .��5�      �� $ 
Horizontal=�6!   .+�5�      �� ���#567b79$��25��63   $��25��6>   �� 5�      $��50��6$   $ Center=�6/   $��Center=�6F   W6d   5�      5�      �� 5�      .��5�      �� $ 
Horizontal=�6!   .+�5�      �� ���#4e584a$��25��63   $��25��6>   �� 5�      $��50��6$   $ Center=�6/   $��Center=�6F   X6d   5�      5�      �� 5�      .��5�      �� $ 
Horizontal=�6!   .+�5�      �� ���#7b7243$��25��63   $��25��6>   �� 5�      $��50��6$   $ Center=�6/   $��Center=�6F   Y6d   5�      5�      �� 5�      .��5�      �� $ 
Horizontal=�6!   .+�5�      �� ���#b2b47e$��25��63   $��25��6>   �� 5�      $��50��6$   $ Center=�6/   $��Center=�6F   Z6d   5�      5�      5�      �� 5�      �� 5�      $��14(�6   Level width63   �� 5�      -   5        $��TbInfoLvlWidth��5�   &   $��14(�6   6>   �� 5�      �� 5�      $��14(�6   Level Height64   �� 5�      -	   5        $��TbInfoLvlHeight��5�   &   $��14(�6   6?   �� 5�      �� 5�      $��14(�6   Mouse position X68   �� 5�      -
   5        $��TbInfoMousePositionX��5�   &   $��14(�6   6D   �� 5�      �� 5�      $��14(�6   Mouse position Y68   �� 5�      -   5        $��TbInfoMousePositionY��5�   &   $��14(�6   6D   �� 5      5     �� 5  
   $��1��6   $��1��6"   .@�5     �� ��5     �� 5     $ 
Horizontal=�6!   .+�5     A� $��10��6"   $��10��6-   
�������69   �� 5	     Level Editor62   5
     .��5     �� $	��900��6#   $	��600��6/   $
��Auto=�6=   .��5     �� -   5        $��canvas_board��5  !   $	��900��65   $	��600��6A   
������� � Cursor$
 None��6�   5     5     �� 5     ��5     �� 5     $ 
Horizontal=�6!   .+�5     A� $��10��6"   $��10��6-   
�������69   �� 5     Object Configuration6:   5     .��5     �  5     �� 5     $��25 �6(   �� 5     .+�5!     � $��0��6   $��0��6(   $��Center=�68    5"     �� 5#     �� 5$     �� 5%     �� 5&     �� 5'     �� 5(     .+�5+     �� $��0��6$   $��Center=�64   OBJECT LETTER :6`   �� 5-     -   5        $��Cb_entities_config��5-  #   $ False��6=   $��1��6�   .@�5/     �� .��50  "   �� $ 
Horizontal=�6-   .+�51  &   �� ���#f2f0e5$��25��6@   $��25��6K   �� 52  &   $��50��60   $ Center=�6;   $��Center=�6R   A6p   53  #   54     �� 56     .��57  "   �� $ 
Horizontal=�6-   .+�58  &   �� ���#b8b5b9$��25��6?   $��25��6J   �� 59  &   $��50��60   $ Center=�6;   $��Center=�6R   B6p   5:  #   5;     �� 5=     .��5>  "   �� $ 
Horizontal=�6-   .+�5?  &   �� ���#868188$��25��6?   $��25��6J   �� 5@  &   $��50��60   $ Center=�6;   $��Center=�6R   C6p   5A  #   5B     �� 5D     .��5E  "   �� $ 
Horizontal=�6-   .+�5F  &   �� ���#646365$��25��6?   $��25��6J   �� 5G  &   $��50��60   $ Center=�6;   $��Center=�6R   D6p   5H  #   5I     �� 5K     .��5L  "   �� $ 
Horizontal=�6-   .+�5M  &   �� ���#45444f$��25��6?   $��25��6J   �� 5N  &   $��50��60   $ Center=�6;   $��Center=�6R   E6p   5O  #   5P     �� 5R     .��5S  "   �� $ 
Horizontal=�6-   .+�5T  &   �� ���#3a3858$��25��6?   $��25��6J   �� 5U  &   $��50��60   $ Center=�6;   $��Center=�6R   F6p   5V  #   5W     �� 5Y     .��5Z  "   �� $ 
Horizontal=�6-   .+�5[  &   �� ���#212123$��25��6?   $��25��6J   �� 5\  &   $��50��60   $ Center=�6;   $��Center=�6R   G6p   5]  #   5^     �� 5`     .��5a  "   �� $ 
Horizontal=�6-   .+�5b  &   �� ���#352b42$��25��6?   $��25��6J   �� 5c  &   $��50��60   $ Center=�6;   $��Center=�6R   H6p   5d  #   5e     �� 5g     .��5h  "   �� $ 
Horizontal=�6-   .+�5i  &   �� ���#43436a$��25��6?   $��25��6J   �� 5j  &   $��50��60   $ Center=�6;   $��Center=�6R   I6p   5k  #   5l     �� 5n     .��5o  "   �� $ 
Horizontal=�6-   .+�5p  &   �� ���#4b80ca$��25��6?   $��25��6J   �� 5q  &   $��50��60   $ Center=�6;   $��Center=�6R   J6p   5r  #   5s     �� 5u     .��5v  "   �� $ 
Horizontal=�6-   .+�5w  &   �� ���#68c2d3$��25��6?   $��25��6J   �� 5x  &   $��50��60   $ Center=�6;   $��Center=�6R   K6p   5y  #   5z     �� 5|     .��5}  "   �� $ 
Horizontal=�6-   .+�5~  &   �� ���#a2dcc7$��25��6?   $��25��6J   �� 5  &   $��50��60   $ Center=�6;   $��Center=�6R   L6p   5�  #   5�     �� 5�     .��5�  "   �� $ 
Horizontal=�6-   .+�5�  &   �� ���#ede19e$��25��6?   $��25��6J   �� 5�  &   $��50��60   $ Center=�6;   $��Center=�6R   M6p   5�  #   5�     �� 5�     .��5�  "   �� $ 
Horizontal=�6-   .+�5�  &   �� ���#d3a068$��25��6?   $��25��6J   �� 5�  &   $��50��60   $ Center=�6;   $��Center=�6R   N6p   5�  #   5�     �� 5�     .��5�  "   �� $ 
Horizontal=�6-   .+�5�  &   �� ���#b45252$��25��6?   $��25��6J   �� 5�  &   $��50��60   $ Center=�6;   $��Center=�6R   O6p   5�  #   5�     �� 5�     .��5�  "   �� $ 
Horizontal=�6-   .+�5�  &   �� ���#6a536e$��25��6?   $��25��6J   �� 5�  &   $��50��60   $ Center=�6;   $��Center=�6R   P6p   5�  #   5�     �� 5�     .��5�  "   �� $ 
Horizontal=�6-   .+�5�  &   �� ���#4b4158$��25��6?   $��25��6J   �� 5�  &   $��50��60   $ Center=�6;   $��Center=�6R   Q6p   5�  #   5�     �� 5�     .��5�  "   �� $ 
Horizontal=�6-   .+�5�  &   �� ���#80493a$��25��6?   $��25��6J   �� 5�  &   $��50��60   $ Center=�6;   $��Center=�6R   R6p   5�  #   5�     �� 5�     .��5�  "   �� $ 
Horizontal=�6-   .+�5�  &   �� ���#a77b5b$��25��6?   $��25��6J   �� 5�  &   $��50��60   $ Center=�6;   $��Center=�6R   S6p   5�  #   5�     �� 5�     .��5�  "   �� $ 
Horizontal=�6-   .+�5�  &   �� ���#e5ceb4$��25��6?   $��25��6J   �� 5�  &   $��50��60   $ Center=�6;   $��Center=�6R   T6p   5�  #   5�     �� 5�     .��5�  "   �� $ 
Horizontal=�6-   .+�5�  &   �� ���#c2d368$��25��6?   $��25��6J   �� 5�  &   $��50��60   $ Center=�6;   $��Center=�6R   U6p   5�  #   5�     �� 5�     .��5�  "   �� $ 
Horizontal=�6-   .+�5�  &   �� ���#8ab060$��25��6?   $��25��6J   �� 5�  &   $��50��60   $ Center=�6;   $��Center=�6R   V6p   5�  #   5�     �� 5�     .��5�  "   �� $ 
Horizontal=�6-   .+�5�  &   �� ���#567b79$��25��6?   $��25��6J   �� 5�  &   $��50��60   $ Center=�6;   $��Center=�6R   W6p   5�  #   5�     �� 5�     .��5�  "   �� $ 
Horizontal=�6-   .+�5�  &   �� ���#4e584a$��25��6?   $��25��6J   �� 5�  &   $��50��60   $ Center=�6;   $��Center=�6R   X6p   5�  #   5�     �� 5�     .��5�  "   �� $ 
Horizontal=�6-   .+�5�  &   �� ���#7b7243$��25��6?   $��25��6J   �� 5�  &   $��50��60   $ Center=�6;   $��Center=�6R   Y6p   5�  #   5�     �� 5�     .��5�  "   �� $ 
Horizontal=�6-   .+�5�  &   �� ���#b2b47e$��25��6?   $��25��6J   �� 5�  &   $��50��60   $ Center=�6;   $��Center=�6R   Z6p   5�  #   5�     5�     5�     &   System.Windows.Controls.DataGrid  5�     -   5        $��Dg_Attributes��5�        AutoGenerateColumns$ False��64   $��1��6Q   $��0��6^      Columns 5�     0  *System.Windows.Controls.DataGridTextColumn  5�     ,  &System.Windows.Controls.DataGridColumn	   Header$		 KEY��61   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6?   �� *Name+  5�     $	 VALUE��61   
 6@   �� *Value+5�     5�     5�     5�     �� 5�  
   -   5        $��tb_debug��5�     $��2��6$   $��1��61   5�     5�     