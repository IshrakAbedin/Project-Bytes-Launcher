   M S B A M L   `   `   `  ���� Q  MProject Bytes Launcher, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:Project_Bytes_LauncherProject_Bytes_Launcher  '    !Project_Bytes_Launcher.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6local$clr-namespace:Project_Bytes_Launcher     -     �Name$  MainWindow1�� � Title$ Project Bytes Launcher��$	��540��$��960         �� � UseLayoutRounding .  $	��960��$	��540��$	��960��$	��540��$��Disabled=� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=� � Icon$? 9/Project Bytes Launcher;component/Images/LauncherIcon.png�� � WindowStyle$
 None=�����  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.��� 	 � Color$	 Black��
 � Offset$
 0Q�� $	 White��$
 1Q�.��� -   ����  �� ImageSource$= 7/Project Bytes Launcher;component/Images/LauncherBG.png��.+��� -    ��Name$ AnimationImageBox��$��0,0,0,0q�$D��>/Project Bytes Launcher;component/Images/LauncherAnimation.png��$��Center=�$��Center=�$
��Fill=� � Triggers :�  :� RoutedEvent$ Loaded��.[��� .���� .��W�  g� RepeatBehavior$ Forever�� �� TargetProperty$ Opacity�	 W� To$
 0.20X� g� Duration$ 0:0:0.82D� g� AutoReverse . �� -    ��Name$ 
PlayButton��$
��Play��$��746,0,37,29q�
������� J� Opacity$	 0.8Q� J� RenderTransformOrigin$ 0.5,0.5&�$��75��$��Rockwell)�$
��Bold"�$��36(� � Cursor$
 Hand��$��Bottom=���Z� z�V� .~��� ��  �� AngleX$	 -12Q��� T�  J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect  ���� $ 0.5,1&�$ 0.5,0&�.��� $	 	#FF1F329F��$
 0Q�� $	 	#FF0A1554��$
 1Q��� -   $ 
QuitButton��$
��Quit��$��37,0,745.6,29q�
�������$	 0.8Q�$ 0.5,0.5&�$��Rockwell)�$
��Bold"�$��36(�$��75��$��Bottom=�$
 Hand����Z� z�V� .~��� �� $	 -12Q��� T�    ���� $ 0.5,1&�$ 0.5,0&�.��� $	 	#FF9F1F1F��$
 0Q�� $	 	#FF400707��$
 1Q��� -   $ AboutButton��$��?��$��44,32,852.6,0q�
�������$	 0.8Q�$ 0.5,0.5&�$��Rockwell)�$
��Bold"�$��36(�$
 Hand��$��45��$	��Top=���Z� z�V� .~��� �� $	 -12Q��� T�    ���� $ 0.5,1&�$ 0.5,0&�.��� $	 	#FF1F9F21��$
 0Q�� $	 	#FF0F4007��$
 1Q��� -   $ 
HelpButton��$��!��$��116,32,780.6,0q�
�������$	 0.8Q�$ 0.5,0.5&�$��Rockwell)�$
��Bold"�$��36(�$
 Hand��$��45��$	��Top=���Z� z�V� .~��� �� $	 -12Q��� T�    ���� $ 0.5,1&�$ 0.5,0&�.��� $	 	#FFEDFF1C��$
 0Q�� $	 	#FF403E07��$
 1Q��� -   $ AudioButton��$��195,37,725.6,0q�$	 0.8Q�$ 0.5,0.5&�$��Rockwell)�$
��Bold"�$��36(�$
 Hand��$��35��$	��Top=���Z� ��Z� z�V� .~��� �� $	 -12Q��� T�    ���� $> 8/Project Bytes Launcher;component/Images/AudioOnIcon.png��