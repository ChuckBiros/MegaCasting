   M S B A M L   `   `   `  ����J  FMegaCasting.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:MegaCasting.WPFMegaCasting.WPF  5   	   =#clr-namespace:MegaCasting.WPF.ViewsMegaCasting.WPF.Views  5   	        MegaCasting.WPF.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:MegaCasting.WPF     5   	   5views#clr-namespace:MegaCasting.WPF.Views     5   	   U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  MegaCasting��5	   	   $	��550��5
   	   $
��1050��5   	   $	��550��5   	   $
��1050��5   	    � 
ResizeMode$ CanResizeWithGrip=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	      MaterialDesignBody#���   5   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	   .��5      �  � RowDefinitions 5   
   �� 5      $
��25pt �6   6,   �� 5      $��* �6   6)    � ColumnDefinitions 5    
   �� 5!      $	��200 �6   6-   �� 5"      $��* �6   6+   .+�5%   
   � -   5        $��0��5%      $��2��6   
��� E��.+�5&      ��  �� Orientation$ 
Horizontal=�6   $��Right=�62   ��6N   Z� .+�5'      �� -   5        	 ��Name$	 buttonMinimize��5'       0 ,MaterialDesignFloatingActionMiniAccentButton#��[ 5(      $��25��5)      $��25��5*      $��Center=�5+      
���������5-      Z� ��5.      Z� .��50      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=null]]
   Kind$
 WindowMinimize=�6.   51      �� 52      -   5        $	 buttonMaximize��52      #��[ 53      $��25��54      $��25��55      $��Center=�56      
���������58      Z� ��59      Z� .��5;        $
 WindowMaximize=�6.   5<      �� 5=      -   5        $	 
buttonExit��5=      #��[ 5>   !   $��25��5?   !   $��25��5@   !   $��Center=�5A   !   
���������5C   !   Z� ��5D   !   Z� .��5F        $
 CloseBox=�6.   5G      5H      5I      � 5J   
   $��1��6   $��0��6   
��� E��.+�5K      �� $ Vertical=�6   .+�5L      �� -   5        $	 buttonAnnouncer��5N      $��3,6,3,3q�5M      
��� ���
���   �$	��Top=�5R      ��5P      Z� .��5U      � $	��200��6    5V      �� 5W      $��30 �6/   6<   �� 5X      $��* �6/   6;   .+�5[        $
 Announcement=�62   
�������$��40��6Y   $��25��6d   6r   �� 5\      $��1��6    $��
Annonceurs��60   
�������6E   5]      5^      �� 5_      -   5        $	 buttonOffers��5a      $��3q�5`      
��� ���
���   �$	��Top=�5e      ��5c      Z� .��5h      � $	��200��6    5i      �� 5j      $��30 �6/   6<   �� 5k      $��* �6/   6;   .+�5n        $
 
LocalOffer=�62   
�������$��40��6W   $��25��6b   6p   �� 5o      $��1��6    $��Offres��60   
�������6A   5p      5q      �� 5r      -   5        $	 buttonContactType��5t      $��3q�5s      
��� ���
���   �$	��Top=�5x      ��5v      Z� .��5{      � $	��200��6    5|      �� 5}      $��30 �6/   6<   �� 5~      $��* �6/   6;   .+�5�        $
 Paper=�62   
�������$��40��6R   $��25��6]   6k   �� 5�      $��1��6    $��Types de contrats��60   
�������6L   5�      5�      5�      5�      � 5�   
   -   5        $��0��5�      $��0��6   .+�5�      �� $ 
Horizontal=�6   $��Center=�62   .+�5�      �� $��Megacasting��5�      $��30��5�      $��Segoe UI)�5�   +   $��20(�5�      $
��Bold"�6#   ��5�      Z� 5�      5�      5�      ]� 5�   
   -	   5         ]�Name$ dockPanelMain��5�      $��1��5�      $��1��5�      .+�5�      $   MegaCasting.WPF.Views.ViewMain  5�      5�      5�      