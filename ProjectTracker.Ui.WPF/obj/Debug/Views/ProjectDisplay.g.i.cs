﻿#pragma checksum "..\..\..\Views\ProjectDisplay.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FE1AFC73E615A801E22A748DC45BE79681E23905236CBFBABCC97ADFE22C04F3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bxf.Xaml;
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
using WpfUI.ViewModels;


namespace WpfUI.Views {
    
    
    /// <summary>
    /// ProjectDisplay
    /// </summary>
    public partial class ProjectDisplay : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\Views\ProjectDisplay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid LayoutRoot;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Views\ProjectDisplay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grid1;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Views\ProjectDisplay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock nameTextBlock;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Views\ProjectDisplay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock startedTextBlock;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Views\ProjectDisplay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock endedTextBlock;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Views\ProjectDisplay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox descriptionTextBox;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Views\ProjectDisplay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ResourcesListBox;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfUI;component/views/projectdisplay.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\ProjectDisplay.xaml"
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
            this.LayoutRoot = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.grid1 = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.nameTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.startedTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.endedTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.descriptionTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.ResourcesListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
