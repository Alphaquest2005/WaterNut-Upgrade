   M S B A M L   `   `   `  ����I  ECore.Common.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullmGclr-namespace:Core.Common.UI.DataVirtualization;assembly=Core.Common.UI!Core.Common.UI.DataVirtualization  5      S OWaterNut.Client.Entities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullyRclr-namespace:PreviousDocumentQS.Client.Entities;assembly=WaterNut.Client.Entities"PreviousDocumentQS.Client.Entities 5      C ?WaterNut, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulli9clr-namespace:WaterNut.QuerySpace.CoreEntities.ViewModels+WaterNut.QuerySpace.CoreEntities.ViewModels 5      u?clr-namespace:WaterNut.QuerySpace.PreviousDocumentQS.ViewModels1WaterNut.QuerySpace.PreviousDocumentQS.ViewModels 5      "   WaterNut.Views.PreviousItems   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    YvirtualGclr-namespace:Core.Common.UI.DataVirtualization;assembly=Core.Common.UI    5      wqsPreviousDocumentEntitiesRclr-namespace:PreviousDocumentQS.Client.Entities;assembly=WaterNut.Client.Entities    5      Gqcv9clr-namespace:WaterNut.QuerySpace.CoreEntities.ViewModels    5      T
viewModels?clr-namespace:WaterNut.QuerySpace.PreviousDocumentQS.ViewModels    5      Hmc;http://schemas.openxmlformats.org/markup-compatibility/2006    5      >d2http://schemas.microsoft.com/Expression/blend/2008    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5	        � 	Resources  5      �� 5   
    �� Member$0 *viewModels:PreviousItemsViewModel.Instance��6      Key PreviousItemsModelDataSource  6G   �� 5   
    �� 
TargetType" ��6   .�5      �� ;   5Core.Common.UI.DataVirtualization.VirtualListItemBase �� Property �@ AutoLoad �� Value . 6E   5      �� 5   
   %!PreviousItemsDataTemplateTemplate   �� DataType8  2PreviousDocumentQS.Client.Entities.PreviousItemsEx"  6A   .R�5      � $��95��6A   .+�5      ��   TextBox2TextBlock#���  6Y   $
��Left=�6�   $��30��6�   $��35,0,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��250��6�   $��16(�6�   $
��Bold"�6   �� TextAlignment$ Center=�6  ��6   �� *!PreviousDocumentItem.ItemNumber+ �� Mode$ OneWay=�6  �� 5      #���  6L   $
��Left=�6y   $��30��6�   $��	315,0,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��165��6�   $��14(�6�   $��Normal"�6�   ��6   �� *!PreviousDocumentItem.TariffCode+6�   �� 5      #���  6F   $
��Left=�6s   $��30��6�   $��	565,0,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��60��6�   $��14(�6�   $��Normal"�6�   ��6   �� *QtyAllocated+$ OneWay=�6�   �� 5      $
��Left=�6   $��20��68   $��
630,10,0,0q�6D   $
��Wrap=�6X   $��Of��6l   $	��Top=�6v   $��17��6�   �� 5      #���  6B   $
��Left=�6o   $��30��6�   $��	652,0,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��60��6�   $��14(�6�   $��Normal"�6�   ��6   �� *Suplementary_Quantity+6�   � 5      $
��Left=�6   $��51��62   $��	16,35,0,0q�6>   $	��Top=�6Q   $	��439��6i   ���	#7FE7EC9C.+�5      �� #���  6E   $
��Left=�6r   $��25��6�   $��10,0,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��95��6�   $��12(�6�   $
��Bold"�6�   $ Center=�6  ��6   �� *	CNumber+$ OneWay=�6  �� 5      #���  6^   $
��Left=�6�   $��25��6�   $��	130,0,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��119��6�   $��12(�6�   $��Normal"�6  $ Center=�6  ��6   �� *RegistrationDate+	 �� StringFormat$	 d��$ OneWay=�6  �� 5      #���  6D   $
��Left=�6q   $��25��6�   $��10,0,0,1q�6�   $
 Wrap=�6�   $��Bottom=�6�   $��95��6�   $��12(�6�   $
��Bold"�6�   $ Center=�6  ��6   �� *Current_item_number+6  �� 5       #���  6F   $
��Left=�6s   $��25��6�   $��
110,25,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��95��6�   $��12(�6�   $��Normal"�6�   $ Center=�6  ��6   �� *Suplementary_Quantity+6  �� 5!      #���  6U   $
��Left=�6�   $��25��6�   $��
210,25,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��95��6�   $��12(�6�   $��Normal"�6  $ Center=�6  ��6   �� *Packages_number+$	 0:pkgs��6  �� 5"      #���  6N   $
��Left=�6{   $��25��6�   $��
310,25,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��95��6�   $��12(�6�   $��Normal"�6�   $ Center=�6  ��6   �� *
Net_weight+$
	 0 kg��6  5$      � 5%      $
��Left=�6   $��51��62   $��
474,35,0,0q�6>   $	��Top=�6R   $	��443��6j   ���	#7FBCF4AA.+�5&      �� #���  6=   $
��Left=�6j   $��25��6�   $��10,0,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��95��6�   $��12(�6�   $
��Bold"�6�   $ Center=�6�   ��6   �� *Prev_reg_nbr+6�   �� 5'      #���  6M   $
��Left=�6z   $��25��6�   $��	130,0,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��131��6�   $��12(�6�   $��Normal"�6�   $ Center=�6  ��6   �� *Prev_reg_dat+$	 d��6  �� 5(      #���  6M   $
��Left=�6z   $��25��6�   $��	266,0,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��95��6�   $��12(�6�   $��Normal"�6�   $ Center=�6  ��6   �� *Prev_reg_cuo+$	 d��6  �� 5)      #���  6E   $
��Left=�6r   $��25��6�   $��	10,25,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��95��6�   $��12(�6�   $
��Bold"�6�   $ Center=�6  ��6   �� *Previous_item_number+6  �� 5*      #���  6P   $
��Left=�6}   $��25��6�   $��
110,25,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��95��6�   $��12(�6�   $��Normal"�6�   $ Center=�6  ��6   �� *!Preveious_suplementary_quantity+6  �� 5+      #���  6^   $
��Left=�6�   $��25��6�   $��
210,25,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��95��6�   $��12(�6�   $��Normal"�6  $ Center=�6  ��6   �� *Previous_Packages_number+$	 0:pkgs��6  �� 5,      #���  6S   $
��Left=�6�   $��25��6�   $��
310,25,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��95��6�   $��12(�6�   $��Normal"�6   $ Center=�6  ��6   �� *Prev_net_weight+$
	 0 kg��6  5-      �� 5.      $
��Left=�6   $��85��67   $��0,1,0,0q�6C   $	��Top=�6f   $��16��6~   ��6T   Z� ��5/      
� 50      .��51      � 
 � Color$
 White��6+    � Offset$ 0.011Q�69   � 52      $
 	#335872AB��6+   $ 1Q�6=   53      55      57      58      .��5;      � -   5         �Name$ 
LayoutRoot��5;       � DataContext 6   ��    PreviousItemsModelDataSource �� Source# [ .+�5<   
   �� $
��Left=�6   $��33��6/   $��9,14,0,0q�6;   $
��Wrap=�6M   $	��Top=�6a   $	��209��6y   $��21.333(�6�   $��Previous Item Details��6�   �� 5=   
   -   5         ��Name$ ItemLst��5?   9    % !PreviousItemsDataTemplateTemplate#���  5=        AlphaListBoxStyle#���  5?   K   $��Stretch=�6x   $	��385��6�   $��0,95,0,0q�6�   $	��Top=�6�   $
��Auto��6�    �� SelectedItem 5>      �� E  ?WaterNut.QuerySpace.PreviousDocumentQS.ViewModels.BaseViewModel   Instance# Z  �� Path$ CurrentPreviousItemsEx���5?      �� *PreviousItems+6�   �� 5@   
   $
��Left=�6Z   $��24��6u   $��
223,19,0,0q�6�   $
��Wrap=�6�   $	��Top=�6�   $	��201��6�   $��20(�6�    �� TextAlignment$ Right=�6�   ���	#FFE4E453��6   �� *PreviousItems.Count+$	 0 Filtered Results��6�   �� 5A   
   -   5          TextButtonStyle#���  5A      $
��Left=�6?   $��24��6Z   $��
511,19,0,0q�6f   $
��Wrap=�6z   $��Send to Excel ��6�   $	��Top=�6�   $	��121��6�   $��16(�6�   $��Segoe UI Symbol)�6�   y�6  �� ?  9WaterNut.QuerySpace.CoreEntities.ViewModels.BaseViewModel   Instance# Z $3 -CurrentApplicationSettings.AllowExportToExcel��� 5B   
   $
��Left=�6   $��23��6/   $��	13,63,0,0q�6;   $
��Wrap=�6N   $	��Top=�6b   $	��112��6z   $��16(�6�   $��Prev. cNumber��6�   $ Center=�6�   �� 5C   
   -   5        ���	#7FFFFFFF$
��Left=�5C   y   $��23��6�   $��
130,63,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��117��6�   $��16(�6�   $ Center=�6�     TransparentTextBoxStyle#���  6  ��6   �� *Prev_reg_nbrFilter+$ TwoWay=� �� UpdateSourceTrigger$ Explicit=�6E  �� 5D   
   $
��Left=�6   $��23��6/   $��
252,63,0,0q�6;   $
��Wrap=�6O   $	��Top=�6c   $	��117��6{   $��16(�6�   $��Prev. Line No.��6�   $ Center=�6�   �� 5E   
   -   5        ���	#7FFFFFFF$
��Left=�5E   �   $��23��6�   $��
369,63,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��117��6�   $��16(�6�   $ Center=�6  #���  6  ��6   �� *Previous_item_numberFilter+$ TwoWay=�$ Explicit=�6M  5F      5G      