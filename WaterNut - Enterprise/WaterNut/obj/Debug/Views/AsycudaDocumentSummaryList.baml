   M S B A M L   `   `   `  ����C  ?WaterNut, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulli9clr-namespace:WaterNut.QuerySpace.CoreEntities.ViewModels+WaterNut.QuerySpace.CoreEntities.ViewModels  5      I ECore.Common.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullmGclr-namespace:Core.Common.UI.DataVirtualization;assembly=Core.Common.UI!Core.Common.UI.DataVirtualization 5      S OWaterNut.Client.Entities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullmLclr-namespace:CoreEntities.Client.Entities;assembly=WaterNut.Client.EntitiesCoreEntities.Client.Entities 5      #clr-namespace:WaterNutWaterNut  5
      /    )WaterNut.Views.AsycudaDocumentSummaryList   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/Expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      HQS9clr-namespace:WaterNut.QuerySpace.CoreEntities.ViewModels     5      [virtualGclr-namespace:Core.Common.UI.DataVirtualization;assembly=Core.Common.UI     5      gQSCoreEntitiesLclr-namespace:CoreEntities.Client.Entities;assembly=WaterNut.Client.Entities     5      (localclr-namespace:WaterNut     5
        � 	Resources  5      �� 5   
    �� Member$* $QS:AsycudaDocumentSetsModel.Instance��6      Key&"AsycudaDocumentSetsModelDataSource  6A   �� 5   
    �� 
TargetType" ��6   .�5      �� ;  5Core.Common.UI.DataVirtualization.VirtualListItemBase �� Property �@ AutoLoad �� Value . 6E   5      �� 5   
   xcuda_ASYCUDATemplate   �� DataType2  ,CoreEntities.Client.Entities.AsycudaDocument"  65   .R�5      � $
��Auto��6?   .+�5      �� $
��Left=�6B   $��33��6]   $��21,21,0,-0.667q�6i   $
��Wrap=�6�   $	��Top=�6�   $��81��6�   $��21.333(�6�   ��6   �� *	CNumber+ �� Mode$ OneWay=�6�   �� 5      $
��Left=�6=   $	��164��6X   $��30��6d   $��
119,-1,0,0q�6p   $
��Wrap=�6�   $	��Top=�6�   $��16(�6�   ��6   �� *ReferenceNumber+6�   �� 5      $
��Left=�6I   $��23��6d   $��
494,-1,0,0q�6p   $
��Wrap=�6�   $	��Top=�6�   $��57��6�   $��18.667(�6�   ��6   �� *Lines+ �� StringFormat$ 0 lines��6�   �� 5      $
��Left=�6>   $��28��6Y   $��	300,1,0,0q�6e   $
��Wrap=�6x   $	��Top=�6�   $��87��6�   $��18.667(�6�   ��6   �� *RegistrationDate+6�   �� 5      $��21,0,0,0q�6:   $
��Left=�6L   $	��Top=�6g   $��45��6   $��22��6�   $��18.667(�6�   $
��Bold"�6�   ��6   �� *DocumentType+6�   �� 5      $
��Left=�69   $
��Auto��6T   $��21��6a   $��	96,26,0,0q�6m   $
��Wrap=�6�   $	��Top=�6�   $��13.333(�6�   ��6   �� *Description+6�   �� 5      $
��Left=�6K   $��21��6f   $��	407,1,0,0q�6r   $
��Wrap=�6�   $	��Top=�6�   $��82��6�   $��16(�6�   ��6   �� *Customs_clearance_office_code+6�   �� 5      $��	CancelImg��6   $��25��6)   $��25��65   $��10,0,595.578,4.866q�6@   �� 5      $
��Left=�6   $��53��67   $��0,1,0,-0.667q�6C   $	��Top=�6k   $��15��6�   ��6Y   Z� ��5       
� 5!      .��5"      �  � Color$ White��6+   	 � Offset$	 0.011Q�69   � 5#      $ 	#FF5872AB��6+   $	 1Q�6=   5$      5&      5'      
 �� Triggers
 5(      �� 5)       �� Value$ False��6A    �� Binding 6   �� *ImportComplete+.a�5*      ��  �� 
TargetName$ 	CancelImg��6     CancelImage# [ 6F    � ��5+      5-      �� 5.   
   AsycudaDocumentSetTemplate  7  1CoreEntities.Client.Entities.AsycudaDocumentSetEx"  6;   .R�5/      9� -   5        ��50      � 51      $	��561��6G   ���	#00000000.+�52      ��   TextBox2TextBlock#���  6`   $
