﻿#pragma checksum "..\..\..\Window5.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4DD1A05110E650262EFB0FE10BD2801BCD21C193"
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
    /// Window5
    /// </summary>
    public partial class Window5 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\Window5.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbname;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Window5.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblogin;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Window5.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbpass;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Window5.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbemail;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Window5.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbwlogin;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Window5.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tblogin;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Window5.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbemail;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Window5.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbpass;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Window5.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbpass2;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Window5.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnreg;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Window5.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbpass_Copy;
        
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
            System.Uri resourceLocater = new System.Uri("/kursachwpf;component/window5.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Window5.xaml"
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
            this.lbname = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.lblogin = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.lbpass = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.lbemail = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.lbwlogin = ((System.Windows.Controls.Label)(target));
            
            #line 26 "..\..\..\Window5.xaml"
            this.lbwlogin.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.lbwlogin_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.tblogin = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.tbemail = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.tbpass = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.tbpass2 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.btnreg = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\Window5.xaml"
            this.btnreg.Click += new System.Windows.RoutedEventHandler(this.btnreg_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.lbpass_Copy = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

