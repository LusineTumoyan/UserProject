   M S B A M L   `   `   `  ����B  >UserWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:UserWPFUserWPF  5   	       UserWPF.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:UserWPF     5   	   X TXceed.Wpf.Toolkit, Version=3.4.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5   	     � Title$  
MainWindow��5	   	   $	��490��6   $	��940��6)    � 
ResizeMode$ CanMinimize=�65   .��5
      � .+�5   
    � -   5          �Name$ myPageFrame��5      $
��Left=�6%   $	��419��6@   $	��Top=�6M   $	��650��6e   $��	236,0,0,0q�6q   
�������  � NavigationUIVisibility$ Hidden=�6�   � 5   
   $
��Left=�6   $��71��6*   $	��Top=�66   $	��181��6N   $��	19,30,0,0q�6Z   .+�5      %  Xceed.Wpf.Toolkit.BusyIndicator  -   5          Name$ busyIndicator1��5   !      IsBusy .  $y�Hidden=�6H   $��70��6\   $��0,1,0,0q�6h   $
��Left=�6y   $	��181��6�   �� 5      -   5         ��Name$ mainDataButton��5      $��22(�6-   $��Get Data��6;   $��Center=�6N   $��Center=�6r   $
��Left=�6�   $��71��6�   $	��Top=�6�   $	��181��6�   5      � 5   
   $
��Left=�6   $��71��6*   $	��Top=�66   $	��181��6N   $��
19,180,0,0q�6Z   .+�5        -   5        $ busyIndicator2��5   !    .  $y�Hidden=�6H   $��70��6\   $��0,1,0,0q�6h   $
��Left=�6y   $	��181��6�   �� 5      -   5        $ mainClearButton��5      $��22(�6.   $��Clear��6<   {�.  $��Center=�6^   $��Center=�6�   $
��Left=�6�   $��71��6�   $	��Top=�6�   $	��181��6  5      � 5   
   $
��Left=�6   $��71��6*   $	��181��66   $	��Top=�6B   $��
19,330,0,0q�6Z   .+�5        -   5        $ busyIndicator3��5   !    .  $y�Hidden=�6H   $��71��6\   $��0,1,0,0q�6h   $
��Left=�6y   $	��181��6�   �� 5      -   5        $ mainAddDataButton��5      $��22(�60   $��Add Data��6>   $��Center=�6Q   $��Center=�6u   $��71��6�   $	��Top=�6�   $
��Left=�6�   $	��181��6�   5      5      5      