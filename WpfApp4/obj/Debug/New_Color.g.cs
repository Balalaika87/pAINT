﻿#pragma checksum "..\..\New_Color.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FBC6F28F69B48E2DB47B820803CB3DD9B444C50BA1619B47B3F194404289F340"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using WpfApp4;


namespace WpfApp4 {
    
    
    /// <summary>
    /// New_Color
    /// </summary>
    public partial class New_Color : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\New_Color.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider slider1;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\New_Color.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TB1;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\New_Color.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider slider2;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\New_Color.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TB2;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\New_Color.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider slider3;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\New_Color.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TB3;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\New_Color.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle r1;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp4;component/new_color.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\New_Color.xaml"
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
            this.slider1 = ((System.Windows.Controls.Slider)(target));
            
            #line 22 "..\..\New_Color.xaml"
            this.slider1.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.slider1_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TB1 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.slider2 = ((System.Windows.Controls.Slider)(target));
            
            #line 36 "..\..\New_Color.xaml"
            this.slider2.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.slider1_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TB2 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.slider3 = ((System.Windows.Controls.Slider)(target));
            
            #line 50 "..\..\New_Color.xaml"
            this.slider3.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.slider1_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.TB3 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.r1 = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 8:
            
            #line 67 "..\..\New_Color.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

