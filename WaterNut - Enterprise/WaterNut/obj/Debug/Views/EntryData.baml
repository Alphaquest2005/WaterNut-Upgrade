   M S B A M L   `   `   `  ����I  ECore.Common.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullmGclr-namespace:Core.Common.UI.DataVirtualization;assembly=Core.Common.UI!Core.Common.UI.DataVirtualization  5      S OWaterNut.Client.Entities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullkKclr-namespace:EntryDataQS.Client.Entities;assembly=WaterNut.Client.EntitiesEntryDataQS.Client.Entities 5      C ?WaterNut, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullg8clr-namespace:WaterNut.QuerySpace.EntryDataQS.ViewModels*WaterNut.QuerySpace.EntryDataQS.ViewModels 5      i9clr-namespace:WaterNut.QuerySpace.CoreEntities.ViewModels+WaterNut.QuerySpace.CoreEntities.ViewModels 5	         WaterNut.Views.EntryData   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/Expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      [virtualGclr-namespace:Core.Common.UI.DataVirtualization;assembly=Core.Common.UI     5      kqsEntryDataEntitiesKclr-namespace:EntryDataQS.Client.Entities;assembly=WaterNut.Client.Entities     5      Hqsv8clr-namespace:WaterNut.QuerySpace.EntryDataQS.ViewModels     5      Iqcv9clr-namespace:WaterNut.QuerySpace.CoreEntities.ViewModels     5	      $��527.761��5        � 	Resources  5      �� 5   
    �� Member$! qsv:EntryDataModel.Instance��6      KeyEntryDataModelDataSource  68   �� 5   
    �� 
TargetType" ��6   .�5      �� ;   5Core.Common.UI.DataVirtualization.VirtualListItemBase �� Property �@ AutoLoad �� Value . 6E   5      �� 5   
   VPurchaseOrderTemplate   �� DataType-  'EntryDataQS.Client.Entities.EntryDataEx"  66   .R�5      �  �Name$ ItmGrid��6   $��Stretch=�6%   $��Stretch=�6C   $��0q�6_   $	��770��6j   $��35��6v   .+�5      ��   TextBox2TextBlock#���  6   $��295,0,345,0q�6v   ��6G   �� *Data.InvoiceDate+ �� Mode$ OneWay=�6v   �� 5      #���  6   $��122,-1,480,0q�6t   $��14(�6�   ��6G   �� *Data.InvoiceNo+$ OneWay=�6�   �� 5      $��	430,0,0,0q�69   $
��Left=�6L   $	��Top=�6g   $��78��6   $��35��6�   ��6   �� *Data.Filled+6�   �� 5       ��Name$ RemovePOTxt��6   -   5        $
��Left=�5   1   $��25��6L   $��	690,6,0,0q�6X   $
��Wrap=�6k   $��	Remove PO��6   $	��Top=�6�   $��80��6�     TextButtonStyle#���  6�   $��14(�6�   6�   �� 5      #���  6   $��
25,0,653,4q�6o   $��18(�6�   $
��Bold"�6�   ��6G   �� *	Data.Type+$ OneWay=�6�   �� 5      $��	508,0,0,0q�6`   $
��Left=�6s   $	��Top=�6�   $	��157��6�   $��35��6�   ��6   �� *Data.MissingLines+	 �� StringFormat$	 Missing Lines: 0��6�   �� 5      $
��Left=�6   $��34��67   $��0,1,0,0q�6C   $	��Top=�6f   $��10��6~   ��6T   Z� ��5      
� 5      .��5      � 
 � Color$
 White��6+    � Offset$ 0.011Q�69   � 5      $
 	#FF5872AB��6+   $ 1Q�6=   5       5"      5$       �� Triggers 5%      �� 5&       �� Value$ False��6C    �� Binding 6   �� *Data.TotalsEqual+.a�5'      ��  �� 
TargetName$ ItmGrid��63    � �� �	#19FF01016H   5(      5*      .��5-      � -   5        $ 
LayoutRoot��5-       � DataContext 6   ��   EntryDataModelDataSource �� Source# [ .+�5.   
   �� $
