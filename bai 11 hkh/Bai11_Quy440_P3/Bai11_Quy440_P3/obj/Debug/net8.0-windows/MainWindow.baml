   M S B A M L   `   `   `  ����J  FBai11_Quy440_P3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Bai11_Quy440_P3Bai11_Quy440_P3  5   	        Bai11_Quy440_P3.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:Bai11_Quy440_P3     5   	     � Title$  
MainWindow��5   	   $	��500��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��auto �6   �� 5       � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� $��0��6   $��0��6      
labelStyle#��[  6-   .��6Q   Mã sản phẩm:6_   �� 5   
   -   5         ��Name$ tbMaSP��5      $��0��6"   $��1��6/     textBoxStyle#��[ 6?   �� 5   
   $��1��6   $��0��6   #��[  6-   .��6Q   Tên sản phẩm:6`   �� 5   
   -   5        $ tbTenSP��5      $��1��6#   $��2��60   #��[ 6@   �� 5   
   $��2��6   $��0��6   #��[  6-   .��6Q   Số lượng:6]   �� 5   
   -   5        $ 	tbSoLuong��5      $��2��6%   $��1��62   #��[ 6B   �� 5!   
   $��3��6   $��0��6   #��[  6-   .��6Q   Đơn giá:6\   �� 5"   
   -   5        $ tbDonGia��5"      $��3��6$   $��1��61   #��[ 6A   �� 5$   
   $��4��6   $��0��6   #��[  6-   .��6Q   Mã loại:6\   �� 5%   
   -   5        $ tbMaLoai��5%      $��4��6$   $��1��61   #��[ 6A   &   System.Windows.Controls.DataGrid  5'   
   -   5          Name$ 
dtgSanPham��5'      $��5��6'   $��0��64   $��2��6D      AutoGenerateColumns$ False��6X   !   RowDetailsTemplateSelector 5(      2  ,System.Windows.Controls.DataTemplateSelector  5)         Columns 5+      0  *System.Windows.Controls.DataGridTextColumn  5,      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã sản phẩm��6%   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6:   �� *MaSp+  5-      $ Tên sản phẩm��6%   	 6;   �� *TenSp+  5.      $ Số lượng��6%   	 67   �� *	SoLuong+  5/      $ 
Đơn giá��6%   	 66   �� *DonGia+  50      $ 
Mã loại��6%   	 66   �� *MaLoai+52      �� 54   
   $��6��6   $��0��6"   $��2��62   $��5q�6F   $��Center=�6Q   $��Center=�6l   
 �� Orientation$
 
Horizontal=�6�   .+�55      �� -   5         ��Name$ btnThem��55        buttonStyle#��[ 6&   .��6a   Thêm6g   �� 56      -   5        $ btnSua��56      #��[ 6%   .��6_   Sửa6d   �� 57      -	   5        $ btnXoa��57      #��[ 6%   .��6_   Xóa6d   �� 58      -
   5        $ btnThoat��58      #��[ 6'     buttonControlTemplete#��[ 6L   .��6�   Thoát6�   59      5:      5;      