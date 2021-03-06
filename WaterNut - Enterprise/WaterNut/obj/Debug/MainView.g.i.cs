﻿#pragma checksum "MainView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C1A725736D9BF69F1846EC6D15E70B81"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using AllocationDS.Client.Entities;
using Core.Common.UI;
using DocumentDS.Client.Entities;
using DocumentItemDS.Client.Entities;
using EntryDataDS.Client.Entities;
using InventoryDS.Client.Entities;
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
using WaterNut.QuerySpace;
using WaterNut.QuerySpace.CoreEntities.ViewModels;
using WaterNut.Views;


namespace WaterNut.Views {
    
    
    /// <summary>
    /// MainView
    /// </summary>
    public partial class MainView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 41 "MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid LayoutRoot;
        
        #line default
        #line hidden
        
        
        #line 42 "MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Core.Common.UI.SliderPanel slider;
        
        #line default
        #line hidden
        
        
        #line 54 "MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Expander CreateAsycudaDocumentExP;
        
        #line default
        #line hidden
        
        
        #line 65 "MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Expander AsycudaDocumentSummaryIntroExP;
        
        #line default
        #line hidden
        
        
        #line 76 "MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Expander CPPurchaseOrdersExP;
        
        #line default
        #line hidden
        
        
        #line 87 "MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Expander EntryDataExP;
        
        #line default
        #line hidden
        
        
        #line 97 "MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Expander PurchaseOrderDetailsExP;
        
        #line default
        #line hidden
        
        
        #line 107 "MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Expander TariffInventoryItemsExP;
        
        #line default
        #line hidden
        
        
        #line 119 "MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Expander TariffCodesExP;
        
        #line default
        #line hidden
        
        
        #line 129 "MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Expander TariffCategoryExP;
        
        #line default
        #line hidden
        
        
        #line 139 "MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Expander TariffSuppUnitsExP;
        
        #line default
        #line hidden
        
        
        #line 149 "MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Expander LicenceExP;
        
        #line default
        #line hidden
        
        
        #line 160 "MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Expander AsycudaDocumentSummaryExP;
        
        #line default
        #line hidden
        
        
        #line 170 "MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Expander CreateAsycudaDocument2ExP;
        
        #line default
        #line hidden
        
        
        #line 182 "MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Expander AsycudaDocumentsExP;
        
        #line default
        #line hidden
        
        
        #line 204 "MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Expander AsycudaEntrySummaryListExP;
        
        #line default
        #line hidden
        
        
        #line 214 "MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Expander SubItemsExp;
        
        #line default
        #line hidden
        
        
        #line 235 "MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Expander LicenceSummaryExP;
        
        #line default
        #line hidden
        
        
        #line 245 "MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Expander Ex9IntroExP;
        
        #line default
        #line hidden
        
        
        #line 255 "MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Expander SalesReportExP;
        
        #line default
        #line hidden
        
        
        #line 265 "MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Expander CPSalesExP;
        
        #line default
        #line hidden
        
        
        #line 275 "MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Expander QBSalesExP;
        
        #line default
        #line hidden
        
        
        #line 285 "MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Expander SalesDataExP;
        
        #line default
        #line hidden
        
        
        #line 294 "MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Expander SalesDataDetailsExP;
        
        #line default
        #line hidden
        
        
        #line 304 "MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Expander AllocationsExP;
        
        #line default
        #line hidden
        
        
        #line 314 "MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Expander PreviousEntriesExP;
        
        #line default
        #line hidden
        
        
        #line 324 "MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Expander PreviousItemsExP;
        
        #line default
        #line hidden
        
        
        #line 336 "MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Expander PreviousDocumentsExP;
        
        #line default
        #line hidden
        
        
        #line 346 "MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Expander OversShortExP;
        
        #line default
        #line hidden
        
        
        #line 356 "MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Expander OverShortDetailsExP;
        
        #line default
        #line hidden
        
        
        #line 366 "MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Expander OverShortDetailAllocationsExP;
        
        #line default
        #line hidden
        
        
        #line 376 "MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Expander OSPreviousEntriesExP;
        
        #line default
        #line hidden
        
        
        #line 386 "MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Expander OSPreviousItemsExP;
        
        #line default
        #line hidden
        
        
        #line 398 "MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Expander OSPreviousDocumentsExP;
        
        #line default
        #line hidden
        
        
        #line 410 "MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Header;
        
        #line default
        #line hidden
        
        
        #line 412 "MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContentControl CurrentItmCC;
        
        #line default
        #line hidden
        
        
        #line 442 "MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock BackBtn;
        
        #line default
        #line hidden
        
        
        #line 443 "MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContentControl CurrentAsycudaDocumentCC;
        
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
            System.Uri resourceLocater = new System.Uri("/WaterNut;component/mainview.xaml", System.UriKind.Relative);
            
