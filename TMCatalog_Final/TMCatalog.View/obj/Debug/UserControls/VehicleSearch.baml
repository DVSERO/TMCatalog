   M S B A M L   `   `   `  ����K  GTMCatalog.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullcCclr-namespace:TMCatalog.Common.Converters;assembly=TMCatalog.CommonTMCatalog.Common.Converters  5       TMCatalog.View/   )TMCatalog.View.UserControls.VehicleSearch   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Z
convertersCclr-namespace:TMCatalog.Common.Converters;assembly=TMCatalog.Common     5        � 	Resources  5	      <   6TMCatalog.Common.Converters.DataGridRowNumberConverter   DataGridRowNumberConverter��%   &	          5
      6,   5      .��5      �  � RowDefinitions 5      �� 5      $
��Auto �6   6&   �� 5      $
��Auto �6   6&   �� 5      $��* �6   6#    � ColumnDefinitions 5      �� 5      $��* �6   6%   �� 5      $��2* �6   6&   �� 5      $��* �6   6%   .+�5      �� $��0��6   $��0��6   $��Manufacturer��6)   6B   �� 5       �� DisplayMemberPath$ Description��65    �� SelectedValuePath$ Id��6�   $��0��5      $��1��6   ��5      �� *Manufacturers+ �� SelectedValue 6U   �� *ManufacturerId+ �� Mode$ TwoWay=�5   .   �� 5      $��1��6   $��0��6   $��Model��6)   6;   �� 5       $ Description��6.   $ Id��6}   $��1��5!      $��1��6   ��5       �� *Models+ 6N   �� *	ModelId+$ TwoWay=�5!   .   &   System.Windows.Controls.DataGrid  5#      $��2��5%      $��3��5&         AutoGenerateColumns .  $��5q�5(         
IsReadOnly . $
��Left=�5*      ��5#      �� *VehicleList+	 �� SelectedItem	 5$      �� *SelectedVehicleType+
 J� InputBindings
 5+      d� 5,   
    d� Gesture$ LeftDoubleClicka�6    �� Command 61   �� *OpenVehicleCommand+6Z      Columns 5.      0  *System.Windows.Controls.DataGridTextColumn  5/   
   ,  &System.Windows.Controls.DataGridColumn   Header$ Manufacturer��6      Width5  /System.Windows.Controls.DataGridLengthConverter$ 2* 63   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6>   �� * Model.Manufacturer.Description+6s     50   
   $ Model��6   $ 2* 6,    67   �� *Model.Description+6_     51   
   $
 Type��6   $ 3* 6+    67   �� *Description+6Y     52   
   $ 	Fuel Type��6   $ 60 60    6;   �� *FuelType.Description+6f     53   
   $
 From��6   $ 40 6+    66   �� *ProductionYearFrom+6_     54   
   $ To��6   $ 40 6*    65   �� *ProductionYearTo+6\      RowHeaderTemplate 56      �� 57   
   .R�58      �� ��6   ��  �� RelativeSource ��  �� AncestorType$ DataGridRowL� �� 	Converter# [  6�   59      5;      5<      5=      