��Left=�6   $��33��6/   $��9,14,0,0q�6;   $
��Wrap=�6M   $	��Top=�6a   $	��102��6y   $��21.333(�6�   $��
Entry Data��6�   �� 5/   
   -   5         ��Name$ ItemLst��5/       %� IsVirtualizing .  %� VirtualizationMode$ 	Recycling=�51      ! �� IsDeferredScrollingEnabled . C   =Core.Common.UI.DataVirtualization.VirtualListLoadingIndicator   
IsAttached .   VPurchaseOrderTemplate#���  55       �� SelectionMode$ Multiple=�56   ^   $��Stretch=�57      $	��310��6+   $��0,141,0.333,0q�68   $	��Top=�6O   $
��Auto��6g     AlphaListBoxStyle#���  6t    �� SelectedItem 54      �� >  8WaterNut.QuerySpace.EntryDataQS.ViewModels.BaseViewModel   Instance# Z  �� Path$ VCurrentEntryDataEx���56      �� *EntryDataEx+57   t   �� 58   
   -   5        $ DeselectTxt��58      $
��Left=�6)   $��22��6D   $��127,115,0,0q�6P   $
��Wrap=�6e   $	��Top=�6y   $��92��6�   $��16(�6�   $��De-Select All��6�    �� TextAlignment$
 Left=�6�   #���  6�   6�   �� 59   
   -   5        $ 	SelectTxt��59      $
��Left=�6'   $��22��6B   $��252,115,0,0q�6N   $
��Wrap=�6c   $	��Top=�6w   $��83��6�   $��16(�6�   $��
Select All��6�   $
 Left=�6�   #���  6�   6�   �� 5:   
   -   5        $
��Left=�5:      $��26��6/   $��650,114,0,0q�6;   $
��Wrap=�6P   $��Add to Asy. Doc.��6d   $	��Top=�6|   $	��126��6�   $��16(�6�   #���  6�   $ Right=�6�   6�   �� 5;   
   -   5         ��Name$ MultiSelectChk��5;      $
��Left=�6+   $��26��6F   $��
15,116,0,0q�6R   $	��Top=�6f   $	��107��6~   $��MultiSelect��6�    d� 	IsChecked$ FalseY�6�   �� 5<   
   -   5        $ ImportSalesTxt��5<      $
��Left=�6,   $��22��6G   $��
498,10,0,0q�6S   $
��Wrap=�6g   $	��Top=�6{   $	��152��6�   $��14(�6�   $��Import Sales��6�   $
 Left=�6�   #���  6�   6   �� 5=   
   -	   5        $ ImportPOTxt��5=      $
��Left=�6)   $��22��6D   $��
498,32,0,0q�6P   $
��Wrap=�6d   $	��Top=�6x   $	��152��6�   $��14(�6�   $��Import Purchase Orders��6�   $
 Left=�6�   #���  6�   6  �� 5>   
   -
   5        $ ImportOPSTxt��5>      $
��Left=�6*   $��22��6E   $��
498,54,0,0q�6Q   $
��Wrap=�6e   $	��Top=�6y   $	��152��6�   $��14(�6�   $��Import Opening Stock��6�   $
 Left=�6�   #���  6�   6  �� 5?   
   -   5        $
��Left=�5?      $��26��6/   $��
650,87,0,0q�6;   $
��Wrap=�6O   $��Allocate Sales��6c   $	��Top=�6y   $	��126��6�   $��16(�6�   #���  6�   $ Right=�6�   6�   �� 5@   
   -   5        $
��Left=�5@   9   $��26��6T   $��340,116,0,0q�6`   $
��Wrap=�6u   $��Remove Selected��6�   $	��Top=�6�   $	��126��6�   $��16(�6�     CloseButtonStyle#���  6�   $ Right=�6�   �� 5A   
   $
��Left=�6X   $��24��6s   $��
134,23,0,0q�6   $
��Wrap=�6�   $	��Top=�6�   $	��144��6�   $��20(�6�   $
 Left=�6�   ���	#FFE4E453��6   �� *EntryDataEx.Count+$	 0 Filtered Results��6�   �� 5B   
   $
��Left=�6L   $��24��6g   $��498,471,0,0q�6s   $
��Wrap=�6�   $	��Top=�6�   $	��147��6�   $��20(�6�   $ Right=�6�   ���	#FFE4E453��6   �� *SelectedTotal+$	 {0:c} Of��6�   �� 5C   
   $
��Left=�6F   $��24��6a   $��650,471,0,0q�6m   $
��Wrap=�6�   $	��Top=�6�   $	��147��6�   $��20(�6�   ���	#FFE4E453��6   �� *
TotalTotal+$	 {0:c}��6�   �� 5D   
   -   5        #���  5D      $
��Left=�6?   $��24��6Z   $��
666,14,0,0q�6f   $
��Wrap=�6z   $��Send to Excel ��6�   $	��Top=�6�   $	��121��6�   $��16(�6�   $��Segoe UI Symbol)�6�   y�6  �� ?  9WaterNut.QuerySpace.CoreEntities.ViewModels.BaseViewModel   Instance# Z $3 -CurrentApplicationSettings.AllowExportToExcel��� 5E   
   $
��Left=�6   $��23��6/   $��9,59,0,0q�6;   $
��Wrap=�6M   $	��Top=�6a   $	��154��6y   $��14(�6�   $��Invoice Number��6�   $ Center=�6�   �� 5F   
   -   5        ���	#7FFFFFFF$
��Left=�5F   i   $��22��6�   $��9,82,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��154��6�   $��14(�6�     �� TextAlignment$  Center=�6�     TransparentTextBoxStyle#���  6   ��6   �� *InvoiceNoFilter+! �� UpdateSourceTrigger$! Explicit=�62  �� 5G   
   $
��Left=�6   $��23��6/   $��
184,59,0,0q�6;   $
��Wrap=�6O   $	��Top=�6c   $	��139��6{   $��14(�6�   $��
Start Date��6�   $ Center=�6�   (  "System.Windows.Controls.DatePicker  5H   
   $
��Left=�6E   $��22��6`   $��
184,82,0,0q�6l   $	��Top=�6�   $	��139��6�   "   SelectedDate" 6   �� *StartInvoiceDateFilter+6�   �� 5I   
   $
��Left=�6   $��23��6/   $��
340,58,0,0q�6;   $
��Wrap=�6O   $	��Top=�6c   $	��139��6{   $��14(�6�   $��End Date��6�   $ Center=�6�     5J   
   $
��Left=�6C   $��22��6^   $��
340,81,0,0q�6j   $	��Top=�6~   $	��139��6�   " 6   �� *EndInvoiceDateFilter+6�   �� 5K   
   -   5        $
��Left=�5K      $��26��6/   $��
650,61,0,0q�6;   $
��Wrap=�6O   $��View All��6c   $	��Top=�6s   $	��126��6�   $��16(�6�   #���  6�   $ Right=�6�   6�   5L      5M      