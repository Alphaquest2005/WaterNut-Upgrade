   M S B A M L   `   `   `  ����C  ?WaterNut, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WaterNutWaterNut  5      i9clr-namespace:WaterNut.QuerySpace.OversShortQS.ViewModels+WaterNut.QuerySpace.OversShortQS.ViewModels  5      I ECore.Common.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullmGclr-namespace:Core.Common.UI.DataVirtualization;assembly=Core.Common.UI!Core.Common.UI.DataVirtualization 5	      )    #WaterNut.Views.OverShortDetailsView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      (localclr-namespace:WaterNut     5      Iqsv9clr-namespace:WaterNut.QuerySpace.OversShortQS.ViewModels     5      fdataVirtualizationGclr-namespace:Core.Common.UI.DataVirtualization;assembly=Core.Common.UI     5	        � 	Resources  5      �� 5   
    �� Member$( "qsv:OverShortDetailsModel.Instance��6      Key#OverShortDetailsModelDataSource  6@   �� 5   
    �� 
TargetType" ��6   .�5      �� ;  5Core.Common.UI.DataVirtualization.VirtualListItemBase �� Property �@ AutoLoad �� Value . 6P   5      �� 5   
   OversShortsTemplate  .R�5      � $��95��6   $	��810��6   .+�5      ��   TextBox2TextBlock#���  6   $
��Left=�6u   $��25��6�   $��	90,10,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��155��6�   $
��Bold"�6�   $��14(�6�   ��6F   �� *Data.ItemNumber+ �� Mode$ OneWay=�6�   �� 5      #���  6   $
��Left=�6�   $��25��6�   $��
265,10,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��255��6  ��6F   �� *Data.Data.ItemDescription+ �� StringFormat$ {0:dd-MMM-yy}��$ OneWay=�6  �� 5      #���  6   $
��Left=�6u   $��25��6�   $��
615,10,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��90��6�    �� TextAlignment$ Right=�6�   ��6F   �� *Data.InvoiceQty+$ OneWay=�6�   �� 5      #���  6   $
��Left=�6v   $��25��6�   $��
710,10,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��80��6�   $ Right=�6�   ��6F   �� *Data.ReceivedQty+$ OneWay=�6�   �� 5      #���  6   $
��Left=�6~   $��25��6�   $��
525,10,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��85��6�   $ Right=�6�   ��6F   �� *	Data.Cost+$ c��$ OneWay=�6�   �� 5      #���  6   $
��Left=�6o   $��25��6�   $��	10,20,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��75��6�   $
��Bold"�6�   $��14(�6�   ��6F   �� *	Data.Type+$ OneWay=�6�   �� 5      #���  6   $
��Left=�6q   $��20��6�   $��	90,40,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��245��6�   $
��Bold"�6�   $��14(�6�   ��6F   �� *Data.Status+$ OneWay=�6�   �� 5      	 ��Name$	 ViewSuggestionTxt��6   -   5        $
��Left=�5   7   $��20��6R   $��
700,38,0,0q�6^   $
��Wrap=�6r   $	��Top=�6�   $	��100��6�   $��11(�6�   $��View Suggestions��6�   
 �� TextAlignment$

 Left=�6�     TextButtonStyle#���  6�   6  �� 5      $	 ViewSuggestionTxt_Copy��6   -   5        $
��Left=�5   <   $��20��6W   $��
590,38,0,0q�6c   $
��Wrap=�6w   $	��Top=�6�   $	��105��6�   $��11(�6�   $��Match Current Item��6�   $

 Left=�6�   #���  6�   6  �� 5      $	 ViewSuggestionTxt_Copy1��6   -   5        $
��Left=�5   =   $��20��6X   $��
350,38,0,0q�6d   $
��Wrap=�6x   $	��Top=�6�   $��80��6�   $��11(�6�   $��Remove Match��6�   $

 Left=�6�     CloseButtonStyle#���  6�   6  �� 5      $	 ViewSuggestionTxt_Copy2��6   -   5        $
��Left=�5   =   $��20��6X   $��
470,38,0,0q�6d   $
��Wrap=�6x   $	��Top=�6�   $��95��6�   $��11(�6�   $��Remove O/S Detail��6�   $

 Left=�6�   #���  6�   6  �� 5      #���  6   $
��Left=�6�   $��20��6�   $��	90,70,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��130��6  $
��Bold"�6  $��14(�6-  ��6F   �� *ECData.LastOverShortDetailAllocation.xcuda_Item.xcuda_ASYCUDA.CNumber+$ OneWay=�6-  �� 5      #���  6   $
��Left=�6�   $��20��6�   $��
225,70,0,0q�6�   $
 Wrap=�6�   $	��Top=�6  $	��130��6)  $
��Bold"�65  $��14(�6G  ��6F   �� *NLData.LastOverShortDetailAllocation.xcuda_Item.xcuda_ASYCUDA.RegistrationDate+$ OneWay=�$ d��6G  �� 5       #���  6   $
��Left=�6�   $��20��6�   $��
360,70,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��35��6  $
��Bold"�6  $��14(�6"  ��6F   �� *:8Data.LastOverShortDetailAllocation.xcuda_Item.LineNumber+$ OneWay=�6"  �� 5!      #���  6   $
��Left=�6�   $��20��6�   $��
420,70,0,0q�6�   $
 Wrap=�6�   $	��Top=�6   $��65��6  $
��Bold"�6#  $��14(�65  ��6F   �� *:8Data.LastOverShortDetailAllocation.xcuda_Item.PiQuantity+$ OneWay=�$
 Pi 0��65  �� 5"      #���  6   $
��Left=�6�   $��20��6�   $��
575,70,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��215��6  $
��Bold"�6  $��14(�6  ��6F   �� *64Data.LastOverShortDetailAllocation.xcuda_Item.Status+$ OneWay=�6  5#      5$      .��5)      � -   5         �Name$ 
LayoutRoot��5)       � DataContext 6   ��  # OverShortDetailsModelDataSource �� Source# [ .+�5*   
   �� $
��Left=�6   $��O/S Details��6/   $��55��6B   $��9,14,0,0q�6N   $
��Wrap=�6`   $	��Top=�6t   $	��161��6�   $��21.333(�6�   �� 5+   
   -   5         ��Name$ ItemLst��52   7    %� IsVirtualizing .  %� VirtualizationMode$ 	Recycling=�5-      ! �� IsDeferredScrollingEnabled . C  =Core.Common.UI.DataVirtualization.VirtualListLoadingIndicator   
IsAttached .   OversShortsTemplate#���  50      $��Stretch=�52   H   $	��295��6f   $��	0,135,0,0q�6s   $	��Top=�6�   $
��Auto��6�     AlphaListBoxStyle#���  6�    �� SelectedItem 51      �� ?   9WaterNut.QuerySpace.OversShortQS.ViewModels.BaseViewModel   Instance# Z  �� Path$  VCurrentOverShortDetailsEX���52      �� *OverShortDetails+6�   �� 53   
   $
��Left=�6]   $��24��6x   $��
175,23,0,0q�6�   $
��Wrap=�6�   $	��Top=�6�   $	��200��6�   $��20(�6�   $
 Right=�6�   ���	#FFE4E453��6   �� *OverShortDetails.Count+$ 0 Filtered Results��6�   �� 54   
   -   5        #���  54      $
��Left=�6?   $��24��6Z   $��
511,19,0,0q�6f   $
��Wrap=�6z   $��Send to Excel ��6�   $	��Top=�6�   $	��121��6�   $��16(�6�   $��Segoe UI Symbol)�6�   y�6  �� */-CurrentApplicationSettings.AllowExportToExcel+�� 55   
   $
��Left=�6   $��23��6/   $��	13,74,0,0q�6;   $
��Wrap=�6N   $	��Top=�6b   $	��117��6z   $��16(�6�   $��Item Number��6�   $
 Center=�6�   �� 56   
   -   5        ���	#7FFFFFFF$
��Left=�56   w   $��23��6�   $��	13,97,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��117��6�   $��16(�6�   $ Center=�6�     TransparentTextBoxStyle#���  6  ��6   �� *ItemNumberFilter+$ TwoWay=� �� UpdateSourceTrigger$ Explicit=�6A  �� 57   
   $
��Left=�6   $��23��6/   $��
135,74,0,0q�6;   $
��Wrap=�6O   $	��Top=�6c   $	��155��6{   $��16(�6�   $��Item Description��6�   $
 Center=�6�   �� 58   
   -	   5        ���	#7FFFFFFF$
��Left=�58   |   $��23��6�   $��
135,97,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��155��6�   $��16(�6�   $ Center=�6�   #���  6  ��6   �� *ItemDescriptionFilter+$ TwoWay=�$ Explicit=�6G  �� 59   
   $
��Left=�6   $��23��6/   $��
295,74,0,0q�6;   $
��Wrap=�6O   $	��Top=�6c   $��80��6{   $��16(�6�   $��Status��6�   $
 Center=�6�   �� 5:   
   -
   5        ���	#7FFFFFFF$
��Left=�5:   s   $��23��6�   $��
295,97,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��80��6�   $��16(�6�   $ Center=�6�   #���  6  ��6   �� *StatusFilter+$ TwoWay=�$ Explicit=�6=  �� 5;   
   -   5         ��Name$ ViewErrorChk��5;   Y   $
��Left=�6o   $��22��6�   $��
532,59,0,0q�6�   $	��Top=�6�   $��90��6�   $��View Errors��6�    J� RenderTransformOrigin$ 0.488,0.464&�6�    d� 	IsChecked 6   �� *
ViewErrors+$ PropertyChanged=�6�   �� 5=   
   -   5        $ ViewErrorChk_Copy1��5=   Z   $
��Left=�6v   $��22��6�   $��
532,81,0,0q�6�   $	��Top=�6�   $	��100��6�   $��View Matches��6�   $ 0.488,0.464&�6�    6   �� *ViewMatches+$ PropertyChanged=�6�   �� 5>   
   -   5        $ ViewErrorChk_Copy2��5>   [   $
��Left=�6w   $��22��6�   $��402,108,0,0q�6�   $	��Top=�6�   $	��125��6�   $��View Selected O/S��6�   $ 0.488,0.464&�6�    6   �� *ViewSelected+$ PropertyChanged=�6�   �� 5?   
   -   5        $ ViewErrorChk_Copy3��5?   X   $
��Left=�6t   $��22��6�   $��
402,59,0,0q�6�   $	��Top=�6�   $��79��6�   $��
View Overs��6�   $ 0.488,0.464&�6�    6   �� *	ViewOvers+$ PropertyChanged=�6�   �� 5@   
   -   5        $ ViewErrorChk_Copy4��5@   Y   $
��Left=�6u   $��22��6�   $��
402,81,0,0q�6�   $	��Top=�6�   $��90��6�   $��View Shorts��6�   $ 0.488,0.464&�6�    6   �� *
ViewShorts+$ PropertyChanged=�6�   �� 5A   
   $
��Left=�6]   $��24��6x   $��429,446,0,0q�6�   $
��Wrap=�6�   $	��Top=�6�   $	��201��6�   $��20(�6�   $
 Right=�6�   ���	#FFE4E453��6   �� *SelectedTotal+$ Total {0:c}�� �� IsAsync . 6�   �� 5B   
   -   5        $ ViewErrorChk_Copy5��5B   ]   $
��Left=�6y   $��22��6�   $��
402,32,0,0q�6�   $	��Top=�6�   $	��100��6�   $��View Bad Matches��6�   $ 0.488,0.464&�6�    6   �� *ViewBadMatches+$ PropertyChanged=�6�   5C      5D      