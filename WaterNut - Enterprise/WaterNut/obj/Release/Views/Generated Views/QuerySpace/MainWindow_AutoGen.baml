   M S B A M L   `   `   `  ���� C  ?WaterNut, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:WaterNut.QuerySpace.ViewsWaterNut.QuerySpace.Views  i9clr-namespace:WaterNut.QuerySpace.CoreEntities.ViewModels+WaterNut.QuerySpace.CoreEntities.ViewModels  I ECore.Common.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG4clr-namespace:Core.Common.UI;assembly=Core.Common.UICore.Common.UI 2    ,WaterNut.QuerySpace.Views.MainWindow_AutoGen   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     =	autoviews'clr-namespace:WaterNut.QuerySpace.Views     P
automodels9clr-namespace:WaterNut.QuerySpace.CoreEntities.ViewModels     Cui4clr-namespace:Core.Common.UI;assembly=Core.Common.UI     c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  h dMicrosoft.Expression.Interactions, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bei9http://schemas.microsoft.com/expression/2010/interactions  :d2http://schemas.microsoft.com/expression/blend/2008  Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  -     �Name$  Window�� � Title$ 
MainWindow��$��1609.91��$	��480�� � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ CanResizeWithGrip=� � WindowStyle$
 None=����	#FF3F3F3F � WindowState$ 	Maximized=�����  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ 	#FF783A00��	 � Offset$
	 0.98Q�� $ 	#FFECC058��
 � 	Resources
 E   ?WaterNut.QuerySpace.CoreEntities.ViewModels.MainWindowViewModel !  MainWindowViewModelDataSource��%   &	          .��� -    �Name$ 
LayoutRoot�� � DataContext ��  �� Source# [  .+�0   *WaterNut.QuerySpace.Views.MainView_AutoGen  $��	0,0,0,105q��� $��80��$��0,0,0,25q�$��Bottom=�$��2q����	#4CFAFAFA J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     Color$ 	#FF805E00��._�]� -    ]�Name$ 	FooterBar����.  $��80��.+�9� -   $��
homeexpand�� 9� 
IsExpanded .  9� ExpandDirection$ Right=�$
��Auto��$	��Top=�$
��Left=���� $	��365��.+��� -    ��Name$ HomeBtn��$��63��$	��Top=�$
��Left=�$��22,6,0,0q�$��55��  TextButtonStyle#��[ $��Segoe UI Symbol)�$��40(�$	������ $
��Home��#��[ $
��Left=�$��20��$��4,0,0,-1q�$
��Wrap=�$��Bottom=�$��82�� �� TextAlignment$ Center=�.��� $
��1074��.+�� $��	0,7,295,3q�.+��� $��Common Tasks��$
��Left=�$��49��$��0,5,25,0q�$
��Wrap=�$	��Top=�$��82��$ Center=�$��16(�$
��Bold"����	#FFFDFFB9��  �� Orientation$ 
Horizontal=�.+��� $��Allocation QS��#��[ $��Right=�$��40��$
��Wrap=�$��Bottom=�$��82��$ Center=� J� InputBindings d�  d� MouseAction$ 	LeftClicke� �� Command �� *NavAllocationQS+�� $��Counter Point QS��#��[ $��Right=�$��40��$
��Wrap=�$��Bottom=�$��82��$ Center=� d� $ 	LeftClicke� �� *NavCounterPointQS+�� $��Core Entities��#��[ $��Right=�$��40��$
��Wrap=�$��Bottom=�$��82��$ Center=� d� $ 	LeftClicke� �� *NavCoreEntities+�� $��Entry Data QS��#��[ $��Right=�$��40��$
��Wrap=�$��Bottom=�$��82��$ Center=� d� $ 	LeftClicke� �� *NavEntryDataQS+�� $��Inventory QS��#��[ $��Right=�$��40��$
��Wrap=�$��Bottom=�$��82��$ Center=� d� $ 	LeftClicke� �� *NavInventoryQS+�� $��Previous Document QS��#��[ $��Right=�$��40��$
��Wrap=�$��Bottom=�$��82��$ Center=� d� $ 	LeftClicke� �� *NavPreviousDocumentQS+�� $��Sales Data QS��#��[ $��Right=�$��40��$
��Wrap=�$��Bottom=�$��82��$ Center=� d� $ 	LeftClicke� �� *NavSalesDataQS+�� $��Overs Short QS��#��[ $��Right=�$��40��$
��Wrap=�$��Bottom=�$��82��$ Center=� d� $ 	LeftClicke� �� *NavOversShortQS+� -   $ 	HeaderBar��$��35��$��0,0,-0.49,0q�$	��Top=����	#00000000.+�� -   ���	#00000000$��0,0,-0.49,0q��� -   $	����  CloseButtonStyle#��[ $��Right=�$��50��$	��Top=�$��35��$��Segoe UI Symbol)�$��24(�$��
0,10,0.4,0q��� -	   $	����#���  $��Right=�$��32��$	��Top=�$��30��$��Segoe UI Symbol)�$��24(�$��0,8,39.69,-5q��� -
   $	����#���  $��Right=�$��25��$	��Top=�$��30��$��Segoe UI Symbol)�$��24(�$��0,16,69.69,-6q