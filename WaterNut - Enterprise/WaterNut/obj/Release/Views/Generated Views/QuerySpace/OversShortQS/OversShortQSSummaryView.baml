   M S B A M L   `   `   `  ���� I  ECore.Common.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullmGclr-namespace:Core.Common.UI.DataVirtualization;assembly=Core.Common.UI!Core.Common.UI.DataVirtualization  S OWaterNut.Client.Entities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullmLclr-namespace:OversShortQS.Client.Entities;assembly=WaterNut.Client.EntitiesOversShortQS.Client.Entities C ?WaterNut, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulli9clr-namespace:WaterNut.QuerySpace.OversShortQS.ViewModels+WaterNut.QuerySpace.OversShortQS.ViewModels _4clr-namespace:WaterNut.QuerySpace.OversShortQS.Views&WaterNut.QuerySpace.OversShortQS.Views #clr-namespace:WaterNutWaterNut G4clr-namespace:Core.Common.UI;assembly=Core.Common.UICore.Common.UI  O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem D   >WaterNut.QuerySpace.OversShortQS.Views.OversShortQSSummaryView   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     [virtualGclr-namespace:Core.Common.UI.DataVirtualization;assembly=Core.Common.UI     aentitiesLclr-namespace:OversShortQS.Client.Entities;assembly=WaterNut.Client.Entities     Lmodels9clr-namespace:WaterNut.QuerySpace.OversShortQS.ViewModels     Fviews4clr-namespace:WaterNut.QuerySpace.OversShortQS.Views     (localclr-namespace:WaterNut     Gcoreui4clr-namespace:Core.Common.UI;assembly=Core.Common.UI     9System&clr-namespace:System;assembly=mscorlib     $
��Auto��$��1385.191��$	��Top=�  � 	Resources  P  JWaterNut.QuerySpace.OversShortQS.ViewModels.OversShortSummaryListViewModel (  $OversShortSummaryListModelDataSource �� 
TargetType;   5Core.Common.UI.DataVirtualization.VirtualListItemBase �� Property �� Value  OversShortSummaryIDT �� DataType-  'OversShortQS.Client.Entities.OversShort �� EndPoint �� 
StartPoint � Color � Offset	 �� Mode  TransparentTextBoxStyle
 �� 
TargetType ��Name  ExpHeadFontSize  ExpHeadStyle �� Triggers P� Property P� Value��%  &	        '��      &	 /     &	 �    &	 \    &	 h      �� " ��.���  �@ AutoLoad . �� "  .R�� $��80��$	��469������ $ 0.5,1&�$ 0.5,0&�.��� $ 	#33000000��$ 0.907Q�� $ 	#19FFFFFF��$ 0.069Q�.+��� $��	10,10,0,0q�$
��Left=�$	��Top=�$��37��$	��264��$��18.667(����� *Data.EntityName+�� $��	10,52,0,0q�$
��Left=�$	��Top=�$��27��$	��264��$��16(����� *LastAddress.DisplayLine+$	 OneWay=��� $��
282,52,0,0q�$
��Left=�$	��Top=�$��27��$	��159��$��16(����� *LastPhoneNumber.PhoneNumber+$	 OneWay=��� $��
282,10,0,0q�$
��Left=�$	��Top=�$��27��$	��147��$��NoWrap=�$��14(�$
��Bold"����� *#!LastJobPosition.JobPosition.Title+$	 OneWay=��� " ��.���  �@�FocusVisualStyle Z� ��  � �� �� "
 ��.R�� .+��� $ PART_ContentHost�����	#4CFFFFFF|�. $��Hidden=�$��Hidden=�X�16Q��� " ��.���  � �� �	#FFECF9A7 P�  �@J�IsMouseOver . . ���  � �� �	#FF8E9600.��� -    �Name$ 
LayoutRoot��$��0,0,0,0q� � DataContext ��  �� Source# [  .+���  �� SelectedValuePath$ EntityId�� %� IsVirtualizing .  %� VirtualizationMode$ 	Recycling=�! �� IsDeferredScrollingEnabled . C   =Core.Common.UI.DataVirtualization.VirtualListLoadingIndicator   
IsAttached . #���  $ �� IsSynchronizedWithCurrentItem$
 TrueY�$
��Left=�$	��388��$��
10,125,0,0q�$	��Top=�$	��500��  AlphaListBoxStyle#���   �� SelectedValue �� *CurrentOversShortID+ �� SelectedItem �� *VCurrentOversShort+���� *OversShorts+�� $
��Left=�$��44��$��	22,10,0,0q�$
��Wrap=�$��	Employees��$	��Top=�$	��281��$��26(����	#FF17204A�� ���	#4CFFFFFF$
��Left=�$��23��$��
189,54,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��304��$��16(� �� TextAlignment$ Center=�#���  ���� *OversShortFilter+ �� UpdateSourceTrigger$ PropertyChanged=��� $
��Left=�$��23��$��	21,54,0,0q�$
��Wrap=�$��Filter by OversShort Name��$	��Top=�$	��168��$��14(�    Core.Common.UI.SliderPanel  -     Name$ OversShortslider��$��668,54,0,-10000q�   Orientation$ Vertical��.+���  �� Orientation$ Vertical=�$��Stretch=�$��Stretch=����	#7FB0CAD3.+�9� -     9�Name$  AsycudaDocumentListEXP��! 9� 
IsExpanded! . " 9� ExpandDirection$" Right=�$��0,0,0,10q�$
��Auto��$
��Auto��$
��Left=�$	��Top=�$��5,5,5,10q����	#FFDEAFAF��� -   $
��Auto��.+��� $��63��#���  $	��Top=�$��Right=�$��	0,10,23,0q�$��55��$��Segoe UI Symbol)�$��40(�$	������ $��AsycudaDocument��#���  $��Right=�$��
0,65,0.4,0q�$
��Wrap=�$��78��# �� TextAlignment$# Center=�$ J� RenderTransformOrigin$$ 
0.535,1.32&�#���  $
��Bold"�$��42��$	��Top=�.��H  BWaterNut.QuerySpace.OversShortQS.Views.AsycudaDocumentList_AutoGen  $��0q�9� -   $   AsycudaDocumentItemListEXP��! . $" Right=�$��0,0,0,10q�$
��Auto��$
��Auto��$
��Left=�$	��Top=�$��5,5,5,10q����	#FFDEAFAF��� -   $
��Auto��.+��� $��63��#���  $	��Top=�$��Right=�$��	0,10,23,0q�$��55��$��Segoe UI Symbol)�$��40(�$	������ $��AsycudaDocumentItem��#���  $��Right=�$��
0,65,0.4,0q�$
��Wrap=�$��78��$# Center=�$$ 
0.535,1.32&�#���  $
��Bold"�$��42��$	��Top=�.��L  FWaterNut.QuerySpace.OversShortQS.Views.AsycudaDocumentItemList_AutoGen  $��0q�9� -   $  InventoryItemListEXP��! . $" Right=�$��0,0,0,10q�$
��Auto��$
��Auto��$
��Left=�$	��Top=�$��5,5,5,10q����	#FFDEAFAF��� -   $
��Auto��.+��� $��63��#���  $	��Top=�$��Right=�$��	0,10,23,0q�$��55��$��Segoe UI Symbol)�$��40(�$	������ $��InventoryItem��#���  $��Right=�$��
0,65,0.4,0q�$
��Wrap=�$��78��$# Center=�$$ 
0.535,1.32&�#���  $
��Bold"�$��42��$	��Top=�.��F  @WaterNut.QuerySpace.OversShortQS.Views.InventoryItemList_AutoGen  $��0q�9� -	   $#  OverShortAllocationsEXListEXP��! . $" Right=�$��0,0,0,10q�$
��Auto��$
��Auto��$
��Left=�$	��Top=�$��5,5,5,10q����	#FFDEAFAF��� -
   $
��Auto��.+��� $��63��#���  $	��Top=�$��Right=�$��	0,10,23,0q�$��55��$��Segoe UI Symbol)�$��40(�$	������ $��OverShortAllocationsEX��#���  $��Right=�$��
0,65,0.4,0q�$
��Wrap=�$��78��$# Center=�$$ 
0.535,1.32&�#���  $
��Bold"�$��42��$	��Top=�.��O	  IWaterNut.QuerySpace.OversShortQS.Views.OverShortAllocationsEXList_AutoGen	  $��0q�9� -   $  OverShortDetailListEXP��! . $" Right=�$��0,0,0,10q�$
��Auto��$
��Auto��$
��Left=�$	��Top=�$��5,5,5,10q����	#FFDEAFAF��� -   $
��Auto��.+��� $��63��#���  $	��Top=�$��Right=�$��	0,10,23,0q�$��55��$��Segoe UI Symbol)�$��40(�$	������ $��OverShortDetail��#���  $��Right=�$��
0,65,0.4,0q�$
��Wrap=�$��78��$# Center=�$$ 
0.535,1.32&�#���  $
��Bold"�$��42��$	��Top=�.��H
  BWaterNut.QuerySpace.OversShortQS.Views.OverShortDetailList_AutoGen
  $��0q�9� -   $&   OverShortDetailAllocationListEXP��! . $" Right=�$��0,0,0,10q�$
��Auto��$
��Auto��$
��Left=�$	��Top=�$��5,5,5,10q����	#FFDEAFAF��� -   $
��Auto��.+��� $��63��#���  $	��Top=�$��Right=�$��	0,10,23,0q�$��55��$��Segoe UI Symbol)�$��40(�$	������ $��OverShortDetailAllocation��#���  $��Right=�$��
0,65,0.4,0q�$
��Wrap=�$��78��$# Center=�$$ 
0.535,1.32&�#���  $
��Bold"�$��42��$	��Top=�.��R  LWaterNut.QuerySpace.OversShortQS.Views.OverShortDetailAllocationList_AutoGen  $��0q�9� -   $  OverShortDetailsEXListEXP��! . $" Right=�$��0,0,0,10q�$
��Auto��$
��Auto��$
��Left=�$	��Top=�$��5,5,5,10q����	#FFDEAFAF��� -   $
��Auto��.+��� $��63��#���  $	��Top=�$��Right=�$��	0,10,23,0q�$��55��$��Segoe UI Symbol)�$��40(�$	������ $��OverShortDetailsEX��#���  $��Right=�$��
0,65,0.4,0q�$
��Wrap=�$��78��$# Center=�$$ 
0.535,1.32&�#���  $
��Bold"�$��42��$	��Top=�.��K  EWaterNut.QuerySpace.OversShortQS.Views.OverShortDetailsEXList_AutoGen  $��0q�9� -   $'  !OverShortSuggestedDocumentListEXP��! . $" Right=�$��0,0,0,10q�$
��Auto��$
��Auto��$
��Left=�$	��Top=�$��5,5,5,10q����	#FFDEAFAF��� -   $
��Auto��.+��� $��63��#���  $	��Top=�$��Right=�$��	0,10,23,0q�$��55��$��Segoe UI Symbol)�$��40(�$	������ $ ��OverShortSuggestedDocument��#���  $��Right=�$��
0,65,0.4,0q�$
��Wrap=�$��78��$# Center=�$$ 
0.535,1.32&�#���  $
��Bold"�$��42��$	��Top=�.��S  MWaterNut.QuerySpace.OversShortQS.Views.OverShortSuggestedDocumentList_AutoGen  $��0q�9� -   $  OversShortListEXP��! . $" Right=�$��0,0,0,10q�$
��Auto��$
��Auto��$
��Left=�$	��Top=�$��5,5,5,10q����	#FFDEAFAF��� -   $
��Auto��.+��� $��63��#���  $	��Top=�$��Right=�$��	0,10,23,0q�$��55��$��Segoe UI Symbol)�$��40(�$	������ $��
OversShort��#���  $��Right=�$��
0,65,0.4,0q�$
��Wrap=�$��78��$# Center=�$$ 
0.535,1.32&�#���  $
��Bold"�$��42��$	��Top=�.��C  =WaterNut.QuerySpace.OversShortQS.Views.OversShortList_AutoGen  $��0q�9� -   $  OversShortEXListEXP��! . $" Right=�$��0,0,0,10q�$
��Auto��$
��Auto��$
��Left=�$	��Top=�$��5,5,5,10q����	#FFDEAFAF��� -   $
��Auto��.+��� $��63��#���  $	��Top=�$��Right=�$��	0,10,23,0q�$��55��$��Segoe UI Symbol)�$��40(�$	������ $��OversShortEX��#���  $��Right=�$��
0,65,0.4,0q�$
��Wrap=�$��78��$# Center=�$$ 
0.535,1.32&�#���  $
��Bold"�$��42��$	��Top=�.��E  ?WaterNut.QuerySpace.OversShortQS.Views.OversShortEXList_AutoGen  $��0q��� $
��Left=�$	��449��$��
517,54,0,0q�$	��Top=�$	��142��$��0,0,0,0q�$
��Auto=���. .���� $$ 0.5,0.5&�$	��449��$	��134��$��0,0,0,0q�.+��� -   $��Asycuda Document��#���  $��Right=�$
��Auto��$��
0,10,20,10q�$
��Wrap=�$	��Top=�$
��Auto��$	��110��$# Right=�$$ 
0.535,1.32&�#���  $
��Bold"��� -   $��Asycuda Document Item��#���  $��Right=�$
��Auto��$��
0,10,20,10q�$
��Wrap=�$	��Top=�$
��Auto��$	��110��$# Right=�$$ 
0.535,1.32&�#���  $
��Bold"��� -   $��Inventory Item��#���  $��Right=�$
��Auto��$��
0,10,20,10q�$
��Wrap=�$	��Top=�$
��Auto��$	��110��$# Right=�$$ 
0.535,1.32&�#���  $
��Bold"��� -   $��Over Short Allocations EX��#���  $��Right=�$
��Auto��$��
0,10,20,10q�$
��Wrap=�$	��Top=�$
��Auto��$	��110��$# Right=�$$ 
0.535,1.32&�#���  $
��Bold"��� -   $��Over Short Detail��#���  $��Right=�$
��Auto��$��
0,10,20,10q�$
��Wrap=�$	��Top=�$
��Auto��$	��110��$# Right=�$$ 
0.535,1.32&�#���  $
��Bold"��� -   $"��Over Short Detail Allocation��#���  $��Right=�$
��Auto��$��
0,10,20,10q�$
��Wrap=�$	��Top=�$
��Auto��$	��110��$# Right=�$$ 
0.535,1.32&�#���  $
��Bold"��� -   $��Over Short Details EX��#���  $��Right=�$
��Auto��$��
0,10,20,10q�$
��Wrap=�$	��Top=�$
��Auto��$	��110��$# Right=�$$ 
0.535,1.32&�#���  $
��Bold"��� -   $#��Over Short Suggested Document��#���  $��Right=�$
��Auto��$��
0,10,20,10q�$
��Wrap=�$	��Top=�$
��Auto��$	��110��$# Right=�$$ 
0.535,1.32&�#���  $
��Bold"��� -   $��EX��#���  $��Right=�$
��Auto��$��
0,10,20,10q�$
��Wrap=�$	��Top=�$
��Auto��$	��110��$# Right=�$$ 
0.535,1.32&�#���  $
��Bold"��� $
��Left=�$	��459��$��
659,54,0,0q�$	��Top=�$��4����
� .��� $ 	#7F6570B6��$ 1Q�� $ 	#FFEDEEF4��