            #line 1 "MainView.xaml"
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
            this.slider = ((Core.Common.UI.SliderPanel)(target));
            return;
            case 3:
            this.CreateAsycudaDocumentExP = ((System.Windows.Controls.Expander)(target));
            return;
            case 4:
            
            #line 56 "MainView.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.BringIntoView);
            
            #line default
            #line hidden
            return;
            case 5:
            this.AsycudaDocumentSummaryIntroExP = ((System.Windows.Controls.Expander)(target));
            return;
            case 6:
            
            #line 67 "MainView.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.BringIntoView);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 68 "MainView.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.BringIntoViewClick);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 69 "MainView.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.BringIntoViewClick);
            
            #line default
            #line hidden
            return;
            case 9:
            this.CPPurchaseOrdersExP = ((System.Windows.Controls.Expander)(target));
            return;
            case 10:
            
            #line 78 "MainView.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.BringIntoView);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 79 "MainView.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.BringIntoViewClick);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 80 "MainView.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.BringIntoViewClick);
            
            #line default
            #line hidden
            return;
            case 13:
            this.EntryDataExP = ((System.Windows.Controls.Expander)(target));
            return;
            case 14:
            
            #line 89 "MainView.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.BringIntoView);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 90 "MainView.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.BringIntoViewClick);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 91 "MainView.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.BringIntoViewClick);
            
            #line default
            #line hidden
            return;
            case 17:
            this.PurchaseOrderDetailsExP = ((System.Windows.Controls.Expander)(target));
            return;
            case 18:
            
            #line 99 "MainView.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.BringIntoView);
            
            #line default
            #line hidden
            return;
            case 19:
            
            #line 100 "MainView.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.BringIntoViewClick);
            
            #line default
            #line hidden
            return;
            case 20:
            
            #line 101 "MainView.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.BringIntoViewClick);
            
            #line default
            #line hidden
            return;
            case 21:
            this.TariffInventoryItemsExP = ((System.Windows.Controls.Expander)(target));
            return;
            case 22:
            
            #line 109 "MainView.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.BringIntoView);
            
            #line default
            #line hidden
            return;
            case 23:
            this.TariffCodesExP = ((System.Windows.Controls.Expander)(target));
            return;
            case 24:
            
            #line 121 "MainView.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.BringIntoView);
            
            #line default
            #line hidden
            return;
            case 25:
            this.TariffCategoryExP = ((System.Windows.Controls.Expander)(target));
            return;
            case 26:
            
            #line 131 "MainView.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.BringIntoView);
            
            #line default
            #line hidden
            return;
            case 27:
            this.TariffSuppUnitsExP = ((System.Windows.Controls.Expander)(target));
            return;
            case 28:
            
            #line 141 "MainView.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.BringIntoView);
            
            #line default
            #line hidden
            return;
            case 29:
            this.LicenceExP = ((System.Windows.Controls.Expander)(target));
            return;
            case 30:
            
            #line 151 "MainView.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.BringIntoView);
            
            #line default
            #line hidden
            return;
            case 31:
            this.AsycudaDocumentSummaryExP = ((System.Windows.Controls.Expander)(target));
            return;
            case 32:
            
            #line 162 "MainView.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.BringIntoView);
            
            #line default
            #line hidden
            return;
            case 33:
            this.CreateAsycudaDocument2ExP = ((System.Windows.Controls.Expander)(target));
            return;
            case 34:
            
            #line 172 "MainView.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.BringIntoView);
            
            #line default
            #line hidden
            return;
            case 35:
            this.AsycudaDocumentsExP = ((System.Windows.Controls.Expander)(target));
            return;
            case 36:
            
            #line 184 "MainView.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.BringIntoView);
            
            #line default
            #line hidden
            return;
            case 37:
            this.AsycudaEntrySummaryListExP = ((System.Windows.Controls.Expander)(target));
            return;
            case 38:
            
            #line 206 "MainView.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.BringIntoView);
            
            #line default
            #line hidden
            return;
            case 39:
            this.SubItemsExp = ((System.Windows.Controls.Expander)(target));
            return;
            case 40:
            
            #line 216 "MainView.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.BringIntoView);
            
            #line default
            #line hidden
            return;
            case 41:
            this.LicenceSummaryExP = ((System.Windows.Controls.Expander)(target));
            return;
            case 42:
            
            #line 237 "MainView.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.BringIntoView);
            
            #line default
            #line hidden
            return;
            case 43:
            this.Ex9IntroExP = ((System.Windows.Controls.Expander)(target));
            return;
            case 44:
            
            #line 247 "MainView.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.BringIntoView);
            
