   M S B A M L   `   `   `  ���� I  ECore.Common.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullmGclr-namespace:Core.Common.UI.DataVirtualization;assembly=Core.Common.UI!Core.Common.UI.DataVirtualization  \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   DataGridStyle  �� 
TargetType&    System.Windows.Controls.DataGrid �� Property �� Value=  7System.Windows.Controls.Primitives.DataGridColumnHeader)  #System.Windows.Controls.DataGridRow �� Triggers P� Property P� Value*  $System.Windows.Controls.DataGridCell �� 
TargetType �� Padding  TextBoxStyle1  TextButtonStyle  CloseButtonStyle  ReportListBox  ReportListBoxItemStyle ��Name	 J� SnapsToDevicePixels
 �� Triggers �� RelativeSource �� AncestorType  	TextBrush ��Name ��Name �� 
TargetName  HorizontalItemsPanelTPL K� IsItemsHost $� Orientation  VirturalLoadLisBoxItem;   5Core.Common.UI.DataVirtualization.VirtualListItemBase 	 VirturalLoadListBoxC   =Core.Common.UI.DataVirtualization.VirtualListLoadingIndicator 
 TextBox2TextBlock  TransparentTextBoxStyle�� D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     SvirtualGclr-namespace:Core.Common.UI.DataVirtualization;assembly=Core.Common.UI  8d2http://schemas.microsoft.com/Expression/blend/2008  Bmc;http://schemas.openxmlformats.org/markup-compatibility/2006  %�
  &	        &	 �    &	 9    &	 �    &	     &	 r    &	     &	 1    &		 [    &	
 		    &	 �	    �� "    .���  � �� �#DDDDDD��   �@  HorizontalGridLinesBrush �#DDDDDD��  �@  VerticalGridLinesBrush �#DDDDDD��  �@  GridLinesVisibility$
 None=���  �@  ColumnHeaderStyle �� "   .���  � ��
 ���� ��  � ��
 �������  � ��$ Segoe UI Light)���  � ��$ 4,3,4,3q���  � ��$
 13px(���  �@  RowStyle �� "   .���  � �� �#044D7C��  � ��
 �������  � ��
 ����� P�  �@J�IsMouseOver . . ���  � �� �#C2B4E9��  �@  	CellStyle �� "   .���  � ��$
 12px(���  � ��$ 4,3,4,3q���  � �� �� "  .R��� # z��#��z��._���  P�  �@ 
IsSelected . . ���  � ��$
 14px(���  � �� �#044D7C��  � ��
 �������  � ��
 �����P�  �@ 	IsEditing . . ���  � ��$
 16px(���  � �� �#82B7D9��  � ��
 �  ����  � ��$ 2q���  � ��
 ������� "  ��.���  � �� �#988C8B��  � ��
 �������  � ��
 ������� "  ��.���  � �� �	#FFEEEB37 P�  �@J�IsMouseOver . . ���  � �� �	#FFCDD79B�� "  ��.���  � �� �	#FFFE2B2B P�  �@J�IsMouseOver . . ���  � �� �	#FFFF4600�� "  ��.���  � ��# �  ��  � ��# � ����  � ��# � ����  � ��$
 Auto=���  � ��$
 Auto=���  � �� . ��  � ��$ Center=���  � �� �� " ��.R�� ��Z� .+��� $ scrollViewer��|�.  #��z��.���� #	 z	 
 P�  � {� .  P�  �@��
IsGrouping . . ���  � �� .  �� "  ��.���  � ��
 ���� ��  � �� �� *HorizontalContentAlignment+ �� " ����  � �� �� *VerticalContentAlignment+ �� " ����  � ��# �  ��  � ��$ 30����  � �� �� " ��.R��� $ Bd��	 . ._�� .+��� $ contentPresenter��#��z��#��z��#	 z	 #��z��
 P�  � {� .  . ��� $ contentPresenter�� �@J�Opacity$	 0.5Q��� .R�$�  . $ 
Horizontal=��� "  ��.���  �@ AutoLoad . �� "  ��.���  �@%�IsVirtualizing . ��  �@%�VirtualizationMode$ 	Recycling=��� " �@��IsDeferredScrollingEnabled . ��  �@ 
IsAttached . �� "  ��.���  �@�FocusVisualStyle Z� ��  � �� �� " ��.R�� .+��� $ PART_ContentHost��
������ |�. $��Hidden=�$��Hidden=��� "  ��.���  �@�FocusVisualStyle Z� ��  � �� �� " ��.R�� .+��� $ PART_ContentHost�����	#4CFFFFFF|�. $��Hidden=�$��Hidden=