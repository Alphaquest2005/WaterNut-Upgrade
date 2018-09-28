﻿#pragma checksum "..\..\..\Views\EX9SalesData.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3A09106EE5C98774995CEF63778CC2A1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Core.Common.UI.DataVirtualization;
using SalesDataQS.Client.Entities;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using WaterNut;
using WaterNut.QuerySpace.SalesDataQS.ViewModels;


namespace WaterNut.Views {
    
    
    /// <summary>
    /// Ex9SalesData
    /// </summary>
    public partial class Ex9SalesData : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 31 "..\..\..\Views\EX9SalesData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid LayoutRoot;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Views\EX9SalesData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ItemLst;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Views\EX9SalesData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock DeselectTxt;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Views\EX9SalesData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock SelectTxt;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Views\EX9SalesData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox MultiSelectChk;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\Views\EX9SalesData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ImportSalesTxt;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Views\EX9SalesData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox MultiSelectChk_Copy;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\Views\EX9SalesData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox MultiSelectChk_Copy1;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WaterNut;component/views/ex9salesdata.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\EX9SalesData.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 2:
            this.LayoutRoot = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.ItemLst = ((System.Windows.Controls.ListBox)(target));
            
            #line 40 "..\..\..\Views\EX9SalesData.xaml"
            this.ItemLst.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ItemList_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.DeselectTxt = ((System.Windows.Controls.TextBlock)(target));
            
            #line 41 "..\..\..\Views\EX9SalesData.xaml"
            this.DeselectTxt.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.DeselectTxt_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.SelectTxt = ((System.Windows.Controls.TextBlock)(target));
            
            #line 42 "..\..\..\Views\EX9SalesData.xaml"
            this.SelectTxt.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.SelectTxt_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.MultiSelectChk = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 7:
            
            #line 44 "..\..\..\Views\EX9SalesData.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.AllocateSales);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ImportSalesTxt = ((System.Windows.Controls.TextBlock)(target));
            
            #line 45 "..\..\..\Views\EX9SalesData.xaml"
            this.ImportSalesTxt.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.ImportSales);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 46 "..\..\..\Views\EX9SalesData.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.RemoveSelected);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 48 "..\..\..\Views\EX9SalesData.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.TextBox_PreviewKeyDown);
            
            #line default
            #line hidden
            return;
            case 11:
            this.MultiSelectChk_Copy = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 12:
            this.MultiSelectChk_Copy1 = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 13:
            
            #line 57 "..\..\..\Views\EX9SalesData.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.ViewAll);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 24 "..\..\..\Views\EX9SalesData.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.RemovePOTxt_MouseLeftButtonUp);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

