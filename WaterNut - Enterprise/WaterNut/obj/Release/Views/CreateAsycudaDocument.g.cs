﻿#pragma checksum "..\..\..\Views\CreateAsycudaDocument.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4400692318223AF5F8B0C3FE39408555"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
    /// CreateAsycudaDocument
    /// </summary>
    public partial class CreateAsycudaDocument : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\Views\CreateAsycudaDocument.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid LayoutRoot;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Views\CreateAsycudaDocument.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock SaveBtn;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Views\CreateAsycudaDocument.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock DeleteBtn;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\Views\CreateAsycudaDocument.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock NewBtn;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\Views\CreateAsycudaDocument.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock CreateSetTxt;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\Views\CreateAsycudaDocument.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ManuallyAssessAll;
        
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
            System.Uri resourceLocater = new System.Uri("/WaterNut;component/views/createasycudadocument.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\CreateAsycudaDocument.xaml"
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
            this.SaveBtn = ((System.Windows.Controls.TextBlock)(target));
            
            #line 50 "..\..\..\Views\CreateAsycudaDocument.xaml"
            this.SaveBtn.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.SaveBtn_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.DeleteBtn = ((System.Windows.Controls.TextBlock)(target));
            
            #line 51 "..\..\..\Views\CreateAsycudaDocument.xaml"
            this.DeleteBtn.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.DeleteBtn_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.NewBtn = ((System.Windows.Controls.TextBlock)(target));
            
            #line 52 "..\..\..\Views\CreateAsycudaDocument.xaml"
            this.NewBtn.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.NewBtn_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.CreateSetTxt = ((System.Windows.Controls.TextBlock)(target));
            
            #line 63 "..\..\..\Views\CreateAsycudaDocument.xaml"
            this.CreateSetTxt.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.CreateSet);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ManuallyAssessAll = ((System.Windows.Controls.TextBlock)(target));
            
            #line 65 "..\..\..\Views\CreateAsycudaDocument.xaml"
            this.ManuallyAssessAll.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.AssessAll);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