            #line default
            #line hidden
            return;
            case 45:
            
            #line 248 "MainView.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.BringIntoViewClick);
            
            #line default
            #line hidden
            return;
            case 46:
            
            #line 249 "MainView.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.BringIntoViewClick);
            
            #line default
            #line hidden
            return;
            case 47:
            this.SalesReportExP = ((System.Windows.Controls.Expander)(target));
            return;
            case 48:
            
            #line 257 "MainView.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.BringIntoView);
            
            #line default
            #line hidden
            return;
            case 49:
            this.CPSalesExP = ((System.Windows.Controls.Expander)(target));
            return;
            case 50:
            
            #line 267 "MainView.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.BringIntoView);
            
            #line default
            #line hidden
            return;
            case 51:
            
            #line 268 "MainView.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.BringIntoViewClick);
            
            #line default
            #line hidden
            return;
            case 52:
            
            #line 269 "MainView.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.BringIntoViewClick);
            
            #line default
            #line hidden
            return;
            case 53:
            this.QBSalesExP = ((System.Windows.Controls.Expander)(target));
            return;
            case 54:
            
            #line 277 "MainView.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.BringIntoView);
            
            #line default
            #line hidden
            return;
            case 55:
            
            #line 278 "MainView.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.BringIntoViewClick);
            
            #line default
            #line hidden
            return;
            case 56:
            
            #line 279 "MainView.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.BringIntoViewClick);
            
            #line default
            #line hidden
            return;
            case 57:
            this.SalesDataExP = ((System.Windows.Controls.Expander)(target));
            return;
            case 58:
            
            #line 287 "MainView.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.BringIntoView);
            
            #line default
            #line hidden
            return;
            case 59:
            this.SalesDataDetailsExP = ((System.Windows.Controls.Expander)(target));
            return;
            case 60:
            
            #line 296 "MainView.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.BringIntoView);
            
            #line default
            #line hidden
            return;
            case 61:
            this.AllocationsExP = ((System.Windows.Controls.Expander)(target));
            return;
            case 62:
            
            #line 306 "MainView.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.BringIntoView);
            
            #line default
            #line hidden
            return;
            case 63:
            this.PreviousEntriesExP = ((System.Windows.Controls.Expander)(target));
            return;
            case 64:
            
            #line 316 "MainView.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.BringIntoView);
            
            #line default
            #line hidden
            return;
            case 65:
            this.PreviousItemsExP = ((System.Windows.Controls.Expander)(target));
            return;
            case 66:
            
            #line 326 "MainView.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.BringIntoView);
            
            #line default
            #line hidden
            return;
            case 67:
            this.PreviousDocumentsExP = ((System.Windows.Controls.Expander)(target));
            return;
            case 68:
            
            #line 338 "MainView.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.BringIntoView);
            
            #line default
            #line hidden
            return;
            case 69:
            this.OversShortExP = ((System.Windows.Controls.Expander)(target));
            return;
            case 70:
            
            #line 348 "MainView.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.BringIntoView);
            
            #line default
            #line hidden
            return;
            case 71:
            this.OverShortDetailsExP = ((System.Windows.Controls.Expander)(target));
            return;
            case 72:
            
            #line 358 "MainView.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.BringIntoView);
            
            #line default
            #line hidden
            return;
            case 73:
            this.OverShortDetailAllocationsExP = ((System.Windows.Controls.Expander)(target));
            return;
            case 74:
            
            #line 368 "MainView.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.BringIntoView);
            
            #line default
            #line hidden
            return;
            case 75:
            this.OSPreviousEntriesExP = ((System.Windows.Controls.Expander)(target));
            return;
            case 76:
            
            #line 378 "MainView.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.BringIntoView);
            
            #line default
            #line hidden
            return;
            case 77:
            this.OSPreviousItemsExP = ((System.Windows.Controls.Expander)(target));
            return;
            case 78:
            
            #line 388 "MainView.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.BringIntoView);
            
            #line default
            #line hidden
            return;
            case 79:
            this.OSPreviousDocumentsExP = ((System.Windows.Controls.Expander)(target));
            return;
            case 80:
            
            #line 400 "MainView.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.BringIntoView);
            
            #line default
            #line hidden
            return;
            case 81:
            this.Header = ((System.Windows.Controls.Grid)(target));
            return;
            case 82:
            this.CurrentItmCC = ((System.Windows.Controls.ContentControl)(target));
            return;
            case 83:
            this.BackBtn = ((System.Windows.Controls.TextBlock)(target));
            
            #line 442 "MainView.xaml"
            this.BackBtn.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.BackBtn_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 84:
            this.CurrentAsycudaDocumentCC = ((System.Windows.Controls.ContentControl)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

