   M S B A M L   `   `   `  ����C  ?WaterNut, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullg8clr-namespace:WaterNut.QuerySpace.InventoryQS.ViewModels*WaterNut.QuerySpace.InventoryQS.ViewModels  5      I ECore.Common.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullmGclr-namespace:Core.Common.UI.DataVirtualization;assembly=Core.Common.UI!Core.Common.UI.DataVirtualization 5      S OWaterNut.Client.Entities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullkKclr-namespace:InventoryQS.Client.Entities;assembly=WaterNut.Client.EntitiesInventoryQS.Client.Entities 5      #clr-namespace:WaterNutWaterNut  5
      #    WaterNut.Views.TariffCategory   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/Expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      GQS8clr-namespace:WaterNut.QuerySpace.InventoryQS.ViewModels     5      [virtualGclr-namespace:Core.Common.UI.DataVirtualization;assembly=Core.Common.UI     5      kQSInventoryEntitiesKclr-namespace:InventoryQS.Client.Entities;assembly=WaterNut.Client.Entities     5      (localclr-namespace:WaterNut     5
        � 	Resources  5      �� 5   
    �� Member$% QS:TariffCategoryModel.Instance��6      Key!TariffCategoryModelDataSource  6<   �� 5   
    �� 
TargetType" ��6   .�5      �� ;  5Core.Common.UI.DataVirtualization.VirtualListItemBase �� Property �@ AutoLoad �� Value . 6E   5      �� 5      InventoryItemTemplate   �� DataType0  *InventoryQS.Client.Entities.TariffCategory"  6/   .R�5      � $��67��6
   $	��611��6   .+�5      ��   TextBox2TextBlock#���  6   $
��Left=�6v   $	��Top=�6�   $��	160,0,0,0q�6�   $��12(�6�   $	��352��6�   $��67��6�    �� TextWrapping$
 Wrap=�6�   ��6G   �� *Data.Description+ �� Mode$ OneWay=�6�   �� 5      #���  6   $
��Left=�6}   $	��Top=�6�   $��	10,10,0,0q�6�   $��31.781��6�   $��136.641��6�   $��16(�6�   $
��Bold"�6�   ��6G   �� *Data.TariffCategoryCode+$ OneWay=�6�   �� 5      #���  6   $
��Left=�6�   $	��Top=�6�   $��
517,10,0,0q�6�   $��32��6�   $��84��6�   $��17.333(�6�   ��6G   �� *Data.ParentTariffCategoryCode+$ OneWay=�6�   �� 5      $
��Left=�6F   $��25��6a   $��
496,42,0,0q�6m   $	��Top=�6�   $	��115��6�   $��License Required��6�    d� 	IsChecked 6   �� *Data.LicenseRequired+6�   5      5      .��5      � -   5        	 �Name$	 
LayoutRoot��5      
 � DataContext
 6   ��  ! TariffCategoryModelDataSource �� Source# [ .+�5      �� $
��Left=�6   $��32.766��6)   $��8.838,14.011,0,0q�69   $
��Wrap=�6S   $	��Top=�6g   $��396.779��6   $��21.333(�6�   �� 6�   $�Tariff Categories��6�   �� 6�   �� 6�   6�   �� 5   
   $
��Left=�6   $	��307��6-   $��-1,173,-10,0q�6:   $	��Top=�6P   $	��651��6h     InventoryItemTemplate#���  5         AlphaListBoxStyle#���  5!   :    �� SelectedItem 5      �� >   8WaterNut.QuerySpace.InventoryQS.ViewModels.BaseViewModel   Instance# Z  �� Path$ VCurrentTariffCategory�$ OneWayToSource=���5!      �� *TariffCategory+6:   �� 5"      $
��Left=�6   $��33��6)   $��	10,52,0,0q�65   $
��Wrap=�6H   $	��Top=�6\   $	��154��6t   $��16(�6�   $��Tariff Category Code��6�    �� TextAlignment$ Center=�6�   �� 5#      $
��Left=�6   $��33��6)   $��
169,52,0,0q�65   $
��Wrap=�6I   $	��Top=�6]   $	��283��6u   $��16(�6�   $��Description��6�   $ Center=�6�   �� 5$      $
��Left=�6   $��33��6)   $��
481,52,0,0q�65   $
��Wrap=�6I   $	��Top=�6]   $	��154��6u   $��16(�6�   $��Parent Cat. Codes��6�   $ Center=�6�   �� 5%   
   -   5        ���	#7FFFFFFF$
��Left=�5%   r   $��33��6�   $��	10,85,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��154��6�   $��16(�6�    �� TextAlignment$ Center=�6�     TransparentTextBoxStyle#���  6
  ��6   �� *TariffCategoryCodeFilter+ �� UpdateSourceTrigger$ Explicit=�6=  �� 5&   
   -   5        ���	#4CFFFFFF$
��Left=�5&   j   $��33��6�   $��
169,85,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��307��6�   $��16(�6�   $ Center=�6�   #���  6  ��6   �� *DescriptionFilter+$ Explicit=�66  �� 5'   
   -   5        ���	#4CFFFFFF$
��Left=�5'   w   $��29��6�   $��
481,85,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��154��6�   $��16(�6�   $ Center=�6�   #���  6  ��6   �� * ParentTariffCategoryCodeFilter+$ Explicit=�6A  �� 5(   
   -   5        $
��Left=�5(      $��26��6/   $��555,142,0,0q�6;   $
��Wrap=�6P   $��View All��6d   $	��Top=�6t   $��75��6�   $��16(�6�     TextButtonStyle#���  6�   $ Right=�6�   6�   �� 5)   
   $
��Left=�6?   $��25��6Z   $��481,119,0,0q�6f   $	��Top=�6{   $	��149��6�   $��License Required��6�    6   �� *LicenseRequiredFilter+6�   5*      5+      