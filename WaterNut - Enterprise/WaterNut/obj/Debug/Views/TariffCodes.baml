   M S B A M L   `   `   `  ����C  ?WaterNut, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullg8clr-namespace:WaterNut.QuerySpace.InventoryQS.ViewModels*WaterNut.QuerySpace.InventoryQS.ViewModels  5      S OWaterNut.Client.Entities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullkKclr-namespace:InventoryQS.Client.Entities;assembly=WaterNut.Client.EntitiesInventoryQS.Client.Entities 5      I ECore.Common.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullmGclr-namespace:Core.Common.UI.DataVirtualization;assembly=Core.Common.UI!Core.Common.UI.DataVirtualization 5      #clr-namespace:WaterNutWaterNut  5
      i9clr-namespace:WaterNut.QuerySpace.CoreEntities.ViewModels+WaterNut.QuerySpace.CoreEntities.ViewModels  5           WaterNut.Views.TariffCodes   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/Expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      GQS8clr-namespace:WaterNut.QuerySpace.InventoryQS.ViewModels     5      kQSInventoryEntitiesKclr-namespace:InventoryQS.Client.Entities;assembly=WaterNut.Client.Entities     5      [virtualGclr-namespace:Core.Common.UI.DataVirtualization;assembly=Core.Common.UI     5      (localclr-namespace:WaterNut     5
      RcoreEntities9clr-namespace:WaterNut.QuerySpace.CoreEntities.ViewModels     5        � 	Resources  5      �� 5   
    �� Member$" QS:TariffCodesModel.Instance��6      KeyTariffCodesModelDataSource  69   �� 5   
    �� 
TargetType" ��6   .�5      �� ;  5Core.Common.UI.DataVirtualization.VirtualListItemBase �� Property �@ AutoLoad �� Value . 6E   5      �� 5   
   InventoryItemTemplate   �� DataType-  'InventoryQS.Client.Entities.TariffCodes"  65   .R�5      � $��67��6   $	��611��6    � ColumnDefinitions 5      �� 5      $
��594* �6'   �� 5      $	��17* �6'   .+�5      ��   TextBox2TextBlock#���  6   $
��Left=�6v   $	��Top=�6�   $��	160,0,0,0q�6�   $��16(�6�   $	��322��6�   $��48��6�    �� TextWrapping$
 Wrap=�6�   ��6G   �� *Data.Description+ �� Mode$ OneWay=�6�   �� 5      #���  6   $
��Left=�6u   $	��Top=�6�   $��	25,10,0,0q�6�   $��32��6�   $	��122��6�   $��16(�6�   $
��Bold"�6�   ��6G   �� *Data.TariffCode+$ OneWay=�6�   �� 5      	 ��Name$	 ParentTarifCodeTxt��6   -   5        $
��Left=�5   a   $	��Top=�6|   $��	496,0,0,0q�6�   $��30��6�   $	��105��6�   $��17.333(�6�     TextButtonStyle#���  6�   $��2��64  ��68   �� *Data.TariffCategoryCode+64  �� 5      $
��Left=�6   $��18��67   $��
264,49,0,0q�6C   $
��Wrap=�6W   $	��D.L��6k   $	��Top=�6v   $��24��6�   �� 5      $
��Left=�6   $��18��67   $��
340,48,0,0q�6C   $
��Wrap=�6W   $��C.S.C.��6k   $	��Top=�6y   $��30��6�   �� 5      $
��Left=�6   $��18��67   $��
430,48,0,0q�6C   $
��Wrap=�6W   $��V.A.T��6k   $	��Top=�6x   $��30��6�   �� 5      #���  6   $
��Left=�6�   $��18��6�   $��
293,49,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��34��6�   ��6G   �� *Data.RateofDuty+
 �� StringFormat$
 p��$ OneWay=�6�   �� 5       #���  6   $
��Left=�6�   $��18��6�   $��
375,48,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��45��6�   ��6G   �� *Data.CustomsServiceCharge+$
 p��$ OneWay=�6�   �� 5!      #���  6   $
��Left=�6�   $��18��6�   $��
465,48,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��38��6�   ��6G   �� *Data.VatRate+$
 p��$ OneWay=�6�   �� 5"      $	 	AssignTxt��6   -   5        $
��Left=�5"   /   $��18��6J   $��
542,48,0,0q�6V   $
��Wrap=�6j   $	��Top=�6~   $��59��6�   #���  6�   $��2��6�   $y�Hidden=�6  �� 6&  $�	Assign...��6*  �� 6=  �� 6I  �� 6O  �� 6[  6b  �� 5#      $	 ItemsTxt��6   -   5        $
��Left=�5#   .   $��18��6I   $��0,49,0,0q�6U   $
��Wrap=�6g   $	��Top=�6{   $	��101��6�   #���  6�   $��Inventory Items...��6�   $y�Hidden=�6  �� 5$      $
��Left=�6   $��18��67   $��
196,48,0,0q�6C   $
��Wrap=�6W   $
��E.L.��6k   $	��Top=�6w   $��24��6�   �� 5%      #���  6   $
��Left=�6�   $��18��6�   $��
225,48,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��34��6�   ��6G   �� *Data.EnvironmentalLevy+$
 p��$ OneWay=�6�   �� 5&      $
��Left=�6   $
��Auto��67   $��
128,48,0,1q�6E   $
��Wrap=�6Y   $	��Ex.��6m   $��Stretch=�6x   $��24��6�   �� 5'      #���  6   $
��Left=�6�   $��18��6�   $��
157,48,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��34��6�   ��6G   �� *Data.ExciseTax+$
 p��$ OneWay=�6�   �� 5(      $
��Left=�6   $��65��67   $��0,1,0,0q�6C   $	��Top=�6f   $��20��6~   ��6T   Z� ��5)      
� 5*      .��5+      �  � Color$ White��6+    � Offset$ 0.011Q�69   � 5,      $ 	#FF5872AB��6+   $ 1Q�6=   5-      5/      50      51      .��54      � -   5         �Name$ 
LayoutRoot��54       � DataContext 6   ��   TariffCodesModelDataSource �� Source# [  55   
   �� 56      $
��237* �6   �� 57      $	��83* �6   .+�59   
   �� $
��Left=�6   $��33��6/   $��9,14,0,0q�6;   $
��Wrap=�6M   $	��Top=�6a   $	��155��6y   $��21.333(�6�   �� 6�   $�Tariff Codes��6�   �� 6�   �� 6�   6�   �� 5:   
   $
��Left=�6   $	��307��6-   $��-1,173,-10,0q�6:   $	��Top=�6P   $	��651��6h     InventoryItemTemplate#���  5<      $��2��5=   6     AlphaListBoxStyle#���  6K    �� SelectedItem 5;      �� >   8WaterNut.QuerySpace.InventoryQS.ViewModels.BaseViewModel   Instance# Z  �� Path$ VCurrentTariffCodes�$ OneWayToSource=���5=      �� *TariffCodes+6K   �� 5>   
   $
��Left=�6   $��33��6/   $��	10,52,0,0q�6;   $
��Wrap=�6N   $	��Top=�6b   $	��154��6z   $��16(�6�   $��Tariff Code��6�    �� TextAlignment$ Center=�6�   �� 5?   
   $
��Left=�6   $��33��6/   $��
169,52,0,0q�6;   $
��Wrap=�6O   $	��Top=�6c   $	��283��6{   $��16(�6�   $��Description��6�   $ Center=�6�   �� 5@   
   $
��Left=�6   $��33��6/   $��
7.4,52,0,0q�6;   $
��Wrap=�6O   $	��Top=�6c   $	��154��6{   $��16(�6�   $��Tariff Category Code��6�   $ Center=�6�   $��1��6�   �� 5A   
   -   5        ���	#7FFFFFFF$
��Left=�5A   v   $��33��6�   $��	10,85,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��154��6�   $��16(�6�    �� TextAlignment$ Center=�6�     TransparentTextBoxStyle#���  6  ��6   �� *TariffCodeFilter+$ TwoWay=� �� UpdateSourceTrigger$ Explicit=�6@  �� 5B   
   -   5        ���	#4CFFFFFF$
��Left=�5B   v   $��33��6�   $��
169,85,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��307��6�   $��16(�6�   $ Center=�6�   #���  6  $��2��6j  ��6   �� *DescriptionFilter+$ TwoWay=�$ Explicit=�6j  �� 5C   
   -   5        ���	#4CFFFFFF$
��Left=�5C   }   $��33��6�   $��
7.4,85,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��154��6�   $��16(�6�   $ Center=�6�   #���  6  $��1��6p  ��6   �� *TariffCategoryCodeFilter+$ TwoWay=�$ Explicit=�6p  �� 5D   
   -   5        $
��Left=�5D      $��26��6/   $��81.4,142,0,0q�6;   $
��Wrap=�6Q   $��View All��6e   $	��Top=�6u   $��75��6�   $��16(�6�   #���  6�   $ Right=�6�   $��1��6  �� 5E   
   -	   5        $
��Left=�5E      $��51��6/   $��	48,10,0,0q�6;   $
��Wrap=�6N   $#��Validate Existing TariffCodes��6b   $	��Top=�6�   $	��118��6�   $��16(�6�   #���  6�   $ Right=�6�   $��1��6#  y�63  �� ?   9WaterNut.QuerySpace.CoreEntities.ViewModels.BaseViewModel   Instance# Z $9 3CurrentApplicationSettings.AllowValidateTariffCodes�5F      5G      