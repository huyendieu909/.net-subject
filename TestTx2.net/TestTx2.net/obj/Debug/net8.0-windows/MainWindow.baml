   M S B A M L   `   `   `  ����F  BTestTx2.net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:TestTx2.netTestTx2.net  5   	       TestTx2.net.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:TestTx2.net     5   	     � Title$  
MainWindow��5   	   $	��600��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
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
��auto �6   �� 5      �� 5      $
��auto �6   .+�5   
   �� $��1��6   $��0��6   $��7��6.   $��2��6?   
�������
��� � �$��1q�6z   $��5q�6�   �� 5   
   $��0��6   $��0��6   $��2��6-   $��25(�6A   $
��Bold"�6O   
����  �$��Center=�6s   .��6�   #!Quản lý thông tin nhân viên6�   �� 5   
   $��1��6   $��0��6      
labelStyle#��[  6-   .��6Q   Mã nhân viên6_   �� 5   
   -   5         ��Name$ tbMaNV��5      $��1��6"   $��1��6/     textBoxStyle#��[ 6?   �� 5   
   $��2��6   $��0��6   #��[  6-   .��6Q   	Họ tên6Y   �� 5    
   -   5        $ tbHoTen��5       $��2��6#   $��1��60   #��[ 6@   $	��300��6f   �� 5"   
   $��3��6   $��0��6   #��[  6-   .��6Q   
Ngày sinh6\   (  "System.Windows.Controls.DatePicker  5#   
   -   5        $��dtpNgaySinh��5#      $��3��6(   $��1��65   $��Center=�6E   $��200px��6`   $
��Left=�6n   �� 5%   
   $��4��6   $��0��6   #��[  6-   .��6Q   Giới tính6\   �� 5&   
   $��4��6   $��1��6"    �� Orientation$ 
Horizontal=�62   $��Center=�6K   .+�5'      	� -   5        $��radNam��5'   /    	� 	GroupName$ gioiTinh��6     radioButtonStyle#��[ 6=    d� 	IsChecked$
 TrueY�6g   .��6x   Nam6}   	� 5(      -   5        $��radNu��5(   /   $ gioiTinh��6   #��[ 6<   .��6f   Nữ6j   5)      �� 5+   
   $��5��6   $��0��6   #��[  6-   .��6Q   
Phòng ban6\   �� 5,   
   -   5        $��
cbPhongBan��5,      $��5��6%   $��1��62     comboBoxStyle#��[ 6B    �� SelectedIndex$ 0��6i   .@�5-      �� -   5        $��	cbiToChuc��5-      .��6,   Tổ chức65   �� 5.      -   5        $��
cbiKeHoach��5.      .��6-   Kế hoạch67   �� 5/      -	   5        $��cbiVatTu��5/      .��6+   	Vật tư63   50      �� 52   
   $��6��6   $��0��6   #��[  6-   .��6Q   Hệ số lương6^   �� 53   
   -
   5        $ tbHeSoLuong��53      $��6��6'   $��1��64   #��[ 6D   &   System.Windows.Controls.DataGrid  55   
   -   5          Name$ dtgNhanVien��55      $��7��6(   $��0��65   $��2��6E   	   AutoGenerateColumns$	 False��6Y   $��10q�6u   
   Columns
 56      0  *System.Windows.Controls.DataGridTextColumn  57      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã nhân viên��6%     headerDtgStyle   HeaderStyle# [ 6T   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *MaNV+6T     58      $ 	Họ tên��6%   # [ 6O    65   �� *HoTen+6O     59      $ Giới tính��6%   # [ 6U    68   �� *
GioiTinh+6U     5:      $ 
Phòng ban��6%   # [ 6U    68   �� *
PhongBan+6U     5;      $ 
Ngày sinh��6%   # [ 6o    68   �� *
NgaySinh+ �� StringFormat$ dd-MMM-yyyy��6o     5<      $ Tuổi��6%     headerTuoiStyle# [ 6L      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6{    63   �� *Tuoi+6{   5>      �� 5@   
   $��8��6   $��0��6"   $��2��62   $ 
Horizontal=�6F   $��Center=�6_   $��Center=�6|   .+�5A      �� -   5         ��Name$ btnNhap��5A        btnStyle#��[ 6&     btnControlTempleteStyle#��[ 6H   .��6�   Nhập6�   �� 5B      -   5        $ 
btnWindow2��5B      #��[ 6)   #��[ 6K   .��6�   	Window26�   5C      5D      5E      