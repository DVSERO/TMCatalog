   M S B A M L   `   `   `  ����  TMCatalog.View#    TMCatalog.View.ShoppingBasket   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .��5      �   � RowDefinitions  5	      �� 5
      $��50 �6   6$   �� 5      $��* �6   6#   �� 5      $��60 �6   6$    � ColumnDefinitions 5      �� 5      $��* �6   6%   �� 5      $	��100 �6   6'   .+�5      �� $��0��6   $��0��5      $��2��5      ��5      �� *Order.Description+ �� Mode$ TwoWay=�6@   &   System.Windows.Controls.DataGrid  5      $��1��6   $��0��5         AutoGenerateColumns .     
IsReadOnly . ��5      �� *Order.OrderEntries+ �� SelectedItem 5      �� *SelectedOrderEntry+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5   
   ,  &System.Windows.Controls.DataGridColumn   Header$ Article Number��6      Width5  /System.Windows.Controls.DataGridLengthConverter$ 2* 65   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6@   �� *Article.ArticleNumber+6l     5    
   $ Description��6   $ 4* 62   	 6=   �� *Article.Description+6g     5!   
   $ 
Unit Price��6   $ * 61   	 6;   �� *	UnitPrice+6[     5"   
   $ Quantity��6   $ * 6/   	 69   �� *
Quantity+6X     5#   
   $ Price��6   $ * 6,   	 66   �� *Price+6R   5%      �� 5&      $��1��6   $��1��5'      
 �� Orientation$
 Vertical=�5(      .+�5)      �� $��Center=�6   $��Center=�5*      $��+��5+      ��5,      �� *CommandIncreaseStock+5-   	   �� 5.      $��Center=�6   $��Center=�5/      $��-��50      ��51      �� *CommandDecreaseStock+52   	   53      � 55      $��2��6   $��2��56       57      �� 58   
   $��* �6   6'   �� 59   
   $
��Auto �6   6*   .+�5<      �� $��0��6   $
 
Horizontal=�5=      .+�5>   
   �� $��Center=�6   $��Close Order��5?      ��5@      �� *CommandCloseOrder+5A      �� 5C   
   $��Center=�6   $��Save Shopping Basket��5D      ��5E      �� *CommandSaveShoppingBasket+5F      �� 5H   
   $��Center=�6   $��Open Orders��5I      ��5J      �� *CommandOpenOrders+5K      5L   	   �� 5O      $��1��6   $
 
Horizontal=�5P      .+�5Q   
   �� $��Total Price:��6   $��Center=�5R      $��25(�5S      
����  �5T   "   �� 5U   
   $��Center=�5V      $��25(�5W      
����  �$��	5,0,100,0q�5Y      ��5U      �� *Order.TotalPrice+5Y   #   5Z   	   5[      5\      5]      