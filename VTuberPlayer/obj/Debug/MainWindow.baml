   M S B A M L   `   `   `  ����G  CVTuberPlayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:VTuberPlayerVTuberPlayer  5   	       VTuberPlayer.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:VTuberPlayer     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5	         Esc �� Text�� 5
   
   %3   &	        �� 5      $ Exit Fullscreen��6*   5       J� InputBindings 5      �� 5   
    �� Command# [  6   
 �� Key$	 Esc��64    J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command# [  5      68   .��5      � -   5         �Name$ gridRoot��5      $��10q�6   	 � RowDefinitions	 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   r� -   5        $��mePlayer��5   /   
 r� LoadedBehavior$
 Manual=�6   6/   �� 5   
   $��1��6   .+�5      �� -   5        $��	lblStatus��5      $��Not playing...��6%   $��Center=�6>   $��5q�6b   � 5      $��Center=�6   .+�5      �� -   5        $��btnPlay��5      .��6>   Play6D   �� 5      -   5        $��btnPause��5      $	��5,0q�6)   .��6M   Pause6T   �� 5       -   5        $��btnStop��5       .��6>   Stop6D   �� 5!      -   5        $��btnFullscreen��5!      .��6K   Full Screen6X   5"      5#      �� 5$   
   $��2��6   .+�5%      � $��Center=�6   .+�5&      �� -	   5        $��btnAnimation1��5&      .��6D   Anim16K   5'      5(      5)      5*      