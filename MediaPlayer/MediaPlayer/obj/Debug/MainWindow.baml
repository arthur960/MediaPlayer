   M S B A M L   `   `   `  ����F  BMediaPlayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:MediaPlayerMediaPlayer  5   	   f bTelerik.Windows.Controls, Version=2014.3.1021.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7uPclr-namespace:Telerik.Windows.Controls.Chromes;assembly=Telerik.Windows.Controls Telerik.Windows.Controls.Chromes 5          MediaPlayer.MainWindow   5   
   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      +localclr-namespace:MediaPlayer     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     62   +drawerLayoutusing:DrawerLayout     6o   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      dChromesPclr-namespace:Telerik.Windows.Controls.Chromes;assembly=Telerik.Windows.Controls     5      n jTelerik.Windows.Controls.Docking, Version=2014.3.1021.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7q mTelerik.Windows.Controls.Navigation, Version=2014.3.1021.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7Ctelerik1http://schemas.telerik.com/2008/xaml/presentation    6f   ��.    � Title$  MediaPlayer��5      $	��524��6   $	��288��6&    � 
ResizeMode$ NoResize=�62   ��5,      �� 5-   
    �� ImageSource$= 7D:\PCS\MediaPlayer\MediaPlayer\Resources\background.png��6   .��52      � $��0,0,0,5q�6    � ColumnDefinitions 53   
   �� 54      $	��39* �6   �� 55      $
��101* �6    � RowDefinitions 57   
   �� 58      $��40 �6   �� 59      $��40 �6   �� 5:      $	��20* �6   �� 5;      $
��197* �6   �� 5<      $	��49* �6   �� 5=      $	��39* �6   �� 5>      $
��105* �6   .+�5A   
   r� -   5         r�Name$ player��5A       r� LoadedBehavior$ Manual=�6'   $��63,20,140,20q�6?   $��1��6U   � 5C   
   $��0��6   $��2��6   .+�5D      �� -   5         ��Name$ Title��5D   3   $
��Left=�6   $��102,43,0,-43q�6B   $��Current Song��6X   5E      � 5G   
   $��6��6   $��2��6   $��	0,39,0,25q�60    5H      �� 5I      $	��39* �6#   �� 5J      �� 5K      $��40 �6#   �� 5L      $	��40* �6#   �� 5M      $	��41* �6#   �� 5N      $	��40* �6#   �� 5O      $	��41* �6#   �� 5P      $	��40* �6#   .+�5S      �� -   5         ��Name$ offsetSlider��5S      $��
0,-27,3,27q�6+   $	��200��6?   $��6��6K   $��1��6_   �� 5T      -   5        	 ��Name$	 button_back��5T      $��5,1,35,-1.4q�6*   $��1q�6?   
 J� RenderTransformOrigin$
 	-0.55,1.7&�6S   $��2��6u   $��2��6�    J� Opacity$	 0.8Q�6�   ��6�   Z� z�5U      V� 5V      .~�5W      �� �� 5X      �� 5Y       �� Angle$ -0.238Q�6*   T� 5Z      5[      ��5]      �� 5^      $B <D:\PCS\MediaPlayer\MediaPlayer\Resources\mediaButtons_01.png��6!   5`      �� 5a      -   5        $	 button_stop��5a      $��3��6*   $
 1.4,0.6&�6k   $��2��6�   $��13,1,26.8,-1.4q�6�   $	 0.9Q�6�   ��6T   Z� ��5b      �� 5c      $B <D:\PCS\MediaPlayer\MediaPlayer\Resources\mediaButtons_05.png��6!   5e      �� 5f      -   5        $	 button_forward��5f      $��5��6-   $��30.2,1,9.6,-1.4q�6=   $��2��6V   $	 0.8Q�6�   ��6j   Z� ��5g      �� 5h      $B <D:\PCS\MediaPlayer\MediaPlayer\Resources\mediaButtons_02.png��6!   5j      �� 5k      -   5        $	 
button_add��5k      $��40,-417,0,417q�6)   $��6��6@   $��2��6P   $	 0.6Q�6d   ��5l      �� 5m      $B <D:\PCS\MediaPlayer\MediaPlayer\Resources\mediaButtons_08.png��6!   5o      �� 5p      -   5        $	 button_repeat��5p      $��7��6,   $��0.4,1,-0.4,-1.4q�6<   $
 
1.025,0.55&�6q   $	 0.7Q�6�   ��6�   Z� ��5q      �� 5r      $B <D:\PCS\MediaPlayer\MediaPlayer\Resources\mediaButtons_07.png��6!   5t      �� 5u      -	   5        $	 button_shuffle��5u      $
 0.975,0.525&�6a   $��0,-1,0,0q�6�   $	 0.7Q�6�   $��2��6�   ��6-   Z� ��5v      �� 5w      $B <D:\PCS\MediaPlayer\MediaPlayer\Resources\mediaButtons_06.png��6!   5y      �� 5z      -
   5        $	 button_play��5z      $��4��6*   $
 
1.15,0.525&�6:   $
��Left=�6t   $��40��6�   $��2��6�   $��20,2,0,-2.4q�6�   ��6]   Z� ��5{      �� 5|      $B <D:\PCS\MediaPlayer\MediaPlayer\Resources\mediaButtons_04.png��6!   5~      �� 5      -   5        $	 button_list��5      $
��Left=�6*   $��
0,-417,0,0q�6E   $	��Top=�6Y   $��40��6q   $��40��6|   $��2��6�   ��5�      �� 5�      $I CD:\PCS\MediaPlayer\MediaPlayer\Resources\mediaButtonsIconSet_10.png��6!   5�      5�      �� 5�   
   $��2��6   $
 0.5,0.5&�6$   $��	45,1,40,7q�6D    � Cursor$
 Hand��6W   $��2��6e   $��1��6v   z�5�      V� 5�      .~�5�      �� �� 5�       �� AngleY$ 0.206Q�6$   �� 5�      T� 5�       T� Y$ 0.496Q�6)   5�      .��5�      �� $	��130��64   $	��238��6@   ��6   �� *Songs+��6M   Z� ��6c   Z� ��5�      �� 5�      .R�5�      �� 
������ ��6$   �� *Title+6;   5�      5�      5�      �� 5�   
   -   5        $ timer2��5�      $
��Left=�6$   $��4,10,0,0q�6?   $��6��6Q   $
��Wrap=�6^   $��00:00��6r   $	��Top=�6   $��16��6�   $��28��6�   {�.  6�   �� 5�   
   -   5         ��Name$ listbox��5�      $��2��6#   $
��Left=�67   $	��346��6R   $��	10,10,0,0q�6_   $	��Top=�6r   $	��211��6�   $��6��6�   $y�Hidden=�5�      �� 5�   
   -   5        $
 Time��5�      $��161,14,14,75q�6"   $��00:00��68   $
 0.214,0.562&�6E   $��1��6i   $��6��6y   {�.  6�   5�      5�      