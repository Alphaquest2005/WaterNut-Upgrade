   M S B A M L   `   `   `  ����C  ?WaterNut, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WaterNutWaterNut  5      i9clr-namespace:WaterNut.QuerySpace.OversShortQS.ViewModels+WaterNut.QuerySpace.OversShortQS.ViewModels  5      I ECore.Common.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullmGclr-namespace:Core.Common.UI.DataVirtualization;assembly=Core.Common.UI!Core.Common.UI.DataVirtualization 5	      $    WaterNut.Views.OversShortsView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      (localclr-namespace:WaterNut     5      Iqsv9clr-namespace:WaterNut.QuerySpace.OversShortQS.ViewModels     5      fdataVirtualizationGclr-namespace:Core.Common.UI.DataVirtualization;assembly=Core.Common.UI     5	      $	��710��5
   @     � 	Resources  5      �� 5   
    �� Member$# qsv:OversShortsModel.Instance��6      KeyOversShortsModelDataSource  6:   �� 5   
    �� 
TargetType" ��6   .�5      �� ;  5Core.Common.UI.DataVirtualization.VirtualListItemBase �� Property �@ AutoLoad �� Value . 6P   5      �� 5   
   OversShortsTemplate  .R�5      � $��90��6   $	��725��6   .+�5      ��   TextBox2TextBlock#���  6   $
��Left=�6t   $��35��6�   $��	10,15,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��155��6�   $
��Bold"�6�   $��14(�6�   ��6F   �� *Data.InvoiceNo+ �� Mode$ OneWay=�6�   �� 5      #���  6   $
��Left=�6�   $��35��6�   $��
185,15,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��275��6�   ��6F   �� *Data.InvoiceDate+ �� StringFormat$ {0:dd-MMM-yy}��$ OneWay=�6�   �� 5      #���  6   $
��Left=�6�   $��35��6�   $��	10,55,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��155��6�   ��6F   �� **(Data.OverShortSuggestedDocuments.CNumber+$ OneWay=�6�   �� 5      #���  6   $
��Left=�6�   $��35��6�   $��
185,55,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��330��6�   ��6F   �� *20Data.OverShortSuggestedDocuments.ReferenceNumber+$ OneWay=�6�   5      5      .��5      � -   5         �Name$ 
LayoutRoot��5      	 � DataContext	 6   ��   OversShortsModelDataSource
 �� Source#
 [ .+�5   
   �� $
��Left=�6   $��33��6/   $��9,14,0,0q�6;   $
��Wrap=�6M   $	��Top=�6a   $	��209��6y   $��21.333(�6�   $��Overs and Shorts��6�   �� 5   
   -   5         ��Name$ ItemLst��5       %� IsVirtualizing .  %� VirtualizationMode$ 	Recycling=�5!      ! �� IsDeferredScrollingEnabled . C  =Core.Common.UI.DataVirtualization.VirtualListLoadingIndicator   
IsAttached .   OversShortsTemplate#���  5$      $��Stretch=�5'      $	��258��60   $��	0,172,0,0q�6=   $	��Top=�6P   $
��Auto��6h    �� SelectionMode$ Multiple=�6�     AlphaListBoxStyle#���  6�    �� SelectedItem 5%      �� ?   9WaterNut.QuerySpace.OversShortQS.ViewModels.BaseViewModel   Instance#
 Z  �� Path$ VCurrentOversShortEX���5&      �� *OversShorts+5'   �   �� 5(   
   $
��Left=�6X   $��24��6s   $��
255,19,0,0q�6   $
��Wrap=�6�   $	��Top=�6�   $	��201��6�   $��20(�6�    �� TextAlignment$ Right=�6�   ���	#FFE4E453��6   �� *OversShorts.Count+$ 0 Filtered Results��6�   �� 5)   
   -   5          TextButtonStyle#���  5)      $
��Left=�6?   $��24��6Z   $��
577,18,0,0q�6f   $
��Wrap=�6z   $��Send to Excel ��6�   $	��Top=�6�   $	��121��6�   $��16(�6�   $��Segoe UI Symbol)�6�   y�6  �� */-CurrentApplicationSettings.AllowExportToExcel+�� 5*   
   $
��Left=�6   $��23��6/   $��	13,54,0,0q�6;   $
��Wrap=�6N   $	��Top=�6b   $	��116��6z   $��16(�6�   $��Invoice No.��6�   $ Center=�6�   �� 5+   
   -   5        ���	#7FFFFFFF$
��Left=�5+   v   $��23��6�   $��	13,77,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��130��6�   $��16(�6�    �� TextAlignment$ Center=�6�     TransparentTextBoxStyle#���  6  ��6   �� *InvoiceNoFilter+$ TwoWay=� �� UpdateSourceTrigger$ Explicit=�6@  �� 5,   
   $
��Left=�6   $��23��6/   $��
148,54,0,0q�6;   $
��Wrap=�6O   $	��Top=�6c   $	��116��6{   $��16(�6�   $��Invoice Date��6�   $ Center=�6�   (  "System.Windows.Controls.DatePicker  5-   
   ���	#7FFFFFFF$
��Left=�6�   $��23��6�   $��
148,77,0,0q�6�   $	��Top=�6�   $	��130��6�   $��16(�6�      SelectedDate 6   �� *InvoiceDateFilter+$ TwoWay=�$ PropertyChanged=�6�   �� 5.   
   $
��Left=�6   $��23��6/   $��
287,54,0,0q�6;   $
��Wrap=�6O   $	��Top=�6c   $	��122��6{   $��14(�6�   $��Reference Number��6�   $ Center=�6�   �� 5/   
   -   5         ��Name$ 	RefNumTxt��5/      ���	#7FFFFFFF$
��Left=�6�   $��23��6�   $��
287,77,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��181��6�   $��16(�6  $ Center=�6  #���  6(  ��6%   �� *ReferenceNumberFilter+$ TwoWay=�$ Explicit=�6Z  �� 50   
   $
��Left=�6   $��23��6/   $��
480,54,0,0q�6;   $
��Wrap=�6O   $	��Top=�6c   $��75��6{   $��16(�6�   $��CNumber��6�   $ Center=�6�   �� 51   
   -   5        $ 
CNumberTxt��51      ���	#7FFFFFFF$
��Left=�6�   $��23��6�   $��
480,77,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��130��6�   $��16(�6�   $ Center=�6
  #���  6!  ��6&   �� *CNumberFilter+$ TwoWay=�$ Explicit=�6S  �� 52   
   $��View Document O/S��65   $
��Left=�6Q   $��21��6l   $��
13,143,0,0q�6x   $	��Top=�6�   $	��157��6�    d� 	IsChecked 6   �� *ViewDocData+6�   �� 53   
   -   5        #���  53      $
��Left=�6?   $��24��6Z   $��
634,42,0,0q�6f   $
��Wrap=�6z   $��Import��6�   $	��Top=�6�   $��64��6�   $��16(�6�   $��Segoe UI Symbol)�6�   y�6  �� *-+CurrentApplicationSettings.AllowOversShorts+�� 54   
   -   5        $
��Left=�54      $��26��6/   $��541,115,0,0q�6;   $
��Wrap=�6P   $��Match By Ref/CN. No��6d   $	��Top=�6   $	��155��6�   $��16(�6�   #���  6�   $ Right=�6�   6�   �� 55   
   -	   5         ��Name$ MultiSelectChk��55      $
��Left=�6+   $��26��6F   $��
13,110,0,0q�6R   $	��Top=�6f   $��83��6~   $��MultiSelect��6�   $ FalseY�6�   �� 56   
   -
   5         ��Name$ DeselectTxt��56      $
��Left=�6)   $��22��6D   $��117,110,0,0q�6P   $
��Wrap=�6e   $	��Top=�6y   $��98��6�   $��16(�6�   $��De-Select All��6�   $
 Left=�6�   #���  6�   6�   �� 57   
   -   5        $ 	SelectTxt��57      $
��Left=�6'   $��22��6B   $��239,110,0,0q�6N   $
��Wrap=�6c   $	��Top=�6w   $��67��6�   $��16(�6�   $��
Select All��6�   $
 Left=�6�   #���  6�   6�   �� 58   
   -   5        $ 
SaveRefNum��58      $
��Left=�6(   $��17��6C   $��
414,55,0,0q�6O   $
��Wrap=�6c   $	��Top=�6w   $��54��6�   $��	Save Ref#��6�   $
 Left=�6�   #���  6�   6�   �� 59   
   -   5        $ 
ViewAllTxt��59      $
��Left=�6(   $��23��6C   $��
634,67,0,0q�6O   $
��Wrap=�6c   $	��Top=�6w   $��64��6�   $��View All��6�   $
 Left=�6�   #���  6�   $��16(�6  �� 5:   
   -   5        $
��Left=�5:   9   $��26��6T   $��320,110,0,0q�6`   $
��Wrap=�6u   $��Remove Selected��6�   $	��Top=�6�   $	��126��6�   $��16(�6�     CloseButtonStyle#���  6�   $ Right=�6�   �� 5;   
   $
��Left=�6d   $��24��6   $��499,446,0,0q�6�   $
��Wrap=�6�   $	��Top=�6�   $	��201��6�   $��20(�6�   $ Right=�6�   ���	#FFE4E453��6   �� *SelectedInvoiceValue+$ Total {0:c}�� �� IsAsync . 6�   �� 5<   
   -   5        $
��Left=�5<      $��26��6/   $��
615,91,0,0q�6;   $
��Wrap=�6O   $��
Auto Match��6c   $	��Top=�6u   $��85��6�   $��16(�6�   #���  6�   $ Right=�6�   6�   �� 5=   
   -   5        $ SaveRefNum_Copy��5=      $
��Left=�6-   $��17��6H   $��
555,54,0,0q�6T   $
��Wrap=�6h   $	��Top=�6|   $��54��6�   $��Save C#��6�   $
 Left=�6�   #���  6�   6�   �� 5>   
   -   5        $ MultiSelectChk_Copy6��5>   ]   $
��Left=�6{   $��22��6�   $��308,143,0,0q�6�   $	��Top=�6�   $	��124��6�   $��Apply EX9 Bucket��6�    J� RenderTransformOrigin$ 0.488,0.464&�6�    6   �� *ApplyEX9Bucket+$ PropertyChanged=�6�   �� 5?   
   -   5        $ MultiSelectChk_Copy7��5?   _   $
��Left=�6}   $��22��6�   $��451,145,0,0q�6�   $	��Top=�6�   $	��148��6�   $��Break On Month Year��6�   $ 0.488,0.464&�6�    6   �� *BreakOnMonthYear+$ PropertyChanged=�6�   �� 5@   
   -   5        $
��Left=�5@      $��26��6/   $��606,141,0,0q�6;   $
��Wrap=�6P   $��Add to Entry��6d   $	��Top=�6x   $��90��6�   $��16(�6�   #���  6�   $ Right=�6�   6�   5A      5B      