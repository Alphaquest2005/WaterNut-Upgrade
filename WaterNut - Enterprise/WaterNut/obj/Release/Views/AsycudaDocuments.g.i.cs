﻿#pragma checksum "..\..\..\Views\AsycudaDocuments.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "351BBD3C6D9DC56BAACEA86144F41319"
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
    /// AsycudaDocuments
    /// </summary>
    public partial class AsycudaDocuments : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 38 "..\..\..\Views\AsycudaDocuments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid LayoutRoot;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Views\AsycudaDocuments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ItemLstGrd;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\Views\AsycudaDocuments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ExportBtn;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\Views\AsycudaDocuments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ImportBtn;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\Views\AsycudaDocuments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox MultiSelectChk_Copy;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\Views\AsycudaDocuments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox MultiSelectChk_Copy1;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\Views\AsycudaDocuments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox MultiSelectChk_Copy2;
        
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
            System.Uri resourceLocater = new System.Uri("/WaterNut;component/views/asycudadocuments.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\AsycudaDocuments.xaml"
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
            this.ItemLstGrd = ((System.Windows.Controls.ListBox)(target));
            
            #line 44 "..\..\..\Views\AsycudaDocuments.xaml"
            this.ItemLstGrd.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ItemLstGrd_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 48 "..\..\..\Views\AsycudaDocuments.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.TextBox_PreviewKeyDown);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 49 "..\..\..\Views\AsycudaDocuments.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.TextBox_PreviewKeyDown);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 50 "..\..\..\Views\AsycudaDocuments.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.ViewAll);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 53 "..\..\..\Views\AsycudaDocuments.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Send2Excel);
            
            #line default
            #line hidden
            return;
            case 9:
            this.ExportBtn = ((System.Windows.Controls.TextBlock)(target));
            
            #line 54 "..\..\..\Views\AsycudaDocuments.xaml"
            this.ExportBtn.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.ExportDocument);
            
            #line default
            #line hidden
            return;
            case 10:
            this.ImportBtn = ((System.Windows.Controls.TextBlock)(target));
            
            #line 55 "..\..\..\Views\AsycudaDocuments.xaml"
            this.ImportBtn.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.ImportDocument);
            
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
            this.MultiSelectChk_Copy2 = ((System.Windows.Controls.CheckBox)(target));
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
            
            #line 29 "..\..\..\Views\AsycudaDocuments.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Checked += new System.Windows.RoutedEventHandler(this.CheckBox_Checked);
            
            #line default
            #line hidden
            
            #line 29 "..\..\..\Views\AsycudaDocuments.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Unchecked += new System.Windows.RoutedEventHandler(this.CheckBox_Checked);
            
            #line default
            #line hidden
            break;
            case 2:
            
            #line 30 "..\..\..\Views\AsycudaDocuments.xaml"
            ((System.Windows.Controls.DatePicker)(target)).SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.DatePicker_SelectedDateChanged);
            
            #line default
            #line hidden
            
            #line 30 "..\..\..\Views\AsycudaDocuments.xaml"
            ((System.Windows.Controls.DatePicker)(target)).LostFocus += new System.Windows.RoutedEventHandler(this.DatePicker_LostFocus);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

