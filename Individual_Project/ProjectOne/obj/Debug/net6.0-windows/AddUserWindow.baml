   M S B A M L   `   `   `  ����E  AProjectOne, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:ProjectOne
ProjectOne  5   	       ProjectOne.AddUserWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:ProjectOne     5   	     � Title$  AddUserWindow��5   	   $	��480��6   $	��870��6,    � WindowStartupLocation$ CenterScreen=�68    � DataContext 5
         ProjectOne.AddUserVM  5   
   .��5      � 
�������.+�5   
   �� 
�������$��20 10q�61   .+�5      �� $	��800��6   $��5q�6)   .+�5      �� $!��Student Registration System��6   $��Center=�6B   $��25��6_   $��18(�5      $��1q�6"   $
��Bold"�6.   6B   �� 5      $2��,Faculty Of Engineering, University Of Ruhuna��6   $��Center=�6S   $��25��6p   $��18(�5      $��1q�6"   $
��Bold"�6.   6B   �� 5      $(��"Department Of Computer Engineering��6   $��Center=�6I   $��25��6f   $��18(�5      $��1q�6"   $
��Bold"�6.   6B   �� 5      $��Semester 05��6   $��Center=�62   $��25��6O   $��15(�5      $��1q�6"   $
��Bold"�6.   6B   5      �� 5        �� Orientation$ 
Horizontal=�6   $��5 30 5 5q�66   .+�5!      �� $	��400��6!   .+�5"      �� $ 
Horizontal=�6%   $
��5 10q�6>   .+�5#      �� $��First Name     :��6$   $��15(�6?   $	��105��6M   6[   �� 5$      $	��295��6&   ��62   �� *	FirstName+ �� UpdateSourceTrigger$ PropertyChanged=�6s   5%      �� 5&      $ 
Horizontal=�6%   $
��5 10q�6>   .+�5'      �� $��Last Name     :��6$   $��15(�6>   $	��105��6L   6Z   �� 5(      $	��295��6"   ��6.   �� *
LastName+$ PropertyChanged=�6n   5)      �� 5*      $ 
Horizontal=�6%   $
��5 10q�6>   .+�5+      �� $��Date Of Birth :��6$   $��15(�6>   $	��105��6L   6Z   �� 5,      $	��295��6"   ��6.   �� *DateOfBirth+$ PropertyChanged=�6q   5-      �� 5.      $ 
Horizontal=�6%   $
��5 10q�6>   .+�5/      �� $��Image:��6%   $��15(�66   $	��105��6D   ��6P   �� *UploadPhotoCommand+6y   �� 50      $��50��6$   $
��20 0q�6/   6?   51      53      �� 55      $	��400��6!   .+�56      �� $ 
Horizontal=�6%   $
��5 10q�6>   .+�57      �� $��Reg No        :��6$   $��15(�6>   $	��100��6L   6Z   �� 58      $	��300��6"   ��6.   �� *RegNo+$ PropertyChanged=�6k   59      �� 5:      $ 
Horizontal=�6%   $
��5 10q�6>   .+�5;      �� $��GPA             :��6$   $��15(�6@   $	��100��6N   6\   �� 5<      $	��300��6"   ��6.   �� *Gpa+$ PropertyChanged=�6i   5=      �� 5>      $ 
Horizontal=�6%   $
��5 10q�6>   .+�5?      �� $��Age             :��6$   $��15(�6@   $	��100��6N   6\   �� 5@      $	��300��6"   ��6.   �� *Age+$ PropertyChanged=�6i   5A      5C      5E      �� 5K      $ 
Horizontal=�6   $��5 30 5 5q�66   .+�5M      �� -   5        $��
backbutton��5N   4   $	��120��5M      $
��BACK��6)   $��18(�68   $��20 5 0 5q�6F   $��30��5N      $��2q�6(      
mainbutten#��[  5O      
�������5P      �� 5R      -   5        $��
savebutton��5S   1   $	��200��5R      $
��SAVE��6)   $��18(�68   $��160 2.5 160 2.5 q�6F   $��35��5S      $��2q�6%   #��[  5T      
���  ����5U      �� *SaveCommand+5V      �� 5X      -   5        $��
exitbutton��5Y   4   $	��120��5X      $
��EXIT��6)   $��18(�68   $��0 5 20 5q�6F   $��30��5Y      $��2q�6(   #��[  5Z      
�������5[      5^      5a      5d      5h      