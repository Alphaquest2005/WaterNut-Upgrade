   M S B A M L   `   `   `  ����S  OWaterNut.Client.Entities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullkKclr-namespace:InventoryQS.Client.Entities;assembly=WaterNut.Client.EntitiesInventoryQS.Client.Entities  5      I ECore.Common.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullmGclr-namespace:Core.Common.UI.DataVirtualization;assembly=Core.Common.UI!Core.Common.UI.DataVirtualization 5      C ?WaterNut, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WaterNutWaterNut 5	      g8clr-namespace:WaterNut.QuerySpace.InventoryQS.ViewModels*WaterNut.QuerySpace.InventoryQS.ViewModels 5
      i9clr-namespace:WaterNut.QuerySpace.CoreEntities.ViewModels+WaterNut.QuerySpace.CoreEntities.ViewModels 5      ,   &WaterNut.Views.NullTarifInventoryItems   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/Expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      kQSInventoryEntitiesKclr-namespace:InventoryQS.Client.Entities;assembly=WaterNut.Client.Entities     5      [virtualGclr-namespace:Core.Common.UI.DataVirtualization;assembly=Core.Common.UI     5      (localclr-namespace:WaterNut     5	      Hqsv8clr-namespace:WaterNut.QuerySpace.InventoryQS.ViewModels     5
      Iqcv9clr-namespace:WaterNut.QuerySpace.CoreEntities.ViewModels     5      $��649.552��5   H     � 	Resources  5      �� 5   
    �� Member$&  qsv:InventoryItemsModel.Instance��6      Key*&NullTarifInventoryItemsModelDataSource  6=   �� 5   
    �� 
TargetType" ��6   .�5      �� ;  5Core.Common.UI.DataVirtualization.VirtualListItemBase �� Property �@ AutoLoad �� Value . 6E   5      �� 5   
   InventoryItemTemplate   �� DataType2   ,InventoryQS.Client.Entities.InventoryItemsEx"  65   .R�5      � $��51.781��6   $��611.294��6#   .+�5      ��   TextBox2TextBlock#���  6   $
��Left=�6s   $	��Top=�6�   $��
170,26,0,0q�6�   $	��320��6�   $��16��6�   ��6G   �� *Data.Category+ �� Mode$ OneWay=�6�   �� 5      #���  6   $
��Left=�6v   $	��Top=�6�   $��	170,0,0,0q�6�   $��16(�6�   $	��320��6�   ��6G   �� *Data.Description+$ OneWay=�6�   �� 5      #���  6   $
��Left=�6u   $	��Top=�6�   $��	28,10,0,0q�6�   $��32��6�   $	��137��6�   $��16(�6�   $
��Bold"�6�   ��6G   �� *Data.ItemNumber+$ OneWay=�6�   �� 5      -   5        $
��Left=�5   h   $	��Top=�6�   $��
495,10,0,0q�6�   $��32��6�   $	��106��6�   $��17.333(�6�   ��6   �� *Data.TariffCode+$ TwoWay=� �� UpdateSourceTrigger$ Explicit=�6�   �� 5      $
��Left=�6   $��51��67   $��0,1,0,-0.219q�6C   $	��Top=�6k   $��15��6�   ��6Y   Z� ��5      
� 5      .��5      �  � Color$ White��6+   	 � Offset$	 0.011Q�69   � 5      $ 	#FF5872AB��6+   $	 1Q�6=   5      5      5       5!      .��5$      � -   5        
 �Name$
 
LayoutRoot��5$       � DataContext 6   ��  * &NullTarifInventoryItemsModelDataSource �� Source# [ .+�5%   
   �� $
��Left=�6   $��33��6/   $��9,14,0,0q�6;   $
��Wrap=�6M   $	��Top=�6a   $	��200��6y   $��21.333(�6�   �� 6�   $�Inventory Items List��6�   �� 6�   �� 6�   6�   �� 5&   
   -   5         ��Name$ ItemLst��5&      $
��Left=�6#   $	��286��6>   $��0,225,-1.667,-31q�6K   $	��Top=�6e   $	��651��6}    %� IsVirtualizing .  %� VirtualizationMode$ 	Recycling=�5(      ! �� IsDeferredScrollingEnabled . C  =Core.Common.UI.DataVirtualization.VirtualListLoadingIndicator   
IsAttached .   InventoryItemTemplate#���  5,       �� SelectionMode$ Multiple=�5.        AlphaListBoxStyle#���  6X    �� SelectedItem 5+      �� >  8WaterNut.QuerySpace.InventoryQS.ViewModels.BaseViewModel   Instance# Z  �� Path$ VCurrentInventoryItemsEx�$ OneWayToSource=���5-      �� *InventoryItemsEx+5.   X   �� 5/   
   $
��Left=�6   $��26��6/   $��
10,105,0,0q�6;   $
��Wrap=�6O   $	��Top=�6c   $	��154��6{   $��16(�6�   $��Item Number��6�    �� TextAlignment$ Center=�6�   �� 50   
   $
��Left=�6   $��26��6/   $��169,105,0,0q�6;   $
��Wrap=�6P   $	��Top=�6d   $	��283��6|   $��16(�6�   $��Description��6�   $ Center=�6�   �� 51   
   $
��Left=�6   $��26��6/   $��476,105,0,0q�6;   $
��Wrap=�6P   $	��Top=�6d   $	��154��6|   $��16(�6�   $��Tariff Codes��6�   $ Center=�6�   �� 52   
   -   5        ���	#7FFFFFFF$
��Left=�52   j   $��33��6�   $��
10,131,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��154��6�   $��16(�6�    �� TextAlignment$ Center=�6�     TransparentTextBoxStyle#���  6  ��6   �� *ItemNumberFilter+$ Explicit=�65  �� 53   
   -   5        ���	#4CFFFFFF$
��Left=�53   j   $��33��6�   $��169,131,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��307��6�   $��16(�6�   $ Center=�6�   #���  6  ��6   �� *DescriptionFilter+$ Explicit=�66  �� 54   
   -   5        ���	#4CFFFFFF$
��Left=�54   i   $��33��6�   $��481,131,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��154��6�   $��16(�6�   $ Center=�6�   #���  6  ��6   �� *TariffCodeFilter+$ Explicit=�64  �� 55   
   -   5        ���	#4CFFFFFF$
��Left=�55   g   $��24��6�   $��169,169,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��307��6�   $��13.333(�6�   $ Center=�6�   #���  6  ��6   �� *CategoryFilter+$ Explicit=�67  �� 56   
   $
��Left=�68   $��23��6S   $��
242,74,0,0q�6_   $	��Top=�6s   $	��112��6�   $��View New Items��6�    d� 	IsChecked 6   �� *ViewNullTariff+6�   �� 57   
   -   5         ��Name$ AssignTariffTxt��57      $
��Left=�6-   $��22��6H   $��482,198,0,0q�6T   $
��Wrap=�6i   $	��Top=�6}   $	��154��6�   $��16(�6�   $��Assign Tariff Code��6�   $ Center=�6�     TextButtonStyle#���  6�   6
  �� 58   
   -	   5        $ DeselectTxt��58      $
��Left=�6)   $��22��6D   $��156,198,0,0q�6P   $
��Wrap=�6e   $	��Top=�6y   $	��154��6�   $��16(�6�   $��De-Select All��6�   $
 Left=�6�   #���  6�   6�   �� 59   
   -
   5        $ 	SelectTxt��59      $
��Left=�6'   $��22��6B   $��315,198,0,0q�6N   $
��Wrap=�6c   $	��Top=�6w   $��83��6�   $��16(�6�   $��
Select All��6�   $
 Left=�6�   #���  6�   6�   �� 5:   
   $
��Left=�68   $��23��6S   $��
481,28,0,0q�6_   $	��Top=�6s   $	��159��6�   $��View Sales Items��6�   $y�Hidden=�6�    6   �� *ViewSalesItems+6�   �� 5;   
   -   5         ��Name$ MultiSelectChk��5;      $
��Left=�6+   $��23��6F   $��	3,197,0,0q�6R   $	��Top=�6e   $	��111��6}   $��Multiple Select��6�   �� 5<   
   $
��Left=�66   $��23��6Q   $��
131,74,0,0q�6]   $	��Top=�6q   $	��106��6�   $��View PO Items��6�    6   �� *ViewPOItems+6�   �� 5=   
   $
��Left=�6;   $��32��6V   $��
359,74,0,0q�6b   $	��Top=�6v   $��90��6�   $��View Wrong
 Tariff Codes��6�    6   �� *ViewUnknownTariff+6�   �� 5>   
   $
��Left=�6]   $��24��6x   $��
221,21,0,0q�6�   $
��Wrap=�6�   $	��Top=�6�   $	��201��6�   $��20(�6�   $ Right=�6�   ���	#FFE4E453��6   �� *InventoryItemsEx.Count+ �� StringFormat$ 0 Filtered Results��6�   �� 5?   
   $
��Left=�6:   $��23��6U   $��	20,74,0,0q�6a   $	��Top=�6t   $	��106��6�   $��View Doc Items��6�    6   �� *ViewDocSetItems+6�   �� 5@   
   -   5        #���  5@      $
��Left=�6?   $��24��6Z   $��
515,14,0,0q�6f   $
��Wrap=�6z   $��Send to Excel ��6�   $	��Top=�6�   $	��121��6�   $��16(�6�   $��Segoe UI Symbol)�6�   y�6  �� ?  9WaterNut.QuerySpace.CoreEntities.ViewModels.BaseViewModel   Instance# Z $3 -CurrentApplicationSettings.AllowExportToExcel��� 5A   
   -   5        $
��Left=�5A      $��26��6/   $��560,169,0,0q�6;   $
��Wrap=�6P   $��View All��6d   $	��Top=�6t   $��75��6�   $��16(�6�   #���  6�   $ Right=�6�   6�   �� 5B   
   $
��Left=�6A   $��33��6\   $��
500,74,0,0q�6h   $	��Top=�6|   $	��106��6�   $!��View Current 
Tariff Codes��6�    6   �� *ViewCurrentTariffCodes+6�   �� 5C   
   -   5        #���  5C      $
��Left=�6?   $��24��6Z   $��
440,38,0,0q�6f   $
��Wrap=�6z   $��Map Inventory to Asycuda��6�   $	��Top=�6�   $	��190��6�   $��16(�6�   $��Segoe UI Symbol)�6�   y�6   �� *+)CurrentApplicationSettings.AllowCleanBond+# Z 5D      5E      