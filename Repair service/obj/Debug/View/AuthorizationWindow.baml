   M S B A M L   `   `   `  ����I  ERepair service, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Repair_service.ViewRepair_service.View  5   	   C&clr-namespace:Repair_service.ViewModelRepair_service.ViewModel  69   -    'Repair_service.View.AuthorizationWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:Repair_service.View     5   	   <	viewmodel&clr-namespace:Repair_service.ViewModel     69     � Title$  Авторизация��5   	   $	��400��6   $	��300��6*    � 
ResizeMode$ NoResize=�66    � WindowStartupLocation$ CenterScreen=�6L   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��0,2* �6   �� 5      $
��0,4* �6   �� 5      $
��0,3* �6   �� 5      $
��0,3* �6   �� 5      $
��0,3* �6   .+�5   
   �� $��0��6   $��25(�6   $	��Top=�6+   $��Center=�5      $��0,10,0,0q�6-   .��6?   Авторизация6L   �� 5   
   $��1��6   $��60(�6   $��Center=�6+   $��Center=�6F   .��6c   	🛠️6h   � 5   
   $��2��6    � ColumnDefinitions 5      �� 5      $
��0.3* �6#   �� 5      $
��0.7* �6#   .+�5      �� $��0��6   $��Center=�5      $��30,0,0,0q�6+   .��6=   Логин:6E   �� 5      -   5         ��Name$ loginTxtBox��5      $��Center=�5      $��1��5      $��
0,20,20,20q�6!   ��5   +   �� *Login+5   7   5      � 5!   
   $��3��6    5"      �� 5#      $
��0.3* �6#   �� 5$      $
��0.7* �6#   .+�5&      �� $��0��6   $��Center=�5'      $��30,0,0,0q�6+   .��6=   Пароль:6F   �� 5(      -   5        $ passwordTxtBox��5(      $��Center=�5)      $��1��5*      $��
0,20,20,20q�6!   ��5(   .   �� *
Password+5*   7   5+      �� 5-   
   -   5         ��Name$ AuthorizateBtn��5-      $��4��5.      $��70,20,70,20q�6   .��6P   
Войти6W   50      51      