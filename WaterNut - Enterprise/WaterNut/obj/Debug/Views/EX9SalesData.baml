   M S B A M L   `   `   `  ����C  ?WaterNut, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WaterNutWaterNut  5      g8clr-namespace:WaterNut.QuerySpace.SalesDataQS.ViewModels*WaterNut.QuerySpace.SalesDataQS.ViewModels  5      S OWaterNut.Client.Entities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullkKclr-namespace:SalesDataQS.Client.Entities;assembly=WaterNut.Client.EntitiesSalesDataQS.Client.Entities 5	      I ECore.Common.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullmGclr-namespace:Core.Common.UI.DataVirtualization;assembly=Core.Common.UI!Core.Common.UI.DataVirtualization 5
      g8clr-namespace:WaterNut.QuerySpace.SalesDataQS.ViewModels*WaterNut.QuerySpace.SalesDataQS.ViewModels  5      !    WaterNut.Views.Ex9SalesData   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/Expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      (localclr-namespace:WaterNut     5      O
querySpace8clr-namespace:WaterNut.QuerySpace.SalesDataQS.ViewModels     5      gQSSalesEntitiesKclr-namespace:SalesDataQS.Client.Entities;assembly=WaterNut.Client.Entities     5	      [virtualGclr-namespace:Core.Common.UI.DataVirtualization;assembly=Core.Common.UI     5
      Hqsv8clr-namespace:WaterNut.QuerySpace.SalesDataQS.ViewModels     5      $��528.2��5        � 	Resources  5      �� 5   
    �� Member$+ %querySpace:Ex9SalesDataModel.Instance��6      KeyEx9SalesDataModelDataSource  6B   �� 5   
    �� 
TargetType" ��6   .�5      �� ;  5Core.Common.UI.DataVirtualization.VirtualListItemBase �� Property �@ AutoLoad �� Value . 6E   5      �� 5   
   PurchaseOrderTemplate   �� DataType+  %SalesDataQS.Client.Entities.SalesData"  65   .R�5      � $��Stretch=�6   $��Stretch=�61   $��0q�6M   $��629.183��6X   $��35.16��6h   .+�5      ��   TextBox2TextBlock#���  6   $��229,-1,248.183,-0.84q�6x   $��14(�6�   ��6G   �� *Data.EntryDataDate+ �� Mode$ OneWay=�6�   �� 5      #���  6   $��119,-1,404.183,-1.84q�6v   $��14(�6�   ��6G   �� *Data.EntryDataId+$ OneWay=�6�   �� 5      #���  6   $��	385,0,0,0q�6w   $
��Left=�6�   $	��Top=�6�   $��93��6�   $��35��6�   $��14(�6�   ��6G   �� *Data.DutyFreePaid+$ OneWay=�6�   �� 5       ��Name$ RemovePOTxt��6   -   5        $
��Left=�5   1   $��25��6L   $��	539,6,0,0q�6X   $
��Wrap=�6k   $��	Remove PO��6   $	��Top=�6�   $��80��6�     TextButtonStyle#���  6�   $��14(�6�   6�   �� 5      #���  6   $��35,0,532.183,3.16q�6o   $��18(�6�   $
��Bold"�6�   ��6G   �� *	Data.Type+$ OneWay=�6�   �� 5      $
��Left=�6   $��34��67   $��0,1,0,0q�6C   $	��Top=�6f   $��15��6~   ��6T   Z� ��5      
� 5      .��5      �  � Color$ White��6+   	 � Offset$	 0.011Q�69   � 5      $ 	#FF5872AB��6+   $	 1Q�6=   5      5!      5#      5$      .��5'      � -   5        
 �Name$
 
LayoutRoot��5'       � DataContext 6   ��   Ex9SalesDataModelDataSource �� Source# [ .+�5(   
   �� $
��Left=�6   $��33��6/   $��9,14,0,0q�6;   $
��Wrap=�6M   $	��Top=�6a   $	��154��6y   $��21.333(�6�   $��
Sales Data��6�   �� 5)   
   -   5         ��Name$ ItemLst��5)      $��Stretch=�6#   $	��321��6A   $��
0,154,10,0q�6N   $	��Top=�6b   $
��Auto��6z    %� IsVirtualizing .  %� VirtualizationMode$ 	Recycling=�5+      ! �� IsDeferredScrollingEnabled . C  =Core.Common.UI.DataVirtualization.VirtualListLoadingIndicator   
IsAttached .   PurchaseOrderTemplate#���  5/       �� SelectionMode$ Multiple=�50   b    J� 	AllowDrop .   AlphaListBoxStyle#���  6�    �� SelectedItem 5.      �� >   8WaterNut.QuerySpace.SalesDataQS.ViewModels.BaseViewModel   Instance# Z  �� Path$ VCurrentSalesData���50      �� *
SalesDatas+6�   �� 51   
   -   5        $ DeselectTxt��51      $
��Left=�6)   $��22��6D   $��179,118,0,0q�6P   $
��Wrap=�6e   $	��Top=�6y   $��92��6�   $��16(�6�   $��De-Select All��6�    �� TextAlignment$
 Left=�6�   #���  6�   6�   �� 52   
   -   5        $ 	SelectTxt��52      $
��Left=�6'   $��22��6B   $��304,118,0,0q�6N   $
��Wrap=�6c   $	��Top=�6w   $��83��6�   $��16(�6�   $��
Select All��6�   $
 Left=�6�   #���  6�   6�   �� 53   
   -   5         ��Name$ MultiSelectChk��53      $
��Left=�6+   $��26��6F   $��
67,118,0,0q�6R   $	��Top=�6f   $	��107��6~   $��MultiSelect��6�    d� 	IsChecked$ FalseY�6�   �� 54   
   -   5        $
��Left=�54      $��26��6/   $��
515,48,0,0q�6;   $
��Wrap=�6O   $��Allocate Sales��6c   $	��Top=�6y   $	��100��6�   $��16(�6�   #���  6�   $ Right=�6�   $y�Hidden=�6  �� 55   
   -   5        $ ImportSalesTxt��55      $
��Left=�6,   $��22��6G   $��
533,22,0,0q�6S   $
��Wrap=�6g   $	��Top=�6{   $��82��6�   $��14(�6�   $��Import Sales��6�   $
 Left=�6�   #���  6�   6�   �� 56   
   -	   5        $
��Left=�56   9   $��26��6T   $��387,118,0,0q�6`   $
��Wrap=�6u   $��Remove Selected��6�   $	��Top=�6�   $	��126��6�   $��16(�6�     CloseButtonStyle#���  6�   $ Right=�6�   �� 57   
   $
��Left=�6   $��23��6/   $��9,59,0,0q�6;   $
��Wrap=�6M   $	��Top=�6a   $	��154��6y   $��14(�6�   $��Invoice Number��6�   $ Center=�6�   �� 58   
   -
   5        ���	#7FFFFFFF$
��Left=�58   k   $��22��6�   $��9,82,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��154��6�   $��14(�6�    �� TextAlignment$ Center=�6�     TransparentTextBoxStyle#���  6  ��6   �� *EntryDataIdFilter+ �� UpdateSourceTrigger$ Explicit=�65  �� 59   
   $
��Left=�6   $��23��6/   $��
183,59,0,0q�6;   $
��Wrap=�6O   $	��Top=�6c   $	��113��6{   $��14(�6�   $��
Start Date��6�   $ Center=�6�   (  "System.Windows.Controls.DatePicker  5:   
   $
��Left=�6G   $��22��6b   $��
179,82,0,0q�6n   $	��Top=�6�   $	��117��6�      SelectedDate 6   �� *StartEntryDataDateFilter+6�   �� 5;   
   -   5        $ MultiSelectChk_Copy��5;   9   $
��Left=�6V   $��22��6q   $��
429,82,0,0q�6}   $	��Top=�6�   $��82��6�   $��	Duty Paid��6�    6   �� *DutyPaidFilter+6�   �� 5<   
   -   5        $ MultiSelectChk_Copy1��5<   8   $
��Left=�6V   $��22��6q   $��
429,52,0,0q�6}   $	��Top=�6�   $��81��6�   $��	Duty Free��6�    J� RenderTransformOrigin$ 0.488,0.464&�6�    6   �� *DutyFreeFilter+6�   �� 5=   
   $
��Left=�6W   $��24��6r   $��
221,21,0,0q�6~   $
��Wrap=�6�   $	��Top=�6�   $	��201��6�   $��20(�6�   $ Right=�6�   ���	#FFE4E453��6   �� *SalesDatas.Count+ �� StringFormat$ 0 Filtered Results��6�   �� 5>   
   $
��Left=�6H   $��24��6c   $��404,495,0,0q�6o   $
��Wrap=�6�   $	��Top=�6�   $	��201��6�   $��20(�6�   ���	#FFE4E453��6   �� *
TotalTotal+$ of {0:c}��6�   �� 5?   
   $
��Left=�6   $��23��6/   $��
305,59,0,0q�6;   $
��Wrap=�6O   $	��Top=�6c   $	��113��6{   $��14(�6�   $��End Date��6�   $ Center=�6�     5@   
   $
��Left=�6E   $��22��6`   $��
305,82,0,0q�6l   $	��Top=�6�   $	��113��6�    6   �� *EndEntryDataDateFilter+6�   �� 5A   
   -   5        $
��Left=�5A      $��26��6M   $��
540,77,0,0q�6Y   $
��Wrap=�6m   $��View All��6�   $	��Top=�6�   $��75��6�   $��16(�6�   #���  6�   $ Right=�6�   �� 5B   
   $
��Left=�6O   $��24��6j   $��198,495,0,0q�6v   $
��Wrap=�6�   $	��Top=�6�   $	��201��6�   $��20(�6�   $ Right=�6�   ���	#FFE4E453��6   �� *SelectedTotal+$ Total {0:c}��6�   5C      5D      