   M S B A M L   `   `   `  ���� I  ECore.Common.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullmGclr-namespace:Core.Common.UI.DataVirtualization;assembly=Core.Common.UI!Core.Common.UI.DataVirtualization  S OWaterNut.Client.Entities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullmLclr-namespace:CoreEntities.Client.Entities;assembly=WaterNut.Client.EntitiesCoreEntities.Client.Entities C ?WaterNut, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulli9clr-namespace:WaterNut.QuerySpace.CoreEntities.ViewModels+WaterNut.QuerySpace.CoreEntities.ViewModels _4clr-namespace:WaterNut.QuerySpace.CoreEntities.Views&WaterNut.QuerySpace.CoreEntities.Views #clr-namespace:WaterNutWaterNut G4clr-namespace:Core.Common.UI;assembly=Core.Common.UICore.Common.UI  O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem D   >WaterNut.QuerySpace.CoreEntities.Views.CoreEntitiesSummaryView   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     [virtualGclr-namespace:Core.Common.UI.DataVirtualization;assembly=Core.Common.UI     aentitiesLclr-namespace:CoreEntities.Client.Entities;assembly=WaterNut.Client.Entities     Lmodels9clr-namespace:WaterNut.QuerySpace.CoreEntities.ViewModels     Fviews4clr-namespace:WaterNut.QuerySpace.CoreEntities.Views     (localclr-namespace:WaterNut     Gcoreui4clr-namespace:Core.Common.UI;assembly=Core.Common.UI     9System&clr-namespace:System;assembly=mscorlib     $
��Auto��$��1385.191��$	��Top=�  � 	Resources  Y  SWaterNut.QuerySpace.CoreEntities.ViewModels.ApplicationSettingsSummaryListViewModel 1  -ApplicationSettingsSummaryListModelDataSource �� 
TargetType;   5Core.Common.UI.DataVirtualization.VirtualListItemBase �� Property �� Value ! ApplicationSettingsSummaryIDT �� DataType6  0CoreEntities.Client.Entities.ApplicationSettings �� EndPoint �� 
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
10,125,0,0q�$	��Top=�$	��500��  AlphaListBoxStyle#���   �� SelectedValue �� *CurrentApplicationSettingsID+ �� SelectedItem �� *VCurrentApplicationSettings+���� *ApplicationSettings+�� $
��Left=�$��44��$��	22,10,0,0q�$
��Wrap=�$��	Employees��$	��Top=�$	��281��$��26(����	#FF17204A�� ���	#4CFFFFFF$
��Left=�$��23��$��
189,54,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��304��$��16(� �� TextAlignment$ Center=�#���  ���� *ApplicationSettingsFilter+ �� UpdateSourceTrigger$ PropertyChanged=��� $
��Left=�$��23��$��	21,54,0,0q�$
��Wrap=�$(��"Filter by ApplicationSettings Name��$	��Top=�$	��168��$��14(�    Core.Common.UI.SliderPanel  -     Name$ ApplicationSettingsslider��$��668,54,0,-10000q�   Orientation$ Vertical��.+���  �� Orientation$ Vertical=�$��Stretch=�$��Stretch=����	#7FB0CAD3.+�9� -     9�Name$   ApplicationSettingsListEXP��! 9� 
IsExpanded! . " 9� ExpandDirection$" Right=�$��0,0,0,10q�$
��Auto��$
��Auto��$
��Left=�$	��Top=�$��5,5,5,10q����	#FFDEAFAF��� -   $
��Auto��.+��� $��63��#���  $	��Top=�$��Right=�$��	0,10,23,0q�$��55��$��Segoe UI Symbol)�$��40(�$	������ $��ApplicationSettings��#���  $��Right=�$��
0,65,0.4,0q�$
��Wrap=�$��78��# �� TextAlignment$# Center=�$ J� RenderTransformOrigin$$ 
0.535,1.32&�#���  $
��Bold"�$��42��$	��Top=�.��L  FWaterNut.QuerySpace.CoreEntities.Views.ApplicationSettingsList_AutoGen  $��0q�9� -   $  AsycudaDocumentListEXP��! . $" Right=�$��0,0,0,10q�$
��Auto��$
��Auto��$
��Left=�$	��Top=�$��5,5,5,10q����	#FFDEAFAF��� -   $
��Auto��.+��� $��63��#���  $	��Top=�$��Right=�$��	0,10,23,0q�$��55��$��Segoe UI Symbol)�$��40(�$	������ $��AsycudaDocument��#���  $��Right=�$��
0,65,0.4,0q�$
��Wrap=�$��78��$# Center=�$$ 
0.535,1.32&�#���  $
��Bold"�$��42��$	��Top=�.��H  BWaterNut.QuerySpace.CoreEntities.Views.AsycudaDocumentList_AutoGen  $��0q�9� -   $   AsycudaDocumentItemListEXP��! . $" Right=�$��0,0,0,10q�$
��Auto��$
��Auto��$
��Left=�$	��Top=�$��5,5,5,10q����	#FFDEAFAF��� -   $
��Auto��.+��� $��63��#���  $	��Top=�$��Right=�$��	0,10,23,0q�$��55��$��Segoe UI Symbol)�$��40(�$	������ $��AsycudaDocumentItem��#���  $��Right=�$��
0,65,0.4,0q�$
��Wrap=�$��78��$# Center=�$$ 
0.535,1.32&�#���  $
��Bold"�$��42��$	��Top=�.��L  FWaterNut.QuerySpace.CoreEntities.Views.AsycudaDocumentItemList_AutoGen  $��0q�9� -	   $!  AsycudaDocumentSetExListEXP��! . $" Right=�$��0,0,0,10q�$
��Auto��$
��Auto��$
��Left=�$	��Top=�$��5,5,5,10q����	#FFDEAFAF��� -
   $
��Auto��.+��� $��63��#���  $	��Top=�$��Right=�$��	0,10,23,0q�$��55��$��Segoe UI Symbol)�$��40(�$	������ $��AsycudaDocumentSetEx��#���  $��Right=�$��
0,65,0.4,0q�$
��Wrap=�$��78��$# Center=�$$ 
0.535,1.32&�#���  $
��Bold"�$��42��$	��Top=�.��M	  GWaterNut.QuerySpace.CoreEntities.Views.AsycudaDocumentSetExList_AutoGen	  $��0q�9� -   $  Customs_ProcedureListEXP��! . $" Right=�$��0,0,0,10q�$
��Auto��$
��Auto��$
��Left=�$	��Top=�$��5,5,5,10q����	#FFDEAFAF��� -   $
��Auto��.+��� $��63��#���  $	��Top=�$��Right=�$��	0,10,23,0q�$��55��$��Segoe UI Symbol)�$��40(�$	������ $��Customs_Procedure��#���  $��Right=�$��
0,65,0.4,0q�$
��Wrap=�$��78��$# Center=�$$ 
0.535,1.32&�#���  $
��Bold"�$��42��$	��Top=�.��J
  DWaterNut.QuerySpace.CoreEntities.Views.Customs_ProcedureList_AutoGen
  $��0q�9� -   $  Document_TypeListEXP��! . $" Right=�$��0,0,0,10q�$
��Auto��$
��Auto��$
��Left=�$	��Top=�$��5,5,5,10q����	#FFDEAFAF��� -   $
��Auto��.+��� $��63��#���  $	��Top=�$��Right=�$��	0,10,23,0q�$��55��$��Segoe UI Symbol)�$��40(�$	������ $��Document_Type��#���  $��Right=�$��
0,65,0.4,0q�$
��Wrap=�$��78��$# Center=�$$ 
0.535,1.32&�#���  $
��Bold"�$��42��$	��Top=�.��F  @WaterNut.QuerySpace.CoreEntities.Views.Document_TypeList_AutoGen  $��0q�9� -   $  LicenceSummaryListEXP��! . $" Right=�$��0,0,0,10q�$
��Auto��$
��Auto��$
��Left=�$	��Top=�$��5,5,5,10q����	#FFDEAFAF��� -   $
��Auto��.+��� $��63��#���  $	��Top=�$��Right=�$��	0,10,23,0q�$��55��$��Segoe UI Symbol)�$��40(�$	������ $��LicenceSummary��#���  $��Right=�$��
0,65,0.4,0q�$
��Wrap=�$��78��$# Center=�$$ 
0.535,1.32&�#���  $
��Bold"�$��42��$	��Top=�.��G  AWaterNut.QuerySpace.CoreEntities.Views.LicenceSummaryList_AutoGen  $��0q�9� -   $  SubItemsListEXP��! . $" Right=�$��0,0,0,10q�$
��Auto��$
��Auto��$
��Left=�$	��Top=�$��5,5,5,10q����	#FFDEAFAF��� -   $
��Auto��.+��� $��63��#���  $	��Top=�$��Right=�$��	0,10,23,0q�$��55��$��Segoe UI Symbol)�$��40(�$	������ $��SubItems��#���  $��Right=�$��
0,65,0.4,0q�$
��Wrap=�$��78��$# Center=�$$ 
0.535,1.32&�#���  $
��Bold"�$��42��$	��Top=�.��A  ;WaterNut.QuerySpace.CoreEntities.Views.SubItemsList_AutoGen  $��0q��� $
��Left=�$	��449��$��
517,54,0,0q�$	��Top=�$	��142��$��0,0,0,0q�$
��Auto=���. .���� $$ 0.5,0.5&�$	��449��$	��134��$��0,0,0,0q�.+��� -   $��Asycuda Document��#���  $��Right=�$
��Auto��$��
0,10,20,10q�$
��Wrap=�$	��Top=�$
��Auto��$	��110��$# Right=�$$ 
0.535,1.32&�#���  $
��Bold"��� -   $��Asycuda Document Item��#���  $��Right=�$
��Auto��$��
0,10,20,10q�$
��Wrap=�$	��Top=�$
��Auto��$	��110��$# Right=�$$ 
0.535,1.32&�#���  $
��Bold"��� -   $��Asycuda Document Set Ex��#���  $��Right=�$
��Auto��$��
0,10,20,10q�$
��Wrap=�$	��Top=�$
��Auto��$	��110��$# Right=�$$ 
0.535,1.32&�#���  $
��Bold"��� -   $��Customs_ Procedure��#���  $��Right=�$
��Auto��$��
0,10,20,10q�$
��Wrap=�$	��Top=�$
��Auto��$	��110��$# Right=�$$ 
0.535,1.32&�#���  $
��Bold"��� -   $��Document_ Type��#���  $��Right=�$
��Auto��$��
0,10,20,10q�$
��Wrap=�$	��Top=�$
��Auto��$	��110��$# Right=�$$ 
0.535,1.32&�#���  $
��Bold"��� -   $��Licence Summary��#���  $��Right=�$
��Auto��$��
0,10,20,10q�$
��Wrap=�$	��Top=�$
��Auto��$	��110��$# Right=�$$ 
0.535,1.32&�#���  $
��Bold"��� -   $��	Sub Items��#���  $��Right=�$
��Auto��$��
0,10,20,10q�$
��Wrap=�$	��Top=�$
��Auto��$	��110��$# Right=�$$ 
0.535,1.32&�#���  $
��Bold"��� $
��Left=�$	��459��$��
659,54,0,0q�$	��Top=�$��4����
� .��� $ 	#7F6570B6��$ 1Q�� $ 	#FFEDEEF4��