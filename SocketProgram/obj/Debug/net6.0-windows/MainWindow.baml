   M S B A M L   `   `   `  ����H  DSocketProgram, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:SocketProgramSocketProgram  5   	       SocketProgram.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:SocketProgram     5   	   Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5   	   $	��350��5	   	   $	��700��6   $	��200��6"   $	��600��62     � AllowsTransparency$
  True��6A    � WindowStartupLocation$ CenterScreen=�6[    � WindowStyle$
 None=�6�   
������ .��5      � .+�5   
   �  � ColumnDefinitions 5      �� 5      $
��auto �6$   �� 5      $��* �6$   .+�5      �� -   5        $	��250��5       �� CornerRadius$ 	20 0 0 20��6!   ��5      �� 5       �� 
StartPoint$	 0,0&�6*    �� EndPoint$	 0,1&�6;   .��5      �  � Color$ #343145��6(    � Offset$ 0Q�68   � 5      $ #3B2E98��6(   $ 1Q�68   5      5      �� 5      -   5        $ 	0 25 25 0��5      $��1��6.   ��5      �� 5       $	 0,0&�6*   $	 0,1&�6;   .��5!      � $ #3E3C65��6(   $ 0Q�68   � 5"      $ #473795��6(   $ 1Q�68   5#      5%      � 5(       5)      �� 5*      $
��auto �6'   �� 5+      $��* �6'   5-      �� 50      $	��250��6   .+�51      �� 	 �� Orientation$	 
Horizontal=�6   $��
0 50 20 40q�66   $��Center=�6J   .+�52      "  FontAwesome.WPF.ImageAwesome  
   Icon$

 Code=�6&      
Foreground �#fff$��50��6D   �� 53      $��Server��6    $��25(�6.   $
��Bold"�6<   $��Center=�6N   
�������$��10 0 0 0q�6|   54      �� 57      -   5           
menuButton#��[  57      .��58      � .+�59      �� $	 
Horizontal=�6%   $
��Left=�6>   .+�5:        $
 Flash=�6.     
buttonIcon#��[ 6;   �� 5;      $��Toggle Lamb��6(     
buttonText#��[ 6;   5<        5=      $
 
AngleRight=�6*   $��Right=�6<   $y�Visible=�6X     buttonIconExpanded#��[ 6m   5>      5?      �� 5B      ���#e0e0e0 J� Opacity$	 0.5Q�61   $��40 10 40 10q�6?   �� 5E      -   5        #��[  5E      .��5F      � .+�5G      �� $	 
Horizontal=�6%   $
��Left=�6>   .+�5H        $
 Random=�6.   #��[ 6<   �� 5I      $��Random Number��6(   #��[ 6=   5J        5K      $
 
AngleRight=�6*   $��Right=�6<   $y�Visible=�6X   #��[ 6m   5L      5M      5N      � 5Q      $��1��6   .+�5R      �� $��20 200 20 20q�6    
 border#��[ 6/   ._�5S      �� $��Center=�6!   .+�5T      �� $��Random Number��6$     	textLabel#��[ 69   �� 5U      -   5         ��Name$ 	RndmTxtBx��5U   "   $��0 10 0 5q�6�    �� TextAlignment$ Center=�6�   ��65   �� *Number+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�   5V      5W      �� 5Z      $��
50 30 50 0q�6     lambBackground#��[ 6-   ._�5\      � .+�5]        $
 LightbulbOutline=�6*   $��Center=�6B   $��Center=�6_    �#fff$��25��6�   $��0 5 53 0q�6�   �� 5^      $
��LAMB��6$   $��SemiBold"�60   $��13(�6F   ���#FFF$��Center=�6f   $��Center=�6�   $��	35 5 15 0q�6�   5_      5`      5a      5b      5c      5d      