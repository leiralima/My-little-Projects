   M S B A M L   `   `   `  ����G  CContactsBook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:ContactsBookContactsBook  5   	       ContactsBook.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:ContactsBook     5   	   -   5          �Name$  Main1��5   	    � Title$ Main1��5   	   $	��450��6   $	��800��6$    � 
ResizeMode$ CanMinimize=�60   $��5,5,5,5q�6I   $��Stretch=�6Z   $��Stretch=�6x   .��5	      � -   5         �Name$ Grid1��5	      .+�5
   
   �� -   5         ��Name$ btnAdd��5
      $��_Add Contact��6!   $
��Left=�68   $��550,370,0,0q�6S   $	��Top=�6h   $��30��6�   $��90��6�   6�   �� 5   
   -   5        $ btnExit��5      $��_Exit��6"   $��30��6H   $	��Top=�6T   $
��Left=�6l   $��90��6�   $��670,370,0,0q�6�   �� 5   
   -   5        $ 
btnRefresh��5      $��_Refresh��6%   $
��Left=�68   $��425,370,0,0q�6S   $	��Top=�6h   $��30��6�   $��90��6�   6�   �� 5   
   -   5         ��Name$ MainList��5      $��Center=�6%   $	��344��6B   $��0,10,0,0q�6O   $	��Top=�6a   $	��780��6y    �� View 5      �� 5      -   5        Grid��.P�5      �� $
��Name��6%    �� Width$	 194��63    �� DisplayMemberBinding 6?   �� *Name+�� 5      $��Phone��6%   $	 194��64    6@   �� *Phone+�� 5      $��Email��6%   $	 194��64    6@   �� *Email+�� 5      $��ID��6%   $	 194��61    6=   �� *ID+5      	 � ContextMenu	 5      �� 5      .@�5      m� -   5        $
��Edit��5      6-   m� 5      -	   5        $��Detele��5      6/   5      5      5      5      