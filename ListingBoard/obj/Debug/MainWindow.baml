   M S B A M L   `   `   `  ����G  CListingBoard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:ListingBoardListingBoard  5   	       ListingBoard.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:ListingBoard     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � Icon$ Resources/icon.png��65   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      .+�5   
   �� -   5         ��Name$ imgLogo��5      $��/Resources/icon.png��6!   $��38��6>   $
��Left=�6J   $��38��6e   �� 5   
   -   5         ��Name$ btnBack��5      $��0��6"   $��
Назад��6E   $	��100��6U   $
��Left=�6a   $	��Top=�6|   $��50,0,0,0q�6�    � 5   
   -   5          �Name$ frMainFrame��5      $��1��6%     � NavigationUIVisibility$ Hidden=�62     � Source$ Pages/ListingsPage.xaml?�6R   6s   �� 5   
   -   5        $ btnLogin��5      $��0��6#   $��Авторизация��6G   $	��100��6]   $
��Left=�6i   $	��Top=�6�   $��	170,0,0,0q�6�   �� 5   
   -   5        $ btnMainPage��5      $��0��6&   $��Главная��6M   $	��100��6_   $
��Left=�6k   $	��Top=�6�   $��	290,0,0,0q�6�   �� 5   
   -   5        $ btnUserPage��5      $��0��6&   $y�Hidden=�6M   $!��Личный кабинет��6a   $
��Auto��6z   $
��Left=�6�   $	��Top=�6�   $��	410,0,0,0q�6�   �� 5   
   -   5        $ btnCompletedListings��5      $��0��6/   $y�Hidden=�6_   $��Завершенные��6s   $
��Auto��6�   $
��Left=�6�   $	��Top=�6�   $��	540,0,0,0q�6�   5      5      