   M S B A M L   `   `   `  ����  FaceAPI-WPF-Samples@    :Microsoft.ProjectOxford.Face.Controls.FaceVerificationPage   5#      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5$      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5%      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5&      @d2http://schemas.microsoft.com/expression/blend/2008     5'      -   5          N�Name$  FaceVerificationPane��5)   a   $	��360��67   $	��710��6G    N� FontSize$ 14(�6S   .��5*      �  � ColumnDefinitions 5+   
   �� 5,      $	��300 �6   �� 5-      $	��110 �6   �� 5.      $	��300 �6    � RowDefinitions 50   
   �� 51      $��54 �6   �� 52      $��45 �6   �� 53      $	��132 �6   �� 54      $��58 �6   �� 55      $��22 �6   �� 56      $��88 �6   .+�58   
   �� $��0��6   $��0��6!   $��3��61   $
��Left=�6E   $
��Wrap=�6�   ��6`   �� *FaceVerificationDescription+6�   � 59   
   $��0��6   $��2��6   $��4��6,   .+�5:      ��  K� ZIndex$	 999��6j   ��6   �� *LeftResultCollection+ �� ElementName$ FaceVerificationPane����5;      �� 5<      .R�5=      �� 
������ $��Center=�6:   $��Center=�6W   ��6r   �� *MaxImageSize+$ FaceVerificationPane����6�   �� *MaxImageSize+$ FaceVerificationPane��5>      ��5@      �� 5A       �� 
TargetType" ��6   .�5B      ��  �� Property �@��Left �� Value 68   �� *Left+�� 5C       �@��Top 67   �� *Top+5D      ��5F      �� 5G      .R�5H      �� ���	#FF26B8F4$��1��6i   ��6$   �� *Width+��6<   �� *Height+6i   5I      5K      �� 5L      -   5        	 ��Name$	 LeftImageDisplay��5L      $��Center=�6�   $��Center=�6�   $��0,0,0,0q�6�   $7��1/FaceAPI-WPF-Samples;component/Assets/default.jpg��6�   ��6.   �� *MaxImageSize+$ FaceVerificationPane����6p   �� *MaxImageSize+$ FaceVerificationPane��6�   5M      �� 5N   
   -   5        $��0��5N      $��1��6!   $��Choose Image��6.   $��Center=�6E   $	��Top=�6b   $	��300��6{   $��35��6�   ���#2196f3
�������
������ $��
0, 0, 0, 0q�6�   6�   �� 5O   
   -   5        $��1��5O      $��3��6!   $��Verify��6.   $��90��6?   $��35��6J   ���#2196f3
�������
������ 6�   �� 5P   
   $��1��6   $��4��6$   $��10,0,0,0q�61   $
��Left=�6C   $	��Top=�6^   $��Results:��6v   $
��Wrap=�6�   �� 5Q   
   $��1��6   $��5��6$   $��10,0,0,0q�61   $
��Left=�6C   $	��Top=�6^   $
��Wrap=�6�   ��6v   �� *VerifyResult+$ FaceVerificationPane��6�   � 5R   
   $��2��6   $��2��6   $��4��6,   .+�5S      �� $	 999��6k   ��6   �� *RightResultCollection+$ FaceVerificationPane����5T      �� 5U      .R�5V      �� 
������ $��Center=�6:   $��Center=�6W   ��6r   �� *MaxImageSize+$ FaceVerificationPane����6�   �� *MaxImageSize+$ FaceVerificationPane��5W      ��5Y      �� 5Z      " ��6   .�5[      ��  �@��Left 68   �� *Left+�� 5\       �@��Top 67   �� *Top+5]      ��5_      �� 5`      .R�5a      �� ���	#FF26B8F4$��1��6i   ��6$   �� *Width+��6<   �� *Height+6i   5b      5d      �� 5e      -   5        $	 RightImageDisplay��5e   $   $��2��6   $��Center=�6�   $��Center=�6�   $��0,0,0,0q�6�   $7��1/FaceAPI-WPF-Samples;component/Assets/default.jpg��6  ��6?   �� *MaxImageSize+$ FaceVerificationPane����6�   �� *MaxImageSize+$ FaceVerificationPane��6  5f      �� 5g   
   -   5        $��2��5g      $��1��6!   $��Choose Image��6.   $��Center=�6E   $	��Top=�6b   $	��300��6z   $��35��6�   ���#2196f3
�������
������ $��
0, 0, 0, 0q�6�   6�   5h      5i      