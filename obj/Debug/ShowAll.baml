   M S B A M L   `   `   `  ����H  DDoctorStrange, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:DoctorStrangeDoctorStrange  5   	       DoctorStrange.ShowAll   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:DoctorStrange     5   	   -   5          �Name$  SearchForAll��5   2    � Title$ ShowAll��6	   $	��450��6   $	��800��6&   
�������.��5	      �  � RowDefinitions 5
   
   �� 5      $��5 �6   �� 5      $��40 �6   �� 5      $
��160* �6   �� 5      $��5 �6    � ColumnDefinitions 5   
   �� 5      $��5 �6   6+   �� 5      $
��460* �6   6.   �� 5      $��5 �6   6+   .+�5   
   �� -   5         ��Name$ stpSearchbar��5      $
��Auto��6+   $��1��68   $��1��6E   $��2��6U    �� CanVerticallyScroll . .+�5      �� -   5         ��Name$ textBox��5   ,   $��30��6=   $��5,5,10,5q�6K   6   �� 5      $
��auto��6   $	��150��6"   
���   �$��1q�6C   
�������$��8,8,10,8q�6j   ._�5      �� $
��Auto=�6   .��5      �� -   5        $ resultStack��5   !   6:   5      5      5      &   System.Windows.Controls.DataGrid  5   
   -   5        $��	grdResult��5      $
��Auto��6%      AutoGenerateColumns .  $��2��6P   $��1��6]   $��Stretch=�6n      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5       ,  &System.Windows.Controls.DataGridColumn	   Header$	 رقم الملف ��6%   
   
IsReadOnly
 .    Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6b   1  +System.Windows.Controls.DataGridBoundColumn   Binding 69   �� *ID+6b     5!      $	 
الاسم��6%   
 .  $	 30* 6o    64   �� *PName+ �� Mode$ TwoWay=�6o     5"      $	 اسم العائله��6%   
 . $	 40* 6g    6;   �� *FName+6g     5#      $ 	  تاريخ الميلاد��6%   
 . $	 25* 6l    6=   �� *
DOfBirth+6l     5$      $	 الهاتف��6%   
 . $	 30* 6a    65   �� *Phone+6a   5&      5'      5(      