﻿#pragma checksum "..\..\..\Views\EntryDataDetails.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2B7B75DBE1765C23AD641B0F6DCF0E91A7B0CA0D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Core.Common.UI.DataVirtualization;
using Core.Common.UI.Validation;
using EntryDataQS.Client.Entities;
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
using WaterNut.Converters;
using WaterNut.QuerySpace.CoreEntities.ViewModels;
using WaterNut.QuerySpace.EntryDataQS.ViewModels;


namespace WaterNut.Views {
    
    
    /// <summary>
    /// EntryDataDetailsView
    /// </summary>
    public partial class EntryDataDetailsView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 47 "..\..\..\Views\EntryDataDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid LayoutRoot;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\Views\EntryDataDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ItemLst;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\Views\EntryDataDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox MultiSelectChk;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\Views\EntryDataDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock DeselectTxt;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\Views\EntryDataDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock SelectTxt;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\Views\EntryDataDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock NewItemTxt;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\Views\EntryDataDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock SaveItemTxt_Copy;
        
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
            System.Uri resourceLocater = new System.Uri("/WaterNut;component/views/entrydatadetails.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\EntryDataDetails.xaml"
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
            case 3:
            this.LayoutRoot = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.ItemLst = ((System.Windows.Controls.ListBox)(target));
            
            #line 52 "..\..\..\Views\EntryDataDetails.xaml"
            this.ItemLst.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ItemList_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 59 "..\..\..\Views\EntryDataDetails.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.AddItemtoAdocTxt_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 6:
            this.MultiSelectChk = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 7:
            this.DeselectTxt = ((System.Windows.Controls.TextBlock)(target));
            
            #line 61 "..\..\..\Views\EntryDataDetails.xaml"
            this.DeselectTxt.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.DeselectTxt_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 8:
            this.SelectTxt = ((System.Windows.Controls.TextBlock)(target));
            
            #line 62 "..\..\..\Views\EntryDataDetails.xaml"
            this.SelectTxt.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.SelectTxt_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 9:
            this.NewItemTxt = ((System.Windows.Controls.TextBlock)(target));
            
            #line 71 "..\..\..\Views\EntryDataDetails.xaml"
            this.NewItemTxt.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.NewItm);
            
            #line default
            #line hidden
            return;
            case 10:
            this.SaveItemTxt_Copy = ((System.Windows.Controls.TextBlock)(target));
            
            #line 73 "..\..\..\Views\EntryDataDetails.xaml"
            this.SaveItemTxt_Copy.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.SaveItm);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 75 "..\..\..\Views\EntryDataDetails.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.TextBox_PreviewKeyDown);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 76 "..\..\..\Views\EntryDataDetails.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.TextBox_PreviewKeyDown);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 77 "..\..\..\Views\EntryDataDetails.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.TextBox_PreviewKeyDown);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 78 "..\..\..\Views\EntryDataDetails.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.TextBox_PreviewKeyDown);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 84 "..\..\..\Views\EntryDataDetails.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.TextBox_PreviewKeyDown);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 89 "..\..\..\Views\EntryDataDetails.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Send2Excel);
            
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
            
            #line 32 "..\..\..\Views\EntryDataDetails.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.AddItemtoAdocTxt_MouseLeftButtonUp);
            
            #line default
            #line hidden
            break;
            case 2:
            
            #line 33 "..\..\..\Views\EntryDataDetails.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Checked += new System.Windows.RoutedEventHandler(this.CheckBox_Checked);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

