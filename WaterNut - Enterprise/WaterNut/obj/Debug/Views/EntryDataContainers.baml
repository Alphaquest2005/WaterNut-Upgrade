   M S B A M L   `   `   `  ����C  ?WaterNut, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullg8clr-namespace:WaterNut.QuerySpace.EntryDataQS.ViewModels*WaterNut.QuerySpace.EntryDataQS.ViewModels  5      I ECore.Common.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullmGclr-namespace:Core.Common.UI.DataVirtualization;assembly=Core.Common.UI!Core.Common.UI.DataVirtualization 5      S OWaterNut.Client.Entities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullkKclr-namespace:EntryDataQS.Client.Entities;assembly=WaterNut.Client.EntitiesEntryDataQS.Client.Entities 5      9!clr-namespace:WaterNut.ConvertersWaterNut.Converters  5
      ]?clr-namespace:Core.Common.UI.Validation;assembly=Core.Common.UICore.Common.UI.Validation 5      i9clr-namespace:WaterNut.QuerySpace.CoreEntities.ViewModels+WaterNut.QuerySpace.CoreEntities.ViewModels  5      ,    &WaterNut.Views.EntryDataContainersView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/Expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      Gqs8clr-namespace:WaterNut.QuerySpace.EntryDataQS.ViewModels     5      [virtualGclr-namespace:Core.Common.UI.DataVirtualization;assembly=Core.Common.UI     5      kqsEntryDataEntitiesKclr-namespace:EntryDataQS.Client.Entities;assembly=WaterNut.Client.Entities     5      8
converters!clr-namespace:WaterNut.Converters     5
      V
validation?clr-namespace:Core.Common.UI.Validation;assembly=Core.Common.UI     5      RcoreEntities9clr-namespace:WaterNut.QuerySpace.CoreEntities.ViewModels     5      $��518.209��5   6   $��807.2��6G     � 	Resources  5      �� 5   
    �� Member$* $qs:EntryDataContainersModel.Instance��6      Key&"EntryDataContainersModelDataSource  6A   �� 5   
    �� 
TargetType" ��6   .�5      �� ;  5Core.Common.UI.DataVirtualization.VirtualListItemBase �� Property �@ AutoLoad �� Value . 6E   5      *   $WaterNut.Converters.NotBoolConverter  5   
   NotBoolConverter  6&   �� 5   
   EntryDataContainerTemplate   �� DataType-  'EntryDataQS.Client.Entities.ContainerEx"  6:   .R�5      � $	��861��6   $��70��6   ��5      �� 5       �� EndPoint$ 0.5,1&�6*    �� 
StartPoint$ 0.5,0&�6;   .��5      �  � Color$ 	#4C000000��6'   	 � Offset$	 0Q�69   � 5      $ 	#4CFFFFFF��6'   $	 1Q�69   5      .+�5      ��   TextBox2TextBlock#���  6   $��
710,3,0,42q�6�   $
��Left=�6�   $	��141��6�   $��14(�6�   ��6G   �� *Data.TotalValue+
 �� StringFormat$
 c�� �� Mode$ OneWay=�6�   �� 5      #���  6   $��
170,37,0,0q�6|   $
��Left=�6�   $	��232��6�   $��14(�6�   ��6G   �� *Data.Goods_description+$ OneWay=�6�   �� 5       #���  6   $��
170,3,0,38q�6}   $
��Left=�6�   $	��205��6�   $��14(�6�   ��6G   �� *Data.Container_identity+$ OneWay=�6�   �� 5!      #���  6   $��
407,3,0,45q�6�   $
��Left=�6�   $	��128��6�   $��14(�6�   ��6G   �� *Data.Packages_number+$
 Qty: 0��$ OneWay=�6�   �� 5"      #���  6   $��
407,40,0,0q�6�   $
��Left=�6�   $	��128��6�   $��14(�6�   ��6G   �� *Data.Packages_type+$ OneWay=�$
 Pkg. Type: 0��6�   �� 5#      #���  6   $��	10,0,0,38q�6y   $
��Left=�6�   $	��150��6�   $��14(�6�   ��6G   �� *Data.Container_type+$ OneWay=�6�   �� 5$      #���  6   $��
577,3,0,40q�6�   $
��Left=�6�   $	��128��6�   $��14(�6�   ��6G   �� *Data.ShipDate+$ OneWay=�$
 d��6�   �� 5%      #���  6   $��
577,40,0,0q�6�   $
��Left=�6�   $	��128��6�   $��14(�6�   ��6G   �� *Data.DeliveryDate+$ OneWay=�$
 d��6�   �� 5&      #���  6   $��710,30,0,10q�6z   $
��Left=�6�   $	��141��6�   $��14(�6�   ��6G   �� *Data.Packages_weight+$ OneWay=�6�   �� 5'      #���  6   $��	10,37,0,0q�6   $
��Left=�6�   $	��150��6�   $��14(�6�   ��6G   �� *Data.Empty_full_indicator+$ OneWay=�6�   5*      5+      .��5.      � -   5         �Name$ 
LayoutRoot��5.       � DataContext 6   ��  & "EntryDataContainersModelDataSource �� Source# [ .+�5/   
   �� $
��Left=�6   $��33��6/   $��9,14,0,0q�6;   $
��Wrap=�6M   $	��Top=�6a   $	��131��6y   $��21.333(�6�   $��
Containers��6�   �� 50   
   -   5         ��Name$ ItemLst��54   +     EntryDataContainerTemplate#���  51       �� SelectionMode$ Multiple=�54       %� IsVirtualizing .  %� VirtualizationMode$ 	Recycling=�56      ! �� IsDeferredScrollingEnabled . C  =Core.Common.UI.DataVirtualization.VirtualListLoadingIndicator   
IsAttached . $��Stretch=�59      $	��245��60   $��2,110,-1.667,0q�6=   $	��Top=�6U   $
��Auto��6m     AlphaListBoxStyle#���  6z    �� SelectedItem 50      �� >   8WaterNut.QuerySpace.EntryDataQS.ViewModels.BaseViewModel   Instance# Z  �� Path$ VCurrentContainerEx���52      �� *ContainerExes+59   z   �� 5;   
   -   5         ��Name$ MultiSelectChk��5;      $
��Left=�6+   $��26��6F   $��	14,79,0,0q�6R   $	��Top=�6e   $	��126��6}   $��MultiSelect��6�    d� 	IsChecked$ FalseY�6�   �� 5<   
   -   5         ��Name$ DeselectTxt��5<      $
��Left=�6)   $��22��6D   $��
161,79,0,0q�6P   $
��Wrap=�6d   $	��Top=�6x   $��98��6�   $��16(�6�   $��De-Select All��6�    �� TextAlignment$
 Left=�6�     TextButtonStyle#���  6�   6�   �� 5=   
   -   5        $ 	SelectTxt��5=      $
��Left=�6'   $��22��6B   $��
264,79,0,0q�6N   $
��Wrap=�6b   $	��Top=�6v   $��67��6�   $��16(�6�   $��
Select All��6�   $
 Left=�6�   #���  6�   6�   � 5?   
   $
��Left=�6l   $��96��6�   $��	0,370,0,0q�6�   $	��Top=�6�   $	��807��6�   ���	#4CFFFFFF 6   �� # Z $ CurrentContainerEx�.+�5@      �� $��	640,7,0,0q�6f   $
��Left=�6y   $��82��6�   $	��Top=�6�   $��24��6�   ��6   �� *
TotalValue+$
 c�� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5A      $��	90,42,0,0q�6]   $
��Left=�6p   $	��155��6�   $	��Top=�6�   $��51��6�   ��6   �� *Goods_description+$ PropertyChanged=�6�   �� 5B      $��	205,5,0,0q�6^   $
��Left=�6q   $	��228��6�   $	��Top=�6�   $��26��6�   ��6   �� *Container_identity+$ PropertyChanged=�6�   �� 5C      $��	482,0,0,4q�6[   $
��Left=�6n   $��85��6�   $��25��6�   $��Bottom=�6�   ��6   �� *Packages_number+$ PropertyChanged=�6�   �� 5D      $��
640,68,0,0q�6[   $
��Left=�6o   $��82��6�   $	��Top=�6�   $��24��6�   ��6   �� *Packages_weight+$ PropertyChanged=�6�   �� 5F      -   5        $ SaveItemTxt��5F      $
��Left=�6.   $��19��6I   $��
739,70,0,0q�6U   $	��Top=�6i   $��46��6�   #���  6�   $
��Wrap=�6�   $ Center=�6�   $��16(�6�    J� RenderTransformOrigin$ 
0.565,1.42&�6  �� 61  $
�Save��65  �� 6C  �� 6O  6V  �� 5G      -   5        $ SaveItemTxt_Copy��5G      $
��Left=�63   $��27��6N   $��	739,7,0,0q�6Z   $	��Top=�6m   $��46��6�   #���  6�   $
��Wrap=�6�   $ Center=�6�   $��16(�6  �� 6  $	�New��6  �� 6(  �� 64  6;  �� 5H       �� DisplayMemberPath$ PackageDescription��5I       �� SelectedValuePath$ PackageCode��5J      $
��Left=�5L      $��24��62   $��
482,39,0,0q�6>   $	��Top=�6R   $��85��6j   ��5H      �� *PackageTypes+# [   �� SelectedValue  5K      �� *Packages_type+5L   j   �� 5M      $��Identity��6   $
��Left=�6(   $��19��6C   $��	150,5,0,0q�6O   $
��Wrap=�6b   $	��Top=�6w   $��50��6�   �� 5N      $��Goods Description��6   $
��Left=�61   $��40��6L   $��	10,42,0,0q�6X   $
��Wrap=�6k   $	��Top=�6�   $��75��6�   (  "System.Windows.Controls.DatePicker  5O      $
��Left=�6;   $��24��6V   $��
316,39,0,0q�6b   $	��Top=�6v   $��90��6�   !   SelectedDate! 6   �� *
ShipDate+6�     5P      $
��Left=�6?   $��24��6Z   $��
316,62,0,0q�6f   $	��Top=�6z   $��90��6�   ! 6   �� *DeliveryDate+6�   �� 5Q      $��	Ship Date��6   $
��Left=�6*   $��19��6E   $��
251,39,0,0q�6Q   $
��Wrap=�6e   $	��Top=�6z   $��65��6�   �� 5R      $��	Del. Date��6   $
��Left=�6*   $��19��6E   $��
250,64,0,0q�6Q   $
��Wrap=�6e   $	��Top=�6z   $��65��6�   �� 5S      $��Pk. Type��6   $
��Left=�6)   $��19��6D   $��
412,41,0,0q�6P   $
��Wrap=�6d   $	��Top=�6y   $��65��6�   �� 5T      $��Quantity��6   $
��Left=�6)   $��19��6D   $��
412,67,0,0q�6P   $
��Wrap=�6d   $	��Top=�6y   $��65��6�   �� 5U      $��
Tot. Value��6   $
��Left=�6+   $��19��6F   $��
575,10,0,0q�6R   $
��Wrap=�6f   $	��Top=�6{   $��65��6�   �� 5V      $��Wgt. Kg.��6   $
��Left=�6)   $��19��6D   $��
572,68,0,0q�6P   $
��Wrap=�6d   $	��Top=�6y   $��65��6�   �� 5W      $ ContainerTypeDescription��5X      $ ContainerCode��5Y      $
��Left=�5[      $��24��6)   $��0,7,0,0q�65   $	��Top=�6F   $	��135��6^   ��5W      �� *ContainerTypes+# [   5Z      �� *Container_type+5[   ^   �� 5\      $ EmptyFullDescription��5]      $ EmptyFullCodeName��5^      $
��Left=�5`      $��24��6)   $��	457,5,0,0q�65   $	��Top=�6H   $	��110��6`   ��5\      �� *EmptyFullCodes+# [   5_      �� *Empty_full_indicator+5`   `   �� 5a      $��
643,39,0,0q�6Y   $
��Left=�6m   $��82��6�   $	��Top=�6�   $��24��6�   ��6   �� *Gross_weight+$ PropertyChanged=�6�   �� 5b      $��	Gross Kg.��6   $
��Left=�6*   $��19��6E   $��
575,39,0,0q�6Q   $
��Wrap=�6e   $	��Top=�6z   $��65��6�   5d      �� 5e   
   $
��Left=�6Z   $��24��6u   $��
145,14,0,0q�6�   $
��Wrap=�6�   $	��Top=�6�   $	��180��6�   $��20(�6�   $ Right=�6�   ���	#FFE4E453��6   �� *ContainerExes.Count+$
 0 Filtered Results��6�   �� 5f   
   $
��Left=�6K   $��24��6f   $��650,471,0,0q�6r   $
��Wrap=�6�   $	��Top=�6�   $	��147��6�   $��20(�6�   ���	#FFE4E453��6   �� *TotalTotalValue+$
 {0:c}��6�   �� 5g   
   -   5        #���  5g      $
��Left=�6?   $��24��6Z   $��
636,14,0,0q�6f   $
��Wrap=�6z   $��Send to Excel ��6�   $	��Top=�6�   $	��121��6�   $��16(�6�   $��Segoe UI Symbol)�6�   y�6  �� ?   9WaterNut.QuerySpace.CoreEntities.ViewModels.BaseViewModel"   Instance# Z" $3 -CurrentApplicationSettings.AllowExportToExcel��� 5i   
   $
��Left=�6Q   $��24��6l   $��498,471,0,0q�6x   $
��Wrap=�6�   $	��Top=�6�   $	��147��6�   $��20(�6�   $ Right=�6�   ���	#FFE4E453��6   �� *SelectedTotalValue+$
 {0:c} Of��6�   �� 5j   
   -	   5        $ SelectTxt_Copy��5j      $
��Left=�6,   $��22��6G   $��
650,43,0,0q�6S   $
��Wrap=�6g   $	��Top=�6{   $	��107��6�   $��16(�6�   $��Assign Invoice��6�   $
 Left=�6�   #���  6�   6  �� 5k   
   $
��Left=�6   $��23��6/   $��
341,43,0,0q�6;   $
��Wrap=�6O   $	��Top=�6c   $	��104��6{   $��14(�6�   $��
Start Date��6�   $ Center=�6�     5l   
   $
��Left=�6>   $��22��6Y   $��
450,43,0,0q�6e   $	��Top=�6y   $	��139��6�   ! 6   �� *StartDateFilter+6�   �� 5m   
   $
��Left=�6   $��23��6/   $��
341,67,0,0q�6;   $
��Wrap=�6O   $	��Top=�6c   $	��109��6{   $��14(�6�   $��End Date��6�   $ Center=�6�     5n   
   $
��Left=�6<   $��22��6W   $��
450,67,0,0q�6c   $	��Top=�6w   $	��139��6�   ! 6   �� *EndDateFilter+6�   �� 5o   
   -
   5        $ SelectTxt_Copy1��5o      $
��Left=�6-   $��22��6H   $��
690,79,0,0q�6T   $
��Wrap=�6h   $	��Top=�6|   $��67��6�   $��16(�6�   $��View All��6�   $
 Left=�6�   #���  6�   6�   5p      5q      