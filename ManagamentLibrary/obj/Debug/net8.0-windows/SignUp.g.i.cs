﻿#pragma checksum "..\..\..\SignUp.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4BCCBDA99769CDAB5F1253AF2664E2783C1009D2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ManagamentLibrary;
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


namespace ManagamentLibrary {
    
    
    /// <summary>
    /// SignUp
    /// </summary>
    public partial class SignUp : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\SignUp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnArrow;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\SignUp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UsernameTextBox;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\SignUp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PasswordTextBox;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\SignUp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox VisiblePasswordTextBox;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\SignUp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button TogglePasswordVisibilityButton;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\SignUp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EmailTextBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ManagamentLibrary;component/signup.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\SignUp.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.btnArrow = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\..\SignUp.xaml"
            this.btnArrow.Click += new System.Windows.RoutedEventHandler(this.btnArrow_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.UsernameTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 17 "..\..\..\SignUp.xaml"
            this.UsernameTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.TextBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 17 "..\..\..\SignUp.xaml"
            this.UsernameTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.TextBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 3:
            this.PasswordTextBox = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 23 "..\..\..\SignUp.xaml"
            this.PasswordTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.PasswordBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 23 "..\..\..\SignUp.xaml"
            this.PasswordTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.PasswordBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 4:
            this.VisiblePasswordTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 25 "..\..\..\SignUp.xaml"
            this.VisiblePasswordTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.PasswordBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 25 "..\..\..\SignUp.xaml"
            this.VisiblePasswordTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.PasswordBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 5:
            this.TogglePasswordVisibilityButton = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\SignUp.xaml"
            this.TogglePasswordVisibilityButton.Click += new System.Windows.RoutedEventHandler(this.TogglePasswordVisibilityButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.EmailTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 36 "..\..\..\SignUp.xaml"
            this.EmailTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.EmailBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 36 "..\..\..\SignUp.xaml"
            this.EmailTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.EmailBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 37 "..\..\..\SignUp.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SignUpAdmin_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

