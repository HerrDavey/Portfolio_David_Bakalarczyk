   M S B A M L   `   `   `  ����P  LprostaPrzegladarkaWEB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:prostaPrzegladarkaWEBprostaPrzegladarkaWEB  5   	   &     prostaPrzegladarkaWEB.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:prostaPrzegladarkaWEB     5   	     � Title$  Prosta przegladarka www��5   	   $	��550��6)   $	��750��66   .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   o� $��0��6   $��0��6   .@�5      m� $
��Plik��6   .@�5      m� -   5        $��Zapisz jako��5      60   m� 5      -   5        $��Drukuj��5      6+   �� 5      m� 5      -   5        $��Wyjście��5      6,   5      m� 5      $��
Narzędzia��6   .@�5       m� -   5        $��Ramka��5        m� 	IsChecked .  m� IsCheckable . 6f   �� 5!      m� 5"      -   5        $��
Ustawienia��5"      6/   m� 5$      $��Rozmiar��6   .@�5%      m� -   5        $��
Zwiększ +��5%      62   m� 5&      -   5        $��
Zmniejsz -��5&      63   5'      �� 5)      m� 5+      -   5        $��O programie��5+       m� Icon 5,      �� 5-      $��rysunki/logo_fox.jpg��6    $��20��6>   $��20��6M    � ToolTip$ Informacje o programie��51   (   52      56      57      ]� 5:   
   $��0��6   $��1��6$   .+�5;      c� $	��Top=�6   .@�5<      �� -	   5         ��Name$ 	btnWstecz��5<      $��Wstecz��6,   $��25��6=   
����İ�$
��Left=�6e   $	��Top=�5=      $��55��61   6<   �� 5>      -
   5        $ btnDalej��5>      $��Dalej��6+   $��25��6;   
����İ�$
��Left=�6c   $	��Top=�5?      $��55��61   6<   �� 5@      �� 5B      -   5         ��Name$ txtAdres��5B      $
��Left=�6,   $��25��6G   	 �� TextWrapping$
	 Wrap=�6S   $��http://��5C      $	��Top=�6@   $	��400��6X   .��6g   
 � ContextMenu
 5D      �� 5E      .@�5F      m�  m� Command$ ApplicationCommands.Cut��6'   $��Wytnij tekst��6I   m� 5G      $ ApplicationCommands.Copy��6'   $��Skopiuj tekst��6J   m� 5H      $ ApplicationCommands.Paste��6'   $��Wklej tekst��6K   �� 5I      m� 5J      $��Dodaj do ulubionych��6'   .@�5K   "   m� -   5        $��
Do folderu��5K   +   6?   m� 5L   "   -   5        $��Do paska ulubionych��5L   +   6H   5M      5N      .��5O   +   5P      �� 5S      -   5        $ btnWejdz��5S      $��Wejdź��6+   $��25��6;   
����İ�$
��Left=�6c   $	��Top=�5T      $��50��61   6<   5U      �� 5W      -   5         ��Name$ brdRamka��5W      $��3q�6'   
����� �._�5X      (  "System.Windows.Controls.WebBrowser  -   5          Name$ wbPrzegladarka��5X      $	��Top=�5Y   D   $
��Left=�5Z   B   5[      5\      5b      5c      