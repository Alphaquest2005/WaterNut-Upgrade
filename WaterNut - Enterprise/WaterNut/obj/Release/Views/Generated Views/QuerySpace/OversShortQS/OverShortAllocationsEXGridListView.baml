   M S B A M L   `   `   `  ���� C  ?WaterNut, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WaterNutWaterNut  I ECore.Common.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullmGclr-namespace:Core.Common.UI.DataVirtualization;assembly=Core.Common.UI!Core.Common.UI.DataVirtualization G4clr-namespace:Core.Common.UI;assembly=Core.Common.UICore.Common.UI ]?clr-namespace:Core.Common.UI.Validation;assembly=Core.Common.UICore.Common.UI.Validation i9clr-namespace:WaterNut.QuerySpace.OversShortQS.ViewModels+WaterNut.QuerySpace.OversShortQS.ViewModels  S OWaterNut.Client.Entities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullmLclr-namespace:OversShortQS.Client.Entities;assembly=WaterNut.Client.EntitiesOversShortQS.Client.Entities O    IWaterNut.QuerySpace.OversShortQS.Views.OverShortAllocationsEXList_AutoGen   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  h dMicrosoft.Expression.Interactions, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bei9http://schemas.microsoft.com/expression/2010/interactions  "localclr-namespace:WaterNut  UvirtualGclr-namespace:Core.Common.UI.DataVirtualization;assembly=Core.Common.UI  Acoreui4clr-namespace:Core.Common.UI;assembly=Core.Common.UI  Ival?clr-namespace:Core.Common.UI.Validation;assembly=Core.Common.UI  Fmodels9clr-namespace:WaterNut.QuerySpace.OversShortQS.ViewModels  [entitiesLclr-namespace:OversShortQS.Client.Entities;assembly=WaterNut.Client.Entities  $��540.609��$
��Auto��  � 	Resources  Y   SWaterNut.QuerySpace.OversShortQS.ViewModels.OverShortAllocationsEXViewModel_AutoGen -  )OverShortAllocationsEXViewModelDataSource �� 
TargetType;  5Core.Common.UI.DataVirtualization.VirtualListItemBase �� Property �� Value  OverShortAllocationsEXTpl �� DataType9  3OversShortQS.Client.Entities.OverShortAllocationsEX.  (System.Windows.Interactivity.Interaction   Triggers/  )System.Windows.Interactivity.EventTrigger   	EventName �� DisplayMemberPath �� SelectedValuePath	 �� 
IsEditable
 �� SelectedValue1  +Core.Common.UI.Validation.ValidationBinding4  .Core.Common.UI.Validation.BindingDecoratorBase   Path �� UpdateSourceTrigger �� Mode �� ElementName �� SelectedItem �� Text   UpdateSourceTrigger   ValidatesOnDataErrors(  "System.Windows.Controls.DatePicker   SelectedDate��%h  &	        '��      &	 /       �� " ��.���  �@ AutoLoad . �� "  .R�� -   $
��Auto��$	��497��   $ 
MouseLeave��.+��� $��Over Short Detail��$
��Left=�$��24��$��	10,25,0,0q�$	��Top=�$
��Auto��$��75���� $ 
EntityName��$ OverShortDetailId��	 . $
��Left=�$��24��$��
150,25,0,0q�$	��Top=�$
��Auto��$��75��$��14(�
   $ Data.OverShortDetailId����� *#!DataContext.Data.OverShortDetails+$ PropertyChanged=�$ OneWay=�$ 
LayoutRoot�� �� *VData.OverShortDetail+ �� * Data.OverShortDetailEntityName+$ 	LostFocus=��� $��Overs Shorts��$
��Left=�$��24��$��	10,50,0,0q�$	��Top=�$
��Auto��$��75���� $ 
EntityName��$ OversShortsId��	 . $
��Left=�$��24��$��
150,50,0,0q�$	��Top=�$
��Auto��$��75��$��14(�
   $ Data.OversShortsId����� *DataContext.Data.OversShorts+$ PropertyChanged=�$ OneWay=�$ 
LayoutRoot�� �� *VData.OversShorts+ �� *Data.OversShortsEntityName+$ 	LostFocus=��� $��Received Qty��$
��Left=�$��24��$��	10,75,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��
150,75,0,0q�$	��Top=�$	��100��$��75����  $ Data.ReceivedQty�$ PropertyChanged=� . �� $��Item Number��$
��Left=�$��24��$��
10,100,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��150,100,0,0q�$	��Top=�$
��Auto��$��75����  $ Data.ItemNumber�$ PropertyChanged=� . �� $��Item Description��$
��Left=�$��24��$��
10,125,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��150,125,0,0q�$	��Top=�$
��Auto��$��75����  $ Data.ItemDescription�$ PropertyChanged=� . �� $
��Cost��$
��Left=�$��24��$��
10,150,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��150,150,0,0q�$	��Top=�$	��100��$��75����  $ 	Data.Cost�$ PropertyChanged=� . �� $��Invoice Qty��$
��Left=�$��24��$��
10,175,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��150,175,0,0q�$	��Top=�$	��100��$��75����  $ Data.InvoiceQty�$ PropertyChanged=� . �� $��Status��$
��Left=�$��24��$��
10,200,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��150,200,0,0q�$	��Top=�$
��Auto��$��75����  $ Data.Status�$ PropertyChanged=� . �� $��
Invoice No��$
��Left=�$��24��$��
10,225,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��150,225,0,0q�$	��Top=�$
��Auto��$��75����  $ Data.InvoiceNo�$ PropertyChanged=� . �� $��Invoice Date��$
��Left=�$��24��$��
10,250,0,0q�$	��Top=�$
��Auto��  $
��Left=�$��24��$��150,250,0,0q�$	��Top=�$
��Auto��   $ Data.InvoiceDate�$ PropertyChanged=� . �� $��CNumber��$
��Left=�$��24��$��
10,275,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��150,275,0,0q�$	��Top=�$
��Auto��$��75����  $ Data.CNumber�$ PropertyChanged=� . �� $��Registration Date��$
��Left=�$��24��$��
10,300,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��150,300,0,0q�$	��Top=�$
��Auto��$��75����  $ Data.RegistrationDate�$ PropertyChanged=� . �� $��Duration��$
��Left=�$��24��$��
10,325,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��150,325,0,0q�$	��Top=�$	��100��$��75����  $ Data.Duration�$ PropertyChanged=� . �� $��Invoice Month��$
��Left=�$��24��$��
10,350,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��150,350,0,0q�$	��Top=�$	��100��$��75����  $ Data.InvoiceMonth�$ PropertyChanged=� . �� $��Asycuda Month��$
��Left=�$��24��$��
10,375,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��150,375,0,0q�$	��Top=�$	��100��$��75����  $ Data.AsycudaMonth�$ PropertyChanged=� . �� $��Allocated Value��$
��Left=�$��24��$��
10,400,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��150,400,0,0q�$	��Top=�$	��100��$��75����  $ Data.AllocatedValue�$ PropertyChanged=� . �� $��Received Value��$
��Left=�$��24��$��
10,425,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��150,425,0,0q�$	��Top=�$	��100��$��75����  $ Data.ReceivedValue�$ PropertyChanged=� . �� $��Invoice Value��$
��Left=�$��24��$��
10,450,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��150,450,0,0q�$	��Top=�$	��100��$��75����  $ Data.InvoiceValue�$ PropertyChanged=� . .��� -    �Name$ 
LayoutRoot�� � DataContext ��  �� Source# [  .+��� $��Over Short Allocations EX��$
��Left=�$��37.806��$��17,14.227,0,0q�$
��Wrap=�$	��Top=�$
��Auto��$��18(��� -    ��Name$ OverShortAllocationsEXGrd��$ EntityId�� %� IsVirtualizing .  %� VirtualizationMode$ 	Recycling=�! �� IsDeferredScrollingEnabled . C	  =Core.Common.UI.DataVirtualization.VirtualListLoadingIndicator 	  
IsAttached . $
��Left=�$	��450��$��	10,74,0,0q�$	��Top=�$	��521��#���    AlphaListBoxStyle#���  ���� *OverShortAllocationsEXes+
 �� *!CurrentOverShortAllocationsEXID+ �� * VCurrentOverShortAllocationsEX+�� -    ��Name$ NewBtn1��$��Right=�$��25��$��0,44,64.8,0q�$
��Wrap=�$	��Top=�$��28�� �� TextAlignment$ Center=�  TextButtonStyle#���  $��20(�$	����$��Segoe UI Symbol)�   $ MouseLeftButtonDown��.
  (System.Windows.Interactivity.TriggerBase 
  Actions. >  8Microsoft.Expression.Interactivity.Core.CallMethodAction     
MethodName$ NewOverShortAllocationsEX��    TargetObject  �� # [  �� -   $ DelBtn��$��25��$��0,44,31.8,0q�$
��Wrap=�$	��Top=�$��28��$ Center=�  CloseButtonStyle#���  $��20(�$	����$��Segoe UI Symbol)�$��1��$��Right=�   $ MouseLeftButtonDown��.   $" DeleteOverShortAllocationsEX��  �� # [  