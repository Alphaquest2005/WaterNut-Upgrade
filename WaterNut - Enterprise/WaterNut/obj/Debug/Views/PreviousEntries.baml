   M S B A M L   `   `   `  ����C  ?WaterNut, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullu?clr-namespace:WaterNut.QuerySpace.PreviousDocumentQS.ViewModels1WaterNut.QuerySpace.PreviousDocumentQS.ViewModels  5      I ECore.Common.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullmGclr-namespace:Core.Common.UI.DataVirtualization;assembly=Core.Common.UI!Core.Common.UI.DataVirtualization 5      S OWaterNut.Client.Entities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullyRclr-namespace:PreviousDocumentQS.Client.Entities;assembly=WaterNut.Client.Entities"PreviousDocumentQS.Client.Entities 5      #clr-namespace:WaterNutWaterNut  5
      i9clr-namespace:WaterNut.QuerySpace.CoreEntities.ViewModels+WaterNut.QuerySpace.CoreEntities.ViewModels  5      $    WaterNut.Views.PreviousEntries   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/Expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      NQS?clr-namespace:WaterNut.QuerySpace.PreviousDocumentQS.ViewModels     5      [virtualGclr-namespace:Core.Common.UI.DataVirtualization;assembly=Core.Common.UI     5      qqsPreviousEntitiesRclr-namespace:PreviousDocumentQS.Client.Entities;assembly=WaterNut.Client.Entities     5      (localclr-namespace:WaterNut     5
      Iqcv9clr-namespace:WaterNut.QuerySpace.CoreEntities.ViewModels     5      $��809.552��5   @     � 	Resources  5      �� 5   
    �� Member$, &QS:PreviousDocumentItemsModel.Instance��6      Key"PreviousEntriesModelDataSource  6C   �� 5   
    �� 
TargetType" ��6   .�5      �� ;  5Core.Common.UI.DataVirtualization.VirtualListItemBase �� Property �@ AutoLoad �� Value . 6E   5      �� 5   
   xcuda_ItemTemplate1   �� DataType=  7PreviousDocumentQS.Client.Entities.PreviousDocumentItem"  63   .R�5      � $��70��6=   $	��818��6I   .+�5      ��   TextBox2TextBlock#���  6H   $
��Left=�6u   $��22��6�   $��	86,31,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��229��6�   $��16(�6�   ��6   �� *Data.TariffCode+ �� Mode$ OneWay=�6�   �� 5      #���  6;    �� 
IsReadOnly . $
��Left=�6y   $��27��6�   $��	185,1,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��125��6�   $��18.667(�6�   ��6   �� *Data.ItemNumber+6�   �� 5      #���  6G    . $
��Left=�6�   $��24��6�   $��	350,4,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��208��6�   $��16(�6�   ��6   �� *Data.Commercial_Description+6�   �� 5      #���  6X   $
��Left=�6�   $��32��6�   $��	721,7,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��95��6�   $��18.667(�6�   ��6   �� *Data.Item_price+	 �� StringFormat$	 c��$ OneWay=�6�   �� 5      #���  6[   $
��Left=�6�   $��22��6�   $��
721,44,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��95��6�   $��16(�6�   ��6   �� *Data.Total_CIF_itm+$	 c��$ OneWay=�6�   �� 5      #���  6[   $
��Left=�6�   $��32��6�   $��	661,7,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��61��6�   $��18.667(�6�   ��6   �� *Data.ItemQuantity+$	 n0��$ OneWay=�6�   �� 5      #���  6V   $
��Left=�6�   $��22��6�   $��
563,44,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��153��6�   $��16(�6�   
 �� TextAlignment$
 Center=�6  ��6   �� *Data.Suppplementary_unit_code+$ OneWay=�6  �� 5      #���  6R   $
��Left=�6   $��40��6�   $��314,32,0,-2q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��244��6�   ��6   �� *Data.Description_of_goods+$ OneWay=�6�   �� 5      #���  6C   $
��Left=�6p   $��27��6�   $��	21,0,0,23q�6�   $
 Wrap=�6�   $��Bottom=�6�   $��44��6�   $��21.333(�6�   $
��Bold"�6�   ��6   �� *
LineNumber+$ OneWay=�6�   �� 5       ��Name$ 	RemoveTxt��6   -   5        $
��Left=�5   /   $��18��6J   $��16,1,0,0q�6V   $
��Wrap=�6h   $��Remove��6|   $	��Top=�6�   $��49��6�     CloseButtonStyle#���  6�   6�   �� 5      #���  6J   $
��Left=�6w   $��32��6�   $��	563,7,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��61��6�   $��18.667(�6�   $
 Right=�6�   ��6   �� *Data.QtyAllocated+$ OneWay=�6�   �� 5      $
��Left=�6   $��26��67   $��
631,10,0,0q�6C   $
��Wrap=�6W   $��OF��6k   $	��Top=�6u   $��23��6�    �� TextAlignment$ Center=�6�   $
��Bold"�6�   $��16(�6�   �� 5       #���  6U   $
��Left=�6�   $��16��6�   $��	16,52,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��99��6�   $��13.333(�6�   ��6   �� *Data.PreviousItemsEx.CNumber+$ OneWay=�6�   �� 5!      $
��Left=�6   $��67��67   $��0,1,0,0q�6C   $	��Top=�6f   $��16��6~   ��6T   Z� ��5"      
� 5#      .��5$      �  � Color$ White��6+    � Offset$ 0.011Q�69   � 5%      $ 	#FF5872AB��6+   $ 1Q�6=   5&      5(      �� 5)      -   5        $��Do Not ExBond��5)   >   $
��Left=�6V   $��24��6q   $��70,4,0,0q�6}   $	��Top=�6�   $	��110��6�    d� 	IsChecked 6   �� *Data.DoNotEx+6�   �� 5*      #���  6H   $
��Left=�6u   $��16��6�   $��
140,52,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��70��6�   $��13.333(�6�   ��6   �� *Data.LineNumber+$ OneWay=�6�   5-      5.      .��51      � -   5         �Name$ 
LayoutRoot��51       � DataContext 6   ��  " PreviousEntriesModelDataSource �� Source# [ .+�52   
   �� $
��Left=�6   $��33��6/   $��9,14,0,0q�6;   $
��Wrap=�6M   $	��Top=�6a   $	��213��6y   $��21.333(�6�   $��Asycuda Item Details��6�   �� 53   
   -   5         ��Name$ ItemLst��53      $��Stretch=�6#   $	��337��6A   $��	0,143,0,0q�6N   $	��Top=�6a   $
��Auto��6y     xcuda_ItemTemplate1#���  55       %� IsVirtualizing .  %� VirtualizationMode$ 	Recycling=�58      ! �� IsDeferredScrollingEnabled . C  =Core.Common.UI.DataVirtualization.VirtualListLoadingIndicator   
IsAttached .   AlphaListBoxStyle#���  5;   �    �� SelectedItem 54      �� E   ?WaterNut.QuerySpace.PreviousDocumentQS.ViewModels.BaseViewModel   Instance# Z  �� Path$" VCurrentPreviousDocumentItem���56      �� *PreviousDocumentItems+5;   �   �� 5<   
   $
��Left=�6   $��23��6/   $��	10,46,0,0q�6;   $
��Wrap=�6N   $	��Top=�6b   $	��116��6z   $��16(�6�   $��Item Number��6�   $ Center=�6�   �� 5=   
   $
��Left=�6   $��23��6/   $��
131,46,0,0q�6;   $
��Wrap=�6O   $	��Top=�6c   $	��237��6{   $��16(�6�   $��Description��6�   $ Center=�6�   �� 5>   
   $
��Left=�6   $��23��6/   $��
390,46,0,0q�6;   $
��Wrap=�6O   $	��Top=�6c   $	��112��6{   $��12(�6�   $��
TariffCode��6�   $ Center=�6�   �� 5?   
   -   5        ���	#7FFFFFFF$
��Left=�5?   w   $��23��6�   $��	10,69,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��116��6�   $��16(�6�   $
 Center=�6�     TransparentTextBoxStyle#���  6  ��6   �� *ItemNumberFilter+$ TwoWay=� �� UpdateSourceTrigger$ Explicit=�6B  �� 5@   
   -   5        ���	#4CFFFFFF$
��Left=�5@   {   $��23��6�   $��
131,69,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��237��6�   $��16(�6�   $
 Center=�6�   #���  6  ��6   �� *ItemDescriptionFilter+$ TwoWay=�$ Explicit=�6F  �� 5A   
   -   5        $
��Left=�5A      $��26��6M   $��
634,46,0,0q�6Y   $
��Wrap=�6m   $��View All��6�   $	��Top=�6�   $��75��6�   $��16(�6�     TextButtonStyle#���  6�   $ Right=�6�   �� 5B   
   -   5        ���	#7FFFFFFF$
��Left=�5B   w   $��23��6�   $��
390,70,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��112��6�   $��16(�6�   $
 Center=�6�   #���  6  ��6   �� *TariffCodeFilter+$ TwoWay=�$ Explicit=�6B  �� 5C   
   $
��Left=�6   $��23��6/   $��
507,46,0,0q�6;   $
��Wrap=�6O   $	��Top=�6c   $��67��6{   $��12(�6�   $ Center=�6�   $��Assessed��6�   �� 5D   
   $
��Left=�6   $��20��6.   $��
535,72,0,0q�6:   $	��Top=�6N   $��17��6f    J� RenderTransformOrigin$ 0.955,0.629&�6q   �� 5E   
   -	   5         ��Name$ MultiSelectChk��5E      $
��Left=�6+   $��26��6F   $��
31,108,0,0q�6R   $	��Top=�6f   $��95��6~   $��MultiSelect��6�   $ FalseY�6�   �� 5F   
   -
   5        $
��Left=�5F      $��22��6/   $��371,108,0,0q�6;   $
��Wrap=�6P   $��Remove Selected Items��6d   $	��Top=�6�   $	��138��6�   #���  6�   $��16(�6  �� 5G   
   -   5        $ DeselectTxt��5G      $
��Left=�6)   $��22��6D   $��158,107,0,0q�6P   $
��Wrap=�6e   $	��Top=�6y   $��98��6�   $��16(�6�   $��De-Select All��6�   $
 Left=�6�   #���  6�   6�   �� 5H   
   -   5        $ 	SelectTxt��5H      $
��Left=�6'   $��22��6B   $��280,107,0,0q�6N   $
��Wrap=�6c   $	��Top=�6w   $��67��6�   $��16(�6�   $��
Select All��6�   $
 Left=�6�   #���  6�   6�   �� 5I   
   -   5        $ ManualModeChk��5I      $
��Left=�6K   $��26��6f   $��
599,77,0,0q�6r   $	��Top=�6�   $	��131��6�   $��In Manual Mode��6�   $y�Visible=�6�    6*   �� *
ManualMode+6�   �� 5J   
   $
��Left=�6b   $��24��6}   $��
221,21,0,0q�6�   $
��Wrap=�6�   $	��Top=�6�   $	��201��6�   $��20(�6�   $ Right=�6�   ���	#FFE4E453��6   �� *PreviousDocumentItems.Count+$	 0 Filtered Results��6�   �� 5K   
   -   5        #���  5K      $
��Left=�6?   $��24��6Z   $��
588,17,0,0q�6f   $
��Wrap=�6z   $��Send to Excel ��6�   $	��Top=�6�   $	��121��6�   $��16(�6�   $��Segoe UI Symbol)�6�   y�6  �� ?   9WaterNut.QuerySpace.CoreEntities.ViewModels.BaseViewModel   Instance# Z $3 -CurrentApplicationSettings.AllowExportToExcel�5L      5M      