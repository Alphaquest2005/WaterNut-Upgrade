   M S B A M L   `   `   `  ���� C  ?WaterNut, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WaterNutWaterNut  I ECore.Common.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullmGclr-namespace:Core.Common.UI.DataVirtualization;assembly=Core.Common.UI!Core.Common.UI.DataVirtualization G4clr-namespace:Core.Common.UI;assembly=Core.Common.UICore.Common.UI ]?clr-namespace:Core.Common.UI.Validation;assembly=Core.Common.UICore.Common.UI.Validation m;clr-namespace:WaterNut.QuerySpace.CounterPointQS.ViewModels-WaterNut.QuerySpace.CounterPointQS.ViewModels  S OWaterNut.Client.Entities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullqNclr-namespace:CounterPointQS.Client.Entities;assembly=WaterNut.Client.EntitiesCounterPointQS.Client.Entities P    JWaterNut.QuerySpace.CounterPointQS.Views.CounterPointPODetailsList_AutoGen   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  h dMicrosoft.Expression.Interactions, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bei9http://schemas.microsoft.com/expression/2010/interactions  "localclr-namespace:WaterNut  UvirtualGclr-namespace:Core.Common.UI.DataVirtualization;assembly=Core.Common.UI  Acoreui4clr-namespace:Core.Common.UI;assembly=Core.Common.UI  Ival?clr-namespace:Core.Common.UI.Validation;assembly=Core.Common.UI  Hmodels;clr-namespace:WaterNut.QuerySpace.CounterPointQS.ViewModels  ]entitiesNclr-namespace:CounterPointQS.Client.Entities;assembly=WaterNut.Client.Entities  $��540.609��$
��Auto��  � 	Resources  Z   TWaterNut.QuerySpace.CounterPointQS.ViewModels.CounterPointPODetailsViewModel_AutoGen ,  (CounterPointPODetailsViewModelDataSource �� 
TargetType;  5Core.Common.UI.DataVirtualization.VirtualListItemBase �� Property �� Value  CounterPointPODetailsTpl �� DataType:  4CounterPointQS.Client.Entities.CounterPointPODetails.  (System.Windows.Interactivity.Interaction   Triggers/  )System.Windows.Interactivity.EventTrigger   	EventName1  +Core.Common.UI.Validation.ValidationBinding4  .Core.Common.UI.Validation.BindingDecoratorBase   Path   UpdateSourceTrigger	   ValidatesOnDataErrors��%L  &	        '��      &	 /       �� " ��.���  �@ AutoLoad . �� "  .R�� -   $
��Auto��$	��497��   $ 
MouseLeave��.+��� $��SEQ_ NO��$
��Left=�$��24��$��	10,25,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��
150,25,0,0q�$	��Top=�$	��100��$��75����  $ Data.SEQ_NO�$ PropertyChanged=�	 . �� $��ITEM_ NO��$
��Left=�$��24��$��	10,50,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��
150,50,0,0q�$	��Top=�$
��Auto��$��75����  $ Data.ITEM_NO�$ PropertyChanged=�	 . �� $��ORD_ QTY��$
��Left=�$��24��$��	10,75,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��
150,75,0,0q�$	��Top=�$	��100��$��75����  $ Data.ORD_QTY�$ PropertyChanged=�	 . �� $��	ORD_ UNIT��$
��Left=�$��24��$��
10,100,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��150,100,0,0q�$	��Top=�$
��Auto��$��75����  $ Data.ORD_UNIT�$ PropertyChanged=�	 . �� $��ITEM_ DESCR��$
��Left=�$��24��$��
10,125,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��150,125,0,0q�$	��Top=�$
��Auto��$��75����  $ Data.ITEM_DESCR�$ PropertyChanged=�	 . �� $��	ORD_ COST��$
��Left=�$��24��$��
10,150,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��150,150,0,0q�$	��Top=�$	��100��$��75����  $ Data.ORD_COST�$ PropertyChanged=�	 . �� $��UNIT_ WEIGHT��$
��Left=�$��24��$��
10,175,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��150,175,0,0q�$	��Top=�$	��100��$��75����  $ Data.UNIT_WEIGHT�$ PropertyChanged=�	 . .��� -   
 �Name$
 
LayoutRoot�� � DataContext ��  �� Source# [  .+��� $��Counter Point PODetails��$
��Left=�$��37.806��$��17,14.227,0,0q�$
��Wrap=�$	��Top=�$
��Auto��$��18(��� -    ��Name$ CounterPointPODetailsGrd�� �� SelectedValuePath$ EntityId�� %� IsVirtualizing .  %� VirtualizationMode$ 	Recycling=�! �� IsDeferredScrollingEnabled . C  =Core.Common.UI.DataVirtualization.VirtualListLoadingIndicator   
IsAttached . $
��Left=�$	��450��$��	10,74,0,0q�$	��Top=�$	��521��#���    AlphaListBoxStyle#���  ���� *CounterPointPODetails+ �� SelectedValue �� * CurrentCounterPointPODetailsID+ �� SelectedItem �� *VCurrentCounterPointPODetails+�� -    ��Name$ NewBtn1��$��Right=�$��25��$��0,44,64.8,0q�$
��Wrap=�$	��Top=�$��28�� �� TextAlignment$ Center=�  TextButtonStyle#���  $��20(�$	����$��Segoe UI Symbol)�   $ MouseLeftButtonDown��.	  (System.Windows.Interactivity.TriggerBase 	  Actions. >
  8Microsoft.Expression.Interactivity.Core.CallMethodAction
   
  
MethodName$ NewCounterPointPODetails�� 
  TargetObject �� # [  �� -   $ DelBtn��$��25��$��0,44,31.8,0q�$
��Wrap=�$	��Top=�$��28��$ Center=�  CloseButtonStyle#���  $��20(�$	����$��Segoe UI Symbol)�$��1��$��Right=�   $ MouseLeftButtonDown��. 
  $! DeleteCounterPointPODetails�� �� # [  