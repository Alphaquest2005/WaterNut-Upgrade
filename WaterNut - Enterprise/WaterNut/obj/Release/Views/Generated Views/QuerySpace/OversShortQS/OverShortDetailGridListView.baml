   M S B A M L   `   `   `  ���� C  ?WaterNut, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WaterNutWaterNut  I ECore.Common.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullmGclr-namespace:Core.Common.UI.DataVirtualization;assembly=Core.Common.UI!Core.Common.UI.DataVirtualization G4clr-namespace:Core.Common.UI;assembly=Core.Common.UICore.Common.UI ]?clr-namespace:Core.Common.UI.Validation;assembly=Core.Common.UICore.Common.UI.Validation i9clr-namespace:WaterNut.QuerySpace.OversShortQS.ViewModels+WaterNut.QuerySpace.OversShortQS.ViewModels  S OWaterNut.Client.Entities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullmLclr-namespace:OversShortQS.Client.Entities;assembly=WaterNut.Client.EntitiesOversShortQS.Client.Entities H    BWaterNut.QuerySpace.OversShortQS.Views.OverShortDetailList_AutoGen   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  h dMicrosoft.Expression.Interactions, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bei9http://schemas.microsoft.com/expression/2010/interactions  "localclr-namespace:WaterNut  UvirtualGclr-namespace:Core.Common.UI.DataVirtualization;assembly=Core.Common.UI  Acoreui4clr-namespace:Core.Common.UI;assembly=Core.Common.UI  Ival?clr-namespace:Core.Common.UI.Validation;assembly=Core.Common.UI  Fmodels9clr-namespace:WaterNut.QuerySpace.OversShortQS.ViewModels  [entitiesLclr-namespace:OversShortQS.Client.Entities;assembly=WaterNut.Client.Entities  $��540.609��$
��Auto��  � 	Resources  R   LWaterNut.QuerySpace.OversShortQS.ViewModels.OverShortDetailViewModel_AutoGen &  "OverShortDetailViewModelDataSource �� 
TargetType;  5Core.Common.UI.DataVirtualization.VirtualListItemBase �� Property �� Value  OverShortDetailTpl �� DataType2  ,OversShortQS.Client.Entities.OverShortDetail.  (System.Windows.Interactivity.Interaction   Triggers/  )System.Windows.Interactivity.EventTrigger   	EventName �� DisplayMemberPath �� SelectedValuePath	 �� 
IsEditable
 �� SelectedValue1  +Core.Common.UI.Validation.ValidationBinding4  .Core.Common.UI.Validation.BindingDecoratorBase   Path �� UpdateSourceTrigger �� Mode �� ElementName �� SelectedItem �� Text   UpdateSourceTrigger   ValidatesOnDataErrors��%7  &	        '��      &	 /       �� " ��.���  �@ AutoLoad . �� "  .R�� -   $
��Auto��$	��497��   $ 
MouseLeave��.+��� $��Overs Shorts��$
��Left=�$��24��$��	10,25,0,0q�$	��Top=�$
��Auto��$��75���� $ 
EntityName��$ OversShortsId��	 . $
��Left=�$��24��$��
150,25,0,0q�$	��Top=�$
��Auto��$��75��$��14(�
   $ Data.OversShortsId����� *DataContext.Data.OversShorts+$ PropertyChanged=�$ OneWay=�$ 
LayoutRoot�� �� *VData.OversShorts+ �� *Data.OversShortsEntityName+$ 	LostFocus=��� $��Received Qty��$
��Left=�$��24��$��	10,50,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��
150,50,0,0q�$	��Top=�$	��100��$��75����  $ Data.ReceivedQty�$ PropertyChanged=� . �� $��Item Number��$
��Left=�$��24��$��	10,75,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��
150,75,0,0q�$	��Top=�$
��Auto��$��75����  $ Data.ItemNumber�$ PropertyChanged=� . �� $��Item Description��$
��Left=�$��24��$��
10,100,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��150,100,0,0q�$	��Top=�$
��Auto��$��75����  $ Data.ItemDescription�$ PropertyChanged=� . �� $
��Cost��$
��Left=�$��24��$��
10,125,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��150,125,0,0q�$	��Top=�$	��100��$��75����  $ 	Data.Cost�$ PropertyChanged=� . �� $��Invoice Qty��$
��Left=�$��24��$��
10,150,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��150,150,0,0q�$	��Top=�$	��100��$��75����  $ Data.InvoiceQty�$ PropertyChanged=� . �� $��Status��$
��Left=�$��24��$��
10,175,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��150,175,0,0q�$	��Top=�$
��Auto��$��75����  $ Data.Status�$ PropertyChanged=� . .��� -    �Name$ 
LayoutRoot�� � DataContext ��  �� Source# [  .+��� $��Over Short Detail��$
��Left=�$��37.806��$��17,14.227,0,0q�$
��Wrap=�$	��Top=�$
��Auto��$��18(��� -    ��Name$ OverShortDetailGrd��$ EntityId�� %� IsVirtualizing .  %� VirtualizationMode$ 	Recycling=�! �� IsDeferredScrollingEnabled . C  =Core.Common.UI.DataVirtualization.VirtualListLoadingIndicator   
IsAttached . $
��Left=�$	��450��$��	10,74,0,0q�$	��Top=�$	��521��#���    AlphaListBoxStyle#���  ���� *OverShortDetails+
 �� *CurrentOverShortDetailID+ �� *VCurrentOverShortDetail+�� -    ��Name$ NewBtn1��$��Right=�$��25��$��0,44,64.8,0q�$
��Wrap=�$	��Top=�$��28�� �� TextAlignment$ Center=�  TextButtonStyle#���  $��20(�$	����$��Segoe UI Symbol)�   $ MouseLeftButtonDown��.	  (System.Windows.Interactivity.TriggerBase 	  Actions. >
  8Microsoft.Expression.Interactivity.Core.CallMethodAction
   
  
MethodName$ NewOverShortDetail�� 
  TargetObject �� # [  �� -   $ DelBtn��$��25��$��0,44,31.8,0q�$
��Wrap=�$	��Top=�$��28��$ Center=�  CloseButtonStyle#���  $��20(�$	����$��Segoe UI Symbol)�$��1��$��Right=�   $ MouseLeftButtonDown��. 
  $ DeleteOverShortDetail�� �� # [  