﻿#pragma checksum "..\..\..\Views\PreviousDocuments.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8A557A472D6DC34E1D6400130B32E3C4"
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
using PreviousDocumentQS.Client.Entities;
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
using WaterNut.QuerySpace.CoreEntities.ViewModels;
using WaterNut.QuerySpace.PreviousDocumentQS.ViewModels;


namespace WaterNut.Views {
    
    
    /// <summary>
    /// PreviousDocuments
    /// </summary>
    public partial class PreviousDocuments : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\..\Views\PreviousDocuments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid LayoutRoot;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Views\PreviousDocuments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ItemLstGrd;
        
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
            System.Uri resourceLocater = new System.Uri("/WaterNut;component/views/previousdocuments.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\PreviousDocuments.xaml"
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
            this.ItemLstGrd = ((System.Windows.Controls.ListBox)(target));
            
            #line 44 "..\..\..\Views\PreviousDocuments.xaml"
            this.ItemLstGrd.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ItemLstGrd_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 48 "..\..\..\Views\PreviousDocuments.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.TextBox_PreviewKeyDown);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 49 "..\..\..\Views\PreviousDocuments.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.TextBox_PreviewKeyDown);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 50 "..\..\..\Views\PreviousDocuments.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.ViewAll);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 51 "..\..\..\Views\PreviousDocuments.xaml"
            ((System.Windows.Controls.DatePicker)(target)).SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.DatePicker_OnSelectedDateChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 53 "..\..\..\Views\PreviousDocuments.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Send2Excel);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 54 "..\..\..\Views\PreviousDocuments.xaml"
            ((System.Windows.Controls.DatePicker)(target)).SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.DatePicker_OnSelectedDateChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

