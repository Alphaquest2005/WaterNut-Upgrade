   M S B A M L   `   `   `  ����C  ?WaterNut, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullg8clr-namespace:WaterNut.QuerySpace.EntryDataQS.ViewModels*WaterNut.QuerySpace.EntryDataQS.ViewModels  5      I ECore.Common.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullmGclr-namespace:Core.Common.UI.DataVirtualization;assembly=Core.Common.UI!Core.Common.UI.DataVirtualization 5      S OWaterNut.Client.Entities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullkKclr-namespace:EntryDataQS.Client.Entities;assembly=WaterNut.Client.EntitiesEntryDataQS.Client.Entities 5      9!clr-namespace:WaterNut.ConvertersWaterNut.Converters  5
      ]?clr-namespace:Core.Common.UI.Validation;assembly=Core.Common.UICore.Common.UI.Validation 5      i9clr-namespace:WaterNut.QuerySpace.CoreEntities.ViewModels+WaterNut.QuerySpace.CoreEntities.ViewModels  5      )    #WaterNut.Views.EntryDataDetailsView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/Expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      Gqs8clr-namespace:WaterNut.QuerySpace.EntryDataQS.ViewModels     5      [virtualGclr-namespace:Core.Common.UI.DataVirtualization;assembly=Core.Common.UI     5      kqsEntryDataEntitiesKclr-namespace:EntryDataQS.Client.Entities;assembly=WaterNut.Client.Entities     5      8
converters!clr-namespace:WaterNut.Converters     5
      V
validation?clr-namespace:Core.Common.UI.Validation;assembly=Core.Common.UI     5      RcoreEntities9clr-namespace:WaterNut.QuerySpace.CoreEntities.ViewModels     5      $��518.209��5   3   $��807.2��6D     � 	Resources  5      �� 5   
    �� Member$' !qs:EntryDataDetailsModel.Instance��6      Key#EntryDataDetailsModelDataSource  6>   �� 5   
    �� 
TargetType" ��6   .�5      �� ;  5Core.Common.UI.DataVirtualization.VirtualListItemBase �� Property �@ AutoLoad �� Value . 6E   5      *   $WaterNut.Converters.NotBoolConverter  5   
   NotBoolConverter  6&   �� 5   
   EntryDataDetailTemplate   �� DataType4  .EntryDataQS.Client.Entities.EntryDataDetailsEx"  67   .R�5      � $	��861��6   $��42��6   .+�5      ��   TextBox2TextBlock#���  6   $��
752,1,0,23q�6r   $
��Left=�6�   $��99��6�   $��14(�6�   ��6G   �� *Data.CNumber+ �� Mode$ OneWay=�6�   �� 5      #���  6   $��444,28,0,-3.64q�6   $
��Left=�6�   $��45��6�   ��6G   �� *	Data.Cost+ �� StringFormat$ c��$ OneWay=�6�   �� 5      #���  6   $��
190,10,0,9q�6z   $
��Left=�6�   $	��210��6�   $��14(�6�   ��6G   �� *Data.ItemDescription+$ OneWay=�6�   �� 5      #���  6   $��
80,13,0,12q�6u   $
��Left=�6�   $��85��6�   $��14(�6�   ��6G   �� *Data.ItemNumber+$ OneWay=�6�   �� 5      #���  6   $��444,8,0,14.36q�6�   $
��Left=�6�   $��45��6�   $��14(�6�   ��6G   �� *Data.Quantity+$ 0��$ OneWay=�6�   �� 5      #���  6   $��
675,1,0,24q�6�   $
��Left=�6�   $��69��6�    �� TextWrapping$
 Wrap=�6�   $��14(�6�   ��6G   �� *Data.TariffCode+	 �� TargetNullValue$	 Mapp tariff to use��$ OneWay=�6�   �� 5      #���  6   $��518,10,0,15q�6p   $
��Left=�6�   $��46��6�   $��14(�6�   ��6G   �� *
Data.Units+$ OneWay=�6�   �� 5      #���  6   $��
675,23,0,2q�6v   $
��Left=�6�   $��72��6�   $	��Top=�6�   $��14(�6�   ��6G   �� *Data.CLineNumber+$ OneWay=�6�   �� 5       
 ��Name$
 AddItemtoAdocTxt��6   -   5        $
��Left=�5    �   $��35��6�   $��	579,5,0,0q�6�   $	��Top=�6�   $��57��6�   $��Add To Asy. Doc.��6�     TextButtonStyle#���  6
  $
��Wrap=�64  {�66   �� *Data.Downloaded+  NotBoolConverter �� 	Converter# [ $ OneWay=�6H  �� 5!      -   5        $
��Left=�5!   D   $��21��6_   $��752,23,0,-2q�6k   $	��Top=�6�   $	��104��6�   $��Do not Allocate��6�    d� 	IsChecked 6   �� *Data.DoNotAllocate+6�   �� 5"      $
��Left=�6   $��41��67   $��0,1,0,0q�6C   $	��Top=�6f   $��15��6~   ��6T   Z� ��5#      
� 5$      .��5%      �  � Color$ White��6+    � Offset$ 0.011Q�69   � 5&      $ 	#FF5872AB��6+   $ 1Q�6=   5'      5)      �� 5*      #���  6   $��
20,13,0,12q�6u   $
��Left=�6�   $��31��6�   $��14(�6�   $
��Bold"�6�   ��6G   �� *Data.LineNumber+$ OneWay=�6�   5+      5,      .��5/      � -   5         �Name$ 
LayoutRoot��5/       � DataContext 6   ��  # EntryDataDetailsModelDataSource �� Source# [ .+�50   
   �� $
��Left=�6   $��33��6/   $��9,14,0,0q�6;   $
��Wrap=�6M   $	��Top=�6a   $	��176��6y   $��21.333(�6�   $��Entry Data Details��6�   �� 51   
   -   5         ��Name$ ItemLst��55   +     EntryDataDetailTemplate#���  52       �� SelectionMode$ Multiple=�55       %� IsVirtualizing .  %� VirtualizationMode$ 	Recycling=�57      ! �� IsDeferredScrollingEnabled . C  =Core.Common.UI.DataVirtualization.VirtualListLoadingIndicator   
IsAttached . $��Stretch=�5:      $	��195��60   $��
2,192,-2,0q�6=   $	��Top=�6Q   $
��Auto��6i     AlphaListBoxStyle#���  6v    �� SelectedItem 51      �� >   8WaterNut.QuerySpace.EntryDataQS.ViewModels.BaseViewModel   Instance# Z  �� Path$  VCurrentEntryDataDetailsEx���53      �� *EntryDataDetailsExes+5:   v   �� 5;   
   -   5        $
��Left=�5;      $��26��6/   $��583,164,0,0q�6;   $
��Wrap=�6P   $��Add to Asy. Doc.��6d   $	��Top=�6|   $	��126��6�   $��16(�6�   #���  6�    �� TextAlignment$ Right=�6�   6�   �� 5<   
   -   5         ��Name$ MultiSelectChk��5<      $
��Left=�6+   $��26��6F   $��231,164,0,0q�6R   $	��Top=�6g   $	��126��6   $��MultiSelect��6�   $ FalseY�6�   �� 5=   
   -   5        $
 DeselectTxt��5=      $
��Left=�6)   $��22��6D   $��378,164,0,0q�6P   $
��Wrap=�6e   $	��Top=�6y   $��98��6�   $��16(�6�   $��De-Select All��6�   $
 Left=�6�   #���  6�   6�   �� 5>   
   -   5        $
 	SelectTxt��5>      $
��Left=�6'   $��22��6B   $��500,164,0,0q�6N   $
��Wrap=�6c   $	��Top=�6w   $��67��6�   $��16(�6�   $��
Select All��6�   $
 Left=�6�   #���  6�   6�   �� 5?   
   $
��Left=�69   $��23��6T   $��	96,55,0,0q�6`   $	��Top=�6s   $	��129��6�   $��View Zero Price Items
��6�    6   �� *ZeroPriceItems+6�   � 5@   
   $
