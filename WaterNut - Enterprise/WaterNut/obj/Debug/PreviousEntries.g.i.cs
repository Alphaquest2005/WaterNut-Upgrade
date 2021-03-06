﻿#pragma checksum "PreviousEntries.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A5F5370E0FEDD562E7E57AE1E4208789"
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
using WaterNut;
using WaterNut.QuerySpace.CoreEntities.ViewModels;
using WaterNut.QuerySpace.PreviousDocumentQS.ViewModels;


namespace WaterNut.Views {
    
    
    /// <summary>
    /// PreviousEntries
    /// </summary>
    public partial class PreviousEntries : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 48 "PreviousEntries.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid LayoutRoot;
        
        #line default
        #line hidden
        
        
        #line 50 "PreviousEntries.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ItemLst;
        
        #line default
        #line hidden
        
        
        #line 68 "PreviousEntries.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox MultiSelectChk;
        
        #line default
        #line hidden
        
        
        #line 70 "PreviousEntries.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock DeselectTxt;
        
        #line default
        #line hidden
        
        
        #line 71 "PreviousEntries.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock SelectTxt;
        
        #line default
        #line hidden
        
        
        #line 72 "PreviousEntries.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ManualModeChk;
        
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
            System.Uri resourceLocater = new System.Uri("/WaterNut;component/previousentries.xaml", System.UriKind.Relative);
            
            #line 1 "PreviousEntries.xaml"
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
            
            #line 58 "PreviousEntries.xaml"
            this.ItemLst.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ItemLst_SelectionChanged);
            
            #line default
            #line hidden
            
            #line 58 "PreviousEntries.xaml"
            this.ItemLst.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.ItemLst_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 58 "PreviousEntries.xaml"
            this.ItemLst.PreviewMouseMove += new System.Windows.Input.MouseEventHandler(this.ItemLst_PreviewMouseMove);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 62 "PreviousEntries.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.TextBox_PreviewKeyDown);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 63 "PreviousEntries.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.TextBox_PreviewKeyDown);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 64 "PreviousEntries.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.ViewAll);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 65 "PreviousEntries.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.TextBox_PreviewKeyDown);
            
            #line default
            #line hidden
            return;
            case 9:
            this.MultiSelectChk = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 10:
            
            #line 69 "PreviousEntries.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.TextBlock_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 11:
            this.DeselectTxt = ((System.Windows.Controls.TextBlock)(target));
            
            #line 70 "PreviousEntries.xaml"
            this.DeselectTxt.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.DeselectTxt_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 12:
            this.SelectTxt = ((System.Windows.Controls.TextBlock)(target));
            
            #line 71 "PreviousEntries.xaml"
            this.SelectTxt.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.SelectTxt_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 13:
            this.ManualModeChk = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 14:
            
            #line 74 "PreviousEntries.xaml"
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
            
            #line 29 "PreviousEntries.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.RemoveTxt_MouseLeftButtonUp);
            
            #line default
            #line hidden
            break;
            case 2:
            
            #line 41 "PreviousEntries.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Checked += new System.Windows.RoutedEventHandler(this.CheckBox_Checked);
            
            #line default
            #line hidden
            
            #line 41 "PreviousEntries.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Unchecked += new System.Windows.RoutedEventHandler(this.CheckBox_Unchecked);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

