   M S B A M L   `   `   `  ����   FaceAPI-WPF-Samples@    :Microsoft.ProjectOxford.Face.Controls.FaceVerificationPage   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     -     N�Name$  FaceVerificationPane��$	��360��$	��710�� N� FontSize$ 14(�.���  � ColumnDefinitions �� $	��300 ��� $	��110 ��� $	��300 � � RowDefinitions �� $��54 ��� $��45 ��� $	��132 ��� $��58 ��� $��22 ��� $��88 �.+��� $��0��$��0��$��3��$
��Left=�$
��Wrap=����� *FaceVerificationDescription+� $��0��$��2��$��4��.+���  K� ZIndex$	 999������ *LeftResultCollection+ �� ElementName$ FaceVerificationPane������ .R��� 
������ $��Center=�$��Center=����� *MaxImageSize+$ FaceVerificationPane������ *MaxImageSize+$ FaceVerificationPane������  �� 
TargetType" ��.���  �� Property �@��Left �� Value �� *Left+��  �@��Top �� *Top+���� .R��� ���	#FF26B8F4$��1������ *Width+���� *Height+�� -   	 ��Name$	 LeftImageDisplay��$��Center=�$��Center=�$��0,0,0,0q�$7��1/FaceAPI-WPF-Samples;component/Assets/default.jpg������ *MaxImageSize+$ FaceVerificationPane������ *MaxImageSize+$ FaceVerificationPane���� -   $��0��$��1��$��Choose Image��$��Center=�$	��Top=�$	��300��$��35�����#2196f3
�������
������ $��
0, 0, 0, 0q��� -   $��1��$��3��$��Verify��$��90��$��35�����#2196f3
�������
������ �� $��1��$��4��$��10,0,0,0q�$
��Left=�$	��Top=�$��Results:��$
��Wrap=��� $��1��$��5��$��10,0,0,0q�$
��Left=�$	��Top=�$
��Wrap=����� *VerifyResult+$ FaceVerificationPane��� $��2��$��2��$��4��.+��� $	 999������ *RightResultCollection+$ FaceVerificationPane������ .R��� 
������ $��Center=�$��Center=����� *MaxImageSize+$ FaceVerificationPane������ *MaxImageSize+$ FaceVerificationPane������ " ��.���  �@��Left �� *Left+��  �@��Top �� *Top+���� .R��� ���	#FF26B8F4$��1������ *Width+���� *Height+�� -   $	 RightImageDisplay��$��2��$��Center=�$��Center=�$��0,0,0,0q�$7��1/FaceAPI-WPF-Samples;component/Assets/default.jpg������ *MaxImageSize+$ FaceVerificationPane������ *MaxImageSize+$ FaceVerificationPane���� -   $��2��$��1��$��Choose Image��$��Center=�$	��Top=�$	��300��$��35�����#2196f3
�������
������ $��
0, 0, 0, 0q