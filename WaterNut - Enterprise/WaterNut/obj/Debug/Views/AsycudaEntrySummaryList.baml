   M S B A M L   `   `   `  ����C  ?WaterNut, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulli9clr-namespace:WaterNut.QuerySpace.CoreEntities.ViewModels+WaterNut.QuerySpace.CoreEntities.ViewModels  5      I ECore.Common.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullmGclr-namespace:Core.Common.UI.DataVirtualization;assembly=Core.Common.UI!Core.Common.UI.DataVirtualization 5      S OWaterNut.Client.Entities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullmLclr-namespace:CoreEntities.Client.Entities;assembly=WaterNut.Client.EntitiesCoreEntities.Client.Entities 5      #clr-namespace:WaterNutWaterNut  5
      ,    &WaterNut.Views.AsycudaEntrySummaryList   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/Expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      HQS9clr-namespace:WaterNut.QuerySpace.CoreEntities.ViewModels     5      [virtualGclr-namespace:Core.Common.UI.DataVirtualization;assembly=Core.Common.UI     5      gQSCoreEntitiesLclr-namespace:CoreEntities.Client.Entities;assembly=WaterNut.Client.Entities     5      (localclr-namespace:WaterNut     5
      $	��830��5   +     � 	Resources  5      �� 5   
    �� Member$+ %QS:AsycudaDocumentItemsModel.Instance��6      Key'#AsycudaDocumentItemsModelDataSource  6B   �� 5   
    �� 
TargetType" ��6   .�5      �� ;  5Core.Common.UI.DataVirtualization.VirtualListItemBase �� Property �@ AutoLoad �� Value . 6E   5      �� 5   
   xcuda_ItemTemplate1   �� DataType6  0CoreEntities.Client.Entities.AsycudaDocumentItem"  63   .R�5      � $
��69.6��6A   .+�5      ��   TextBox2TextBlock#���  6H   $
��Left=�6u   $��19��6�   $��
360,50,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��135��6�   $��16(�6�   ��6   �� *Data.TariffCode+ �� Mode$ OneWay=�6�   �� 5      #���  6l   $
��Left=�6�   $��28��6�   $��
212,22,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��267��6  $��18.667(�6  ��6   �� *Data.ItemNumber+$ OneWay=� �� TargetNullValue$ Null Product Code��6  �� 5      #���  6T   $
��Left=�6�   $��41��6�   $��	484,4,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��248��6�   $��16(�6�   ��6   �� *Data.Commercial_Description+$ OneWay=�6�   �� 5      #���  6X   $
��Left=�6�   $��32��6�   $��	831,3,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��94��6�   $��18.667(�6�   ��6   �� *Data.Item_price+	 �� StringFormat$	 c��$ OneWay=�6�   �� 5      -   5          TransparentTextBoxStyle#���  5   \   $
��Left=�6�   $��22��6�   $��
831,40,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��94��6�   $��16(�6  ��6   �� *Data.Weight+$	 0.00 kg��$ TwoWay=�6  �� 5      #���  6J   $
��Left=�6w   $��32��6�   $��	737,3,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��94��6�   $��18.667(�6�   ��6   �� *Data.ItemQuantity+$ OneWay=�6�   �� 5      #���  6V   $
��Left=�6�   $��22��6�   $��
737,40,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��94��6�   $��16(�6�   ��6   �� *Data.Suppplementary_unit_code+$ OneWay=�6�   �� 5      #���  6R   $
��Left=�6   $��18��6�   $��
500,50,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��232��6�   ��6   �� *Data.Description_of_goods+$ OneWay=�6�   �� 5      #���  6I   $
��Left=�6v   $��27��6�   $��	25,28,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��55��6�   $��16(�6�   $
��Bold"�6�   ��6   �� *Data.LineNumber+$ OneWay=�6�   �� 5      
 ��Name$
 	RemoveTxt��6   -   5        $
��Left=�5   /   $��18��6J   $��29,52,0,-0.4q�6V   $
��Wrap=�6l   $��Remove��6�   $	��Top=�6�   $��49��6�     CloseButtonStyle#���  6�   6�   �� 5      $
��Left=�6N   $��21��6i   $��25,2,0,0q�6u   $	��Top=�6�   $��87��6�   $��Is Assessed��6�    d� 	IsChecked 6   �� *Data.IsAssessed+$ OneWay=�6�   �� 5      #���  6E   $
��Left=�6r   $��27��6�   $��	92,22,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��115��6�   $��18.667(�6�   ��6   �� *Data.CNumber+$ OneWay=�6�   �� 5       #���  6E   $
��Left=�6r   $��17��6�   $��	92,50,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��115��6�   $��15(�6�   ��6   �� *Data.CNumber+$ OneWay=�6�   �� 5!      #���  6]   $
��Left=�6�   $��17��6�   $��
212,50,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��143��6�   $��15(�6�   ��6   �� *Data.RegistrationDate+$	 d��$ OneWay=�6�   �� 5"      -   5        $
��Left=�5"   N   $��21��6i   $��	145,1,0,0q�6u   $	��Top=�6�   $	��175��6�   $��Attribute Only Allocation��6�    6   �� *Data.AttributeOnlyAllocation+6�   �� 5#      -   5        $
��Left=�5#   D   $��21��6_   $��	340,1,0,0q�6k   $	��Top=�6~   $	��139��6�   $��Do Not Allocate��6�    6   �� *Data.DoNotAllocate+y�6�   �� ?   9WaterNut.QuerySpace.CoreEntities.ViewModels.BaseViewModel   Instance �� Source# Z  �� Path$8 2CurrentApplicationSettings.AllowEntryDoNotAllocate��� 5$      $
��Left=�6   $��67��67   $��0,1,0,0q�6C   $	��Top=�6f   $��15��6~   ��6T   Z� ��5%      
� 5&      .��5'      �  � Color$ White��6+    � Offset$ 0.011Q�69   � 5(      $ 	#FF5872AB��6+   $ 1Q�6=   5)      5+      5.      5/      .��54      � -   5         �Name$ 
LayoutRoot��54       � DataContext 6   ��  ' #AsycudaDocumentItemsModelDataSource# [ .+�55   
   �� $
��Left=�6   $��33��6/   $��9,14,0,0q�6;   $
��Wrap=�6M   $	��Top=�6a   $	��209��6y   $��21.333(�6�   $��Asycuda Item Details��6�   �� 56   
   -   5         ��Name$ ItemLst��57       %� IsVirtualizing .  %� VirtualizationMode$ 	Recycling=�59      ! �� IsDeferredScrollingEnabled . C  =Core.Common.UI.DataVirtualization.VirtualListLoadingIndicator   
IsAttached .   xcuda_ItemTemplate1#���  5>       �� SelectionMode$ Multiple=�5@      $��Stretch=�5A      $	��314��6+   $��	0,166,0,0q�68   $	��Top=�6K   $
��Auto��6c     AlphaListBoxStyle#���  6q    �� SelectedItem 5=      �� # Z $! VCurrentAsycudaDocumentItem� �� UpdateSourceTrigger$ PropertyChanged=���5?      �� *AsycudaDocumentItems+5A   q   �� 5B   
   $
��Left=�6   $��23��6/   $��	10,63,0,0q�6;   $
��Wrap=�6N   $	��Top=�6b   $	��116��6z   $��16(�6�   $��Item Number��6�    �� TextAlignment$ Center=�6�   �� 5C   
   $
��Left=�6   $��23��6/   $��
139,63,0,0q�6;   $
��Wrap=�6O   $	��Top=�6c   $	��206��6{   $��16(�6�   $��Description��6�   $ Center=�6�   �� 5D   
   $
��Left=�6   $��23��6/   $��
490,63,0,0q�6;   $
��Wrap=�6O   $	��Top=�6c   $��87��6{   $��12(�6�   $��
TariffCode��6�   $ Center=�6�   �� 5E   
   -   5        ���	#7FFFFFFF$
��Left=�5E   w   $��23��6�   $��	10,86,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��116��6�   $��16(�6�    �� TextAlignment$ Center=�6�   #���  6  ��6   �� *ItemNumberFilter+$ TwoWay=�$ Explicit=�6A  �� 5F   
   -   5        ���	#4CFFFFFF$
��Left=�5F   �   $��23��6�   $��
139,86,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��206��6�   $��16(�6�   $ Center=�6  #���  6  ��6   �� *Commercial_DescriptionFilter+$ TwoWay=�$ Explicit=�6M  �� 5G   
   -	   5        $
��Left=�5G   2   $��26��6M   $��745,130,0,0q�6Y   $
��Wrap=�6n   $��View All��6�   $	��Top=�6�   $��75��6�   $��16(�6�     TextButtonStyle#���  6�   $ Right=�6�   �� 5H   
   -
   5        ���	#7FFFFFFF$
��Left=�5H   w   $��23��6�   $��
490,87,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��87��6�   $��16(�6�   $ Center=�6�   #���  6  ��6   �� *TariffCodeFilter+$ TwoWay=�$ Explicit=�6A  �� 5I   
   -   5         ��Name$ MultiSelectChk��5I      $
��Left=�6+   $��26��6F   $��546,133,0,0q�6R   $	��Top=�6g   $��95��6   $��MultiSelect��6�   $ FalseY�6�   �� 5J   
   -   5        $
��Left=�5J      $��22��6/   $��371,108,0,0q�6;   $
��Wrap=�6P   $��Remove Selected Items��6d   $	��Top=�6�   $	��138��6�   #���  6�   $��16(�6  $y�Hidden=�6  �� 5K   
   -   5        $
 DeselectTxt��5K      $
��Left=�6)   $��22��6D   $��371,130,0,0q�6P   $
��Wrap=�6e   $	��Top=�6y   $��98��6�   $��16(�6�   $��De-Select All��6�   $
 Left=�6�   #���  6�   6�   �� 5L   
   -   5        $
 	SelectTxt��5L      $
��Left=�6'   $��22��6B   $��474,129,0,0q�6N   $
��Wrap=�6c   $	��Top=�6w   $��67��6�   $��16(�6�   $��
Select All��6�   $
 Left=�6�   #���  6�   6�   �� 5M   
   $
��Left=�6a   $��24��6|   $��
294,14,0,0q�6�   $
��Wrap=�6�   $	��Top=�6�   $	��201��6�   $��20(�6�   $ Right=�6�   ���	#FFE4E453��6   �� *AsycudaDocumentItems.Count+$	 0 Filtered Results��6�   �� 5N   
   -   5        #���  5N      $
��Left=�6?   $��24��6Z   $��
629,14,0,0q�6f   $
��Wrap=�6z   $��Send to Excel ��6�   $	��Top=�6�   $	��121��6�   $��16(�6�   $��Segoe UI Symbol)�6�   y�6  �� # Z $3 -CurrentApplicationSettings.AllowExportToExcel��� 5O   
   -   5        $ MultiSelectChk_Copy��5O   V   $
��Left=�6s   $��18��6�   $��	9,134,0,0q�6�   $	��Top=�6�   $��56��6�   $	��IM7��6�    6   �� *	ViewIM7+$ PropertyChanged=�6�   �� 5P   
   -   5        $ 	SelectEX9��5P   V   $
��Left=�6i   $��18��6�   $��
72,134,0,0q�6�   $	��Top=�6�   $��51��6�   $	��Ex9��6�    6   �� *	ViewEx9+$ PropertyChanged=�6�   �� 5Q   
   -   5        $ 	SelectIM9��5Q   V   $
��Left=�6i   $��18��6�   $��179,134,0,0q�6�   $	��Top=�6�   $��51��6�   $	��IM9��6�    J� RenderTransformOrigin$ 82.478,38.049&�6�    6   �� *	ViewIM9+$ PropertyChanged=�6�   �� 5R   
   -   5        $ MultiSelectChk_Copy2��5R   V   $
��Left=�6t   $��18��6�   $��128,134,0,0q�6�   $	��Top=�6�   $��51��6�   $	��IM4��6�    6   �� *	ViewIM4+$ PropertyChanged=�6�   �� 5S   
   $
��Left=�6   $��23��6/   $��
586,60,0,0q�6;   $
��Wrap=�6O   $	��Top=�6c   $	��101��6{   $��12(�6�   $��Reg.. Start Date��6�   $ Center=�6�   (  "System.Windows.Controls.DatePicker  5T   
   ���	#7FFFFFFF$
��Left=�6�   $��23��6�   $��
586,88,0,0q�6�   $	��Top=�6�   $	��112��6�   $��16(�6     SelectedDate 6   �� *StartRegistrationDateFilter+  �� IsAsync  . $ TwoWay=�$ PropertyChanged=�6  �� 5U   
   $
��Left=�6   $��25��6/   $��
713,60,0,0q�6;   $
��Wrap=�6O   $	��Top=�6c   $	��101��6{   $��12(�6�   $��Reg. End Date��6�   $ Center=�6�     5V   
   ���	#7FFFFFFF$
��Left=�6�   $��23��6�   $��
713,90,0,0q�6�   $	��Top=�6�   $	��112��6�   $��16(�6�    6   �� *EndRegistrationDateFilter+$ TwoWay=�$ PropertyChanged=�6�   �� 5W   
   $
��Left=�6   $��23��6/   $��
350,61,0,0q�6;   $
��Wrap=�6O   $	��Top=�6c   $��75��6{   $��12(�6�   $��CNumber��6�   $ Center=�6�   �� 5X   
   -   5        ���	#7FFFFFFF$
��Left=�5X   t   $��23��6�   $��
350,85,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��75��6�   $��16(�6�   $ Center=�6�   #���  6  ��6   �� *CNumberFilter+$ TwoWay=�$ Explicit=�6>  �� 5Y   
   $
��Left=�6   $��35��6/   $��
430,50,0,0q�6;   $
��Wrap=�6O   $	��Top=�6c   $��55��6{   $��12(�6�   $��Line Number��6�   $ Center=�6�   �� 5Z   
   -   5        ���	#7FFFFFFF$
��Left=�5Z   w   $��23��6�   $��
430,86,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��55��6�   $��16(�6�   $ Center=�6�   #���  6  ��6   �� *LineNumberFilter+$ TwoWay=�$ Explicit=�6A  �� 5[   
   -   5        $ MultiSelectChk_Copy3��5[   f   $
��Left=�6�   $��36��6�   $��243,130,0,0q�6�   $	��Top=�6�   $	��102��6�   $��View Only Current Doc.��6�    6   �� *ViewCurrentDocumentOnly+$ PropertyChanged=�6�   �� 5\   
   -   5        $
 SelectTxt_Copy��5\      $
��Left=�6,   $��43��6G   $��646,117,0,0q�6S   $
��Wrap=�6h   $	��Top=�6|   $��69��6�   $��16(�6�   $��Remove Select��6�   $
 Left=�6�   #���  6�   6  �� 5]   
   -   5        $ MultiSelectChk_Copy4��5]   `   $
��Left=�6~   $��18��6�   $��
490,43,0,0q�6�   $	��Top=�6�   $��78��6�   $��Invalid HS Code��6�   $��8(�6�    6   �� *ViewInvalidHSCode+$ PropertyChanged=�6�   5^      5_      