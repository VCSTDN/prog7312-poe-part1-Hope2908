   M S B A M L   `   `   `  ����	  MyPoe    LibraryApp.Sorting   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Replacing Books��5   	   .��5      (� .��5   
   � $	��511��6   $	��431��6   ��5      �� 5       �� ImageSource$ /background.jpg��6    � ColumnDefinitions 5
      �� 5      $
��393* �6#   �� 5      $	��23* �6#   �� 5      $	��24* �6#   .+�5      �� -   5        $�� ��5      $
��Left=�6    $	��Top=�6;   $	��121��6S   $��192,160,0,0q�6_   $	��100��6�   ��5      �� 5      $2 ,/Generate Call Numbers-logos_transparent.png��6!    j� TileMode$
 Tile=�6\   5      �� 5      -   5        $��CallNumbersListBox��5      $
��Left=�60   $��Center=�6K   $	��150��6f   $	��200��6r   $��20,0,0,0q�6   ��5      �� 5      5      �� 5      -   5        $��NumberButtonsStackPanel��5       �� Orientation$ 
Horizontal=�68   $
��Left=�6Q   $	��Top=�6l   $��170,215,0,0q�6�   5      �� 5       -   5        $��
SortButton��5       $��
��6'   $
��Left=�6<   $	��Top=�6W   $	��121��6o   $��
192,10,0,0q�6{   {�.   J� RenderTransformOrigin$ -0.517,4.789&�6�   $��77��6�   ��5!      �� 5"      $! /Sort-logos_transparent.png��6!   $
 Tile=�6K   5$      �� 5'      -   5        $��PointCountTextBlock��5'      $
��Left=�63   $��Bottom=�6N   $��20,0,0,8q�6i   $
��Bold"�6{   $��24(�6�   
�5(      �� 5)      $�🎉 ��6   
��� ���6%    �� 5*      $�	Points: 0��6    �� 5+      $� 🎉��6   
��� ���6%   ��5-      �� 5.       �� 
TargetType" ��6    �� Triggers 5/      �� 50       �� Binding 6*   �� *IsPointsEarned+	 �� Value	 True6M   
 N� EnterActions
 51   "   �� 52   &   .��53   *   �� .��54   .   W�  �� TargetProperty$ FontSize�6>    W� From$ 24X�6c   	 W� To$ 36X�6m    g� Duration$ 0:0:0.5D�6u    g� AutoReverse .  g� RepeatBehavior$ Forever��6�   �� 55   .   $4 .(TextBlock.Foreground).(SolidColorBrush.Color)�6=    �� From$ BlackX�6�   	 �� To$ GreenX�6�   $ 0:0:0.5D�6�    . $ Forever��6�   56   +   57   '   59      5;      5=      �� 5@      -   5         ��Name$ AnimatedPointsTextBlock��5@      $��Right=�69   $	��Top=�6U   $��	0,10,10,0q�6m   $��18(�6�   $
��Bold"�6�   5B      �� 5E      -   5        $��Restart��5E      $��Right=�6'   $��Bottom=�6C   $	��100��6^   $��30��6j   $��	0,0,13,10q�6v   $��2��6�   ��5F      �� 5G       �� 
StartPoint$ 0.5,0&�6*    �� EndPoint$ 0.5,1&�6=   .��5H      �  � Color$ 	#FF4080C4��6'    � Offset$ 0Q�69   � 5I      $ 	#FFACC3E3��6'   $ 1Q�69   5J      5L      �� 5N      -   5        $��SortedCallNumbersListBox��5N      $
��Left=�66   $��Center=�6Q   $	��150��6l   $	��200��6x   $��	333,0,0,0q�6�   $ 0.467,1.242&�6�   $��3��6�   ��6�   Z� 5O      5P      5Q      