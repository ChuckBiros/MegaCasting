   M S B A M L   `   `   `  ����J  FMegaCasting.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:MegaCasting.WPF.WindowsMegaCasting.WPF.Windows  5   	   0    *MegaCasting.WPF.Windows.WindowAddAnnouncer   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:MegaCasting.WPF.Windows     5   	   U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
   	     � Title$  WindowAddAnnouncer��5   	   $	��450��6$   $	��800��61    � WindowStyle$
 None=�5	   	      MaterialDesignBody#���   5   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	   .��5      �  � RowDefinitions 5   
   �� 5      $
��25pt �6   6,   �� 5      $��* �6   6)    � ColumnDefinitions 5   
   �� 5      $	��200 �6   6-   �� 5      $��* �6   6+   .+�5   
   � -   5        $��0��5      $��2��6   
��� ���.+�5      ��  �� Orientation$ 
Horizontal=�6   $��Right=�62   ��6N   Z� .+�5      �� -   5         ��Name$ buttonMinimize��5       0 ,MaterialDesignFloatingActionMiniAccentButton#��[ 5       $��25��5!      $��25��5"      $��Center=�5#      
���������5%      Z� ��5&      Z� .��5(      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=null]]   Kind$ WindowMinimize=�6.   5)      �� 5*      -   5        $ buttonMaximize��5*      #��[ 5+      $��25��5,      $��25��5-      $��Center=�5.      
���������50      Z� ��51      Z� .��53        $ WindowMaximize=�6.   54      �� 55      -   5        $ 
buttonExit��55      #��[ 56   !   $��25��57   !   $��25��58   !   $��Center=�59   !   
���������5;   !   Z� ��5<   !   Z� .��5>        $ CloseBox=�6.   5?      5@      5A      � 5B   
   -   5        $��0��5B      $��0��6   .+�5D      �� $ 
Horizontal=�6   $��Center=�62   .+�5E      �� $��Ajouter Annonceur :��5F      $��30��5G      $��Segoe UI)�5H   +   $��20(�5I      $
��Bold"�6#   ��5H      Z� 5M      5N      5O      � 5P   
   $��0��6   $��1��6    5Q      �� 5R      $��30 �6    6.   �� 5S      $��30 �6    6.   �� 5T      $��* �6    6-   .+�5W      �� $��0��6   $��0��6$   $��Nom :��61   $��Right=�6A   6_   �� 5X      $��0��6   $��1��6$   $��Identifiant :��61   $��Right=�6I   6g   5[      � 5\   
   $��1��6   $��1��6     5]      �� 5^      $��30 �6    6.   �� 5_      $��30 �6    6.   �� 5`      $��* �6    6-   .+�5c      �� -   5        	 ��Name$	 textBoxAddNom��5c      $��1��6-   $��0��6=   $��Center=�6K   ��6f   �� *SelectedProducer.Name+
 �� UpdateSourceTrigger$
 PropertyChanged=�6�   �� 5d      -   5        $	 	textBoxId��5d      $��1��6)   $��1��69   $��Center=�6G   ��6b   �� *SelectedProducer.UserName+$
 PropertyChanged=�6�   �� 5f      -   5        $ buttonAddAnnouncer��5j      $��1��5g      $��2��5h      $��5q�5i      
��� ���
���   �$	��Top=�5n      ��5l      Z� .��5q      � $	��100��6    5r      �� 5s      $��30 �6+   68   �� 5t      $��* �6+   67   .+�5w        $	 Add=�6.   
�������$��40��6L   $��25��6W   6e   �� 5x      $��1��6   $��Ajouter��6,   
�������6>   5y      5z      5{      5}      5~      