   M S B A M L   `   `   `  ���� B  >WpfApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp2WpfApp2      WpfApp2.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:WpfApp2       � Title$  
MainWindow��$	��800��$	��400�����#dbd4d4 � 	Resources  �� 
TargetType   
LEDButtons �� Property �� Value��%/   &	        �� " ��.���  � ��
 �����.����  �� Padding$ 10q�._��� .+��� -    ��Name$ onButton��$��On��$��Center=�$��15,15,15,15q�$	��Top=�$��80��$��80��$��30(�$
��Bold"�
�������$y�Visible=��� -   $ 	offButton��$	��Off��$��Center=�$��15,15,15,15q�$	��Top=�$��80��$��80��$��30(�$
��Bold"�
���  ��$y�	Collapsed=��� -    ��Name$ status��$��Center=�$��	23,23,0,0q�$
��Wrap=�$��Disconnected��$��25(�
�������$	��Top=�$��30���� -   $��CommPortNumber��$
��Left=�$��23��$��	20,16,0,0q� �� TextWrapping$
 Wrap=�$
��COM4��$	��Top=�$	��120��� 	 � ColumnDefinitions	 �� $��* ��� $��* �.+��� -   $ Connect��$��0��$��Connect��#��[  $
��Left=�$��	20,20,0,0q�$	��Top=�$	��155��$��35���� -   $ 
Disconnect��$��1��$��
Disconnect��#��[  $
��Left=�$��	20,20,0,0q�$	��Top=�$	��155��$��35��� 	 �� $��* ��� $��* ��� $��* �.+��� -   $
��Loop��$��4q�$��0��$
��Loop��$y�Visible=��� -   $��StopLooping��$��4q�$��0��$��Stop Looping��$y�	Collapsed=��� -	   $
��Blue��$��4q�$��1��$
��Blue���� $��4q�$��2��$��Refresh���� $��Pulse Properties��$
��Bold"�$
��0,10q��� $��Description���� $��2q�.��� 	 �� $��2* ��� $��1* �.+��� $��0��$��0,0,10,0q�.+��� $��Status��$
��Bold"�$
��0,10q��� {�.  ���#eeeeee$��2q��� $��1��.+��� $��Revision��$
��Bold"�$
��0,10q��� {�.  ���#eeeeee$��2q��� $��Part Number��$
��0,10q��� {�.  ���#eee
 �� Padding$
 2q��� $��Raw Material��$
��Bold"�$
��0,10q��� $��Material��$
��0,10q��� $��2q��� $��Manufacturing Information��$
��Bold"�$
��0,10q��� $��Work Centers��$��	0,10,0,10q�� 	 �� $��* ��� $��* �.+��� $��0��$��0,0,10,0q�.+��� $
��Weld���� $��Assembly���� $��Laser On���� $��Sinter���� $��1��$��	0,0,10,10q�.+��� $��Lathe���� $��Drill���� $
��Fold���� $	��Saw���� $��Length���� $��2q��� $��Length���� $��2q�{�.  �� $��Finish��$
��Bold"�$
��0,10q���  �� SelectedIndex$ 0��$��2q����� .R��� ���� *Finish+