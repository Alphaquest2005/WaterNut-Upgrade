   M S B A M L   `   `   `  ���� C  ?WaterNut, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WaterNutWaterNut  I ECore.Common.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullmGclr-namespace:Core.Common.UI.DataVirtualization;assembly=Core.Common.UI!Core.Common.UI.DataVirtualization G4clr-namespace:Core.Common.UI;assembly=Core.Common.UICore.Common.UI ]?clr-namespace:Core.Common.UI.Validation;assembly=Core.Common.UICore.Common.UI.Validation u?clr-namespace:WaterNut.QuerySpace.PreviousDocumentQS.ViewModels1WaterNut.QuerySpace.PreviousDocumentQS.ViewModels  S OWaterNut.Client.Entities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullyRclr-namespace:PreviousDocumentQS.Client.Entities;assembly=WaterNut.Client.Entities"PreviousDocumentQS.Client.Entities S    MWaterNut.QuerySpace.PreviousDocumentQS.Views.PreviousDocumentItemList_AutoGen   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  h dMicrosoft.Expression.Interactions, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bei9http://schemas.microsoft.com/expression/2010/interactions  "localclr-namespace:WaterNut  UvirtualGclr-namespace:Core.Common.UI.DataVirtualization;assembly=Core.Common.UI  Acoreui4clr-namespace:Core.Common.UI;assembly=Core.Common.UI  Ival?clr-namespace:Core.Common.UI.Validation;assembly=Core.Common.UI  Lmodels?clr-namespace:WaterNut.QuerySpace.PreviousDocumentQS.ViewModels  aentitiesRclr-namespace:PreviousDocumentQS.Client.Entities;assembly=WaterNut.Client.Entities  $��540.609��$
��Auto��  � 	Resources  ]   WWaterNut.QuerySpace.PreviousDocumentQS.ViewModels.PreviousDocumentItemViewModel_AutoGen +  'PreviousDocumentItemViewModelDataSource �� 
TargetType;  5Core.Common.UI.DataVirtualization.VirtualListItemBase �� Property �� Value  PreviousDocumentItemTpl �� DataType=  7PreviousDocumentQS.Client.Entities.PreviousDocumentItem.  (System.Windows.Interactivity.Interaction   Triggers/  )System.Windows.Interactivity.EventTrigger   	EventName1  +Core.Common.UI.Validation.ValidationBinding4  .Core.Common.UI.Validation.BindingDecoratorBase   Path   UpdateSourceTrigger	   ValidatesOnDataErrors
 �� DisplayMemberPath �� SelectedValuePath �� 
IsEditable �� SelectedValue �� UpdateSourceTrigger �� Mode �� ElementName �� SelectedItem �� Text d� 	IsChecked��%;  &	        '��      &	 /       �� " ��.���  �@ AutoLoad . �� "  .R�� -   $
��Auto��$	��497��   $ 
MouseLeave��.+��� $"��Amount_deducted_from_licence��$
��Left=�$��24��$��	10,25,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��
150,25,0,0q�$	��Top=�$
��Auto��$��75����  $' !Data.Amount_deducted_from_licence�$ PropertyChanged=�	 . �� $��Licence_number��$
��Left=�$��24��$��	10,50,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��
150,50,0,0q�$	��Top=�$
��Auto��$��75����  $ Data.Licence_number�$ PropertyChanged=�	 . �� $��Free_text_1��$
��Left=�$��24��$��	10,75,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��
150,75,0,0q�$	��Top=�$
��Auto��$��75����  $ Data.Free_text_1�$ PropertyChanged=�	 . �� $��Free_text_2��$
��Left=�$��24��$��
10,100,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��150,100,0,0q�$	��Top=�$
��Auto��$��75����  $ Data.Free_text_2�$ PropertyChanged=�	 . �� $��Entry Data Details��$
��Left=�$��24��$��
10,125,0,0q�$	��Top=�$
��Auto��$��75���� $
 
EntityName��$ EntryDataDetailsId�� . $
��Left=�$��24��$��150,125,0,0q�$	��Top=�$
��Auto��$��75��$��14(�   $ Data.EntryDataDetailsId����� *#!DataContext.Data.EntryDataDetails+$ PropertyChanged=�$ OneWay=�$ 
LayoutRoot�� �� *VData.EntryDataDetails+ �� *!Data.EntryDataDetailsEntityName+$ 	LostFocus=��� $��Line Number��$
��Left=�$��24��$��
10,150,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��150,150,0,0q�$	��Top=�$	��100��$��75����  $ Data.LineNumber�$ PropertyChanged=�	 . �� $��Is Assessed��$
��Left=�$��24��$��
10,175,0,0q�$	��Top=�$
��Auto��$��75���� $�� ��$
��Left=�$��24��$��150,175,0,0q�$	��Top=�$	��100��   $ Data.IsAssessed�$ PropertyChanged=��� $��DPQty Allocated��$
��Left=�$��24��$��
10,200,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��150,200,0,0q�$	��Top=�$	��100��$��75����  $ Data.DPQtyAllocated�$ PropertyChanged=�	 . �� $��DFQty Allocated��$
��Left=�$��24��$��
10,225,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��150,225,0,0q�$	��Top=�$	��100��$��75����  $ Data.DFQtyAllocated�$ PropertyChanged=�	 . �� $��Attribute Only Allocation��$
��Left=�$��24��$��
10,250,0,0q�$	��Top=�$
��Auto��$��75���� $�� ��$
��Left=�$��24��$��150,250,0,0q�$	��Top=�$	��100��   $" Data.AttributeOnlyAllocation�$ PropertyChanged=��� $��Do Not Allocate��$
��Left=�$��24��$��
10,275,0,0q�$	��Top=�$
��Auto��$��75���� $�� ��$
��Left=�$��24��$��150,275,0,0q�$	��Top=�$	��100��   $ Data.DoNotAllocate�$ PropertyChanged=��� $��	Do Not EX��$
��Left=�$��24��$��
10,300,0,0q�$	��Top=�$
��Auto��$��75���� $�� ��$
��Left=�$��24��$��150,300,0,0q�$	��Top=�$	��100��   $ Data.DoNotEX�$ PropertyChanged=��� $��
Item_price��$
��Left=�$��24��$��
10,325,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��150,325,0,0q�$	��Top=�$	��100��$��75����  $ Data.Item_price�$ PropertyChanged=�	 . �� $��Item Number��$
��Left=�$��24��$��
10,350,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��150,350,0,0q�$	��Top=�$
��Auto��$��75����  $ Data.ItemNumber�$ PropertyChanged=�	 . �� $��Tariff Code��$
��Left=�$��24��$��
10,375,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��150,375,0,0q�$	��Top=�$
��Auto��$��75����  $ Data.TariffCode�$ PropertyChanged=�	 . �� $��Duty Liability��$
��Left=�$��24��$��
10,400,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��150,400,0,0q�$	��Top=�$	��100��$��75����  $ Data.DutyLiability�$ PropertyChanged=�	 . �� $��Total_ CIF_itm��$
��Left=�$��24��$��
10,425,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��150,425,0,0q�$	��Top=�$	��100��$��75����  $ Data.Total_CIF_itm�$ PropertyChanged=�	 . �� $��Freight��$
��Left=�$��24��$��
10,450,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��150,450,0,0q�$	��Top=�$	��100��$��75����  $ Data.Freight�$ PropertyChanged=�	 . �� $��Statistical_value��$
��Left=�$��24��$��
10,475,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��150,475,0,0q�$	��Top=�$	��100��$��75����  $ Data.Statistical_value�$ PropertyChanged=�	 . �� $��Pi Quantity��$
��Left=�$��24��$��
10,500,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��150,500,0,0q�$	��Top=�$	��100��$��75����  $ Data.PiQuantity�$ PropertyChanged=�	 . �� $��Item Description��$
��Left=�$��24��$��
10,525,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��150,525,0,0q�$	��Top=�$
��Auto��$��75����  $ Data.Description_of_goods�$ PropertyChanged=�	 . �� $��Commercial_ Description��$
��Left=�$��24��$��
10,550,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��150,550,0,0q�$	��Top=�$
��Auto��$��75����  $! Data.Commercial_Description�$ PropertyChanged=�	 . �� $��Suppplementary_unit_code��$
��Left=�$��24��$��
10,575,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��150,575,0,0q�$	��Top=�$
��Auto��$��75����  $# Data.Suppplementary_unit_code�$ PropertyChanged=�	 . �� $��Item Quantity��$
��Left=�$��24��$��
10,600,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��150,600,0,0q�$	��Top=�$	��100��$��75����  $ Data.ItemQuantity�$ PropertyChanged=�	 . .��� -    �Name$ 
LayoutRoot�� � DataContext ��  �� Source# [  .+��� $��Previous Document Item��$
��Left=�$��37.806��$��17,14.227,0,0q�$
��Wrap=�$	��Top=�$
��Auto��$��18(��� -    ��Name$ PreviousDocumentItemGrd��$ EntityId�� %� IsVirtualizing .  %� VirtualizationMode$ 	Recycling=�! �� IsDeferredScrollingEnabled . C  =Core.Common.UI.DataVirtualization.VirtualListLoadingIndicator   
IsAttached . $
��Left=�$	��450��$��	10,74,0,0q�$	��Top=�$	��521��#���    AlphaListBoxStyle#���  ���� *PreviousDocumentItems+ �� *CurrentPreviousDocumentItemID+ �� *VCurrentPreviousDocumentItem+�� -    ��Name$ NewBtn1��$��Right=�$��25��$��0,44,64.8,0q�$
��Wrap=�$	��Top=�$��28�� �� TextAlignment$ Center=�  TextButtonStyle#���  $��20(�$	����$��Segoe UI Symbol)�   $ MouseLeftButtonDown��.	  (System.Windows.Interactivity.TriggerBase 	  Actions. >
  8Microsoft.Expression.Interactivity.Core.CallMethodAction
   
  
MethodName$ NewPreviousDocumentItem��  
  TargetObject  �� # [  �� -   $ DelBtn��$��25��$��0,44,31.8,0q�$
��Wrap=�$	��Top=�$��28��$ Center=�  CloseButtonStyle#���  $��20(�$	����$��Segoe UI Symbol)�$��1��$��Right=�   $ MouseLeftButtonDown��. 
  $  DeletePreviousDocumentItem��  �� # [  