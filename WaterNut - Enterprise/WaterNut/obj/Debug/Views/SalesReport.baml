   M S B A M L   `   `   `  ����C  ?WaterNut, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulli9clr-namespace:WaterNut.QuerySpace.AllocationQS.ViewModels+WaterNut.QuerySpace.AllocationQS.ViewModels  5      #clr-namespace:WaterNutWaterNut  5           WaterNut.Views.SalesReport   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      HQS9clr-namespace:WaterNut.QuerySpace.AllocationQS.ViewModels     5      @d2http://schemas.microsoft.com/Expression/blend/2008     5      (localclr-namespace:WaterNut     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        � 	Resources  5      �� 5   
      KeySalesReportModelDataSource   �� Member$" QS:SalesReportModel.Instance��66   .��5      � -   5         �Name$ 
LayoutRoot��5       � DataContext 6   ��   SalesReportModelDataSource �� Source# [ .+�5   
   �� -   5         ��Name$ 	ReportBRD��5      $
��1056��5      $��0,45,0,-42.842q�5      ._�5      �� -   5         ��Name$ 	ReportGrd��5      $��0,0,0,10q�6.   .��5      � -   5        $ DailyReportGD��5      $
��1056��5      $
��Auto��5      $	��495��5      $��Center=�5      $	��Top=�5      
������� 5      �� .+�5      � $
��Auto��6   $��38��5      $��	40,97,0,0q�5      $��Stretch=�5      $	��Top=�5       ���	#FFD7D7D7.+�5"      �� $	��346��6$   $��36��5#   $   $��
388,2,42,0q�5$   $   $��Right=�5%   $   $	��Top=�5&   $   $��21.333(�5'   $   ���	#FF353623 �� TextAlignment$ Right=�5+   $   ��5)   $   �� *PayrollJobTotal+ �� StringFormat$ Gross Job Amount {0:c}��5+   $   5,      �� 5-      $	��314��6    $
��31.8��5.       $��460,65.2,42,0q�5/       $��Right=�50       $	��Top=�51       
�������$��25(�53       
���   �$��Customs Sales Report��55       $ Right=�56       $
��Wrap=�57       �� 58      $	��228��6    $��546,13,42,0q�59       $��right=�5:       $	��Top=�5;       $��14.667(�5<       
���   �$ Right=�5?       ��5>       �� *Date+5?       �� 5@      $
��Auto��6!   $��40,140,20,10q�5A   !   	 �� Orientation$	 Vertical=�5B   !   .+�5C      �� $	��237��6$   $��24��5D   $   $��	0,15,0,15q�5E   $   $
��Left=�5F   $   $	��Top=�5G   $   $��20(�5H   $   ���	#FF393939$
 Left=�5K   $   $
��Wrap=�5L   $   ��5J   $   �� *(&CurrentAsycudaDocument.ReferenceNumber+5L   $   &   System.Windows.Controls.DataGrid  5M      -   5        
  Name$
 GridData��5M   #   $��0q�5N   #   $��Stretch=�5O   #   $	��Top=�5P   #      AlternatingRowBackground �	#FFE6F0F4   AutoGenerateColumns .     ColumnHeaderHeight$ 60Q�5S   #     WrappedColumnHeaderStyle   ColumnHeaderStyle# �  5T   #      GridLinesVisibility$
 None=�5U   #      RowBackground
 �����   	RowHeight$ 25Q�5Y   #   ��5V   #   �� *SalesReportData+   Columns 5Z      0  *System.Windows.Controls.DataGridTextColumn  5[   "   ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 60 65      Header$ Line Number��5]   5   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5\   5   �� *Line+5]   5     5^   "   $ 75 65   $
 Date��5a   5    5_   5   �� *Date+$ d��5a   5     5b   "   $ 60 65   $ Invoice#��5d   5    5c   5   �� *	InvoiceNo+5d   5     5e   "   $	 100 65   $ Customer Name��5g   5    5f   5   �� *CustomerName+5g   5     5h   "   $	 100 65   $ Item Number��5j   5    5i   5   �� *
ItemNumber+5j   5     5k   "   $	 200 65   $ Item Description��5m   5    5l   5   �� *ItemDescription+5m   5     5n   "   $ 75 65   $ 
TariffCode��5p   5    5o   5   �� *
TariffCode+5p   5     5q   "   $ 60 65   $ SalesQuantity��5s   5    5r   5   �� *SalesQuantity+5s   5     5t   "   $ 60 65   $ SalesFactor��5v   5    5u   5   �� *SalesFactor+5v   5     5w   "   $ 60 65   $ 	xQuantity��5y   5    5x   5   �� *	xQuantity+5y   5     5z   "   $ 50 65   $ Price��5}   5    5{   5   �� *Price+$ c��5}   5     5~   "   $ 50 65   $ 
Sales Type��5�   5    5   5   �� *	SalesType+5�   5     5�   "   $ 50 65   $ Gross Sales��5�   5    5�   5   �� *
GrossSales+$ c��5�   5     5�   "   $ 70 65   $ Previous CNumber��5�   5    5�   5   �� *PreviousCNumber+5�   5     5�   "   $ 60 65   $ Previous Line Number��5�   5    5�   5   �� *PreviousLineNumber+5�   5     5�   "   $ 60 65   $ Previous Reg Date��5�   5    5�   5   �� *PreviousRegDate+$ d��5�   5   5�      5�      �� 5�      $��243.2��6    $
��29.6��5�       $��37.3,13.4,0,0q�5�       $
��Left=�5�       $	��Top=�5�       $��24(�5�       $
��Wrap=�5�       ��5�       �� *Institution1.Name+5�       �� 5�      $��243.2��6    $��20��5�       $��37.3,48,0,0q�5�       $
��Left=�5�       $	��Top=�5�       $��16(�5�       $
��Wrap=�5�       ��5�       �� *AccountName+5�       �� 5�      $	��321��6    $��24��5�       $��	40,73,0,0q�5�       $
��Left=�5�       $	��Top=�5�       $��16(�5�       $
��Bold"�5�       $
��Wrap=�5�       ��5�       �� *CurrentPayrollJob.Name+5�       5�      5�      5�      �� 5�   
   -   5        $	��167��5�      $��30��5�      $��
879,10,0,0q�5�      $
��Left=�5�      $	��Top=�5�      $��Segoe UI Symbol)�5�      $��20(�5�        TextButtonStyle#���  5�      $��Send to Excel ��5�      $
��Wrap=�5�      �� 5�   
   -   5        $	��243��5�      $��30��5�      $��
577,10,0,0q�5�      $
��Left=�5�      $	��Top=�5�      $��Segoe UI Symbol)�5�      $��20(�5�      #���  5�      $ ��Export All in Document Set��5�      $
��Wrap=�5�      5�      5�      