   M S B A M L   `   `   `  ����G  CListingBoard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:ListingBoard.PagesListingBoard.Pages  5      .    (ListingBoard.Pages.CompletedListingsPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:ListingBoard.Pages     5        N� Title$1  +Завершенные объявления��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� -   5        $��lvCompletedListings��5       $��0��6   $	��300��6;   ��5      �� 5      .R�5      �  5      �� 5      $
��Auto �6,   �� 5      $
��Auto �6,   �� 5      $
��Auto �6,   .+�5      ��  �� Orientation$ Vertical=�6%   .+�5      �� $
��Bold"�6D   $��Center=�6V   ��6$   �� *ListingName+6V   �� 5      $
��Wrap=�6L   ��6(   �� *ListingDescription+6L   5      �� 5       $	��300��6    $	��200��6,   $��1��69   ��5!      �� 5"   "    �� Path$ ListingPhoto�6*    �� TargetNullValue 5#   &   ��5$   *   ]YE:\Задания\Аксёнова\ListingBoard\ListingBoard\Resources\Images\default.png��6�   5&   #   5(      �� 5*      $��2��6    $
��Bold"�6M   $��Center=�6_   ��6-   �� *ListingCost+6_   5+      5,      5.      �� 50   
   $��1��6   $ 
Horizontal=�6"   $��Center=�6;   $��10q�6X   .+�51      �� $0��*Общая сумма заработка: ��6   $��16(�66   $
��Bold"�6D   �� 52      -   5        $��lblTotalEarnings��52      $��0��6,   $��16(�68   $
��Bold"�6F   53      54      55      