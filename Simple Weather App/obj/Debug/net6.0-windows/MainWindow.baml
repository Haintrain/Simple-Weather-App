   M S B A M L   `   `   `  ????M  ISimple Weather App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Simple_Weather_AppSimple_Weather_App  5   	   #    Simple_Weather_App.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Simple_Weather_App     5   	     ? Title$  
MainWindow??5   	   $	??450??6   $	??800??6)   ???#444444.??5
      ?  ? RowDefinitions 5   
   ?? 5      $??1* ?6   ?? 5      $??1* ?6   ?? 5      $??1* ?6   ?? 5      $??1* ?6    ? ColumnDefinitions 5   
   ?? 5      $??1* ?6   ?? 5      $??1* ?6   .+?5   
   ?? -   5         ??Name$ MainTextBox??5         MainTextBox#??[  6'   $??0??6L   $??1??6\   $??2??6i    ?? TextAlignment$ Center=?6}   .??6?   
Enter City6?   ?? 5   
   -   5         ??Name$ MainTextBlock??5        MainTextBlock#??[ 6+   $??0??6S   $??2??6c   $??2??6p    ?? TextAlignment$ Center=?6?   6?   ?? 5   
   -   5        
 ? Tag$ 1??5        
MainButton#??[ 62   $??3??6V   $??2??6c   .??6w   
Get Info6?   5      5      