﻿#pragma checksum "..\..\..\Views\AsycudaDocumentSummaryList.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46146C807D92EBEBEB883128734F336C56D47E43"
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
using CoreEntities.Client.Entities;
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


namespace WaterNut.Views {
    
    
    /// <summary>
    /// AsycudaDocumentSummaryList
    /// </summary>
    public partial class AsycudaDocumentSummaryList : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 69 "..\..\..\Views\AsycudaDocumentSummaryList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid LayoutRoot;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\Views\AsycudaDocumentSummaryList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox DocSetGrd;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\Views\AsycudaDocumentSummaryList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ImportBtn;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\Views\AsycudaDocumentSummaryList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ExportBtn;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\Views\AsycudaDocumentSummaryList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox MultiSelectChk_Copy1;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\Views\AsycudaDocumentSummaryList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox MultiSelectChk_Copy2;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\Views\AsycudaDocumentSummaryList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox MultiSelectChk_Copy3;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\Views\AsycudaDocumentSummaryList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox MultiSelectChk_Copy;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\Views\AsycudaDocumentSummaryList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox MultiSelectChk_Copy4;
        
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
            System.Uri resourceLocater = new System.Uri("/WaterNut;component/views/asycudadocumentsummarylist.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\AsycudaDocumentSummaryList.xaml"
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
            case 5:
            this.LayoutRoot = ((System.Windows.Controls.Grid)(target));
            return;
            case 6:
            this.DocSetGrd = ((System.Windows.Controls.ListBox)(target));
            
            #line 75 "..\..\..\Views\AsycudaDocumentSummaryList.xaml"
            this.DocSetGrd.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DocSetGrd_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 76 "..\..\..\Views\AsycudaDocumentSummaryList.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.ViewAll);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ImportBtn = ((System.Windows.Controls.TextBlock)(target));
            
            #line 77 "..\..\..\Views\AsycudaDocumentSummaryList.xaml"
            this.ImportBtn.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.ImportBtn_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 9:
            this.ExportBtn = ((System.Windows.Controls.TextBlock)(target));
            
            #line 78 "..\..\..\Views\AsycudaDocumentSummaryList.xaml"
            this.ExportBtn.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.ExportBtn_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 10:
            this.MultiSelectChk_Copy1 = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 11:
            this.MultiSelectChk_Copy2 = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 12:
            this.MultiSelectChk_Copy3 = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 13:
            this.MultiSelectChk_Copy = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 14:
            this.MultiSelectChk_Copy4 = ((System.Windows.Controls.CheckBox)(target));
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
            
            #line 47 "..\..\..\Views\AsycudaDocumentSummaryList.xaml"
            ((System.Windows.Controls.Expander)(target)).Expanded += new System.Windows.RoutedEventHandler(this.Expander_Expanded);
            
            #line default
            #line hidden
            
            #line 47 "..\..\..\Views\AsycudaDocumentSummaryList.xaml"
            ((System.Windows.Controls.Expander)(target)).Collapsed += new System.Windows.RoutedEventHandler(this.Expander_Collapsed);
            
            #line default
            #line hidden
            break;
            case 2:
            
            #line 51 "..\..\..\Views\AsycudaDocumentSummaryList.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.DeleteAll);
            
            #line default
            #line hidden
            break;
            case 3:
            
            #line 52 "..\..\..\Views\AsycudaDocumentSummaryList.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.ExportAll);
            
            #line default
            #line hidden
            break;
            case 4:
            
            #line 61 "..\..\..\Views\AsycudaDocumentSummaryList.xaml"
            ((System.Windows.Controls.ListBox)(target)).SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DocGrd_SelectionChanged);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

