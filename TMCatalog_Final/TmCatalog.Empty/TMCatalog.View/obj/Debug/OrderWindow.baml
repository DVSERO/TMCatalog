   M S B A M L   `   `   `  ����K  GTMCatalog.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullcCclr-namespace:TMCatalog.Common.Converters;assembly=TMCatalog.CommonTMCatalog.Common.Converters  5   	    TMCatalog.View    TMCatalog.View.OrderWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Z
convertersCclr-namespace:TMCatalog.Common.Converters;assembly=TMCatalog.Common     5   	     � Icon$  Resources\TMLogo.ico��5   	    � 
ResizeMode$ NoResize=�5	   	    � WindowState$ Normal=�5
   	    � WindowStartupLocation$ CenterOwner=�5   	    � Title$ Orders��5   	   $	��500��5   	   $	��700��6    � 	Resources 5      5   /TMCatalog.Common.Converters.OrderStateConverter   orderStateConverter��%   &	          5      6%   5      .��5      �  � RowDefinitions 5      �� 5      $��60 �6   6$   �� 5      $��* �6   6#   �� 5      $��* �6   6#   .+�5      �� $��0��6     OrderNameLabelStyle#��[ 5       ��5      �� *SelectedOrder.Description+5    ;   &   System.Windows.Controls.DataGrid  5!      $��1��6   $��5q�5"      
����  �$��1q�5$         AutoGenerateColumns .     
IsReadOnly . ��5%      �� *Orders+	 �� SelectedItem	 5&      �� *SelectedOrder+
   Columns
 5)      0  *System.Windows.Controls.DataGridTextColumn  5*   
   ,  &System.Windows.Controls.DataGridColumn   Header$ Description��6      Width5  /System.Windows.Controls.DataGridLengthConverter$ 2* 62   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� *Description+6_     5+   
   $ 
OrderState��6   $ * 61    6;   �� *
OrderState+ �� 	Converter# [  6�     5,   
   $ 
TotalPrice��6   $ * 61    6;   �� *
TotalPrice+6\   5.        50      $��2��6   $��5q�51      
����  �$��1q�53       .   . ��54      �� *SelectedOrder.OrderEntries+
 57        58   
   $ Article number��6   $ 2* 65    6@   �� *Article.ArticleNumber+6l     59   
   $ Description��6   $ * 62    6<   �� *Article.Description+6f     5:   
   $ 
Unit Price��6   $ * 61    6;   �� *	UnitPrice+6[     5;   
   $ Quantity��6   $ * 6/    69   �� *
Quantity+6X     5<   
   $ Price��6   $ * 6,    66   �� *Price+6R   5>      5?      5@      