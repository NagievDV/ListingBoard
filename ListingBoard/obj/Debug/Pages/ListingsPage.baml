   M S B A M L   `   `   `  ����G  CListingBoard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:ListingBoard.PagesListingBoard.Pages  5      %    ListingBoard.Pages.ListingsPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:ListingBoard.Pages     5        N� Title$  Объявления��5	      .��5
      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��0��6.   $	��Top=�6;   .+�5      �� -   5         ��Name$ tbSearch��5      $	��200��6(   64   �� 5      -   5         ��Name$ cmbCity��5      $	��150��6(   $��5,0,0,0q�64   6E   �� 5      -   5        $ cmbCategory��5      $	��150��6,   $��5,0,0,0q�68   6I   �� 5      -   5        $ cmbType��5      $	��150��6(   $��5,0,0,0q�64   6E   �� 5      -   5         ��Name$ btnClearFilters��5      $#��Очистить фильтр��6.   $
��Auto��6H   $��5,0,5,0q�6U   6f   5      �� 5   
   -   5        $��lvListingsList��5      $��1��6)   $	��300��66   $��Disabled=�6F   $��Center=�6|   ��5      �� 5      .R�5      �  � Orientation$ 
Horizontal=�6    $��Center=�69   5      ��5      �� 5       .R�5!      �  5"      �� 5#      $
��Auto �6,   6<   �� 5$      $
��Auto �6,   6<   �� 5%      $
��Auto �6,   6<   .+�5(      �� $ Vertical=�6%   .+�5)      �� $��Center=�6$   $	��300��6?   $��0��6K   $��Center=�6x   $
��Bold"�6�   $
��Auto��6�   
������ ��6X   �� *ListingName+6�   �� 5*      $��0��6$   $��Bottom=�61   $
��Left=�6L   $	��300��6g   $��10(�6�   $
��Auto��6�   ��6s   �� *PublicationDate+6�   5+      �� 5.      $	��300��6    $��1��6,   $
��Fill=�69   $	��200��6H   $��Center=�6U   $	��Top=�6r   ��5/      �� 50   "    �� Path$ Photo�6*    �� TargetNullValue 51   &   ��52   *   ]YE:\Задания\Аксёнова\ListingBoard\ListingBoard\Resources\Images\default.png��6�   54   #   56      �� 57      $ Vertical=�6%   $��2��6<   .+�58      �� $	��300��6$   $��2��60   $��Right=�6^   $
��Auto��6z   $
��Bold"�6�   
������ ��6=   �� *ListingPrice+6�   �� 59      $	��300��6(   $��2��64   $
��Left=�6e   $
��Wrap=�6�   $��10(�6�   
������ ��6A   �� *ListingDescription+6�   5;      5=      5>      5@      5B      5C      