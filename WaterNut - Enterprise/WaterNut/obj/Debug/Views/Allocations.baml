   M S B A M L   `   `   `  ����C  ?WaterNut, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulli9clr-namespace:WaterNut.QuerySpace.AllocationQS.ViewModels+WaterNut.QuerySpace.AllocationQS.ViewModels  5      I ECore.Common.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullmGclr-namespace:Core.Common.UI.DataVirtualization;assembly=Core.Common.UI!Core.Common.UI.DataVirtualization 5	      S OWaterNut.Client.Entities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullmLclr-namespace:AllocationQS.Client.Entities;assembly=WaterNut.Client.EntitiesAllocationQS.Client.Entities 5
      i9clr-namespace:WaterNut.QuerySpace.CoreEntities.ViewModels+WaterNut.QuerySpace.CoreEntities.ViewModels  5           WaterNut.Views.Allocations   5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/Expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      HQS9clr-namespace:WaterNut.QuerySpace.AllocationQS.ViewModels     5      [virtualGclr-namespace:Core.Common.UI.DataVirtualization;assembly=Core.Common.UI     5	      mQSAllocationEntitiesLclr-namespace:AllocationQS.Client.Entities;assembly=WaterNut.Client.Entities     5
      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      PcoreEntities9clr-namespace:WaterNut.QuerySpace.CoreEntities.ViewModels    5      $��1073.635��5   *   $��538.507��6;     � 	Resources  5      �� 5   
    �� Member$" QS:AllocationsModel.Instance��6      KeyAllocationsModelDataSource  69   �� 5   
    �� 
TargetType" ��6   .�5      �� ;  5Core.Common.UI.DataVirtualization.VirtualListItemBase �� Property �@ AutoLoad �� Value . 6E   5      �� 5   
   #AsycudaSalesAllocationsTemplate   �� DataType<  6AllocationQS.Client.Entities.AsycudaSalesAllocationsEx"  6?   .R�5      � -   5        $
��1040��5      $��87��6     J� 	AllowDrop . .+�5      ��   TextBox2TextBlock#���  6   $	��Top=�6q   $
��Left=�6�   $��	693,0,0,0q�6�   $��25��6�   $��18.667(�6�   $	��193��6�   ��6G   �� *Data.Status+ �� Mode$ OneWay=�6�   �� 5      #���  6   $	��Top=�6w   $
��Left=�6�   $��	635,0,0,0q�6�   $��25��6�   $��18.667(�6�   $��38��6�   ��6G   �� *Data.QtyAllocated+$ OneWay=�6�   �� 5      #���  6   $	��Top=�6u   $
��Left=�6�   $��87,0,0,0q�6�   $��33��6�   $��18.667(�6�   $	��135��6�   ��6G   �� *Data.ItemNumber+$ OneWay=�6�   � 5      $
��Left=�6   $��26��62   $��	88,60,0,0q�6>   $	��Top=�6Q   $	��381��6i   ���	#7FE7EC9C � ColumnDefinitions 5      �� 5      $
��188* �6+   �� 5      $
��175* �6+   .+�5      �� #���  6   $
��Left=�6w   $��30��6�   	 �� TextWrapping$
	 Wrap=�6�   $	��Top=�6�   $��59��6�   $��13.333(�6�   $
��Bold"�6�   
 �� TextAlignment$
 Center=�6�   $��0,0,0,-0.618q�6  ��6K   �� *Data.SANumber+$ OneWay=�6  �� 5      #���  6   $
��Left=�6x   $��25��6�   $
	 Wrap=�6�   $	��Top=�6�   $	��109��6�   $��13.333(�6�   $��Normal"�6�   $
 Center=�6�   $��63,0,0,0q�6  ��6K   �� *Data.InvoiceNo+$ OneWay=�6  �� 5      #���  6   $
��Left=�6�   $��30��6�   $
	 Wrap=�6�   $	��Top=�6�   $��90��6�   $��13.333(�6�   $��Normal"�6�   $
 Center=�6  $��	177,0,0,0q�6%  $��2��68  ��6K   �� *Data.InvoiceDate+ �� StringFormat$ d��$ OneWay=�68  �� 5       #���  6   $
��Left=�6�   $��30��6�   $
	 Wrap=�6�   $	��Top=�6�   $��41��6�   $��13.333(�6�   $��Normal"�6�   $
 Center=�6  $��
83.6,0,0,0q�6  $��1��6/  ��6K   �� *Data.SalesQtyAllocated+$ OneWay=�6/  �� 5!      #���  6   $
��Left=�6�   $��30��6�   $
	 Wrap=�6�   $	��Top=�6�   $��50��6�   $��13.333(�6�   $��Normal"�6�   $
 Center=�6  $��142.6,0,-0.6,0q�6(  $��1��6@  ��6K   �� *Data.SalesQuantity+$ n1��$ OneWay=�6@  �� 5"      $
��Left=�6!   $��20��6<   $��125.6,5,0,0q�6H   $
��Wrap=�6]   $��Of��6q   $	��Top=�6{   $��18��6�   $��1��6�   5#      � 5$      $
��Left=�6   $��26��62   $��
474,60,0,0q�6>   $	��Top=�6R   $	��412��6j   ���	#7F9AD28D.+�5%      �� #���  6   $
��Left=�6�   $��29��6�   $
	 Wrap=�6�   $	��Top=�6�   $��59��6�   $��13.333(�6�   $
��Bold"�6�   $
 Center=�6  $��	348,0,0,0q�6%  ���	#FFE6AAAA��6K   �� *Data.PiQuantity+$ OneWay=�$
 Pi 0��68  �� 5&      #���  6   $
��Left=�6w   $��26��6�   $
	 Wrap=�6�   $	��Top=�6�   $��74��6�   $��13.333(�6�   $��Normal"�6�   $
 Center=�6�   $��0q�6  ��6K   �� *Data.pCNumber+$ OneWay=�6  �� 5'      #���  6   $
��Left=�6�   $��29��6�   $
	 Wrap=�6�   $	��Top=�6�   $��75��6�   $��13.333(�6�   $��Normal"�6   $
 Center=�6  $��	161,0,0,0q�6+  ��6K   �� *Data.pRegistrationDate+$ d��$ OneWay=�6+  �� 5(      #���  6   $
��Left=�6|   $��29��6�   $
	 Wrap=�6�   $	��Top=�6�   $��40��6�   $��13.333(�6�   $��Normal"�6�   $
 Center=�6   $��	241,0,0,0q�6  ��6K   �� *Data.pQtyAllocated+$ OneWay=�6  �� 5)      #���  6   $
��Left=�6x   $��29��6�   $
	 Wrap=�6�   $	��Top=�6�   $��42��6�   $��13.333(�6�   $��Normal"�6�   $
 Center=�6�   $��	301,0,0,0q�6  ��6K   �� *Data.pQuantity+$ OneWay=�6  �� 5*      $
��Left=�6!   $��20��6<   $��	284,5,0,0q�6H   $
��Wrap=�6[   $��Of��6o   $	��Top=�6y   $��17��6�   �� 5+      #���  6   $
��Left=�6z   $��26��6�   $
	 Wrap=�6�   $	��Top=�6�   $��74��6�   $��13.333(�6�   $��Normal"�6�   $
 Center=�6�   $��	84,-1,0,0q�6  ��6K   �� *Data.pLineNumber+$ OneWay=�6  5,      �� 5-      $	��Top=�6M   $
��Left=�6e   $��	227,0,0,0q�6�   $��60��6�   $��14(�6�   $	��322��6�   $
	 Wrap=�6�   #���  6�   ��6   �� *Data.ItemDescription+$ OneWay=�6�   �� 5.      #���  6   $	��Top=�6u   $
��Left=�6�   $��	554,0,0,0q�6�   $��25��6�   $��16(�6�   $��76��6�   ��6G   �� *Data.TariffCode+$ OneWay=�6�   �� 5/      #���  6   $	��Top=�6w   $
��Left=�6�   $��	21,10,0,0q�6�   $��50��6�   $��18.667(�6�   $��66��6�   $
	 Wrap=�6�   ��6G   �� *Data.DutyFreePaid+$ OneWay=�6�   � 50      $
��Left=�6   $��86��62   $��891,0,0,-16q�6>   $	��Top=�6S   $	��147��6k   ���	#7FA48DD2 J� RenderTransformOrigin$ 0.503,0.574&�6�   .+�51      �� #���  6   $	��Top=�6   $
��Left=�6�   $��10,2,0,0q�6�   $��25��6�   $��16(�6�   $	��127��6�   $
 Center=�6�   ��6K   �� *Data.xReferenceNumber+$ OneWay=�6�   �� 52      #���  6   $	��Top=�6m   $
��Left=�6�   $��	10,28,0,0q�6�   $��25��6�   $��18.667(�6�   $	��127��6�   $
 Center=�6�   ��6K   �� *Data.xLineNumber+6�   �� 53       ��Name$ GoToEntryTxt��6    -   5        $
��Left=�53   6   $��18��6Q   $��	30,68,0,0q�6]   $
��Wrap=�6p   $��
Goto Entry��6�   $	��Top=�6�   $��76��6�    �� TextAlignment$ Center=�6�     TextButtonStyle#���  6�   6�   54      �� 55      $
��Left=�6   $��85��67   $��0,1,0,0q�6C   $	��Top=�6f   $��16��6~   ��6T   Z� ��56      
� 57      .��58      �  � Color$ White��6+    � Offset$ 0.011Q�69   � 59      $ 	#335872AB��6+   $ 1Q�6=   5:      5<      5=      5>      .��5A      � -   5         �Name$ 
LayoutRoot��5A       � DataContext 6   ��   AllocationsModelDataSource �� Source# [ .+�5B   
   �� -   5         ��Name$ ItemLst��5B      $��Stretch=�6#   $	��313��6A   $��0,167,0.4,0q�6N   $	��Top=�6c   $
��Auto��6{    # AsycudaSalesAllocationsTemplate#���  5D       %� IsVirtualizing .  %� VirtualizationMode$ 	Recycling=�5G      ! �� IsDeferredScrollingEnabled . C  =Core.Common.UI.DataVirtualization.VirtualListLoadingIndicator   
IsAttached .  �� SelectionMode$ Extended=�5J   >     AlphaListBoxStyle#���  6�    �� SelectedItem 5C      �� ?   9WaterNut.QuerySpace.AllocationQS.ViewModels.BaseViewModel   Instance# Z  �� Path$' !VCurrentAsycudaSalesAllocationsEx���5E      �� *AsycudaSalesAllocationsExs+5J   �   �� 5K   
   $
��Left=�6   $��32.766��6/   $��8.838,14.011,0,0q�6?   $
��Wrap=�6Y   $	��Top=�6m   $��396.779��6�   $��21.333(�6�   $"��Sales to Asycuda Allocations��6�   �� 5L   
   $
��Left=�6   $��24��6/   $��201,112,0,0q�6;   $
��Wrap=�6P   $	��Top=�6d   $	��113��6|   $��13.333(�6�   $��Item Number��6�   $ Center=�6�   �� 5M   
   -   5        ���	#7FFFFFFF$
��Left=�5M   j   $��24��6�   $��201,136,0,0q�6�   $
	 Wrap=�6�   $	��Top=�6�   $	��113��6�   $��13.333(�6�   $
 Center=�6�     TransparentTextBoxStyle#���  6  ��6   �� *ItemNumberFilter+ �� UpdateSourceTrigger$ Explicit=�6:  �� 5N   
   $
��Left=�6   $��24��6/   $��319,112,0,0q�6;   $
��Wrap=�6P   $	��Top=�6d   $	��187��6|   $��13.333(�6�   $��Item Description��6�   $ Center=�6�   �� 5O   
   -   5        ���	#7FFFFFFF$
��Left=�5O   o   $��24��6�   $��319,136,0,0q�6�   $
	 Wrap=�6�   $	��Top=�6�   $	��187��6�   $��13.333(�6�   $
 Center=�6�   #���  6  ��6   �� *ItemDescriptionFilter+$ Explicit=�6?  �� 5P   
   $
��Left=�6   $��24��6/   $��
83,112,0,0q�6;   $
��Wrap=�6O   $	��Top=�6c   $	��114��6{   $��13.333(�6�   $��Invoice Number��6�   $ Center=�6�   �� 5Q   
   -   5        ���	#7FFFFFFF$
��Left=�5Q   i   $��24��6�   $��
83,136,0,0q�6�   $
	 Wrap=�6�   $	��Top=�6�   $	��114��6�   $��13.333(�6�   $
 Center=�6�   #���  6  ��6   �� *InvoiceNoFilter+$ Explicit=�68  �� 5R   
   $
��Left=�6   $��24��6/   $��890,112,0,0q�6;   $
��Wrap=�6P   $	��Top=�6d   $	��153��6|   $��13.333(�6�   $��Allocation Status��6�   $ Center=�6�   �� 5S   
   -   5        ���	#7FFFFFFF$
��Left=�5S   f   $��24��6�   $��890,136,0,0q�6�   $
	 Wrap=�6�   $	��Top=�6�   $	��153��6�   $��13.333(�6�   $
 Center=�6�   #���  6  ��6   �� *StatusFilter+$ Explicit=�66  �� 5T   
   $
��Left=�6   $��24��6/   $��634,112,0,0q�6;   $
��Wrap=�6P   $	��Top=�6d   $	��100��6|   $��13.333(�6�   $��CNumber��6�   $ Center=�6�   �� 5U   
   -	   5        ���	#7FFFFFFF$
��Left=�5U   g   $��24��6�   $��634,136,0,0q�6�   $
	 Wrap=�6�   $	��Top=�6�   $��61��6�   $��13.333(�6�   $
 Center=�6�   #���  6  ��6   �� *CNumberFilter+$ Explicit=�66  �� 5V   
   -
   5        $
��Left=�5V   1   $��26��6L   $��
743,81,0,0q�6X   $
��Wrap=�6l   $��Create X Entries��6�   $	��Top=�6�   $	��121��6�   $��16(�6�   #���  6�   �� 5W   
   $
��Left=�6i   $��24��6�   $��
345,21,0,0q�6�   $
��Wrap=�6�   $	��Top=�6�   $	��201��6�   $��20(�6�   $ Right=�6�   ���	#FFE4E453��6   �� *" AsycudaSalesAllocationsExs.Count+$ 0 Filtered Results��6   �� 5X   
   $
��Left=�6   $��24��6/   $��511,112,0,0q�6;   $
��Wrap=�6P   $	��Top=�6d   $	��118��6|   $��13.333(�6�   $��
TariffCode��6�   $ Center=�6�   �� 5Y   
   -   5        ���	#7FFFFFFF$
��Left=�5Y   j   $��24��6�   $��511,136,0,0q�6�   $
	 Wrap=�6�   $	��Top=�6�   $	��118��6�   $��13.333(�6�   $
 Center=�6�   #���  6  ��6   �� *TariffCodeFilter+$ Explicit=�6:  �� 5Z   
   -   5        $
��Left=�5Z   2   $��26��6M   $��
993,82,0,0q�6Y   $
��Wrap=�6m   $��View All��6�   $	��Top=�6�   $��59��6�   $��16(�6�   #���  6�   $ Right=�6�   �� 5[   
   -   5         ��Name$ MultiSelectChk_Copy��5[   9   $
��Left=�6V   $��22��6q   $��	4,144,0,0q�6}   $	��Top=�6�   $��75��6�   $��	Duty Paid��6�    d� 	IsChecked 6   �� *DutyPaidFilter+6�   �� 5\   
   -   5        $ MultiSelectChk_Copy1��5\   8   $
��Left=�6V   $��22��6q   $��	4,114,0,0q�6}   $	��Top=�6�   $��75��6�   $��	Duty Free��6�   $ 0.488,0.464&�6�    6   �� *DutyFreeFilter+6�   (  "System.Windows.Controls.DatePicker  5]   
   $
��Left=�6j   $��28��6�   $��	85,78,0,0q�6�   $	��Top=�6�   $	��114��6�       SelectedDate  6   �� *StartInvoiceDateFilter+$ PropertyChanged=�6�     5^   
   $
��Left=�6h   $��28��6�   $��
273,79,0,0q�6�   $	��Top=�6�   $	��114��6�     6   �� *EndInvoiceDateFilter+$ PropertyChanged=�6�   �� 5_   
   $
��Left=�6   $��24��6/   $��9,80,0,0q�6;   $
��Wrap=�6M   $	��Top=�6a   $��71��6y   $��13.333(�6�   $��Select from��6�   $ Center=�6�   �� 5`   
   $
