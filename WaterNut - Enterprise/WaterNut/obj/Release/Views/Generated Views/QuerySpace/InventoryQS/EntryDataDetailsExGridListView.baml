   M S B A M L   `   `   `  ���� C  ?WaterNut, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WaterNutWaterNut  I ECore.Common.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullmGclr-namespace:Core.Common.UI.DataVirtualization;assembly=Core.Common.UI!Core.Common.UI.DataVirtualization G4clr-namespace:Core.Common.UI;assembly=Core.Common.UICore.Common.UI ]?clr-namespace:Core.Common.UI.Validation;assembly=Core.Common.UICore.Common.UI.Validation g8clr-namespace:WaterNut.QuerySpace.InventoryQS.ViewModels*WaterNut.QuerySpace.InventoryQS.ViewModels  S OWaterNut.Client.Entities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullkKclr-namespace:InventoryQS.Client.Entities;assembly=WaterNut.Client.EntitiesInventoryQS.Client.Entities J    DWaterNut.QuerySpace.InventoryQS.Views.EntryDataDetailsExList_AutoGen   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  h dMicrosoft.Expression.Interactions, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bei9http://schemas.microsoft.com/expression/2010/interactions  "localclr-namespace:WaterNut  UvirtualGclr-namespace:Core.Common.UI.DataVirtualization;assembly=Core.Common.UI  Acoreui4clr-namespace:Core.Common.UI;assembly=Core.Common.UI  Ival?clr-namespace:Core.Common.UI.Validation;assembly=Core.Common.UI  Emodels8clr-namespace:WaterNut.QuerySpace.InventoryQS.ViewModels  ZentitiesKclr-namespace:InventoryQS.Client.Entities;assembly=WaterNut.Client.Entities  $��540.609��$
��Auto��  � 	Resources  T   NWaterNut.QuerySpace.InventoryQS.ViewModels.EntryDataDetailsExViewModel_AutoGen )  %EntryDataDetailsExViewModelDataSource �� 
TargetType;  5Core.Common.UI.DataVirtualization.VirtualListItemBase �� Property �� Value  EntryDataDetailsExTpl �� DataType4  .InventoryQS.Client.Entities.EntryDataDetailsEx.  (System.Windows.Interactivity.Interaction   Triggers/  )System.Windows.Interactivity.EventTrigger   	EventName1  +Core.Common.UI.Validation.ValidationBinding4  .Core.Common.UI.Validation.BindingDecoratorBase   Path   UpdateSourceTrigger	   ValidatesOnDataErrors
 d� 	IsChecked��%   &	        '��      &	 /       �� " ��.���  �@ AutoLoad . �� "  .R�� -   $
��Auto��$	��497��   $ 
MouseLeave��.+��� $��Entry Data Id��$
��Left=�$��24��$��	10,25,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��
150,25,0,0q�$	��Top=�$
��Auto��$��75����  $ Data.EntryDataId�$ PropertyChanged=�	 . �� $��Line Number��$
��Left=�$��24��$��	10,50,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��
150,50,0,0q�$	��Top=�$	��100��$��75����  $ Data.LineNumber�$ PropertyChanged=�	 . �� $��Quantity��$
��Left=�$��24��$��	10,75,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��
150,75,0,0q�$	��Top=�$	��100��$��75����  $ Data.Quantity�$ PropertyChanged=�	 . �� $��Units��$
��Left=�$��24��$��
10,100,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��150,100,0,0q�$	��Top=�$
��Auto��$��75����  $ 
Data.Units�$ PropertyChanged=�	 . �� $��Item Description��$
��Left=�$��24��$��
10,125,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��150,125,0,0q�$	��Top=�$
��Auto��$��75����  $ Data.ItemDescription�$ PropertyChanged=�	 . �� $
��Cost��$
��Left=�$��24��$��
10,150,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��150,150,0,0q�$	��Top=�$	��100��$��75����  $ 	Data.Cost�$ PropertyChanged=�	 . �� $��Qty Allocated��$
��Left=�$��24��$��
10,175,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��150,175,0,0q�$	��Top=�$	��100��$��75����  $ Data.QtyAllocated�$ PropertyChanged=�	 . �� $��Unit Weight��$
��Left=�$��24��$��
10,200,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��150,200,0,0q�$	��Top=�$	��100��$��75����  $ Data.UnitWeight�$ PropertyChanged=�	 . �� $��Do Not Allocate��$
��Left=�$��24��$��
10,225,0,0q�$	��Top=�$
��Auto��$��75���� $�� ��$
��Left=�$��24��$��150,225,0,0q�$	��Top=�$	��100��
   $ Data.DoNotAllocate�$ PropertyChanged=��� $��Tariff Code��$
��Left=�$��24��$��
10,250,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��150,250,0,0q�$	��Top=�$
��Auto��$��75����  $ Data.TariffCode�$ PropertyChanged=�	 . �� $��CNumber��$
��Left=�$��24��$��
10,275,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��150,275,0,0q�$	��Top=�$
��Auto��$��75����  $ Data.CNumber�$ PropertyChanged=�	 . �� $��CLine Number��$
��Left=�$��24��$��
10,300,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��150,300,0,0q�$	��Top=�$	��100��$��75����  $ Data.CLineNumber�$ PropertyChanged=�	 . �� $��
Downloaded��$
��Left=�$��24��$��
10,325,0,0q�$	��Top=�$
��Auto��$��75���� $�� ��$
��Left=�$��24��$��150,325,0,0q�$	��Top=�$	��100��
   $ Data.Downloaded�$ PropertyChanged=��� $��Duty Free Paid��$
��Left=�$��24��$��
10,350,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��150,350,0,0q�$	��Top=�$
��Auto��$��75����  $ Data.DutyFreePaid�$ PropertyChanged=�	 . �� $��Total��$
��Left=�$��24��$��
10,375,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��150,375,0,0q�$	��Top=�$	��100��$��75����  $ 
Data.Total�$ PropertyChanged=�	 . .��� -    �Name$ 
LayoutRoot�� � DataContext ��  �� Source# [  .+��� $��Entry Data Details Ex��$
��Left=�$��37.806��$��17,14.227,0,0q�$
��Wrap=�$	��Top=�$
��Auto��$��18(��� -    ��Name$ EntryDataDetailsExGrd�� �� SelectedValuePath$ EntityId�� %� IsVirtualizing .  %� VirtualizationMode$ 	Recycling=�! �� IsDeferredScrollingEnabled . C  =Core.Common.UI.DataVirtualization.VirtualListLoadingIndicator   
IsAttached . $
��Left=�$	��450��$��	10,74,0,0q�$	��Top=�$	��521��#���    AlphaListBoxStyle#���  ���� *EntryDataDetailsEx+ �� SelectedValue �� *CurrentEntryDataDetailsExID+ �� SelectedItem �� *VCurrentEntryDataDetailsEx+�� -    ��Name$ NewBtn1��$��Right=�$��25��$��0,44,64.8,0q�$
��Wrap=�$	��Top=�$��28�� �� TextAlignment$ Center=�  TextButtonStyle#���  $��20(�$	����$��Segoe UI Symbol)�   $ MouseLeftButtonDown��.	  (System.Windows.Interactivity.TriggerBase 	  Actions. >
  8Microsoft.Expression.Interactivity.Core.CallMethodAction
   
  
MethodName$ NewEntryDataDetailsEx�� 
  TargetObject �� # [  �� -   $ DelBtn��$��25��$��0,44,31.8,0q�$
��Wrap=�$	��Top=�$��28��$ Center=�  CloseButtonStyle#���  $��20(�$	����$��Segoe UI Symbol)�$��1��$��Right=�   $ MouseLeftButtonDown��. 
  $ DeleteEntryDataDetailsEx�� �� # [  