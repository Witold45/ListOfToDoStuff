   M S B A M L   `   `   `  ����E  ATo_Do_List, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:To_Do_List
To_Do_List  5          To_Do_List.MainPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:To_Do_List     5        N� Title$  MainPage��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $��5* �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $	��10* �6   �� 5      $��1* �6   .+�5   
   �� -   5         ��Name$ listBoxDataSource��5       �� View 5      �� 5      .P�5      �� $��Id��6%    �� Width$
 Auto��6U    �� DisplayMemberBinding 61   �� *Id+6U   �� 5      $��Title��6%   $
 Auto��6[    64   �� *Title+6[   �� 5      $
��Time��6%   $
 Auto��63    �� CellTemplate 5      �� 5      .R�5   "   �� ��6,   �� *Date+5      5!      �� 5"      $��
Multiplier��6%   $
 Auto��6e    69   �� *
Multiplier+6e   �� 5#      $��Prior��6%   $
 Auto��6[    64   �� *Prior+6[   5$      5&      �� 5'   
   -   5         ��Name$ mainPageTextBox��5'      $��1��6+   $
��0, 3q�68   6H   �� 5*   
   $��1��6   .+�5+      �� -   5        	 ��Name$	 mainPagePlusButton��5+      $��20��61   $��12, 0, 12, 5q�6=   .��6t   +6w   �� 5,      -   5        $	 mainPageMinusButton��5,      $��20��62   $��12, 5q�6>   .��6o   -6r   5-      5/      50      