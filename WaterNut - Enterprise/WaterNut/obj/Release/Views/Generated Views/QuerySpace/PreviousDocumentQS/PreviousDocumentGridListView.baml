   M S B A M L   `   `   `  ���� C  ?WaterNut, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WaterNutWaterNut  I ECore.Common.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullmGclr-namespace:Core.Common.UI.DataVirtualization;assembly=Core.Common.UI!Core.Common.UI.DataVirtualization G4clr-namespace:Core.Common.UI;assembly=Core.Common.UICore.Common.UI ]?clr-namespace:Core.Common.UI.Validation;assembly=Core.Common.UICore.Common.UI.Validation u?clr-namespace:WaterNut.QuerySpace.PreviousDocumentQS.ViewModels1WaterNut.QuerySpace.PreviousDocumentQS.ViewModels  S OWaterNut.Client.Entities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullyRclr-namespace:PreviousDocumentQS.Client.Entities;assembly=WaterNut.Client.Entities"PreviousDocumentQS.Client.Entities O    IWaterNut.QuerySpace.PreviousDocumentQS.Views.PreviousDocumentList_AutoGen   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  h dMicrosoft.Expression.Interactions, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bei9http://schemas.microsoft.com/expression/2010/interactions  "localclr-namespace:WaterNut  UvirtualGclr-namespace:Core.Common.UI.DataVirtualization;assembly=Core.Common.UI  Acoreui4clr-namespace:Core.Common.UI;assembly=Core.Common.UI  Ival?clr-namespace:Core.Common.UI.Validation;assembly=Core.Common.UI  Lmodels?clr-namespace:WaterNut.QuerySpace.PreviousDocumentQS.ViewModels  aentitiesRclr-namespace:PreviousDocumentQS.Client.Entities;assembly=WaterNut.Client.Entities  $��540.609��$
��Auto��  � 	Resources  Y   SWaterNut.QuerySpace.PreviousDocumentQS.ViewModels.PreviousDocumentViewModel_AutoGen '  #PreviousDocumentViewModelDataSource �� 
TargetType;  5Core.Common.UI.DataVirtualization.VirtualListItemBase �� Property �� Value  PreviousDocumentTpl �� DataType9  3PreviousDocumentQS.Client.Entities.PreviousDocument.  (System.Windows.Interactivity.Interaction   Triggers/  )System.Windows.Interactivity.EventTrigger   	EventName1  +Core.Common.UI.Validation.ValidationBinding4  .Core.Common.UI.Validation.BindingDecoratorBase   Path   UpdateSourceTrigger	   ValidatesOnDataErrors(  "System.Windows.Controls.DatePicker
   SelectedDate d� 	IsChecked �� DisplayMemberPath �� SelectedValuePath �� 
IsEditable �� SelectedValue �� UpdateSourceTrigger �� Mode �� ElementName �� SelectedItem �� Text��%3  &	        '��      &	 /       �� " ��.���  �@ AutoLoad . �� "  .R�� -   $
��Auto��$	��497��   $ 
MouseLeave��.+��� $��id��$
��Left=�$��24��$��	10,25,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��
150,25,0,0q�$	��Top=�$
��Auto��$��75����  $ Data.id�$ PropertyChanged=�	 . �� $��CNumber��$
��Left=�$��24��$��	10,50,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��
150,50,0,0q�$	��Top=�$
��Auto��$��75����  $ Data.CNumber�$ PropertyChanged=�	 . �� $��Registration Date��$
��Left=�$��24��$��	10,75,0,0q�$	��Top=�$
��Auto��  $
��Left=�$��24��$��
150,75,0,0q�$	��Top=�$
��Auto��
   $ Data.RegistrationDate�$ PropertyChanged=�	 . �� $��Is Manually Assessed��$
��Left=�$��24��$��
10,100,0,0q�$	��Top=�$
��Auto��$��75���� $�� ��$
��Left=�$��24��$��150,100,0,0q�$	��Top=�$	��100��   $ Data.IsManuallyAssessed�$ PropertyChanged=��� $��Reference Number��$
��Left=�$��24��$��
10,125,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��150,125,0,0q�$	��Top=�$
��Auto��$��75����  $ Data.ReferenceNumber�$ PropertyChanged=�	 . �� $!��Effective Registration Date��$
��Left=�$��24��$��
10,150,0,0q�$	��Top=�$
��Auto��  $
��Left=�$��24��$��150,150,0,0q�$	��Top=�$
��Auto��
   $$ Data.EffectiveRegistrationDate�$ PropertyChanged=�	 . �� $��Total Value��$
��Left=�$��24��$��
10,175,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��150,175,0,0q�$	��Top=�$	��100��$��75����  $ Data.TotalValue�$ PropertyChanged=�	 . �� $��Allocated Value��$
��Left=�$��24��$��
10,200,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��150,200,0,0q�$	��Top=�$	��100��$��75����  $ Data.AllocatedValue�$ PropertyChanged=�	 . �� $��Pi Value��$
��Left=�$��24��$��
10,225,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��150,225,0,0q�$	��Top=�$	��100��$��75����  $ Data.PiValue�$ PropertyChanged=�	 . �� $��Asycuda Document Set��$
��Left=�$��24��$��
10,250,0,0q�$	��Top=�$
��Auto��$��75���� $ 
EntityName��$ AsycudaDocumentSetId�� . $
��Left=�$��24��$��150,250,0,0q�$	��Top=�$
��Auto��$��75��$��14(�   $ Data.AsycudaDocumentSetId����� *%#DataContext.Data.AsycudaDocumentSet+$ PropertyChanged=�$ OneWay=�$ 
LayoutRoot�� �� *VData.AsycudaDocumentSet+ �� *#!Data.AsycudaDocumentSetEntityName+$ 	LostFocus=��� $��Do Not Allocate��$
��Left=�$��24��$��
10,275,0,0q�$	��Top=�$
��Auto��$��75���� $�� ��$
��Left=�$��24��$��150,275,0,0q�$	��Top=�$	��100��   $ Data.DoNotAllocate�$ PropertyChanged=��� $��Description��$
��Left=�$��24��$��
10,300,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��150,300,0,0q�$	��Top=�$
��Auto��$��75����  $ Data.Description�$ PropertyChanged=�	 . �� $��BLNumber��$
��Left=�$��24��$��
10,325,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��150,325,0,0q�$	��Top=�$
��Auto��$��75����  $ Data.BLNumber�$ PropertyChanged=�	 . �� $��Lines��$
��Left=�$��24��$��
10,350,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��150,350,0,0q�$	��Top=�$	��100��$��75����  $ 
Data.Lines�$ PropertyChanged=�	 . �� $��Document Type��$
��Left=�$��24��$��
10,375,0,0q�$	��Top=�$
��Auto���� $
��Left=�$��24��$��150,375,0,0q�$	��Top=�$
��Auto��$��75����  $ Data.DocumentType�$ PropertyChanged=�	 . .��� -    �Name$ 
LayoutRoot�� � DataContext ��  �� Source# [  .+��� $��Previous Document��$
��Left=�$��37.806��$��17,14.227,0,0q�$
��Wrap=�$	��Top=�$
��Auto��$��18(��� -    ��Name$ PreviousDocumentGrd��$ EntityId�� %� IsVirtualizing .  %� VirtualizationMode$ 	Recycling=�! �� IsDeferredScrollingEnabled . C	  =Core.Common.UI.DataVirtualization.VirtualListLoadingIndicator 	  
IsAttached . $
��Left=�$	��450��$��	10,74,0,0q�$	��Top=�$	��521��#���    AlphaListBoxStyle#���  ���� *PreviousDocuments+ �� *CurrentPreviousDocumentID+ �� *VCurrentPreviousDocument+�� -    ��Name$ NewBtn1��$��Right=�$��25��$��0,44,64.8,0q�$
��Wrap=�$	��Top=�$��28�� �� TextAlignment$ Center=�  TextButtonStyle#���  $��20(�$	����$��Segoe UI Symbol)�   $ MouseLeftButtonDown��.
  (System.Windows.Interactivity.TriggerBase 
  Actions. >  8Microsoft.Expression.Interactivity.Core.CallMethodAction      
MethodName$  NewPreviousDocument��!   TargetObject! �� # [  �� -   $ DelBtn��$��25��$��0,44,31.8,0q�$
��Wrap=�$	��Top=�$��28��$ Center=�  CloseButtonStyle#���  $��20(�$	����$��Segoe UI Symbol)�$��1��$��Right=�   $ MouseLeftButtonDown��.   $  DeletePreviousDocument��! �� # [  