   M S B A M L   `   `   `  ����H  DDoctorStrange, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:DoctorStrangeDoctorStrange  5   	       DoctorStrange.newPatient   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:DoctorStrange     5   	   -   5          �Name$  AddNewPatient��5   ;    � Title$# اضافة مريض جديد ��6	   $	��600��6"   $	��500��6/   
�������.��5	      �  � RowDefinitions 5
   
   �� 5      $��5 �6   �� 5      $	��40* �6   �� 5      $	��40* �6   �� 5      $	��40* �6   �� 5      $	��40* �6   �� 5      $	��40* �6   �� 5      $	��40* �6   �� 5      $	��40* �6   �� 5      $	��40* �6   �� 5      $	��40* �6   �� 5      $��40 �6   �� 5      $��5 �6    � ColumnDefinitions 5   
   �� 5      $��5 �6   6+   �� 5      $	��30* �6   6-   �� 5      $��5 �6   6+   �� 5      $	��30* �6   6-   �� 5      $��5 �6   6+   �� 5      $	��30* �6   6-   �� 5      $��5 �6   6+   .+�5"   
   �� $��1��6   $��1��6    $��Center=�6-   
���   �$
��Bold"�6b   $��اسم المريض ��6t   $��Stretch=�6�   �� 5#   
   -   5         ��Name$ 
txtNameOfP��5#      $��3��6&   $��1��66   
���   �$��Center=�6X   $��Center=�6s   
���   �$��1q�6�   $	��150��6�    � ToolTip$  تاريخ الميلاد ��6�   �� 5%   
   $��1��6   $��2��6    $��Center=�6-   
���   �$
��Bold"�6b   $��اسم الاب ��6t   $��Stretch=�6�   �� 5&   
   -   5        $ txtNameOfPF��5&      $��3��6'   $��2��67   
���   �$��Center=�6Y   $��Center=�6t   
���   �$��1q�6�   $	��150��6�   $  تاريخ الميلاد ��6�   �� 5(   
   $��1��6   $��3��6    $��Center=�6-   
���   �$
��Bold"�6b   $��اسم العائله ��6t   $��Stretch=�6�   �� 5)   
   -   5        $ txtNameOfFamily��5)      $��3��6+   $��3��6;   
���   �$��Center=�6]   $��Center=�6x   
���   �$��1q�6�   $	��150��6�   $  تاريخ الميلاد ��6�   �� 5+   
   $��1��6   $��4��6    $��Center=�6-   
���   �$
��Bold"�6b   $ ��تاريخ الميلاد ��6t   $��Stretch=�6�   �� 5,   
   -   5        $ txtDate��5,      $��3��6#   $��4��63   
���   �$��Center=�6U   $��Center=�6p   
���   �$��1q�6�   $	��150��6�   $  تاريخ الميلاد ��6�   �� 5.   
   $��1��6   $��5��6    $��Center=�6-   
���   �$
��Bold"�6b   $��الهاتف ��6t   $��Stretch=�6�   �� 5/   
   -   5        $ txtPhone��5/      $��3��6$   $��5��64   
���   �$��Center=�6V   $��Center=�6q   
���   �$��1q�6�   $	��150��6�   $  تاريخ الميلاد ��6�   �� 51   
   $��1��6   $��6��6    $��Center=�6-   
���   �$
��Bold"�6b   $��العنوان ��6t   $��Stretch=�6�   �� 52   
   -   5        $ 
txtAddress��52      $��3��6&   $��6��66   $��3��6C   
���   �$��Center=�6l   $��Center=�6�   
���   �$��1q�6�   $	��300��6�   $  تاريخ الميلاد ��6�   �� 54   
   $��1��6   $��7��6    $��Center=�6-   
���   �$
��Bold"�6b   $(��"البريد الالكتروني ��6t   $��Stretch=�6�   �� 55   
   -   5        $ txtEmail��55      $��3��6$   $��7��64   
���   �$��Center=�6V   $��Center=�6q   
���   �$��1q�6�   $	��150��6�   $  تاريخ الميلاد ��6�   �� 57   
   $��1��6   $��8��6    $��Center=�6-   
���   �$
��Bold"�6b   $��رقم الهويه ��6t   $��Stretch=�6�   �� 58   
   -	   5        $ txtID��58      $��3��6!   $��8��61   
���   �$��Center=�6S   $��Center=�6n   
���   �$��1q�6�   $	��150��6�   $  تاريخ الميلاد ��6�   �� 5:   
   $��1��6   $��9��6    $��Center=�6-   
���   �$
��Bold"�6b   $��معلومات اخري ��6t   $��Stretch=�6�   �� 5;   
   -
   5        $ txtOtherInfo��5;      $��3��6(   $��9��68   $��3��6E   
���   �$��Center=�6n   $��Center=�6�   
���   �$��1q�6�   $	��300��6�   $  تاريخ الميلاد ��6�   �� 5=   
   -   5         ��Name$ 
btnAddNewP��5=      |�.  $��1��67   $��10��6G   ���#1e76bb$
��Auto��6j   $
��auto��6w   $��4,4,4,4q�6�   ���	#FF20B4EC.��5>      �� -   5         ��Name$ 
txtAddNewP��5>      
�������$��اضافه ��6?   $
��Bold"�6M   $��20(�6_   $��calibria)�6m   $��Normal&�6�   $��1q�6�   ��5?      �� 5@       �� 
TargetType" ��6   	 �� BasedOn#	 [B��6,   
 �� Triggers
 5A      P� 5B       P� Property �@J�IsMouseOver P� Value . . �5C      ��  �� Property � �� �� Value
 �����6;   5D      5F      5H      �� 5J   
   -   5        $ 	btnCancel��5J      |�.  $��5��66   $��10��6F   ���#1e76bb$
��Auto��6i   $
��auto��6v   $��4,4,4,4q�6�   ���	#FF20B4EC.��5K      �� -   5        $ 	txtCancel��5K      
�������$��الغاء ��6>   $
��Bold"�6L   $��20(�6^   $��calibria)�6l   $��Normal&�6�   $��1q�6�   ��5L      �� 5M      " ��6   #	 [B��6,   
 5N      P� 5O       �@J�IsMouseOver . . �5P      ��  � ��
 �����6;   5Q      5S      5U      5V      5W      