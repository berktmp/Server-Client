   M S B A M L   `   `   `  ����A  =Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ClientClient  5   	       Client.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Client     5   	   Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5   	   $	��350��5	   	   $	��250��6   $	��200��6"   $	��250��62     � AllowsTransparency$
  True��6A    � WindowStartupLocation$ CenterScreen=�6[    � WindowStyle$
 None=�6�   
������ .��5
      � .+�5   
   �  � ColumnDefinitions 5      �� 5      $
��auto �6#   .+�5      �� -   5        $	��250��5       �� CornerRadius$ 20��6!   ��5      �� 5       �� 
StartPoint$	 0,0&�6*    �� EndPoint$	 0,1&�6;   .��5      �  � Color$ #343145��6(    � Offset$ 0Q�68   � 5      $ #3B2E98��6(   $ 1Q�68   5      5      � 5       5      �� 5      $
��auto �6'   5      �� 5      $	��250��6   .+�5       �� 	 �� Orientation$	 
Horizontal=�6   $��
0 50 20 40q�66   $��Center=�6J   .+�5!      "  FontAwesome.WPF.ImageAwesome  
   Icon$

 Code=�6&      
Foreground �#fff$��50��6D   �� 5"      $��Client��6    $��25(�6.   $
��Bold"�6<   $��Center=�6N   
�������$��10 0 0 0q�6|   5#      �� 5%      -   5           
lambButton#��[  5%      .��5&      � .+�5'      �� $	 
Horizontal=�6%   $
��Left=�6>   .+�5(        $
 Flash=�6.     
buttonIcon#��[ 6;   �� 5)      $��Toggle Lamb��6(     
buttonText#��[ 6;   5*        5+      $
 
AngleRight=�6*   $��Right=�6<   $y�Visible=�6X     buttonIconExpanded#��[ 6m   5,      5-      �� 50      ���#e0e0e0 J� Opacity$	 0.5Q�61   $��40 10 40 10q�6?   �� 52      -   5          
menuButton#��[ 52      .��53      � .+�54      �� $	 
Horizontal=�6%   $
��Left=�6>   .+�55        $
 Random=�6.   #��[ 6<   �� 56      #��[ 6e   ��6(   �� *Number+ �� UpdateSourceTrigger$ PropertyChanged=�6e   57        58      $
 
AngleRight=�6*   $��Right=�6<   $y�Visible=�6X   #��[ 6m   59      5:      5<      5>      5?      5@      