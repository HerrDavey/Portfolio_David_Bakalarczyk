   M S B A M L   `   `   `  ����A  =Zad5_3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Zad5_3Zad5_3  5   	       Zad5_3.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Zad5_3     5   	     � Title$  
MainWindow��5   	   $	��250��6   $	��550��6)   .��5	      �  � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ 
rozmiarTxt��5       � Maximum$ 45Q�6%    � Value$ 25Q�62    � Minimum$ 10Q�6=   $��0��6J   $��1��6W   $��5q�6g   �� 5   
   -   5         ��Name$ kolorTxt��5      $��1��6%   $��1��65   $��5q�6B   .@�5      �� $��Black��6   �� 5      $��Purple��6   �� 5      $
��Blue��6   �� 5      $��Green��6   �� 5      $��Yellow��6   �� 5       $��Orange��6   �� 5!      $	��Red��6   5"      �� 5$   
   -   5         ��Name$ wprowadzanieTxt��5$      $�� ��6+   $��2��63   $��1��6@   $��5q�6P   �� 5&   
   $��Rozmiar tekstu:��6   $��0��6*   $��0��67   $��5q�6G   �� 5'   
   $��Kolor:��6   $��1��6!   $��0��6.   $��5q�6>   �� 5(   
   $��Podaj tekst:��6   $��2��6'   $��0��64   $��5q�6D   �� 5)   
   $��Ilość znaków:��6   $��3��6(   $��0��65   $��5q�6E   �� 5+   
   -   5        	 ��Name$	 	lenghtTxt��5+      $��1��6'   $��3��67   $��5q�6D   ��5,      �� 
 �� StringFormat$
  {0} znaków (znaki/znak)�� �� Path$ Text.Length� �� ElementName$ wprowadzanieTxt���� 5/   
   -   5        $	 Txt��5/      $��0��6   $��2��6/   $��4��6C   $��5q�6P   ��50      �� *Value+$ 
rozmiarTxt����51      �� *Text+$ wprowadzanieTxt�� �� UpdateSourceTrigger$ PropertyChanged=���52      �� *SelectedItem.Content+$ kolorTxt��55      56      