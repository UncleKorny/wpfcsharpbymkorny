﻿#pragma checksum "..\..\..\Window6.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3522449D64B64183FBA9ABCB73F5D1F52C4BFDB0"
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
using System.Windows.Controls.Ribbon;
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
using kursachwpf;


namespace kursachwpf {
    
    
    /// <summary>
    /// Window6
    /// </summary>
    public partial class Window6 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\Window6.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock lblemail;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Window6.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock lblnewpass;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Window6.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbemail;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Window6.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbnewpass;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Window6.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnsend;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Window6.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnsetnewpass;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/kursachwpf;component/window6.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Window6.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\..\Window6.xaml"
            ((kursachwpf.Window6)(target)).Closed += new System.EventHandler(this.Window_Closed);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lblemail = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.lblnewpass = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.tbemail = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.tbnewpass = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.btnsend = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\Window6.xaml"
            this.btnsend.Click += new System.Windows.RoutedEventHandler(this.btnsend_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnsetnewpass = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\Window6.xaml"
            this.btnsetnewpass.Click += new System.Windows.RoutedEventHandler(this.btnsetnewpass_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
