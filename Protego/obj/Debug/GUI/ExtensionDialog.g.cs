﻿#pragma checksum "..\..\..\GUI\ExtensionDialog.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "EA47850899FB7BF11AF977A7CC8A907D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Protego.GUI;
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


namespace Protego.GUI {
    
    
    /// <summary>
    /// ExtensionDialog
    /// </summary>
    public partial class ExtensionDialog : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\GUI\ExtensionDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label extensionLabel;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\GUI\ExtensionDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox extensionTextbox;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\GUI\ExtensionDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GroupBox descriptionGroup;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\GUI\ExtensionDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox descriptionTextbox;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\GUI\ExtensionDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonCancel;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\GUI\ExtensionDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonOK;
        
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
            System.Uri resourceLocater = new System.Uri("/Protego;component/gui/extensiondialog.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\GUI\ExtensionDialog.xaml"
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
            this.extensionLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.extensionTextbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.descriptionGroup = ((System.Windows.Controls.GroupBox)(target));
            return;
            case 4:
            this.descriptionTextbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.buttonCancel = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\GUI\ExtensionDialog.xaml"
            this.buttonCancel.Click += new System.Windows.RoutedEventHandler(this.clickCancel);
            
            #line default
            #line hidden
            return;
            case 6:
            this.buttonOK = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\GUI\ExtensionDialog.xaml"
            this.buttonOK.Click += new System.Windows.RoutedEventHandler(this.clickOK);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
