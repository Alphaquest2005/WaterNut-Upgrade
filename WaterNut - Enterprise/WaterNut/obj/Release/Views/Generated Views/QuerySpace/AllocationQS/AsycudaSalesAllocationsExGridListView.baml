   M S B A M L   `   `   `  ���� C  ?WaterNut, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WaterNutWaterNut  I ECore.Common.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullmGclr-namespace:Core.Common.UI.DataVirtualization;assembly=Core.Common.UI!Core.Common.UI.DataVirtualization G4clr-namespace:Core.Common.UI;assembly=Core.Common.UICore.Common.UI ]?clr-namespace:Core.Common.UI.Validation;assembly=Core.Common.UICore.Common.UI.Validation i9clr-namespace:WaterNut.QuerySpace.AllocationQS.ViewModels+WaterNut.QuerySpace.AllocationQS.ViewModels  S OWaterNut.Client.Entities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullmLclr-namespace:AllocationQS.Client.Entities;assembly=WaterNut.Client.EntitiesAllocationQS.Client.Entities R    LWaterNut.QuerySpace.AllocationQS.Views.AsycudaSalesAllocationsExList_AutoGen   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  h dMicrosoft.Expression.Interactions, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bei9http://schemas.microsoft.com/expression/2010/interactions  "localclr-namespace:WaterNut  UvirtualGclr-namespace:Core.Common.UI.DataVirtualization;assembly=Core.Common.UI  Acoreui4clr-namespace:Core.Common.UI;assembly=Core.Common.UI  Ival?clr-namespace:Core.Common.UI.Validation;assembly=Core.Common.UI  Fmodels9clr-namespace:WaterNut.QuerySpace.AllocationQS.ViewModels  [entitiesLclr-namespace:AllocationQS.Client.Entities;assembly=WaterNut.Client.Entities  $��540.609��$
��Auto��  � 	Resources  \   VWaterNut.QuerySpace.AllocationQS.ViewModels.AsycudaSalesAllocationsExViewModel_AutoGen 0  ,AsycudaSalesAllocationsExViewModelDataSource �� 
TargetType;  5Core.Common.UI.DataVirtualization.VirtualListItemBase �� Property �� Value   AsycudaSalesAllocationsExTpl �� DataType<  6AllocationQS.Client.Entities.AsycudaSalesAllocationsEx.  (System.Windows.Interactivity.Interaction   Triggers/  )System.Windows.Interactivity.EventTrigger   	EventName1  +Core.Common.UI.Validation.ValidationBinding4  .Core.Common.UI.Validation.BindingDecoratorBase   Path   UpdateSourceTrigger	   ValidatesOnDataErrors
 �� DisplayMemberPath �� SelectedValuePath �� 
IsEditable �� SelectedValue �� UpdateSourceTrigger �� Mode �� ElementName �� SelectedItem �� Text(  "System.Windows.Controls.DatePicker   SelectedDate d� 	IsChecked��%�   &	        '��      &	 /       �� " ��.���  �@ AutoLoad . �� "  .R�� -   $
��Auto��$	��497��   $ 
MouseLeave��.+��� $��Total Value��$
��Left=�$��24��$��	10,25,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��
150,25,0,0q�$	��Top=�$	��100��$��75����  $ Data.TotalValue�$ PropertyChanged=�	 . �� $��Allocated Value��$
��Left=�$��24��$��	10,50,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��
150,50,0,0q�$	��Top=�$	��100��$��75����  $ Data.AllocatedValue�$ PropertyChanged=�	 . �� $��Status��$
��Left=�$��24��$��	10,75,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��
150,75,0,0q�$	��Top=�$
��Auto��$��75����  $ Data.Status�$ PropertyChanged=�	 . �� $��Qty Allocated��$
��Left=�$��24��$��
10,100,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��150,100,0,0q�$	��Top=�$	��100��$��75����  $ Data.QtyAllocated�$ PropertyChanged=�	 . �� $��x Line Number��$
��Left=�$��24��$��
10,125,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��150,125,0,0q�$	��Top=�$	��100��$��75����  $ Data.xLineNumber�$ PropertyChanged=�	 . �� $��Previous Item_��$
��Left=�$��24��$��
10,150,0,0q�$	��Top=�$
��Auto��$��75���� $
 
EntityName��$ PreviousItem_Id�� . $
��Left=�$��24��$��150,150,0,0q�$	��Top=�$
��Auto��$��75��$��14(�   $ Data.PreviousItem_Id����� * DataContext.Data.PreviousItem_+$ PropertyChanged=�$ OneWay=�$ 
LayoutRoot�� �� *VData.PreviousItem_+ �� *Data.PreviousItem_EntityName+$ 	LostFocus=��� $��Invoice Date��$
��Left=�$��24��$��
10,175,0,0q�$	��Top=�$
��Auto��  $
��Left=�$��24��$��150,175,0,0q�$	��Top=�$
��Auto��   $ Data.InvoiceDate�$ PropertyChanged=�	 . �� $��Sales Quantity��$
��Left=�$��24��$��
10,200,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��150,200,0,0q�$	��Top=�$	��100��$��75����  $ Data.SalesQuantity�$ PropertyChanged=�	 . �� $��Sales Qty Allocated��$
��Left=�$��24��$��
10,225,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��150,225,0,0q�$	��Top=�$	��100��$��75����  $ Data.SalesQtyAllocated�$ PropertyChanged=�	 . �� $��
Invoice No��$
��Left=�$��24��$��
10,250,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��150,250,0,0q�$	��Top=�$
��Auto��$��75����  $ Data.InvoiceNo�$ PropertyChanged=�	 . �� $��Item Number��$
��Left=�$��24��$��
10,275,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��150,275,0,0q�$	��Top=�$
��Auto��$��75����  $ Data.ItemNumber�$ PropertyChanged=�	 . �� $��Item Description��$
��Left=�$��24��$��
10,300,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��150,300,0,0q�$	��Top=�$
��Auto��$��75����  $ Data.ItemDescription�$ PropertyChanged=�	 . �� $��Entry Data Details��$
��Left=�$��24��$��
10,325,0,0q�$	��Top=�$
��Auto��$��75���� $
 
EntityName��$ EntryDataDetailsId�� . $
��Left=�$��24��$��150,325,0,0q�$	��Top=�$
��Auto��$��75��$��14(�   $ Data.EntryDataDetailsId����� *#!DataContext.Data.EntryDataDetails+$ PropertyChanged=�$ OneWay=�$ 
LayoutRoot�� �� *VData.EntryDataDetails+ �� *!Data.EntryDataDetailsEntityName+$ 	LostFocus=��� $��x Bond_ Item_��$
��Left=�$��24��$��
10,350,0,0q�$	��Top=�$
��Auto��$��75���� $
 
EntityName��$ xBond_Item_Id�� . $
��Left=�$��24��$��150,350,0,0q�$	��Top=�$
��Auto��$��75��$��14(�   $ Data.xBond_Item_Id����� *DataContext.Data.xBond_Item_+$ PropertyChanged=�$ OneWay=�$ 
LayoutRoot�� �� *VData.xBond_Item_+ �� *Data.xBond_Item_EntityName+$ 	LostFocus=��� $��	p CNumber��$
��Left=�$��24��$��
10,375,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��150,375,0,0q�$	��Top=�$
��Auto��$��75����  $ Data.pCNumber�$ PropertyChanged=�	 . �� $��p Registration Date��$
��Left=�$��24��$��
10,400,0,0q�$	��Top=�$
��Auto��  $
��Left=�$��24��$��150,400,0,0q�$	��Top=�$
��Auto��   $ Data.pRegistrationDate�$ PropertyChanged=�	 . �� $��
p Quantity��$
��Left=�$��24��$��
10,425,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��150,425,0,0q�$	��Top=�$	��100��$��75����  $ Data.pQuantity�$ PropertyChanged=�	 . �� $��p Qty Allocated��$
��Left=�$��24��$��
10,450,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��150,450,0,0q�$	��Top=�$	��100��$��75����  $ Data.pQtyAllocated�$ PropertyChanged=�	 . �� $��Pi Quantity��$
��Left=�$��24��$��
10,475,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��150,475,0,0q�$	��Top=�$	��100��$��75����  $ Data.PiQuantity�$ PropertyChanged=�	 . �� $��	x CNumber��$
��Left=�$��24��$��
10,500,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��150,500,0,0q�$	��Top=�$
��Auto��$��75����  $ Data.xCNumber�$ PropertyChanged=�	 . �� $��x Registration Date��$
��Left=�$��24��$��
10,525,0,0q�$	��Top=�$
��Auto��  $
��Left=�$��24��$��150,525,0,0q�$	��Top=�$
��Auto��   $ Data.xRegistrationDate�$ PropertyChanged=�	 . �� $��x Reference Number��$
��Left=�$��24��$��
10,550,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��150,550,0,0q�$	��Top=�$
��Auto��$��75����  $ Data.xReferenceNumber�$ PropertyChanged=�	 . �� $��p Line Number��$
��Left=�$��24��$��
10,575,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��150,575,0,0q�$	��Top=�$	��100��$��75����  $ Data.pLineNumber�$ PropertyChanged=�	 . �� $��
x ASYCUDA_��$
��Left=�$��24��$��
10,600,0,0q�$	��Top=�$
��Auto��$��75���� $
 
EntityName��$ xASYCUDA_Id�� . $
��Left=�$��24��$��150,600,0,0q�$	��Top=�$
��Auto��$��75��$��14(�   $ Data.xASYCUDA_Id����� *DataContext.Data.xASYCUDA_+$ PropertyChanged=�$ OneWay=�$ 
LayoutRoot�� �� *VData.xASYCUDA_+ �� *Data.xASYCUDA_EntityName+$ 	LostFocus=��� $��
p ASYCUDA_��$
��Left=�$��24��$��
10,625,0,0q�$	��Top=�$
��Auto��$��75���� $
 
EntityName��$ pASYCUDA_Id�� . $
��Left=�$��24��$��150,625,0,0q�$	��Top=�$
��Auto��$��75��$��14(�   $ Data.pASYCUDA_Id����� *DataContext.Data.pASYCUDA_+$ PropertyChanged=�$ OneWay=�$ 
LayoutRoot�� �� *VData.pASYCUDA_+ �� *Data.pASYCUDA_EntityName+$ 	LostFocus=��� $
��Cost��$
��Left=�$��24��$��
10,650,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��150,650,0,0q�$	��Top=�$	��100��$��75����  $ 	Data.Cost�$ PropertyChanged=�	 . �� $��Total_ CIF_itm��$
��Left=�$��24��$��
10,675,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��150,675,0,0q�$	��Top=�$	��100��$��75����  $ Data.Total_CIF_itm�$ PropertyChanged=�	 . �� $��Duty Liability��$
��Left=�$��24��$��
10,700,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��150,700,0,0q�$	��Top=�$	��100��$��75����  $ Data.DutyLiability�$ PropertyChanged=�	 . �� $��
Tax Amount��$
��Left=�$��24��$��
10,725,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��150,725,0,0q�$	��Top=�$	��100��$��75����  $ Data.TaxAmount�$ PropertyChanged=�	 . �� $��p Is Assessed��$
��Left=�$��24��$��
10,750,0,0q�$	��Top=�$
��Auto��$��75���� $�� ��$
��Left=�$��24��$��150,750,0,0q�$	��Top=�$	��100��   $ Data.pIsAssessed�$ PropertyChanged=��� $��Do Not Allocate Sales��$
��Left=�$��24��$��
10,775,0,0q�$	��Top=�$
��Auto��$��75���� $�� ��$
��Left=�$��24��$��150,775,0,0q�$	��Top=�$	��100��   $ Data.DoNotAllocateSales�$ PropertyChanged=��� $$��Do Not Allocate Previous Entry��$
��Left=�$��24��$��
10,800,0,0q�$	��Top=�$
��Auto��$��75���� $�� ��$
��Left=�$��24��$��150,800,0,0q�$	��Top=�$	��100��   $% Data.DoNotAllocatePreviousEntry�$ PropertyChanged=��� $��SANumber��$
��Left=�$��24��$��
10,825,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��150,825,0,0q�$	��Top=�$	��100��$��75����  $ Data.SANumber�$ PropertyChanged=�	 . .��� -    �Name$ 
LayoutRoot�� � DataContext ��  �� Source# [  .+��� $"��Asycuda Sales Allocations Ex��$
��Left=�$��37.806��$��17,14.227,0,0q�$
��Wrap=�$	��Top=�$
��Auto��$��18(��� -    ��Name$" AsycudaSalesAllocationsExGrd��$ EntityId�� %� IsVirtualizing .  %� VirtualizationMode$ 	Recycling=�! �� IsDeferredScrollingEnabled . C	  =Core.Common.UI.DataVirtualization.VirtualListLoadingIndicator 	  
IsAttached . $
��Left=�$	��450��$��	10,74,0,0q�$	��Top=�$	��521��#���    AlphaListBoxStyle#���  ���� *AsycudaSalesAllocationsExs+ �� *$"CurrentAsycudaSalesAllocationsExID+ �� *#!VCurrentAsycudaSalesAllocationsEx+�� -    ��Name$ NewBtn1��$��Right=�$��25��$��0,44,64.8,0q�$
��Wrap=�$	��Top=�$��28�� �� TextAlignment$ Center=�  TextButtonStyle#���  $��20(�$	����$��Segoe UI Symbol)�   $ MouseLeftButtonDown��.
  (System.Windows.Interactivity.TriggerBase 
  Actions. >  8Microsoft.Expression.Interactivity.Core.CallMethodAction      
MethodName$"  NewAsycudaSalesAllocationsEx��!   TargetObject! �� # [  �� -   $ DelBtn��$��25��$��0,44,31.8,0q�$
��Wrap=�$	��Top=�$��28��$ Center=�  CloseButtonStyle#���  $��20(�$	����$��Segoe UI Symbol)�$��1��$��Right=�   $ MouseLeftButtonDown��.   $%  DeleteAsycudaSalesAllocationsEx��! �� # [  