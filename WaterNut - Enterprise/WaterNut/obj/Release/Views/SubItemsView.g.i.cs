﻿#pragma checksum "..\..\..\Views\SubItemsView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BC8E06609E3DABE1100CB965D0FF4148"
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
using WaterNut.QuerySpace.CoreEntities.ViewModels;
using WaterNut.QuerySpace.EntryDataQS.ViewModels;


namespace WaterNut.Views {
    
    
    /// <summary>
    /// SubItemsView
    /// </summary>
    public partial class SubItemsView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\Views\SubItemsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid LayoutRoot;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Views\SubItemsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ItemLst;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Views\SubItemsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ImportSubItemsTxt;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\Views\SubItemsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock DeselectTxt;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Views\SubItemsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock SelectTxt;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Views\SubItemsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox MultiSelectChk;
        
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
            System.Uri resourceLocater = new System.Uri("/WaterNut;component/views/subitemsview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\SubItemsView.xaml"
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
            case 1:
            this.LayoutRoot = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.ItemLst = ((System.Windows.Controls.ListBox)(target));
            
            #line 37 "..\..\..\Views\SubItemsView.xaml"
            this.ItemLst.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ItemList_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 40 "..\..\..\Views\SubItemsView.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Send2Excel);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 42 "..\..\..\Views\SubItemsView.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.TextBox_PreviewKeyDown);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 44 "..\..\..\Views\SubItemsView.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.TextBox_PreviewKeyDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ImportSubItemsTxt = ((System.Windows.Controls.TextBlock)(target));
            
            #line 46 "..\..\..\Views\SubItemsView.xaml"
            this.ImportSubItemsTxt.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.ImportSI);
            
            #line default
            #line hidden
            return;
            case 7:
            this.DeselectTxt = ((System.Windows.Controls.TextBlock)(target));
            
            #line 47 "..\..\..\Views\SubItemsView.xaml"
            this.DeselectTxt.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.DeselectTxt_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 8:
            this.SelectTxt = ((System.Windows.Controls.TextBlock)(target));
            
            #line 48 "..\..\..\Views\SubItemsView.xaml"
            this.SelectTxt.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.SelectTxt_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 9:
            this.MultiSelectChk = ((System.Windows.Controls.CheckBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

