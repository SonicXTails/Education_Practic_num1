﻿#pragma checksum "..\..\DataSet_Page.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9E307597A0D07B83B97AE4D15F0BB228F3AE5FC1E2C5EF84C29EB87DA881663D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Education_Practic_num_1;
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


namespace Education_Practic_num_1 {
    
    
    /// <summary>
    /// DataSet_Page
    /// </summary>
    public partial class DataSet_Page : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 35 "..\..\DataSet_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid Products_DataGrid;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\DataSet_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid Stock_DataGrid;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\DataSet_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Open_Table_Products;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\DataSet_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Open_Table_Stock;
        
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
            System.Uri resourceLocater = new System.Uri("/Education_Practic_num-1;component/dataset_page.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\DataSet_Page.xaml"
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
            this.Products_DataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.Stock_DataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.Open_Table_Products = ((System.Windows.Controls.Button)(target));
            
            #line 61 "..\..\DataSet_Page.xaml"
            this.Open_Table_Products.Click += new System.Windows.RoutedEventHandler(this.Open_Table_Products_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Open_Table_Stock = ((System.Windows.Controls.Button)(target));
            
            #line 65 "..\..\DataSet_Page.xaml"
            this.Open_Table_Stock.Click += new System.Windows.RoutedEventHandler(this.Open_Table_Stock_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

