﻿#pragma checksum "..\..\Window5.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D353B62E3864CDFFCA179D7E1A719ADBCE5CF5A17D86BB2BD10E2F9170E45A23"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using CourseProject;
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


namespace CourseProject {
    
    
    /// <summary>
    /// Window5
    /// </summary>
    public partial class Window5 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\Window5.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal CourseProject.Window5 SixthForm;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\Window5.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button InfButton;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\Window5.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AdditionButton;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\Window5.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ExitButton;
        
        #line default
        #line hidden
        
        
        #line 149 "..\..\Window5.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ParTBK;
        
        #line default
        #line hidden
        
        
        #line 150 "..\..\Window5.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ChilTBK;
        
        #line default
        #line hidden
        
        
        #line 154 "..\..\Window5.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock DateBeginTBK;
        
        #line default
        #line hidden
        
        
        #line 160 "..\..\Window5.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock SumTBK;
        
        #line default
        #line hidden
        
        
        #line 164 "..\..\Window5.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock DateEndTBK;
        
        #line default
        #line hidden
        
        
        #line 168 "..\..\Window5.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CodeTB;
        
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
            System.Uri resourceLocater = new System.Uri("/CourseProject;component/window5.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Window5.xaml"
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
            this.SixthForm = ((CourseProject.Window5)(target));
            return;
            case 2:
            
            #line 22 "..\..\Window5.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Grid_MouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.InfButton = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\Window5.xaml"
            this.InfButton.Click += new System.Windows.RoutedEventHandler(this.InfButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.AdditionButton = ((System.Windows.Controls.Button)(target));
            
            #line 86 "..\..\Window5.xaml"
            this.AdditionButton.Click += new System.Windows.RoutedEventHandler(this.AdditionButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ExitButton = ((System.Windows.Controls.Button)(target));
            
            #line 119 "..\..\Window5.xaml"
            this.ExitButton.Click += new System.Windows.RoutedEventHandler(this.ExitButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ParTBK = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.ChilTBK = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.DateBeginTBK = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.SumTBK = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.DateEndTBK = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 11:
            this.CodeTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            
            #line 169 "..\..\Window5.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

