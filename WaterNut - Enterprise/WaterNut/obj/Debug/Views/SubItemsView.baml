   M S B A M L   `   `   `  ����C  ?WaterNut, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WaterNutWaterNut  5      i9clr-namespace:WaterNut.QuerySpace.CoreEntities.ViewModels+WaterNut.QuerySpace.CoreEntities.ViewModels  5      I ECore.Common.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullmGclr-namespace:Core.Common.UI.DataVirtualization;assembly=Core.Common.UI!Core.Common.UI.DataVirtualization 5	      g8clr-namespace:WaterNut.QuerySpace.EntryDataQS.ViewModels*WaterNut.QuerySpace.EntryDataQS.ViewModels  5
      !    WaterNut.Views.SubItemsView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/Expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      (localclr-namespace:WaterNut     5      P
viewModels9clr-namespace:WaterNut.QuerySpace.CoreEntities.ViewModels     5      fdataVirtualizationGclr-namespace:Core.Common.UI.DataVirtualization;assembly=Core.Common.UI     5	      Hqsv8clr-namespace:WaterNut.QuerySpace.EntryDataQS.ViewModels     5
        � 	Resources  5      �� 5   
    �� Member$) #viewModels:SubItemsModelQS.Instance��6      KeySubItemsModelDataSource  6@   �� 5   
    �� 
TargetType" ��6   .�5      �� ;  5Core.Common.UI.DataVirtualization.VirtualListItemBase �� Property �@ AutoLoad �� Value . 6P   5      �� 5   
   SubItemsTemplate  .R�5      � $��65��6   $	��675��6   .+�5      �� $
��Left=�6=   $��30��6X   $��	10,10,0,0q�6d   $
��Wrap=�6w   $	��Top=�6�   $	��160��6�   $
��Bold"�6�   ��6   �� *Data.ItemNumber+6�   �� 5      $
��Left=�6B   $��45��6]   $��
175,10,0,0q�6i   $
��Wrap=�6}   $	��Top=�6�   $	��285��6�   ��6   �� *Data.ItemDescription+6�   �� 5      $
��Left=�6;   $��30��6V   $��
480,10,0,0q�6b   $
��Wrap=�6v   $	��Top=�6�   $��80��6�   ��6   �� *Data.Quantity+6�   �� 5      $
��Left=�6?   $��30��6Z   $��
585,10,0,0q�6f   $
��Wrap=�6z   $	��Top=�6�   $��80��6�   ��6   �� *Data.QtyAllocated+6�   5      5      .��5      � -   5         �Name$ 
LayoutRoot��5       � DataContext 6   ��   SubItemsModelDataSource �� Source# [ .+�5   
   �� $
��Left=�6   $��33��6/   $��9,14,0,0q�6;   $
��Wrap=�6M   $	��Top=�6a   $	��209��6y   $��21.333(�6�   $��	Sub Items��6�   �� 5   
   -   5         ��Name$ ItemLst��5      	 %� IsVirtualizing	 . 
 %� VirtualizationMode$
 	Recycling=�5       ! �� IsDeferredScrollingEnabled . C  =Core.Common.UI.DataVirtualization.VirtualListLoadingIndicator   
IsAttached .   SubItemsTemplate#���  5$       �� SelectionMode$ Multiple=�5%   [   $��Stretch=�5&      $	��335��6+   $��	0,145,0,0q�68   $	��Top=�6K   $
��Auto��6c     AlphaListBoxStyle#���  6p    �� SelectedItem 5#      �� >   8WaterNut.QuerySpace.EntryDataQS.ViewModels.BaseViewModel   Instance# Z  �� Path$ VCurrentEntryDataEx���5%      �� *
SubItems+5&   p   �� 5'   
   $
��Left=�6U   $��24��6p   $��
200,19,0,0q�6|   $
��Wrap=�6�   $	��Top=�6�   $	��201��6�   $��20(�6�    �� TextAlignment$ Right=�6�   ���	#FFE4E453��6   �� *SubItems.Count+ �� StringFormat$ 0 Filtered Results��6�   �� 5(   
   -   5          TextButtonStyle#���  5(      $
��Left=�6?   $��24��6Z   $��
511,19,0,0q�6f   $
��Wrap=�6z   $��Send to Excel ��6�   $	��Top=�6�   $	��121��6�   $��16(�6�   $��Segoe UI Symbol)�6�   y�6  �� */-CurrentApplicationSettings.AllowExportToExcel+�� 5)   
   $
��Left=�6   $��23��6/   $��	10,47,0,0q�6;   $
��Wrap=�6N   $	��Top=�6b   $	��116��6z   $��16(�6�   $��Item Number��6�   $ Center=�6�   �� 5*   
   -   5        ���	#7FFFFFFF$
��Left=�5*   w   $��23��6�   $��	10,77,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��130��6�   $��16(�6�    �� TextAlignment$ Center=�6�     TransparentTextBoxStyle#���  6  ��6   �� *ItemNumberFilter+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ Explicit=�6A  �� 5+   
   $
��Left=�6   $��23��6/   $��
160,47,0,0q�6;   $
��Wrap=�6O   $	��Top=�6c   $	��241��6{   $��16(�6�   $��Item Description��6�   $ Center=�6�   �� 5,   
   -   5        ���	#7FFFFFFF$
��Left=�5,   |   $��23��6�   $��
160,77,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��270��6�   $��16(�6�   $ Center=�6�   #���  6  ��6   �� *ItemDescriptionFilter+$ TwoWay=�$ Explicit=�6G  �� 5-   
   $
��Left=�6]   $��24��6x   $��429,446,0,0q�6�   $
��Wrap=�6�   $	��Top=�6�   $	��201��6�   $��20(�6�   $ Right=�6�   ���	#FFE4E453��6   �� *SelectedTotal+$ Total {0:c}�� �� IsAsync . 6�   �� 5.   
   -   5         ��Name$ ImportSubItemsTxt��5.      $
��Left=�6/   $��22��6J   $��
511,77,0,0q�6V   $
��Wrap=�6j   $	��Top=�6~   $	��119��6�   $��14(�6�   $��Import SubItems��6�   $
 Left=�6�   #���  6�   6  �� 5/   
   -   5        $ DeselectTxt��5/      $
��Left=�6)   $��22��6D   $��127,115,0,0q�6P   $
��Wrap=�6e   $	��Top=�6y   $��92��6�   $��16(�6�   $��De-Select All��6�   $
 Left=�6�   #���  6�   6�   �� 50   
   -   5        $ 	SelectTxt��50      $
��Left=�6'   $��22��6B   $��252,115,0,0q�6N   $
��Wrap=�6c   $	��Top=�6w   $��83��6�   $��16(�6�   $��
Select All��6�   $
 Left=�6�   #���  6�   6�   �� 51   
   -	   5         ��Name$ MultiSelectChk��51      $
��Left=�6+   $��26��6F   $��
15,116,0,0q�6R   $	��Top=�6f   $	��107��6~   $��MultiSelect��6�    d� 	IsChecked$ FalseY�6�   52      53      