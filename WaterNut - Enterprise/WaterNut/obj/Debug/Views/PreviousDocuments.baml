   M S B A M L   `   `   `  ����S  OWaterNut.Client.Entities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullyRclr-namespace:PreviousDocumentQS.Client.Entities;assembly=WaterNut.Client.Entities"PreviousDocumentQS.Client.Entities  5      I ECore.Common.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullmGclr-namespace:Core.Common.UI.DataVirtualization;assembly=Core.Common.UI!Core.Common.UI.DataVirtualization 5      C ?WaterNut, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullu?clr-namespace:WaterNut.QuerySpace.PreviousDocumentQS.ViewModels1WaterNut.QuerySpace.PreviousDocumentQS.ViewModels 5	      i9clr-namespace:WaterNut.QuerySpace.CoreEntities.ViewModels+WaterNut.QuerySpace.CoreEntities.ViewModels 5
      &    WaterNut.Views.PreviousDocuments   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/Expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      qqsPreviousEntitiesRclr-namespace:PreviousDocumentQS.Client.Entities;assembly=WaterNut.Client.Entities     5      fdataVirtualizationGclr-namespace:Core.Common.UI.DataVirtualization;assembly=Core.Common.UI     5      Oqsv?clr-namespace:WaterNut.QuerySpace.PreviousDocumentQS.ViewModels     5	      Iqcv9clr-namespace:WaterNut.QuerySpace.CoreEntities.ViewModels     5
        � 	Resources  5      �� 5   
    �� Member$( "qsv:PreviousDocumentModel.Instance��6      Key$ PreviousDocumentsModelDataSource  6?   �� 5   
    �� 
TargetType" ��6   .�5      �� ;  5Core.Common.UI.DataVirtualization.VirtualListItemBase �� Property �@ AutoLoad �� Value . 6P   5      �� 5   
   xcuda_ASYCUDATemplate   �� DataType9   3PreviousDocumentQS.Client.Entities.PreviousDocument"  65   .R�5      � $
��Auto��6?   .+�5      ��   TextBox2TextBlock#���  6E   $
��Left=�6r   $��27��6�   $��22,27,0,-0.667q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $��81��6�   $��21.333(�6�   ��6   �� *Data.CNumber+ �� Mode$ OneWay=�6�   �� 5      #���  6M   $
��Left=�6z   $
��Auto��6�   $
��29.6��6�   $��95.8,-1,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��16(�6�   ��6   �� *Data.ReferenceNumber+$ OneWay=�6�   �� 5      #���  6C   $��Right=�6p   $��20��6�   $��538.8,7.123,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $
��56.4��6�   $��18.667(�6�   ��6   �� *
Data.Lines+$ OneWay=�6�   �� 5      #���  6N   $��Right=�6{   $��28��6�   $��0,7.123,74,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $
��98.2��6�   $��18.667(�6�   ��6   �� *Data.RegistrationDate+$ OneWay=�6�   �� 5      #���  6B   $��22,0,0,0q�6n   $
��Left=�6�   $	��Top=�6�   $��45��6�   $��22��6�   $��18.667(�6�   $
��Bold"�6�   ��6   �� *	Data.Type+$ OneWay=�6�   �� 5      #���  6I   $
��Left=�6v   $
��Auto��6�   $
��29.6��6�   $��95.8,26,0,-2q�6�   $
 Wrap=�6�   $	��Top=�6�   $��13.333(�6�   ��6   �� *Data.Description+$ OneWay=�6�   �� 5      $
��Left=�6   $��53��67   $��0,1,0,-0.667q�6C   $	��Top=�6k   $��17��6�   ��6Y   Z� ��5      
� 5      .��5      �  � Color$ White��6+   	 � Offset$	 0.011Q�69   � 5      $ 	#FF5872AB��6+   $	 1Q�6=   5      5!      5#      5$      .��5)      � -   5        
 �Name$
 
LayoutRoot��5)      $	��710��6p    � DataContext 6   ��  $  PreviousDocumentsModelDataSource �� Source# [ .+�5*   
   �� $
��Left=�6   $��33��6/   $��9,14,0,0q�6;   $
��Wrap=�6M   $	��Top=�6a   $	��201��6y   $��21.333(�6�   $��Previous Documents��6�   �� 5,   
   -   5         ��Name$ 
ItemLstGrd��5,        xcuda_ASYCUDATemplate#���  5.       %� IsVirtualizing .  %� VirtualizationMode$ 	Recycling=�51      ! �� IsDeferredScrollingEnabled . C  =Core.Common.UI.DataVirtualization.VirtualListLoadingIndicator   
IsAttached . $��Stretch=�54      $��347.881��60   $��0,132.119,0,0q�6A   $	��Top=�6X   $
��Auto��6p     AlphaListBoxStyle#���  6�    �� SelectedItem 5-      �� E  ?WaterNut.QuerySpace.PreviousDocumentQS.ViewModels.BaseViewModel   Instance# Z  �� Path$ VCurrentPreviousDocument���5/      �� *PreviousDocuments+54   �   �� 55   
   $
��Left=�6   $��22.535��6/   $��10,62.465,0,0q�6?   $
��Wrap=�6V   $	��Top=�6j   $��116.164��6�   $��16(�6�   $��C Number��6�    �� TextAlignment$ Center=�6�   �� 56   
   $
��Left=�6   $��22.535��6/   $��131.164,62.465,0,0q�6?   $
��Wrap=�6[   $	��Top=�6o   $��236.617��6�   $��16(�6�   $��Reference Number��6�   $ Center=�6�   �� 57   
   $
��Left=�6   $��23��6/   $��
373,62,0,0q�6;   $
��Wrap=�6O   $	��Top=�6c   $	��217��6{   $��12(�6�   $*��$Start     Registration Date      End��6�   $ Center=�6�   �� 58   
   -   5        ���	#7FFFFFFF$
��Left=�58   t   $��22.535��6�   $��	10,85,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��116.164��6�   $��16(�6�    �� TextAlignment$ Center=�6�     TransparentTextBoxStyle#���  6  ��6   �� *CNumberFilter+$ TwoWay=� �� UpdateSourceTrigger$ Explicit=�6G  �� 59   
   -   5        ���	#4CFFFFFF$
��Left=�59   {   $��22.535��6�   $��131.164,85,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��236.617��6�   $��16(�6�   $ Center=�6	  #���  6   ��6   �� *ReferenceNumberFilter+$ TwoWay=�$ Explicit=�6R  �� 5:   
   -   5        $
��Left=�5:   2   $��26��6M   $��630,106,0,0q�6Y   $
��Wrap=�6n   $��View All��6�   $	��Top=�6�   $��75��6�   $��16(�6�     TextButtonStyle#���  6�   $ Right=�6�   (  "System.Windows.Controls.DatePicker  5;   
   -   5        ���	#7FFFFFFF$
��Left=�5;   �   $��23��6�   $��
373,86,0,0q�6�   $	��Top=�6�   $	��112��6�   $��16(�6�      SelectedDate 6   �� *StartRegistrationDateFilter+$ TwoWay=�$ Explicit=�6�   �� 5<   
   $
��Left=�6^   $��24��6y   $��
221,21,0,0q�6�   $
��Wrap=�6�   $	��Top=�6�   $	��201��6�   $��20(�6�   $ Right=�6�   ���	#FFE4E453��6   �� *PreviousDocuments.Count+ �� StringFormat$ 0 Filtered Results��6�   �� 5=   
   -   5        #���  5=      $
��Left=�6?   $��24��6Z   $��
584,11,0,0q�6f   $
��Wrap=�6z   $��Send to Excel ��6�   $	��Top=�6�   $	��121��6�   $��16(�6�   $��Segoe UI Symbol)�6�   y�6  �� ?  9WaterNut.QuerySpace.CoreEntities.ViewModels.BaseViewModel   Instance# Z $3 -CurrentApplicationSettings.AllowExportToExcel�  5>   
   -   5        ���	#7FFFFFFF$
��Left=�5>   �   $��23��6�   $��
490,85,0,0q�6�   $	��Top=�6�   $	��112��6�   $��16(�6�    6   �� *EndRegistrationDateFilter+$ TwoWay=�$ Explicit=�6�   5?      5@      