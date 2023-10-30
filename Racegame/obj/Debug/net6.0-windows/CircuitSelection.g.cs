﻿#pragma checksum "..\..\..\CircuitSelection.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B33624BF0A33654BDC03AA6E1A9B9107E9E48851"
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
    public partial class CircuitSelection : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\CircuitSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LeftButton;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\CircuitSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RightButton;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\CircuitSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid imageContainer1;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\CircuitSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image image1;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\CircuitSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid imageContainer2;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\CircuitSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image image2;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\CircuitSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid imageContainer3;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\CircuitSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image image3;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.11.0")]
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
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.11.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.LeftButton = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\CircuitSelection.xaml"
            this.LeftButton.Click += new System.Windows.RoutedEventHandler(this.PreviousImage_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.RightButton = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\CircuitSelection.xaml"
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
            case 9:
            
            #line 74 "..\..\..\CircuitSelection.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.StartGame);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

