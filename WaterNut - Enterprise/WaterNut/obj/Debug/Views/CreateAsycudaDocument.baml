   M S B A M L   `   `   `  ����C  ?WaterNut, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulli9clr-namespace:WaterNut.QuerySpace.CoreEntities.ViewModels+WaterNut.QuerySpace.CoreEntities.ViewModels  5      #clr-namespace:WaterNutWaterNut  5      *    $WaterNut.Views.CreateAsycudaDocument   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/Expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      HQS9clr-namespace:WaterNut.QuerySpace.CoreEntities.ViewModels     5      (localclr-namespace:WaterNut     5      $��857.705��5	   1   $��499.924��6A     � 	Resources  5
      �� 5   
    �� Member$, &QS:CreateAsycudaDocumentModel.Instance��6      Key($CreateAsycudaDocumentModelDataSource  6C   .��5      � -   5         �Name$ 
LayoutRoot��5       � DataContext 6   ��  ( $CreateAsycudaDocumentModelDataSource �� Source# [ .+�5   
   �� $
��Left=�6   $��32.766��6/   $��8.838,14.011,0,0q�6?   $
��Wrap=�6Y   $	��Top=�6m   $��396.779��6�   $��21.333(�6�   $)��#Create/Edit Asycuda Documents & Set��6�   � 5   
   $��0,80,-0.4,-0.4q�6   ���	#33FFFFFF  EditGridData#���  6>    6e   �� .+�5      ��  �� DisplayMemberPath$ DisplayName��6�    �� SelectedValuePath$ Document_TypeId��6�   $
��Left=�6�   $��29��6�   $��178,5.861,0,0q�6�   $	��Top=�6  $��64��6.  $��18.667(�6:   �� SelectedValue 6   �� *DocumentTypeId+��6@   �� *DocumentTypes+ �� SelectedItem 6f   �� *VCurrentDocumentType+6:  �� 5      $ DisplayName��6B   $ Customs_ProcedureId��6b   $
��Left=�6�   $��29��6�   $��178,48.861,0,0q�6�   $	��Top=�6�   $	��125��6  ��6   �� *CustomsProcedures+ 6�   �� *VCurrentCustomsProcedure+ 6  �� *CustomsProcedureId+�� 5      $
��Left=�6   $��29.382��63   $��1.162,5.924,0,0q�6C   $
��Wrap=�6\   $��Document Type��6p   $	��Top=�6�   $��141.2��6�   $��16(�6�   	 �� TextAlignment$	 Right=�6�   �� 5      $
��Left=�6   $��46.182��63   $��1.162,40.306,0,0q�6C   $
��Wrap=�6]   $	��Top=�6q   $��141.2��6�   $��16(�6�   $	 Right=�6�   �� 6�   $�Default Customs Procedure��6�   �� 6�   �� 6�   6�   �� 5      $ DisplayName��5      $ Document_TypeId��5      $
��Left=�6;   $��29��6V   $��178,5.861,0,0q�6b   $	��Top=�6y   $��64��6�   $��18.667(�6�    5      �� *Document_TypeId+��5      �� *Document_Types+5   �   �� 5      $ DisplayName��5      $ Customs_ProcedureId��5      $
��Left=�5      $��29��63   $��178,48.861,0,0q�6?   $	��Top=�6W   $	��125��6o   ��5      �� *Customs_Procedures+ 5      �� *Customs_ProcedureId+5   o   �� 5!      $
��Left=�6   $��29.382��63   $��1.162,5.924,0,0q�6C   $
��Wrap=�6\   $��Document Type��6p   $	��Top=�6�   $��141.2��6�   $��16(�6�   $	 Right=�6�   �� 5"      $
��Left=�6   $��46.182��63   $��1.162,40.306,0,0q�6C   $
��Wrap=�6]   $	��Top=�6q   $��141.2��6�   $��16(�6�   $	 Right=�6�   �� 6�   $�Default Customs Procedure��6�   �� 6�   �� 6�   6�   �� 5#      $
��Left=�5$      $��32��5%      $��178,208.861,0,0q�5&      
 �� TextWrapping$

 Wrap=�5'      $	��Top=�5(      $	��279��6.   $��16(�6:    �� 	MaxLength$ 16��6H   ��5#      �� *Declarant_Reference_Number+ �� UpdateSourceTrigger$ PropertyChanged=�5(   H   �� 5*      $
��Left=�6   $��32��63   $��
48,204,0,0q�6?   $
��Wrap=�6S   $	��Top=�6g   $	��120��6   $��16(�6�   $	 Right=�6�   $��Reference Code��6�   �� 5+      $
��Left=�5-      $��59��5.      $��178,255,0,0q�5/      $

 Wrap=�50      $	��Top=�6*   $	��279��6B   $��16(�6N   ��5,      �� *Description+$ PropertyChanged=� �� FallbackValue$  Create New Document or Set�� �� TargetNullValue$ Please Enter Description��50   N   �� 51      $
��Left=�6   $��32��63   $��
48,252,0,0q�6?   $
��Wrap=�6S   $	��Top=�6g   $	��120��6   $��16(�6�   $	 Right=�6�   $��Description��6�   �� 52      -   5         ��Name$ SaveBtn��52      $
��Left=�6)   $��39��6D   $��604,369,0,0q�6P   $
��Wrap=�6e   $	��Top=�6y   $��35��6�   $	 Center=�6�     TextButtonStyle#���  6�   $��26.667(�6�   �� 6"  $��Segoe UI Symbol)�6'   � Language$ en-us�6D  .�6V  �� $	���6Z  6m  6t  �� 53      -   5        $ 	DeleteBtn��53      $
��Left=�6+   $��39��6F   $��803,369,0,0q�6R   $
��Wrap=�6g   $	��Top=�6{   $��35��6�   $	 Center=�6�     CloseButtonStyle#���  6�   $��26.667(�6�   �� 6'  $��Segoe UI Symbol)�6,  $ en-us�6I  .�6[  �� $	���6_  6r  �� 6x  �� 6�  $��Segoe UI Symbol)�6�  $ en-us�6�  .�6�  �� 6�  6�  �� 54      -   5        $ NewBtn��54      $
��Left=�6(   $��39��6C   $��550,371,0,0q�6O   $
��Wrap=�6d   $	��Top=�6x   $��48��6�   $	 Center=�6�   #���  6�   $��26.667(�6�   $	����6�   $��Segoe UI Symbol)�6�   6  �� 55      $
��Left=�6   $��32��61   $��635,141,0,0q�6=   $

 Wrap=�6R   $	��Top=�6�   $��53��6�   $��16(�6�   $ 2��6�   ��6f   �� *Country_of_origin_code+$ PropertyChanged=�6�   �� 56      $
��Left=�6   $��41��63   $��482,140,0,0q�6?   $
��Wrap=�6T   $	��Top=�6h   $	��141��6�   $��16(�6�   $	 Right=�6�   $$��Default Country of Origin Code��6�   �� 57      $
��Left=�6Z   $��32��6u   $��635,190,0,0q�6�   $

 Wrap=�6�   $	��Top=�6�   $��61��6�   $��16(�6�   $ 3��6�   ��6   �� *Currency_Code+$ PropertyChanged=�6�   �� 58      $
��Left=�6   $��29��63   $��483,190,0,0q�6?   $
��Wrap=�6T   $	��Top=�6h   $	��141��6�   $��16(�6�   $	 Right=�6�   $��Currency Code��6�   �� 59      $
��Left=�6k   $��32��6�   $��635,236,0,0q�6�   $

 Wrap=�6�   $	��Top=�6�   $��98��6�   $��16(�6�   ��6   �� *Exchange_Rate+$ PropertyChanged=� �� StringFormat$ c4��6�   �� 5:      $
��Left=�6   $��26��63   $��482,236,0,0q�6?   $
��Wrap=�6T   $	��Top=�6h   $	��141��6�   $��16(�6�   $	 Right=�6�   $��Exchange Rate��6�   �� 5;      $
��Left=�6   $��32��61   $��178,162.861,0,0q�6=   $

 Wrap=�6V   $	��Top=�6�   $	��279��6�   $��16(�6�   $ 16��6�   ��6j   �� *Manifest_Number+$ PropertyChanged=�6�   �� 5<      $
��Left=�6   $��32��63   $��
48,163,0,0q�6?   $
��Wrap=�6S   $	��Top=�6g   $	��120��6   $��16(�6�   $	 Right=�6�   $��Manifest Code��6�   �� 5=      $
��Left=�6   $��32��61   $��635,282,0,0q�6=   $

 Wrap=�6R   $	��Top=�6�   $	��146��6�   $��16(�6�   $ 16��6�   ��6f   �� *
BLNumber+$ PropertyChanged=�6�   �� 5>      $
��Left=�6   $��32��63   $��480,282,0,0q�6?   $
��Wrap=�6T   $	��Top=�6h   $	��141��6�   $��16(�6�   $	 Right=�6�   $��BL Ref. Number��6�   �� 5?      -   5        $ CreateSetTxt��5?      $
��Left=�6.   $��39��6I   $��492,369,0,0q�6U   $
��Wrap=�6j   $	��Top=�6~   $��53��6�   $	 Center=�6�   #���  6�   $��26.667(�6�   $	����6�   $��Segoe UI Symbol)�6�   6  �� 5@      $
��Left=�6�   $��26��6�   $��
483,91,0,0q�6�   $	��Top=�6�   $	��166��6�   $��14(�6�   $��Is Manually Assessed��6�    d� 	IsChecked 6   �� ?   9WaterNut.QuerySpace.CoreEntities.ViewModels.BaseViewModel   Instance# Z  �� Path$/ )CurrentAsycudaDocument.IsManuallyAssessed�6�   �� 5A      -   5        $ ManuallyAssessAll��5A   1   $��Assess All in Set��6   $
��Left=�6L   $��21��6g   $��
516,65,0,0q�6s   $
��Wrap=�6�   $	��Top=�6�   $	��123��6�   $	 Center=�6�   #���  6�   $��16(�6   6  �� 5B      $
��Left=�6�   $��26��6�   $��
483,10,0,0q�6�   $	��Top=�6�   $	��166��6�   $��14(�6�   $��Auto Update��6�    6   �� # Z $' !CurrentAsycudaDocument.AutoUpdate�6�   �� 5C      $
��Left=�6   $��32��61   $��635,329,0,0q�6=   $

 Wrap=�6R   $	��Top=�6�   $	��146��6�   $��16(�6�   $ 16��6�   ��6f   �� *TotalGrossWeight+$ PropertyChanged=�y�6�   �� # Z $; 5CurrentApplicationSettings.AllowAutoWeightCalculation��� 5D      $
��Left=�6   $��32��63   $��484,329,0,0q�6?   $
��Wrap=�6T   $	��Top=�6h   $	��141��6�   $��16(�6�   $	 Right=�6�   $��Total Gross Weight��6�   y�6�   �� # Z $; 5CurrentApplicationSettings.AllowAutoWeightCalculation��� 5E      $
��Left=�6   $��32��61   $��313,329,0,0q�6=   $

 Wrap=�6R   $	��Top=�6�   $	��146��6�   $��16(�6�   $ 16��6�   ��6f   �� *TotalFreight+$ PropertyChanged=�y�6�   �� *75CurrentApplicationSettings.AllowAutoWeightCalculation+# Z �� 5F      $
��Left=�6   $��32��63   $��162,329,0,0q�6?   $
��Wrap=�6T   $	��Top=�6h   $	��141��6�   $��16(�6�   $	 Right=�6�   $��Total Freight��6�   y�6�   �� *75CurrentApplicationSettings.AllowAutoWeightCalculation+# Z 5G      5H      5I      