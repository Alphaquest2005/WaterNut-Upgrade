   M S B A M L   `   `   `  ����C  ?WaterNut, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullm;clr-namespace:WaterNut.QuerySpace.CounterPointQS.ViewModels-WaterNut.QuerySpace.CounterPointQS.ViewModels  5      #clr-namespace:WaterNutWaterNut  5      9!clr-namespace:WaterNut.ConvertersWaterNut.Converters  5      I ECore.Common.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullmGclr-namespace:Core.Common.UI.DataVirtualization;assembly=Core.Common.UI!Core.Common.UI.DataVirtualization 5	          WaterNut.Views.CPSales   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/Expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      JQS;clr-namespace:WaterNut.QuerySpace.CounterPointQS.ViewModels     5      (localclr-namespace:WaterNut     5      8
Converters!clr-namespace:WaterNut.Converters     5      fdataVirtualizationGclr-namespace:Core.Common.UI.DataVirtualization;assembly=Core.Common.UI     5	      $��596.401��5   8     � 	Resources  5      �� 5   
    �� Member$ QS:CPSalesModel.Instance��6      KeyCPSalesModelDataSource  65   �� 5   
    �� 
TargetType" ��6   .�5      �� ;  5Core.Common.UI.DataVirtualization.VirtualListItemBase �� Property �@ AutoLoad �� Value . 6P   5      *   $WaterNut.Converters.NotBoolConverter  5      NotBoolConverter  6    �� 5      &"CounterPointPurchaseOrdersTemplate  .R�5      � $
��39.2��6
   $	��492��6   {�6$   �� *Data.Downloaded+  NotBoolConverter �� 	Converter# [  �� Mode$ OneWay=�.+�5      �� $��112,6,180,6q�67   ��6   �� *	Data.Date+67   �� 5      -   5        $��398,6,76,10.2q�5   N    d� 	IsChecked 6   �� *Data.Downloaded+$ OneWay=�6e   �� 5      $��317,5.2,109.98,10q�6=   ��6   �� *Data.LineNumber+6=   �� 5      $��10,5.2,368.4,6q�6<   ��6   �� *Data.InvoiceNo+6<   �� 5       ��Name$ DownloadTxt��6   -   5        $��Download��5   %   $��421,5,10,10.2q�65     TextButtonStyle#���  6L   6v   5      5      .��5      � -   5        	 �Name$	 
LayoutRoot��5      
 � DataContext
 6   ��   CPSalesModelDataSource �� Source# [ .+�5      �� $
��Left=�6   $��32.766��6)   $��8.838,14.011,0,0q�69   $
��Wrap=�6S   $	��Top=�6g   $��396.779��6   $��21.333(�6�   $��Counter Point Sales��6�   �� 5    
   -   5         ��Name$ SalesGrd��5       $��Stretch=�6$   $	��335��6B   $��	0,145,0,0q�6O   $	��Top=�6b   $
��Auto��6z    & "CounterPointPurchaseOrdersTemplate#���  6�     AlphaListBoxStyle#���  5!   =   ��6   �� *CounterPointSales+6=   �� 5"      $
��Left=�6   $��33��6)   $��	10,52,0,0q�65   $
��Wrap=�6H   $	��Top=�6\   $	��154��6t   $��16(�6�   $��Invoice Number��6�    �� TextAlignment$ Center=�6�   �� 5#      $
��Left=�6   $��33��6)   $��197.44,52,0,0q�65   $
��Wrap=�6L   $	��Top=�6`   $��236.617��6x   $��16(�6�   $��Sales Dates��6�   $ Center=�6�   �� 5$   
   -   5        ���	#7FFFFFFF$
��Left=�5$   v   $��33��6�   $��	10,85,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��154��6�   $��16(�6�    �� TextAlignment$ Center=�6�     TransparentTextBoxStyle#���  6  ��6   �� *InvoiceNoFilter+$ TwoWay=� �� UpdateSourceTrigger$ Explicit=�6A  �� 5%      -   5        $
��Left=�5%      $��26��6)   $��439.057,92,0,0q�65   $
��Wrap=�6M   $��Import Date Range��6a   $	��Top=�6z   $��138.853��6�   $��16(�6�   #���  6�   $ Right=�6�   6�   (  "System.Windows.Controls.DatePicker  5&      $
��Left=�6]   $��28��6x   $��
199,90,0,0q�6�   $	��Top=�6�   $	��114��6�      SelectedDate 6   �� *StartDateFilter+$ PropertyChanged=�6�     5'      $
��Left=�6[   $��28��6v   $��
318,90,0,0q�6�   $	��Top=�6�   $	��114��6�    6   �� *EndDateFilter+$ PropertyChanged=�6�   5(      5)      