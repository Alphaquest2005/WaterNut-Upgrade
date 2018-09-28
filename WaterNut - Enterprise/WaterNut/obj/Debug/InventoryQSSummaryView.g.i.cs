﻿#pragma checksum "InventoryQSSummaryView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "998286D6B2894AA8D5E66FFEBE6FCB55"
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
using Core.Common.UI.DataVirtualization;
using InventoryQS.Client.Entities;
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
using WaterNut.QuerySpace.InventoryQS.ViewModels;
using WaterNut.QuerySpace.InventoryQS.Views;


namespace WaterNut.QuerySpace.InventoryQS.Views {
    
    
    /// <summary>
    /// InventoryQSSummaryView
    /// </summary>
    public partial class InventoryQSSummaryView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 71 "InventoryQSSummaryView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid LayoutRoot;
        
        #line default
        #line hidden
        
        
        #line 83 "InventoryQSSummaryView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Core.Common.UI.SliderPanel TariffCategoryslider;
        
        #line default
        #line hidden
        
        
        #line 87 "InventoryQSSummaryView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Expander InventoryItemsExListEXP;
        
        #line default
        #line hidden
        
        
        #line 98 "InventoryQSSummaryView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Expander TariffCategoryListEXP;
        
        #line default
        #line hidden
        
        
        #line 109 "InventoryQSSummaryView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Expander TariffCodesListEXP;
        
        #line default
        #line hidden
        
        
        #line 120 "InventoryQSSummaryView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Expander TariffSupUnitLkpsListEXP;
        
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
            System.Uri resourceLocater = new System.Uri("/WaterNut;component/inventoryqssummaryview.xaml", System.UriKind.Relative);
            
            #line 1 "InventoryQSSummaryView.xaml"
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
            this.LayoutRoot = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.TariffCategoryslider = ((Core.Common.UI.SliderPanel)(target));
            return;
            case 3:
            this.InventoryItemsExListEXP = ((System.Windows.Controls.Expander)(target));
            return;
            case 4:
            
            #line 89 "InventoryQSSummaryView.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.BringIntoView);
            
            #line default
            #line hidden
            return;
            case 5:
            this.TariffCategoryListEXP = ((System.Windows.Controls.Expander)(target));
            return;
            case 6:
            
            #line 100 "InventoryQSSummaryView.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.BringIntoView);
            
            #line default
            #line hidden
            return;
            case 7:
            this.TariffCodesListEXP = ((System.Windows.Controls.Expander)(target));
            return;
            case 8:
            
            #line 111 "InventoryQSSummaryView.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.BringIntoView);
            
            #line default
            #line hidden
            return;
            case 9:
            this.TariffSupUnitLkpsListEXP = ((System.Windows.Controls.Expander)(target));
            return;
            case 10:
            
            #line 122 "InventoryQSSummaryView.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.BringIntoView);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 136 "InventoryQSSummaryView.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.GoToInventoryItemsEx);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 138 "InventoryQSSummaryView.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.GoToTariffCodes);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 140 "InventoryQSSummaryView.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.GoToTariffSupUnitLkps);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

