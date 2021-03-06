﻿#pragma checksum "MainWindow_AutoGen.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A2FB443FCB56A01434BE92DC660941C5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Core.Common.UI;
using Microsoft.Expression.Interactivity.Core;
using Microsoft.Expression.Interactivity.Input;
using Microsoft.Expression.Interactivity.Layout;
using Microsoft.Expression.Interactivity.Media;
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
using System.Windows.Interactivity;
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
using WaterNut.QuerySpace.Views;


namespace WaterNut.QuerySpace.Views {
    
    
    /// <summary>
    /// MainWindow_AutoGen
    /// </summary>
    public partial class MainWindow_AutoGen : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "MainWindow_AutoGen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal WaterNut.QuerySpace.Views.MainWindow_AutoGen Window;
        
        #line default
        #line hidden
        
        
        #line 29 "MainWindow_AutoGen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid LayoutRoot;
        
        #line default
        #line hidden
        
        
        #line 36 "MainWindow_AutoGen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel FooterBar;
        
        #line default
        #line hidden
        
        
        #line 38 "MainWindow_AutoGen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Expander homeexpand;
        
        #line default
        #line hidden
        
        
        #line 41 "MainWindow_AutoGen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock HomeBtn;
        
        #line default
        #line hidden
        
        
        #line 94 "MainWindow_AutoGen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid HeaderBar;
        
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
            System.Uri resourceLocater = new System.Uri("/WaterNut;component/mainwindow_autogen.xaml", System.UriKind.Relative);
            
            #line 1 "MainWindow_AutoGen.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.Window = ((WaterNut.QuerySpace.Views.MainWindow_AutoGen)(target));
            return;
            case 2:
            this.LayoutRoot = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.FooterBar = ((System.Windows.Controls.DockPanel)(target));
            
            #line 36 "MainWindow_AutoGen.xaml"
            this.FooterBar.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.homeexpand = ((System.Windows.Controls.Expander)(target));
            
            #line 38 "MainWindow_AutoGen.xaml"
            this.homeexpand.Collapsed += new System.Windows.RoutedEventHandler(this.HomeExpander_Collapsed);
            
            #line default
            #line hidden
            
            #line 38 "MainWindow_AutoGen.xaml"
            this.homeexpand.Expanded += new System.Windows.RoutedEventHandler(this.HomeExpander_Expanded_1);
            
            #line default
            #line hidden
            return;
            case 5:
            this.HomeBtn = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.HeaderBar = ((System.Windows.Controls.Grid)(target));
            return;
            case 7:
            
            #line 96 "MainWindow_AutoGen.xaml"
            ((System.Windows.Controls.Grid)(target)).PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Grid_PreviewMouseLeftButtonDown_1);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 98 "MainWindow_AutoGen.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 99 "MainWindow_AutoGen.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.SwitchWindowState);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 100 "MainWindow_AutoGen.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.MinimizeWindow);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

