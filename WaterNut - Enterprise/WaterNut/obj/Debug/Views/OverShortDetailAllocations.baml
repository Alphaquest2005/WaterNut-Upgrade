   M S B A M L   `   `   `  ����C  ?WaterNut, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WaterNutWaterNut  5      i9clr-namespace:WaterNut.QuerySpace.OversShortQS.ViewModels+WaterNut.QuerySpace.OversShortQS.ViewModels  5      I ECore.Common.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullmGclr-namespace:Core.Common.UI.DataVirtualization;assembly=Core.Common.UI!Core.Common.UI.DataVirtualization 5	      3    -WaterNut.Views.OverShortDetailAllocationsView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      (localclr-namespace:WaterNut     5      Iqsv9clr-namespace:WaterNut.QuerySpace.OversShortQS.ViewModels     5      fdataVirtualizationGclr-namespace:Core.Common.UI.DataVirtualization;assembly=Core.Common.UI     5	        � 	Resources  5      �� 5   
    �� Member$2 ,qsv:OverShortDetailAllocationsModel.Instance��6      Key-)OverShortDetailAllocationsModelDataSource  6I   �� 5   
    �� 
TargetType" ��6   .�5      �� ;  5Core.Common.UI.DataVirtualization.VirtualListItemBase �� Property �@ AutoLoad �� Value . 6P   5      �� 5   
   OversShortsTemplate  .R�5      � $	��100��6   $	��810��6    .+�5      ��   TextBox2TextBlock#���  6   $
��Left=�6u   $��25��6�   $��	90,40,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��155��6�   $
��Bold"�6�   $��14(�6�   ��6F   �� *Data.ItemNumber+ �� Mode$ OneWay=�6�   �� 5      #���  6   $
��Left=�6�   $��25��6�   $��
265,40,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��255��6�   ��6F   �� *Data.ItemDescription+ �� StringFormat$ {0:dd-MMM-yy}��$ OneWay=�6�   �� 5      #���  6   $
��Left=�6u   $��25��6�   $��
615,40,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��90��6�    �� TextAlignment$ Right=�6�   ��6F   �� *Data.InvoiceQty+$ OneWay=�6�   �� 5      #���  6   $
��Left=�6v   $��25��6�   $��
710,40,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��80��6�   $ Right=�6�   ��6F   �� *Data.ReceivedQty+$ OneWay=�6�   �� 5      #���  6   $
��Left=�6~   $��25��6�   $��
525,40,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��85��6�   $ Right=�6�   ��6F   �� *	Data.Cost+$ c��$ OneWay=�6�   �� 5      #���  6   $
��Left=�6o   $��25��6�   $��10,4,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��75��6�   $
��Bold"�6�   $��14(�6�   ��6F   �� *	Data.Type+$ OneWay=�6�   �� 5      #���  6   $
��Left=�6r   $��20��6�   $��	90,70,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��130��6�   $
��Bold"�6�   $��14(�6�   ��6F   �� *Data.CNumber+$ OneWay=�6�   �� 5      #���  6   $
��Left=�6�   $��20��6�   $��
225,70,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��130��6�   $
��Bold"�6�   $��14(�6  ��6F   �� *Data.RegistrationDate+$ d��$ OneWay=�6  �� 5      #���  6   $
��Left=�6u   $��20��6�   $��
360,70,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��35��6�   $
��Bold"�6�   $��14(�6�   ��6F   �� *Data.LineNumber+$ OneWay=�6�   �� 5      	 ��Name$	 ViewSuggestionTxt_Copy2��6   -   5        $
��Left=�5   =   $��20��6X   $��	705,4,0,0q�6d   $
��Wrap=�6w   $	��Top=�6�   $��95��6�   $��11(�6�   $��Remove O/S Detail��6�   
 �� TextAlignment$

 Left=�6�     CloseButtonStyle#���  6�   6  �� 5      #���  6   $
��Left=�6�   $��20��6�   $��
420,70,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��65��6�   $
��Bold"�6�   $��14(�6  ��6F   �� *Data.PiQuantity+$
 Pi 0��$ OneWay=�6  �� 5      #���  6   $
��Left=�6�   $��20��6�   $��
490,70,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��65��6�   $
��Bold"�6�   $��14(�6  ��6F   �� *Data.RemainingQty+$ OneWay=�$
 RQ 0��6  �� 5      #���  6   $
��Left=�6w   $��25��6�   $��	120,4,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��75��6�   $
��Bold"�6�   $��14(�6�   ��6F   �� *Data.QtyAllocated+$ OneWay=�6�   �� 5       #���  6   $
��Left=�6{   $��25��6�   $��	225,4,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��260��6�   $
��Bold"�6�   $��14(�6�   ��6F   �� *Data.AllocationStatus+$ OneWay=�6�   5"      5#      .��5(      � -   5         �Name$ 
LayoutRoot��5(       � DataContext 6   ��  - )OverShortDetailAllocationsModelDataSource �� Source# [ .+�5)   
   �� $
��Left=�6   $��33��6/   $��9,14,0,0q�6;   $
��Wrap=�6M   $	��Top=�6a   $	��209��6y   $��21.333(�6�   $��Short Allocations��6�   �� 5*   
   -   5         ��Name$ ItemLst��50   x    %� IsVirtualizing .  %� VirtualizationMode$ 	Recycling=�5,      ! �� IsDeferredScrollingEnabled . C  =Core.Common.UI.DataVirtualization.VirtualListLoadingIndicator   
IsAttached .   OversShortsTemplate#���  50   C   $��Stretch=�6�   $	��295��6�   $��	0,135,0,0q�6�   $	��Top=�6�   $
��Auto��6�     AlphaListBoxStyle#���  6�    �� SelectedItem 5/      �� ?   9WaterNut.QuerySpace.OversShortQS.ViewModels.BaseViewModel   Instance# Z  �� Path$$ VCurrentOverShortAllocationsEX���50      �� *OverShortAllocationsEXes+6�   �� 51   
   $
��Left=�6e   $��24��6�   $��
200,23,0,0q�6�   $
��Wrap=�6�   $	��Top=�6�   $	��175��6�   $��20(�6�   $
 Right=�6�   ���	#FFE4E453��6   �� * OverShortAllocationsEXes.Count+$ 0 Filtered Results��6�   �� 52   
   -   5          TextButtonStyle#���  52      $
��Left=�6?   $��24��6Z   $��
511,19,0,0q�6f   $
��Wrap=�6z   $��Send to Excel ��6�   $	��Top=�6�   $	��121��6�   $��16(�6�   $��Segoe UI Symbol)�6�   y�6  �� */-CurrentApplicationSettings.AllowExportToExcel+�� 53   
   $
��Left=�6   $��23��6/   $��	13,74,0,0q�6;   $
��Wrap=�6N   $	��Top=�6b   $	��117��6z   $��16(�6�   $��Item Number��6�   $
 Center=�6�   �� 54   
   -   5        ���	#7FFFFFFF$
��Left=�54   w   $��23��6�   $��	13,97,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��117��6�   $��16(�6�   $ Center=�6�     TransparentTextBoxStyle#���  6  ��6   �� *ItemNumberFilter+$ TwoWay=� �� UpdateSourceTrigger$ Explicit=�6A  �� 55   
   $
��Left=�6   $��23��6/   $��
135,74,0,0q�6;   $
��Wrap=�6O   $	��Top=�6c   $	��155��6{   $��16(�6�   $��Item Description��6�   $
 Center=�6�   �� 56   
   -   5        ���	#7FFFFFFF$
��Left=�56   |   $��23��6�   $��
135,97,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��155��6�   $��16(�6�   $ Center=�6�   #���  6  ��6   �� *ItemDescriptionFilter+$ TwoWay=�$ Explicit=�6G  �� 57   
   $
��Left=�6   $��23��6/   $��
295,74,0,0q�6;   $
��Wrap=�6O   $	��Top=�6c   $��80��6{   $��16(�6�   $��Status��6�   $
 Center=�6�   �� 58   
   -   5        ���	#7FFFFFFF$
��Left=�58   s   $��23��6�   $��
295,97,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��80��6�   $��16(�6�   $ Center=�6�   #���  6  ��6   �� *StatusFilter+$ TwoWay=�$ Explicit=�6=  �� 59   
   -   5         ��Name$ ViewErrorChk��59   Y   $
��Left=�6o   $��22��6�   $��
532,59,0,0q�6�   $	��Top=�6�   $��90��6�   $��View Errors��6�    J� RenderTransformOrigin$ 0.488,0.464&�6�    d� 	IsChecked 6   �� *
ViewErrors+$ PropertyChanged=�6�   �� 5;   
   -	   5        $ ViewErrorChk_Copy1��5;   Z   $
��Left=�6v   $��22��6�   $��
532,81,0,0q�6�   $	��Top=�6�   $	��100��6�   $��View Matches��6�   $ 0.488,0.464&�6�    6   �� *ViewMatches+$ PropertyChanged=�6�   �� 5<   
   -
   5        $ ViewErrorChk_Copy2��5<   [   $
��Left=�6w   $��22��6�   $��402,108,0,0q�6�   $	��Top=�6�   $	��125��6�   $��View Selected O/S��6�   $ 0.488,0.464&�6�    6   �� *ViewSelected+$ PropertyChanged=�6�   �� 5=   
   $
��Left=�6d   $��24��6   $��429,446,0,0q�6�   $
��Wrap=�6�   $	��Top=�6�   $	��201��6�   $��20(�6�   $
 Right=�6�   ���	#FFE4E453��6   �� *SelectedInvoiceValue+$ Total {0:c}�� �� IsAsync . 6�   �� 5>   
   -   5        $ ViewErrorChk_Copy5��5>   ]   $
��Left=�6y   $��22��6�   $��
402,81,0,0q�6�   $	��Top=�6�   $	��100��6�   $��View Bad Matches��6�   $ 0.488,0.464&�6�    6   �� *ViewBadMatches+$ PropertyChanged=�6�   5?      5@      