��Left=�6s   $��52��6�   $��	0,399,0,0q�6�   $	��Top=�6�   $	��807��6�   ���	#4CFFFFFF 6   �� # Z $ CurrentEntryDataDetailsEx�.+�5A      �� $��	507,8,0,0q�6P   $
��Left=�6c   $��82��6~   $	��Top=�6�   $��32��6�   ��6   �� *Cost+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5B      $��	102,8,0,0q�6[   $
��Left=�6n   $	��252��6�   $	��Top=�6�   $��32��6�   ��6   �� *ItemDescription+$ PropertyChanged=�6�   �� 5C      $��11.879,8,0,0q�6V   $
��Left=�6l   $��85��6�   $	��Top=�6�   $��32��6�   ��6   �� *
ItemNumber+$ PropertyChanged=�6�   �� 5D      $��	363,8,0,0q�6T   $
��Left=�6g   $��63��6�   $��32��6�   $	��Top=�6�   ��6   �� *
Quantity+$ PropertyChanged=�6�   �� 5E      $��	436,8,0,0q�6Q   $
��Left=�6d   $��63��6   $	��Top=�6�   $��32��6�   ��6   �� *Units+$ PropertyChanged=�6�   �� 5G      -	   5        $
 
NewItemTxt��5G      $
��Left=�6-   $��18��6H   $��	740,4,0,0q�6T   $	��Top=�6g   $��46��6   #���  6�   $
��Wrap=�6�   $ Center=�6�   $��16(�6�   �� 6  $	�New��6  �� 6  �� 6(  6/  �� 5H      $
��Left=�6;   $��26��6V   $��
608,15,0,0q�6b   $	��Top=�6v   $	��104��6�   $��Do not Allocate��6�    6   �� *DoNotAllocate+6�   �� 5I      -
   5        $
 SaveItemTxt_Copy��5I      $
��Left=�63   $��18��6N   $��
740,26,0,0q�6Z   $	��Top=�6n   $��46��6�   #���  6�   $
��Wrap=�6�   $ Center=�6�   $��16(�6  �� 6  $
�Save��6  �� 6%  �� 61  68  5J      �� 5K   
   -   5        ���	#7FFFFFFF$
��Left=�5K   j   $��33��6�   $��
27,114,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��81��6�   $��16(�6�    �� TextAlignment$ Center=�6�     TransparentTextBoxStyle#���  6  ��6   �� *ItemNumberFilter+$ Explicit=�64  �� 5L   
   -   5        ���	#7FFFFFFF$
��Left=�5L   o   $��33��6�   $��113,114,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��211��6�   $��16(�6�   $ Center=�6�   #���  6	  ��6   �� *ItemDescriptionFilter+$ Explicit=�6;  �� 5M   
   -   5        ���	#7FFFFFFF$
��Left=�5M   ~   $��33��6�   $��415,114,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��84��6�   $��16(�6�   $ Center=�6   #���  6  ��6   1  +Core.Common.UI.Validation.ValidationBinding  4  .Core.Common.UI.Validation.BindingDecoratorBase   Path$ 
CostFilter�    UpdateSourceTrigger$  Explicit=�6I  �� 5N   
   -   5        ���	#7FFFFFFF$
��Left=�5N   j   $��33��6�   $��519,114,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��135��6�   $��16(�6�   $ Center=�6�   #���  6  ��6   �� *TariffCodeFilter+$ Explicit=�66  �� 5O   
   $
��Left=�6   $��25��6/   $��	24,84,0,0q�6;   $
��Wrap=�6N   $��Item #��6b   $	��Top=�6p   $��84��6�   $ Center=�6�   $��16(�6�   �� 5P   
   $
��Left=�6   $��25��6/   $��
113,84,0,0q�6;   $
��Wrap=�6O   $��Description��6c   $	��Top=�6v   $	��203��6�   $ Center=�6�   $��16(�6�   �� 5Q   
   $
��Left=�6   $��25��6/   $��
321,85,0,0q�6;   $
��Wrap=�6O   $	��Qty��6c   $	��Top=�6n   $��85��6�   $ Center=�6�   $��16(�6�   �� 5R   
   $
��Left=�6   $��25��6/   $��
415,80,0,0q�6;   $
��Wrap=�6O   $
��Cost��6c   $	��Top=�6o   $��84��6�   $ Center=�6�   $��16(�6�   �� 5S   
   $
��Left=�6   $��25��6/   $��
519,80,0,0q�6;   $
��Wrap=�6O   $��
TariffCode��6c   $	��Top=�6u   $	��135��6�   $ Center=�6�   $��16(�6�   �� 5T   
   -   5        ���	#7FFFFFFF$
��Left=�5T   h   $��33��6�   $��335,114,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��67��6�   $��16(�6�   $ Center=�6�   #���  6  ��6   �� *QuantityFilter+$ Explicit=�63  �� 5U   
   $
��Left=�66   $��23��6Q   $��
429,55,0,0q�6]   $	��Top=�6q   $	��141��6�   $��View Document Items��6�    6   �� *ViewDocData+6�   �� 5V   
   $
��Left=�6a   $��24��6|   $��
221,21,0,0q�6�   $
��Wrap=�6�   $	��Top=�6�   $	��201��6�   $��20(�6�   $ Right=�6�   ���	#FFE4E453��6   �� *EntryDataDetailsExes.Count+$ 0 Filtered Results��6�   �� 5W   
   $
��Left=�6F   $��24��6a   $��650,471,0,0q�6m   $
��Wrap=�6�   $	��Top=�6�   $	��147��6�   $��20(�6�   ���	#FFE4E453��6   �� *
TotalTotal+$ {0:c}��6�   �� 5X   
   $
��Left=�62   $��23��6M   $��
583,55,0,0q�6Y   $	��Top=�6m   $	��104��6�   $��View All��6�    6   �� *	ViewAll+6�   �� 5Y   
   -   5        #���  5Y      $
��Left=�6?   $��24��6Z   $��
591,14,0,0q�6f   $
��Wrap=�6z   $��Send to Excel ��6�   $	��Top=�6�   $	��121��6�   $��16(�6�   $��Segoe UI Symbol)�6�   y�6  �� ?   9WaterNut.QuerySpace.CoreEntities.ViewModels.BaseViewModel!   Instance# Z! $3 -CurrentApplicationSettings.AllowExportToExcel��� 5Z   
   $
��Left=�64   $��23��6O   $��
244,55,0,0q�6[   $	��Top=�6o   $	��162��6�   $��View Null Inventory Items��6�    6   �� *	NullItems+6�   �� 5[   
   $
��Left=�6L   $��24��6g   $��498,471,0,0q�6s   $
��Wrap=�6�   $	��Top=�6�   $	��147��6�   $��20(�6�   $ Right=�6�   ���	#FFE4E453��6   �� *SelectedTotal+$ {0:c} Of��6�   5\      5]      