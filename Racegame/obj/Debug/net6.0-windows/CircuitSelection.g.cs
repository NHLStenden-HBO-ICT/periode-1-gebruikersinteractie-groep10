﻿#pragma checksum "..\..\..\CircuitSelection.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2F111E617BCE255A87658AA5D3235D634C1FA1D8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Racegame;
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


namespace Racegame {
    
    
    /// <summary>
    /// CircuitSelection
    /// </summary>
    public partial class CircuitSelection : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\CircuitSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LeftButton;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\CircuitSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RightButton;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\CircuitSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid imageContainer1;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\CircuitSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image image1;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\CircuitSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid imageContainer2;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\CircuitSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image image2;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\CircuitSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid imageContainer3;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\CircuitSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image image3;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.12.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Racegame;component/circuitselection.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\CircuitSelection.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.12.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.LeftButton = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\..\CircuitSelection.xaml"
            this.LeftButton.Click += new System.Windows.RoutedEventHandler(this.PreviousImage_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.RightButton = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\CircuitSelection.xaml"
            this.RightButton.Click += new System.Windows.RoutedEventHandler(this.NextImage_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.imageContainer1 = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.image1 = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.imageContainer2 = ((System.Windows.Controls.Grid)(target));
            return;
            case 6:
            this.image2 = ((System.Windows.Controls.Image)(target));
            return;
            case 7:
            this.imageContainer3 = ((System.Windows.Controls.Grid)(target));
            return;
            case 8:
            this.image3 = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

