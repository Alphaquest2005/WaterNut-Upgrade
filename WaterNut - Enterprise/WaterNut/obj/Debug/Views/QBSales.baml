   M S B A M L   `   `   `  ����C  ?WaterNut, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulli9clr-namespace:WaterNut.QuerySpace.QuickBooksQS.ViewModels+WaterNut.QuerySpace.QuickBooksQS.ViewModels  5      #clr-namespace:WaterNutWaterNut  5      9!clr-namespace:WaterNut.ConvertersWaterNut.Converters  5          WaterNut.Views.QBSales   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/Expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      HQS9clr-namespace:WaterNut.QuerySpace.QuickBooksQS.ViewModels     5      (localclr-namespace:WaterNut     5      8
Converters!clr-namespace:WaterNut.Converters     5        � 	Resources  5      �� 5   
    �� Member$ QS:QBSalesModel.Instance��6      KeyQBSalesModelDataSource  65   *   $WaterNut.Converters.NotBoolConverter  5   
   NotBoolConverter  6&   .��5      � -   5         �Name$ 
LayoutRoot��5       � DataContext 6   ��   QBSalesModelDataSource �� Source# [ .+�5   
   �� $��Right=�6   $��32.766��60   $��0,14.011,234.383,0q�6@   $
��Wrap=�6\   $	��Top=�6p   $��396.779��6�   $��21.333(�6�   $��Download QuickBooks Sales��6�   �� 5   
   $
��Left=�6   $��19.866��6/   $��10,89.683,0,0q�6?   $
��Wrap=�6V   $	��Top=�6j   $��70.647��6�   $��16(�6�   $
��From��6�    �� TextAlignment$ Center=�6�   �� 5   
   -   5        $
��Left=�5      $��26��6/   $��359.057,138.567,0,0q�6;   $
��Wrap=�6X   $��Import Date Range��6l   $	��Top=�6�   $��138.853��6�   $��16(�6�     TextButtonStyle#���  6�   $ Right=�6�   6�   (  "System.Windows.Controls.DatePicker  5   
   $
��Left=�6^   $��28��6y   $��85.647,89.683,0,0q�6�   $	��Top=�6�   $��192.806��6�      SelectedDate 6   �� *	StartDate+ �� UpdateSourceTrigger$ PropertyChanged=�6�     5   
   $
��Left=�6\   $��28��6w   $��85.647,136.567,0,0q�6�   $	��Top=�6�   $��192.806��6�    6   �� *	EndDate+$ PropertyChanged=�6�   �� 5   
   $
��Left=�6   $��19.866��6/   $��8.838,136.567,0,0q�6?   $
��Wrap=�6Z   $	��Top=�6n   $��70.647��6�   $��16(�6�   $��To��6�   $ Center=�6�   �� 5   
   $
��Left=�6   $��22��6.   $��
86,212,0,0q�6:   $	��Top=�6N   $	��113��6f   $��Import Inventory��6r    d� 	IsChecked 6�   �� *ImportInventory+$ PropertyChanged=��� 5   
   $
��Left=�6   $��22��6.   $��
86,185,0,0q�6:   $	��Top=�6N   $	��113��6f   $��Import Sales��6r    6�   �� *ImportSales+$ PropertyChanged=�5      5      