��Left=�6�   $��32��6�   $��0q�6�    �� TextWrapping$ NoWrap=�6�   $	��Top=�6�   $	��361��6�   $��21.333(�6�   ��6"   �� *!Data.Declarant_Reference_Number+$ OneWay=�6�   �� 53      -   5        $��Right=�53   $   $��22��6@   $��0,6,69,0q�6L   $
��Wrap=�6^   $��
Delete All��6r   $	��Top=�6�   $��57��6�   $��12(�6�     CloseButtonStyle#���  6�    �� TextAlignment$ Right=�6�   6�   �� 54      -   5        $��Right=�54   $   $��22��6@   $��0,4,10,0q�6L   $
��Wrap=�6^   $��
Export All��6r   $	��Top=�6�   $��54��6�   $��12(�6�     TextButtonStyle#���  6�   $ Right=�6�   6�   �� 57      $��Right=�6I   $��24��6e   $��	0,4,151,0q�6q   $
��Wrap=�6�   $	��Top=�6�   $��44��6�   $��14.667(�6�   $
��Bold"�6�   $ Center=�6�   ��6$   �� *Data.DocumentsCount+6�   58      .��5:      ��  ��Name$ DocGrd��6   -   5          xcuda_ASYCUDATemplate#���  5<      $��Stretch=�5=      $	��300��6�   $��0,0,0,0q�6�   $	��Top=�6�   $
��Auto��6�    �� SelectedItem 5;      �� ?   9WaterNut.QuerySpace.CoreEntities.ViewModels.BaseViewModel   Instance �� Source# Z  �� Path$ CurrentAsycudaDocument���5=      �� *AsycudaDocuments+ & "AsycudaDocumentSetsModelDataSource# [ 6�   5>      5B      .��5E      � -   5         �Name$ 
LayoutRoot��5E       � DataContext 6   �� # [ .+�5F   
   �� $
��Left=�6   $��33��6/   $��9,7,0,0q�6;   $
��Wrap=�6L   $	��Top=�6`   $	��234��6x   $��21.333(�6�   $��Asycuda Documents List��6�   �� 5G   
   -   5        $ 	DocSetGrd��5G        AsycudaDocumentSetTemplate#���  5I      $��Stretch=�5K      $	��387��60   $��0,93,0,0q�6=   $	��Top=�6O   $
��Auto��6g     AlphaListBoxStyle#���  6�    5H      �� # Z $" VCurrentAsycudaDocumentSetEx���5J      �� *AsycudaDocumentSetExs+5K   �   �� 5L   
   -   5        $
��Left=�5L   2   $��26��6M   $��
545,67,0,0q�6Y   $
��Wrap=�6m   $��View All��6�   $	��Top=�6�   $��75��6�   $��16(�6�   #���  6�   $ Right=�6�   �� 5M   
   -   5         ��Name$ 	ImportBtn��5M      $
��Left=�6[   $��26��6v   $��
547,40,0,0q�6�   $
��Wrap=�6�   $	��Top=�6�   $��75��6�   $��16(�6�   #���  6�   $ Right=�6  �� 6  $�Import��6!  �� 61  �� 6=  6D  �� 5N   
   -	   5        $ 	ExportBtn��5N      $
��Left=�6[   $��26��6v   $��	498,7,0,0q�6�   $
��Wrap=�6�   $	��Top=�6�   $	��132��6�   $��16(�6�   #���  6�   $ Right=�6  $��Export to XML file��6  �� 5O   
   $
��Left=�6Y   $��24��6t   $��	264,6,0,0q�6�   $
��Wrap=�6�   $	��Top=�6�   $	��201��6�   $��20(�6�   $ Right=�6�   ���	#FFE4E453��6   �� *AsycudaDocumentSetExs.Count+$ 	0 Results��6�   �� 5P   
   -
   5         ��Name$ MultiSelectChk_Copy1��5P   G   $
��Left=�6e   $��22��6�   $��	50,43,0,0q�6�   $	��Top=�6�   $	��145��6�   $��Import Only Reg. Docs��6�    J� RenderTransformOrigin$ 0.488,0.464&�6�    d� 	IsChecked 6   �� *ImportOnlyRegisteredDocuments+6�   �� 5Q   
   -   5        $ MultiSelectChk_Copy2��5Q   ;   $
��Left=�6Y   $��22��6t   $��	50,67,0,0q�6�   $	��Top=�6�   $	��120��6�   $��Import TariffCodes��6�   $ 0.488,0.464&�6�    6   �� *ImportTariffCodes+6�   �� 5R   
   -   5        $ MultiSelectChk_Copy3��5R   4   $
��Left=�6R   $��22��6m   $��
225,44,0,0q�6y   $	��Top=�6�   $��95��6�   $��No Messages��6�   $ 0.488,0.464&�6�    6   �� *
NoMessages+6�   �� 5S   
   -   5        $ MultiSelectChk_Copy��5S   ;   $
��Left=�6X   $��48��6t   $��
355,45,0,0q�6�   $	��Top=�6�   $��95��6�   $��Overwrite 
existing Docs��6�   $ 0.488,0.464&�6�    6   �� *OverwriteExisting+6�   �� 5T   
   -   5        $ MultiSelectChk_Copy4��5T   0   $
��Left=�6N   $��22��6i   $��
225,66,0,0q�6u   $	��Top=�6�   $��95��6�   $��Link Pi��6�   $ 0.488,0.464&�6�    6   �� *LinkPi+6�   5U      5V      