��Left=�6   $��24��6/   $��
204,78,0,0q�6;   $
��Wrap=�6O   $	��Top=�6c   $��64��6{   $��13.333(�6�   $��To��6�   $ Center=�6�   �� 5a   
   -   5        $
��Left=�5a   9   $��26��6T   $��
743,35,0,0q�6`   $
��Wrap=�6t   $��Create Error OPS Entries��6�   $	��Top=�6�   $	��191��6�   $��16(�6�   #���  6�   �� 5b   
   -   5        $
��Left=�5b   4   $��26��6O   $��
743,10,0,0q�6[   $
��Wrap=�6o   $��Create OPS Entries��6�   $	��Top=�6�   $	��191��6�   $��16(�6�   #���  6�   $y�Hidden=�6�   �� 5c   
   -   5        $ MultiSelectChk_Copy2��5c   [   $
��Left=�6y   $��22��6�   $��
574,58,0,0q�6�   $	��Top=�6�   $	��107��6�   $��View X Entries��6�   $ 0.488,0.464&�6�    6   �� *ViewXFilter+$ PropertyChanged=�6�   �� 5d   
   -   5        $ ViewNotEXChk��5d   ^   $
��Left=�6t   $��22��6�   $��
574,80,0,0q�6�   $	��Top=�6�   $	��131��6�   $��View Non XEntries��6�    6   �� *ViewNonXFilter+$ PropertyChanged=�y�6�   �� ?   9WaterNut.QuerySpace.CoreEntities.ViewModels.BaseViewModel!   Instance# Z! $1 +CurrentApplicationSettings.AllowNonXEntries��� 5e   
   -   5        $ MultiSelectChk_Copy3��5e   q   $y�Hidden=�6\   $
��Left=�6�   $��22��6�   $��
574,14,0,0q�6�   $	��Top=�6�   $	��107��6�   $��View OPS Entries��6�   $ 0.488,0.464&�6	   6   �� *ViewOPSFilter+$ PropertyChanged=�6	  �� 5f   
   -   5        $ MultiSelectChk_Copy4��5f   ]   $
��Left=�6{   $��22��6�   $��
574,13,0,0q�6�   $	��Top=�6�   $	��107��6�   $��View Err Entries��6�   $ 0.488,0.464&�6�    6   �� *ViewERRFilter+$ PropertyChanged=�6�   �� 5g   
   -   5        $ MultiSelectChk_Copy5��5g   h   $
��Left=�6�   $��22��6�   $��
574,35,0,0q�6�   $	��Top=�6�   $	��159��6�   $��View Incomp. Allocations��6�   $ 0.488,0.464&�6   6   �� *ViewIncompleteAllocations+$ PropertyChanged=�6  �� 5h   
   $
��Left=�6   $��24��6/   $��742,112,0,0q�6;   $
��Wrap=�6P   $	��Top=�6d   $	��143��6|   $��13.333(�6�   $��Reference Number��6�   $ Center=�6�   �� 5i   
   -   5        ���	#7FFFFFFF$
��Left=�5i   o   $��24��6�   $��742,136,0,0q�6�   $
	 Wrap=�6�   $	��Top=�6�   $	��143��6�   $��13.333(�6�   $
 Center=�6�   #���  6  ��6   �� *ReferenceNumberFilter+$ Explicit=�6?  �� 5j   
   $
��Left=�6Q   $��24��6l   $��815,499,0,0q�6x   $
��Wrap=�6�   $	��Top=�6�   $	��248��6�   $��20(�6�   $
 Left=�6�   ���	#FFE4E453��6   �� *TotalTotalValue+$ Total {0:c}��6�   �� 5l   
   -   5        $
��Left=�5l   :   $��26��6U   $��
743,58,0,0q�6a   $
��Wrap=�6u   $��Create Incomp OPS Entries��6�   $	��Top=�6�   $	��200��6�   $��16(�6�   #���  6�   �� 5m   
   $
��Left=�6Y   $��24��6t   $��535,499,0,0q�6�   $
��Wrap=�6�   $	��Top=�6�   $	��235��6�   $��20(�6�   $ Right=�6�   ���	#FFE4E453��6   �� *TotalAllocatedValue+$ Allocated {0:c}��6�   �� 5n   
   $��of��6   $
��Left=�6   $��24��69   $��775,499,0,0q�6E   $
��Wrap=�6Z   $	��Top=�6n   $��35��6�   $��20(�6�   $ Center=�6�   ���	#FFE4E4536�   �� 5o   
   -   5        #���  5o      $
��Left=�6>   $��24��6Y   $��	942,9,0,0q�6e   $
��Wrap=�6x   $��Send to Excel ��6�   $	��Top=�6�   $	��121��6�   $��16(�6�   $��Segoe UI Symbol)�6�   y�6  �� # Z! $3 -CurrentApplicationSettings.AllowExportToExcel��� 5p   
   -   5        $ MultiSelectChk_Copy6��5p   Z   $
��Left=�6x   $��22��6�   $��	85,51,0,0q�6�   $	��Top=�6�   $	��141��6�   $��Process 7100��6�   $ 0.488,0.464&�6�    6   �� *Process7100+$ PropertyChanged=�6�   �� 5q   
   -   5        $ MultiSelectChk_Copy7��5q   a   $
��Left=�6   $��22��6�   $��
251,51,0,0q�6�   $	��Top=�6�   $	��155��6�   $��Apply Current Checks��6�   $ 0.488,0.464&�6�    6   �� *ApplyCurrentChecks+$ PropertyChanged=�6�   �� 5r   
   -   5        $ MultiSelectChk_Copy8��5r   U   $
��Left=�6s   $��22��6�   $��
890,84,0,0q�6�   $	��Top=�6�   $��70��6�   $��Per IM7��6�   $ 0.488,0.464&�6�    6   �� *PerIM7+$ PropertyChanged=�y�6  �� # Z! $1 +CurrentApplicationSettings.AllowEntryPerIM7��� 5s   
   -   5        $
��Left=�5s   7   $��41��6R   $��
948,38,0,0q�6^   $
��Wrap=�6r   $��Rebuild Sales Report��6�   $	��Top=�6�   $	��115��6�   $��14(�6�   #���  6�   $ Right=�6�   y�6  �� # Z! $/ )CurrentApplicationSettings.AllowSalesToPI��� 5t   
   -   5        ���	#7FFFFFFF$
��Left=�5t   h   $��24��6�   $��700,136,0,0q�6�   $
	 Wrap=�6�   $	��Top=�6�   $��33��6�   $��13.333(�6�   $
 Center=�6�   #���  6  ��6   �� *PrevLineFilter+$ Explicit=�67  5w      5x      