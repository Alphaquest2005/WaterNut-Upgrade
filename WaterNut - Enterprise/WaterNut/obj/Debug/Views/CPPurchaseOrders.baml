   M S B A M L   `   `   `  ����C  ?WaterNut, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullm;clr-namespace:WaterNut.QuerySpace.CounterPointQS.ViewModels-WaterNut.QuerySpace.CounterPointQS.ViewModels  5      #clr-namespace:WaterNutWaterNut  5      9!clr-namespace:WaterNut.ConvertersWaterNut.Converters  5	      I ECore.Common.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullmGclr-namespace:Core.Common.UI.DataVirtualization;assembly=Core.Common.UI!Core.Common.UI.DataVirtualization 5
      %    WaterNut.Views.CPPurchaseOrders   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/Expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      JQS;clr-namespace:WaterNut.QuerySpace.CounterPointQS.ViewModels     5      (localclr-namespace:WaterNut     5      8
converters!clr-namespace:WaterNut.Converters     5	      fdataVirtualizationGclr-namespace:Core.Common.UI.DataVirtualization;assembly=Core.Common.UI     5
        � 	Resources  5      �� 5   
    �� Member$' !QS:CPPurchaseOrdersModel.Instance��6      Key#CPPurchaseOrdersModelDataSource  6>   �� 5   
    �� 
TargetType" ��6   .�5      �� ;  5Core.Common.UI.DataVirtualization.VirtualListItemBase �� Property �@ AutoLoad �� Value . 6P   5      *   $WaterNut.Converters.NotBoolConverter  5   
   NotBoolConverter  6&   �� 5   
   &"CounterPointPurchaseOrdersTemplate  .R�5      � $
��39.2��6   $	��492��6!   {�6-   �� *Data.Downloaded+  NotBoolConverter �� 	Converter# [  �� Mode$ OneWay=�.+�5      �� $��112,6,180,6q�67   ��6   �� *	Data.Date+67   �� 5      -   5        $��398,6,76,10.2q�5   A    d� 	IsChecked 6   �� *Data.Downloaded+6X   �� 5      $��317,5.2,109.98,10q�6=   ��6   �� *Data.LineNumber+6=   �� 5      $��10,5.2,368.4,6q�6B   ��6   �� *Data.PurchaseOrderNo+6B   �� 5       ��Name$ DownloadTxt��6   -   5        $��Download��5   1   $��421,5,10,10.2q�6A     TextButtonStyle#���  6X   6�   5      5      .��5      � -   5        	 �Name$	 
LayoutRoot��5      
 � DataContext
 6   ��  # CPPurchaseOrdersModelDataSource �� Source# [ .+�5    
   �� $
��Left=�6   $��33��6/   $��9,14,0,0q�6;   $
��Wrap=�6M   $	��Top=�6a   $	��304��6y   $��21.333(�6�   $#��Counter Point Purchase Orders��6�   �� 5!   
   -   5         ��Name$ CPOGrd��5!      $��Stretch=�6"   $	��335��6@   $��	0,145,0,0q�6M   $	��Top=�6`   $
��Auto��6x    & "CounterPointPurchaseOrdersTemplate#���  6�     AlphaListBoxStyle#���  5"   ;   ��6   �� *CounterPointPOs+6;   �� 5#   
   $
��Left=�6   $��33��6/   $��	10,52,0,0q�6;   $
��Wrap=�6N   $	��Top=�6b   $	��154��6z   $��16(�6�   $��	PO Number��6�    �� TextAlignment$ Center=�6�   �� 5$   
   $
��Left=�6   $��33��6/   $��
196,52,0,0q�6;   $
��Wrap=�6O   $	��Top=�6c   $	��237��6{   $��16(�6�   $��
Order Date��6�   $ Center=�6�   �� 5%   
   -   5        ���	#7FFFFFFF$
��Left=�5%   |   $��33��6�   $��	10,85,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��154��6�   $��16(�6�    �� TextAlignment$ Center=�6�     TransparentTextBoxStyle#���  6  ��6   �� *PurchaseOrderNoFilter+$ TwoWay=� �� UpdateSourceTrigger$ Explicit=�6F  �� 5&   
   -   5        $
��Left=�5&      $��26��6/   $��454,114,0,0q�6;   $
��Wrap=�6P   $��View All��6d   $	��Top=�6t   $��75��6�   $��16(�6�   #���  6�   $ Right=�6�   6�   (  "System.Windows.Controls.DatePicker  5'   
   $
��Left=�6c   $��28��6~   $��
199,90,0,0q�6�   $	��Top=�6�   $	��114��6�      SelectedDate 6   �� *StartDateFilter+$ PropertyChanged=�6�     5(   
   $
��Left=�6a   $��28��6|   $��
318,90,0,0q�6�   $	��Top=�6�   $	��114��6�    6   �� *EndDateFilter+$ PropertyChanged=�6�   �� 5)   
   $
��Left=�6\   $��24��6w   $��
328,21,0,0q�6�   $
��Wrap=�6�   $	��Top=�6�   $	��201��6�   $��20(�6�   $ Right=�6�   ���	#FFE4E453��6   �� *CounterPointPOs.Count+ �� StringFormat$ 0 Filtered Results��6�   5*      5+      