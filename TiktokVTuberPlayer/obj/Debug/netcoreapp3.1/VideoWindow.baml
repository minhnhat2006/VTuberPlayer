   M S B A M L   `   `   `  ����M  ITiktokVTuberPlayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:TiktokVTuberPlayerTiktokVTuberPlayer  5   	   $    TiktokVTuberPlayer.VideoWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:TiktokVTuberPlayer     5   	     � Title$  VideoWindow��5   	   $	��450��6   $	��800��6*    � 	Resources 5	         Esc �� Text�� 5
   
   %3   &	        �� 5      $ Exit Fullscreen��6*   5       J� InputBindings 5      �� 5   
    �� Command# [  6   
 �� Key$	 Esc��64    J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command# [  5      68   .��5      � -   5         �Name$ gridRoot��5      $��0q�6   	 � RowDefinitions	 5   
   �� 5      $��* �6   .+�5   
   r� -   5        $��mePlayer��5   /   
 r� LoadedBehavior$
 Manual=�6   6/   5      5      