   M S B A M L   `   `   `  ����C  ?WaterNut, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulli9clr-namespace:WaterNut.QuerySpace.CoreEntities.ViewModels+WaterNut.QuerySpace.CoreEntities.ViewModels  5      S OWaterNut.Client.Entities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullmLclr-namespace:CoreEntities.Client.Entities;assembly=WaterNut.Client.EntitiesCoreEntities.Client.Entities 5      #clr-namespace:WaterNutWaterNut  5      I ECore.Common.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullmGclr-namespace:Core.Common.UI.DataVirtualization;assembly=Core.Common.UI!Core.Common.UI.DataVirtualization 5	      %    WaterNut.Views.AsycudaDocuments   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      HQS9clr-namespace:WaterNut.QuerySpace.CoreEntities.ViewModels     5      gQSCoreEntitiesLclr-namespace:CoreEntities.Client.Entities;assembly=WaterNut.Client.Entities     5      @d2http://schemas.microsoft.com/Expression/blend/2008     5      (localclr-namespace:WaterNut     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      [virtualGclr-namespace:Core.Common.UI.DataVirtualization;assembly=Core.Common.UI     5	      $	��775��5
        � 	Resources  5      �� 5   
      Key#AsycudaDocumentsModelDataSource   �� Member$' !QS:AsycudaDocumentsModel.Instance��6;   �� 5   
    �� 
TargetType" ��6   .�5      �� ;  5Core.Common.UI.DataVirtualization.VirtualListItemBase �� Property �@ AutoLoad �� Value . 6E   5      �� 5   
    BooleanToVisibilityConverter  6'   �� 5   
   xcuda_ASYCUDATemplate   �� DataType2  ,CoreEntities.Client.Entities.AsycudaDocument"  65   .R�5      � $	��635��6   $��80��5      .+�5      �� $��81��6   $��33��5      $��	44,21,0,0q�5      $
��Left=�5      $	��Top=�5      $��21.333(�5       $
��Wrap=�5#      ��5!      �� *Data.CNumber+ �� Mode$ OneWay=�5#      �� 5$      $	��164��6   $��30��5%      $��	144,1,0,0q�5&      $
��Left=�5'      $	��Top=�5(      $��16(�5)      $
��Wrap=�5+      ��5*      �� *Data.ReferenceNumber+5+      �� 5,      $��57��6   $��23��5-      $��
494,-1,0,0q�5.      $
��Left=�5/      $	��Top=�50      $��18.667(�51      $
��Wrap=�54      ��52      �� *
Data.Lines+ �� StringFormat$ 0 lines��54      �� 55      $��87��6   $��28��56      $��	313,1,0,0q�57      $
��Left=�58      $	��Top=�59      $��16(�5:      $
��Wrap=�5=      ��5;      �� *Data.RegistrationDate+$ d��5=      �� 5>      $
��44.8��6   $��21.883��5?      $��10,0.24,0,0q�5@      $
��Left=�5A      $	��Top=�5B      $��18.667(�5C      $
��Bold"�5D      ��5E      �� *Data.DocumentType+�� 5F      $
��Auto��6   $��21��5G      $��	96,26,0,0q�5H      $
��Left=�5I      $	��Top=�5J      $��13.333(�5K      $
��Wrap=�5M      ��5L      �� *Data.Description+5M      �� 5O      $��75��6   $��33��5P      $��0,21,0,0q�5Q      $��Right=�5R      $	��Top=�5S      $��16(�5T      $
��Wrap=�5W      ��5U      �� *31xcuda_ASYCUDA_ExtendedProperties.TotalGrossWeight+$ 0.00 kg.��5W      �� 5Y      -   5        $	��125��5Y      $��21��5Z      $��
478,52,0,0q�5[      $
��Left=�5\      $	��Top=�5]      $��Do Not Allocate��5_       d� 	IsChecked 5`      �� *Data.DoNotAllocate+y�5b      �� ?   9WaterNut.QuerySpace.CoreEntities.ViewModels.BaseViewModel	   Instance
 �� Source#
 Z	  �� Path$8 2CurrentApplicationSettings.AllowEntryDoNotAllocate�(  "System.Windows.Controls.DatePicker  5d      -   5        $	��133��5d      $��23��5e      $��
317,50,0,0q�5f      $
��Left=�5g      $	��Top=�5h      ���	#7FFFFFFF$��14(�5j         SelectedDate 5l      �� * Data.EffectiveRegistrationDate+$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�y�5p      �� #
 Z	 $= 7CurrentApplicationSettings.AllowEffectiveAssessmentDate�$ PropertyChanged=��� 5s      $	��148��6   $��20��5t      $��
164,52,0,0q�5u      $
��Left=�5v      $	��Top=�5w      $��12(�5x      $��Effective Assessment Date��5y      $
��Wrap=�5z      y�5{      �� #
 Z	 $= 7CurrentApplicationSettings.AllowEffectiveAssessmentDate�$ PropertyChanged=��� 5      $��82��6   $��21��5�      $��	407,1,0,0q�5�      $
��Left=�5�      $	��Top=�5�      $��16(�5�      $
��Wrap=�5�      ��5�      �� *$"Data.Customs_clearance_office_code+5�      �� 5�      $��	CancelImg��6   $��0,17,596,26q�5�      $$��/WaterNut;component/Cancel.png��5�      y�5�      �� *Data.Cancelled+$ OneWay=�   BooleanToVisibilityConverter �� 	Converter# [ 5�       �� Triggers 5�      �� 5�       �� Value$ False��6A    �� Binding 6   �� *ImportComplete+.a�5�      ��  �� 
TargetName$ 	CancelImg��6     CancelImage# [ 6F    � ��5�      5�      .��5�      � -   5         �Name$ 
LayoutRoot��5�       � DataContext 6   ��  # AsycudaDocumentsModelDataSource#
 [ .+�5�   
   �� $	��198��6   $��33��5�      $��9,14,0,0q�5�      $
��Left=�5�      $	��Top=�5�      $��21.333(�5�      $��Asycuda Documents��5�      $
��Wrap=�5�      �� 5�   
   -   5         ��Name$ ItemLst��5�      $
��Auto��5�      $	��325��5�      $��0,155,-0.333,0q�5�      $��Stretch=�5�      $	��Top=�5�        xcuda_ASYCUDATemplate#���  5�       �� SelectionMode$ Multiple=�5�        AlphaListBoxStyle#���  5�      ��5�      �� *AsycudaDocuments+ �� SelectedItem 5�      �� #
 Z	 $ VCurrentAsycudaDocument�5�      �� 5�   
   $��116.164��6   $��22.535��5�      $��10,62.465,0,0q�5�      $
��Left=�5�      $	��Top=�5�      $��16(�5�      $��C Number��5�       �� TextAlignment$ Center=�5�      $
��Wrap=�5�      �� 5�   
   $	��199��6   $��23��5�      $��
131,62,0,0q�5�      $
��Left=�5�      $	��Top=�5�      $��16(�5�      $��Reference Number��5�      $ Center=�5�      $
��Wrap=�5�      �� 5�   
   $��58��6   $��23��5�      $��
342,85,0,0q�5�      $
��Left=�5�      $	��Top=�5�      $��12(�5�      $��
Start Date��5�      $ Center=�5�      $
��Wrap=�5�      �� 5�   
   -   5        $��116.164��5�      $��22.535��5�      $��	10,85,0,0q�5�      $
��Left=�5�      $	��Top=�5�      ���	#7FFFFFFF$��16(�5�        TransparentTextBoxStyle#���  5�       �� TextAlignment$ Center=�5�       �� TextWrapping$
 Wrap=�5�      ��5�      �� *CNumberFilter+$ TwoWay=�$ Explicit=�5�      �� 5�   
   -   5        $	��199��5�      $��23��5�      $��
131,85,0,0q�5�      $
��Left=�5�      $	��Top=�5�      ���	#4CFFFFFF$��16(�5�      #���  5�      $ Center=�5�      $
 Wrap=�5�      ��5�      �� *ReferenceNumberFilter+$ TwoWay=�$ Explicit=�5�      �� 5�   
   -   5        $��75��5�      $��26��5�      $��687,118,0,0q�5�      $
��Left=�5�      $	��Top=�5�      $��16(�5�        TextButtonStyle#���  5�      $��View All��5�      $ Right=�5�      $
��Wrap=�5�        5�   
   $	��112��6   $��23��5�      $��
405,85,0,0q�5�      $
��Left=�5�      $	��Top=�5�      ���	#7FFFFFFF$��16(�5�       5�      �� *StartRegistrationDateFilter+$ TwoWay=�$ PropertyChanged=� �� IsAsync . �� 5�   
   $	��201��6   $��24��5�      $��
221,21,0,0q�5�      $
��Left=�5�      $	��Top=�5�      $��20(�5�      ���	#FFE4E453$ Right=�5     $
��Wrap=�5     ��5     �� *AsycudaDocuments.Count+$ 0 Filtered Results��5     �� 5  
   -   5        $	��121��5     $��24��5     $��
643,14,0,0q�5     $
��Left=�5     $	��Top=�5	     $��Segoe UI Symbol)�5
     $��16(�5     #���  5     $��Send to Excel ��5     $
��Wrap=�5     y�5     �� #
 Z	 $3 -CurrentApplicationSettings.AllowExportToExcel��� 5  
   -	   5         ��Name$ 	ExportBtn��5     $	��132��5     $��26��5     $��
634,40,0,0q�5     $
��Left=�5     $	��Top=�5     $��16(�5     #���  5     $��Export to XML file��5     $ Right=�5     $
��Wrap=�5     �� 5  
   -
   5        $ 	ImportBtn��5     $��75��5     $��26��5      $��
687,66,0,0q�5!     $
��Left=�5"     $	��Top=�5#     $��16(�5$     #���  5&     $ Right=�5'     $
��Wrap=�5(     �� 6)   $�Import��6-   �� 5)     �� 6   6#   �� 5*  
   -   5         ��Name$ MultiSelectChk_Copy��5*     $��56��5+     $��18��5,     $��	9,114,0,0q�5-     $
��Left=�5.     $	��Top=�5/     $	��IM7��50      51     �� *	ViewIm7+$ PropertyChanged=��� 53  
   -   5        $ MultiSelectChk_Copy1��53     $��51��54     $��18��55     $��
78,115,0,0q�56     $
��Left=�57     $	��Top=�58     $	��Ex9��59      5:     �� *	ViewEx9+$ PropertyChanged=��� 5<  
   -   5        $ MultiSelectChk_Copy2��5<     $��51��5=     $��18��5>     $��
78,133,0,0q�5?     $
��Left=�5@     $	��Top=�5A     $	��IM4��5B      5C     �� *	ViewIm4+$ PropertyChanged=��� 5E  
   -   5        $ MultiSelectChk_Copy4��5E     $��51��5F     $��18��5G     $��	9,132,0,0q�5H     $
��Left=�5I     $	��Top=�5J     $	��IM9��5K      5L     �� *	ViewIm9+$ PropertyChanged=�y�5N     �� #
 Z	 $/ )CurrentApplicationSettings.AllowCleanBond��� 5P  
   $��53��6   $��25��5Q     $��
527,85,0,0q�5R     $
��Left=�5S     $	��Top=�5T     $��12(�5U     $��End Date��5V     $ Center=�5W     $
��Wrap=�5X       5Y  
   $	��112��6   $��23��5Z     $��
585,85,0,0q�5[     $
��Left=�5\     $	��Top=�5]     ���	#7FFFFFFF$��16(�5_      5`     �� *EndRegistrationDateFilter+$ TwoWay=�$ PropertyChanged=��� 5c  
   -   5        $ MultiSelectChk_Copy3��5c     $	��125��5d     $��21��5e     $��205,120,0,0q�5f     $
��Left=�5g     $	��Top=�5h     $��Center=�5i     $��Import Complete��5j      5k     �� *ImportCompleteFilter+$ PropertyChanged=��� 5m  
   -   5        $ DeselectTxt��5m     $��92��5n     $��22��5o     $��454,119,0,0q�5p     $
��Left=�5q     $	��Top=�5r     $��16(�5s     #���  5u     $��De-Select All��5v     $
 Left=�5w     $
��Wrap=�5x     �� 5y  
   -   5        $ 	SelectTxt��5y     $��83��5z     $��22��5{     $��579,119,0,0q�5|     $
��Left=�5}     $	��Top=�5~     $��16(�5     #���  5�     $��
Select All��5�     $
 Left=�5�     $
��Wrap=�5�     �� 5�  
   -   5        $ MultiSelectChk��5�     $	��107��5�     $��26��5�     $��342,120,0,0q�5�     $
��Left=�5�     $	��Top=�5�     $��MultiSelect��5�     $ FalseY�5�     5�     5�     