   M S B A M L   `   `   `  ����C  ?Racegame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:RacegameRacegame  5   	       Racegame.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Racegame     5   	     � WindowState$  	Maximized=�5   	    � Title$ 
MainWindow��5	   	   $
��1080��6   $
��1920��6*    � 	Resources 5       �� Source�� 5   
   $ Styles.xaml?�6   %    64   .��5      � -   5        $��mainGrid��5      ���#1f1f1f � RowDefinitions 5   
   �� 5      $	��116 �6   �� 5      $	��158 �6   �� 5      6    � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $��1��6   $��2��6    $��Center=�64   $	��110��6Q   $��0,31,0,0q�6^   $	��Top=�6p   $	��430��6�   $��/sammyRacing text.png��6�   $��2��6�   �� 5   
   -   5         ��Name$ 
fadingLogo��5      $
��Left=�6$   $	��488��6?   $��	265,0,0,0q�6L   $��Center=�6_   $	��642��6z   $��	/logo.png��6�   $��1��6�   $��2��6�   $��2��6�    � Triggers 5       :� 5!       :� RoutedEvent$ Loaded��6   .[�5"      �� .��5#      �� -   5        .��5$      W� 	 �� 
TargetName$	 
fadingLogo��5%      
 �� TargetProperty$
 Opacity�5&       W� From 1.05'      	 W� To 0.05(       g� Duration$ 0:0:2D�5)      5*      5+      5,      5.      �� 5/   
   -   5        $��0��5/      $��	Hoofdmenu��6!      ButtonStyle#��[  6J   $��
54,30,10,4q�6o   $��1��6�   �� 50   
   -   5        $��1��50      $��
Informatie��6!   #��[  6L   $��
10,30,10,4q�6q   $��1��6�   �� 51   
   -   5        $��2��51      $��Instellingen��6!   #��[  6N   $��
10,30,10,4q�6s   $��1��6�   �� 52   
   -   5        $��3��52      $��	Afsluiten��6!   #��[  6K   $��
10,30,54,4q�6p   $��1��6�    � 54   
   -   5          �Name$ 	testFrame��54      $��54,16,54,31q�6#   $��4��68    J� RenderTransformOrigin$ 0.5,0.5&�6L   $��2��6l     � NavigationUIVisibility$ Hidden=�6y   ���#ffb34f$��0q�6�   $��Stretch=�6�   $��Stretch=�6�   55      56      