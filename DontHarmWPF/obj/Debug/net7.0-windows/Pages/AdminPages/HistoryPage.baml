   M S B A M L   `   `   `  ����F  BDontHarmWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:DontHarmWPF.Pages.AdminPagesDontHarmWPF.Pages.AdminPages  5      .    (DontHarmWPF.Pages.AdminPages.HistoryPage   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:DontHarmWPF.Pages.AdminPages     5        N� Title$!  История входов��5      $	��450��6   $	��800��6+   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�5      .+�5      �� $��Фильтрация:��6   �� 5      -   5         ��Name$ FilterComboBox��5      $	��200��5       �� DisplayMemberPath$ Login��5      5      �� 5      $��Сортировка��6   �� 5      -   5        $ SortComboBox��5      $	��150��5      5      5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ HistoryDataGrid��5!      $��1��5      $	��350��5         
IsReadOnly$
 True��5         AutoGenerateColumns$ False��5         CanUserSortColumns$ False��5       	   Columns	 5"      0  *System.Windows.Controls.DataGridTextColumn  5#      ,  &System.Windows.Controls.DataGridColumn
   Header$
 
Логин��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5$   %   �� *Employee.Login+  5%      $
 
Время��6%    5&   %   �� *	LogDate+  5'      $
 Ip-адрес��6%    5(   %   �� *Employee.IpAddress+  5)      $
 Успешный вход��6%    5*   %   �� *Successfully+5,      5-      5.      