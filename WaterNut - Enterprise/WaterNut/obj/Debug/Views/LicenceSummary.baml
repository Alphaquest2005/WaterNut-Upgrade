   M S B A M L   `   `   `  ����C  ?WaterNut, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulli9clr-namespace:WaterNut.QuerySpace.CoreEntities.ViewModels+WaterNut.QuerySpace.CoreEntities.ViewModels  5      #clr-namespace:WaterNutWaterNut  5      i9clr-namespace:WaterNut.QuerySpace.CoreEntities.ViewModels+WaterNut.QuerySpace.CoreEntities.ViewModels  5	      #    WaterNut.Views.LicenceSummary   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/Expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      HQS9clr-namespace:WaterNut.QuerySpace.CoreEntities.ViewModels     5      (localclr-namespace:WaterNut     5      Iqsv9clr-namespace:WaterNut.QuerySpace.CoreEntities.ViewModels     5	        � 	Resources  5      �� 5   
    �� Member$% QS:LicenceSummaryModel.Instance��6      Key!LicenceSummaryModelDataSource  6<   .��5      � -   5         �Name$ 
LayoutRoot��5       � DataContext 6   ��  ! LicenceSummaryModelDataSource �� Source# [ .+�5   
   �� $
��Left=�6   $��33��6/   $��9,14,0,0q�6;   $
��Wrap=�6M   $	��Top=�6a   $	��315��6y   $��21.333(�6�   $"��Document Set Licence Summary��6�   &   System.Windows.Controls.DataGrid  5   
   $
��Left=�6   $	��344��6.   $��0,81,0,0q�6;   $	��Top=�6M   $	��640��6e      AutoGenerateColumns .     GridLinesVisibility$
 None=�6�      	RowHeight$ 30Q�6�      AlternatingRowBackground �	#FFE8F3F9$��16(�6  ���	#FF35448F���	#7FF0F0F0��6�   �� *LicenceSummaryData+	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 
TariffCode��6D      Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 6X   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *
TariffCode+6X     5      $
 Tariff Description��6E   $	 250 6a    6%   �� *Description+6a     5      $
 Quantity��6B   $	 100 6U    6%   �� *
Quantity+6U     5      $
 Total��6O   $	 150 6_    6%   �� *Total+ �� StringFormat$ c��6_   5      �� 5   
   $
��Left=�6M   $��24��6h   $��429,436,0,0q�6t   $
��Wrap=�6�   $	��Top=�6�   $	��201��6�   $��20(�6�    �� TextAlignment$ Right=�6�   ���	#FFE4E453��6   �� *SelectedTotal+$ Total {0:c}��6�   �� 5   
   -   5          TextButtonStyle#���  5      $
��Left=�6?   $��24��6Z   $��
507,19,0,0q�6f   $
��Wrap=�6z   $��Send to Excel ��6�   $	��Top=�6�   $	��121��6�   $��16(�6�   $��Segoe UI Symbol)�6�   y�6  �� ?   9WaterNut.QuerySpace.CoreEntities.ViewModels.BaseViewModel   Instance# Z  �� Path$3 -CurrentApplicationSettings.AllowExportToExcel��� 5   
   -   5        #���  5      $��Right=�6?   $��24��6[   $��	0,52,12,0q�6g   $
��Wrap=�6z   $��Refresh��6�   $	��Top=�6�   $	��121��6�   $��16(�6�   $��Segoe UI Symbol)�6�   $ Right=�6�  y�6  �� */-CurrentApplicationSettings.AllowExportToExcel+# Z 6�  5      5       