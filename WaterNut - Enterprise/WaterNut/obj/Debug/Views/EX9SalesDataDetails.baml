   M S B A M L   `   `   `  ����C  ?WaterNut, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WaterNutWaterNut  5      g8clr-namespace:WaterNut.QuerySpace.SalesDataQS.ViewModels*WaterNut.QuerySpace.SalesDataQS.ViewModels  5      S OWaterNut.Client.Entities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullkKclr-namespace:SalesDataQS.Client.Entities;assembly=WaterNut.Client.EntitiesSalesDataQS.Client.Entities 5      I ECore.Common.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullmGclr-namespace:Core.Common.UI.DataVirtualization;assembly=Core.Common.UI!Core.Common.UI.DataVirtualization 5      9!clr-namespace:WaterNut.ConvertersWaterNut.Converters  5      i9clr-namespace:WaterNut.QuerySpace.CoreEntities.ViewModels+WaterNut.QuerySpace.CoreEntities.ViewModels  5      (    "WaterNut.Views.Ex9SalesDataDetails   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     6P   @d2http://schemas.microsoft.com/Expression/blend/2008     6�   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6�   (localclr-namespace:WaterNut     5      Hqsv8clr-namespace:WaterNut.QuerySpace.SalesDataQS.ViewModels     5      gQSSalesEntitiesKclr-namespace:SalesDataQS.Client.Entities;assembly=WaterNut.Client.Entities     5      [virtualGclr-namespace:Core.Common.UI.DataVirtualization;assembly=Core.Common.UI     5      8
Converters!clr-namespace:WaterNut.Converters     5      RcoreEntities9clr-namespace:WaterNut.QuerySpace.CoreEntities.ViewModels     5      $	��856��5   ;   $��528.955��6X     � 	Resources  5	      �� 5
   
    �� Member$+ %qsv:EX9SalesDataDetailsModel.Instance��6      Key&"Ex9SalesDataDetailsModelDataSource  6B   �� 5   
    �� 
TargetType" ��6   .�5      �� ;  5Core.Common.UI.DataVirtualization.VirtualListItemBase �� Property �@ AutoLoad �� Value . 6E   5      *   $WaterNut.Converters.NotBoolConverter  5   
   NotBoolConverter  6&   �� 5   
   EntryDataDetailTemplate   �� DataType+  %SalesDataQS.Client.Entities.SalesData"  67   .R�5      � $	��834��6   $��42��6   .+�5      ��   TextBox2TextBlock#���  6   $��
655,4,0,20q�6r   $
��Left=�6�   $��58��6�   $��14(�6�   ��6G   �� *Data.CNumber+ �� Mode$ OneWay=�6�   �� 5      #���  6   $��444,28,0,-3.64q�6   $
��Left=�6�   $��45��6�   ��6G   �� *	Data.Cost+ �� StringFormat$ c��$ OneWay=�6�   �� 5      #���  6   $��	170,4,0,8q�6z   $
��Left=�6�   $	��293��6�    �� TextWrapping$
 Wrap=�6�   $��14(�6�   ��6G   �� *Data.ItemDescription+$ OneWay=�6�   �� 5      #���  6   $��
80,15,0,10q�6u   $
��Left=�6�   $��85��6�   $��14(�6�   ��6G   �� *Data.ItemNumber+$ OneWay=�6�   �� 5      #���  6   $��
468,8,0,14q�6�   $
��Left=�6�   $��45��6�   $��14(�6�   ��6G   �� *Data.Quantity+$ 0��$ OneWay=�6�   �� 5      #���  6   $��	576,5,0,2q�6�   $
��Left=�6�   $��69��6�   $
 Wrap=�6�   $��14(�6�   ��6G   �� *Data.TariffCode+	 �� TargetNullValue$	 Mapp tariff to use��$ OneWay=�6�   �� 5      #���  6   $��518,10,0,15q�6p   $
��Left=�6�   $��46��6�   ��6G   �� *
Data.Units+$ OneWay=�6�   �� 5      #���  6   $��
655,23,0,2q�6v   $
��Left=�6�   $��58��6�   ��6G   �� *Data.CLineNumber+$ OneWay=�6�   �� 5      -   5        $
��Left=�5   D   $��26��6_   $��	718,8,0,0q�6k   $	��Top=�6~   $	��104��6�   $��Do not Allocate��6�   
 d� 	IsChecked
 6   �� *Data.DoNotAllocate+6�   �� 5      $
��Left=�6   $��41��67   $��0,1,0,0q�6C   $	��Top=�6f   $��15��6~   ��6T   Z� ��5      
� 5      .��5      �  � Color$ White��6+    � Offset$ 0.011Q�69   � 5      $ 	#FF5872AB��6+   $ 1Q�6=   5       5"      �� 5#      #���  6   $��
20,15,0,10q�6u   $
��Left=�6�   $��35��6�   $��14(�6�   $
��Bold"�6�   ��6G   �� *Data.LineNumber+$ OneWay=�6�   5%      5&      .��5*      � -   5         �Name$ 
LayoutRoot��5*       � DataContext 6   ��  & "Ex9SalesDataDetailsModelDataSource �� Source# [ .+�5+   
   �� $
��Left=�6   $��33��6/   $��9,14,0,0q�6;   $
��Wrap=�6M   $	��Top=�6a   $	��195��6y   $��21.333(�6�   $��Sales Data Details��6�   �� 5,   
   -   5         ��Name$ ItemLst��54        EntryDataDetailTemplate#���  5-       �� SelectionMode$ Multiple=�5/   ?    %� IsVirtualizing .  %� VirtualizationMode$ 	Recycling=�51      ! �� IsDeferredScrollingEnabled . C  =Core.Common.UI.DataVirtualization.VirtualListLoadingIndicator   
IsAttached . $��Stretch=�54   #   $	��288��6A   $��
2,192,-2,0q�6N   $	��Top=�6b   $
��Auto��6z     AlphaListBoxStyle#���  6�    �� SelectedItem 5,      �� >   8WaterNut.QuerySpace.SalesDataQS.ViewModels.BaseViewModel   Instance# Z  �� Path$ VCurrentSalesDataDetail���5.      �� *SalesDataDetails+54   �   �� 55   
   -   5        $��Allocate Sales��55      $y�Hidden=�6*   $
��Left=�6>   $��26��6Y   $��583,164,0,0q�6e   $
��Wrap=�6z   $	��Top=�6�   $	��126��6�   $��16(�6�     TextButtonStyle#���  6�    �� TextAlignment$ Right=�6�   6   �� 56   
   -   5         ��Name$ MultiSelectChk��56      $
��Left=�6+   $��26��6F   $��231,164,0,0q�6R   $	��Top=�6g   $	��126��6   $��MultiSelect��6�   $
 FalseY�6�   �� 57   
   -   5         ��Name$ DeselectTxt��57      $
��Left=�6)   $��22��6D   $��378,164,0,0q�6P   $
��Wrap=�6e   $	��Top=�6y   $��98��6�   $��16(�6�   $��De-Select All��6�   $
 Left=�6�   #���  6�   6�   �� 58   
   -   5        $ 	SelectTxt��58      $
��Left=�6'   $��22��6B   $��500,164,0,0q�6N   $
��Wrap=�6c   $	��Top=�6w   $��67��6�   $��16(�6�   $��
Select All��6�   $
 Left=�6�   #���  6�   6�   �� 59   
   -   5        ���	#7FFFFFFF$
��Left=�59   j   $��33��6�   $��
27,114,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��81��6�   $��16(�6�    �� TextAlignment$ Center=�6�     TransparentTextBoxStyle#���  6  ��6   �� *ItemNumberFilter+ �� UpdateSourceTrigger$ Explicit=�65  �� 5:   
   -	   5        ���	#7FFFFFFF$
��Left=�5:   o   $��33��6�   $��113,114,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��211��6�   $��16(�6�   $ Center=�6�   #���  6	  ��6   �� *ItemDescriptionFilter+$ Explicit=�6;  �� 5;   
   -
   5        ���	#7FFFFFFF$
��Left=�5;   d   $��33��6   $��415,114,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��84��6�   $��16(�6�   $ Center=�6�   #���  6�   ��6   �� *
CostFilter+$ Explicit=�6/  �� 5<   
   -   5        ���	#7FFFFFFF$
��Left=�5<   j   $��33��6�   $��519,114,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��135��6�   $��16(�6�   $ Center=�6�   #���  6  ��6   �� *TariffCodeFilter+$ Explicit=�66  �� 5=   
   $
��Left=�6   $��25��6/   $��	24,84,0,0q�6;   $
��Wrap=�6N   $��Item #��6b   $	��Top=�6p   $��84��6�   $ Center=�6�   $��16(�6�   �� 5>   
   $
��Left=�6   $��25��6/   $��
113,84,0,0q�6;   $
��Wrap=�6O   $��Description��6c   $	��Top=�6v   $	��203��6�   $ Center=�6�   $��16(�6�   �� 5?   
   $
��Left=�6   $��25��6/   $��
321,85,0,0q�6;   $
��Wrap=�6O   $	��Qty��6c   $	��Top=�6n   $��85��6�   $ Center=�6�   $��16(�6�   �� 5@   
   $
��Left=�6   $��25��6/   $��
415,80,0,0q�6;   $
��Wrap=�6O   $
��Cost��6c   $	��Top=�6o   $��84��6�   $ Center=�6�   $��16(�6�   �� 5A   
   $
��Left=�6   $��25��6/   $��
519,80,0,0q�6;   $
��Wrap=�6O   $��
TariffCode��6c   $	��Top=�6u   $	��135��6�   $ Center=�6�   $��16(�6�   �� 5B   
   -   5        ���	#7FFFFFFF$
��Left=�5B   h   $��33��6�   $��335,114,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��67��6�   $��16(�6�   $ Center=�6�   #���  6  ��6   �� *QuantityFilter+$ Explicit=�64  �� 5C   
   $
��Left=�6]   $��24��6x   $��
221,21,0,0q�6�   $
��Wrap=�6�   $	��Top=�6�   $	��201��6�   $��20(�6�   $ Right=�6�   ���	#FFE4E453��6   �� *SalesDataDetails.Count+$ 0 Filtered Results��6�   �� 5D   
   -   5        #���  5D      $
��Left=�6?   $��24��6Z   $��
591,14,0,0q�6f   $
��Wrap=�6z   $��Send to Excel ��6�   $	��Top=�6�   $	��121��6�   $��16(�6�   $��Segoe UI Symbol)�6�   y�6  �� ?   9WaterNut.QuerySpace.CoreEntities.ViewModels.BaseViewModel   Instance# Z $3 -CurrentApplicationSettings.AllowExportToExcel��� 5E   
   $
��Left=�69   $��23��6T   $��	96,55,0,0q�6`   $	��Top=�6s   $	��129��6�   $��View Zero Price Items
��6�   
 6   �� *ZeroPriceItems+6�   �� 5F   
   $
��Left=�66   $��23��6Q   $��
429,55,0,0q�6]   $	��Top=�6q   $	��141��6�   $��View Document Items��6�   
 6   �� *ViewDocData+6�   �� 5G   
   $
��Left=�62   $��23��6M   $��
583,55,0,0q�6Y   $	��Top=�6m   $	��104��6�   $��View All��6�   
 6   �� *	ViewAll+6�   �� 5H   
   $
��Left=�64   $��23��6O   $��
244,55,0,0q�6[   $	��Top=�6o   $	��162��6�   $��View Null Inventory Items��6�   
 6   �� *	NullItems+6�   �� 5I   
   $
��Left=�6N   $��24��6i   $��635,494,0,0q�6u   $
��Wrap=�6�   $	��Top=�6�   $	��201��6�   $��20(�6�   ���	#FFE4E453��6   �� *TotalSalesValue+$ of {0:c}��6�   �� 5J   
   $
��Left=�6T   $��24��6o   $��429,494,0,0q�6{   $
��Wrap=�6�   $	��Top=�6�   $	��201��6�   $��20(�6�   $ Right=�6�   ���	#FFE4E453��6   �� *SelectedSalesValue+$ Total {0:c}��6�   5K      5L      