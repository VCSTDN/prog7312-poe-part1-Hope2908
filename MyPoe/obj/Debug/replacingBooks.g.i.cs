﻿#pragma checksum "..\..\replacingBooks.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E93352901418B8DE76F8BCDA2766291A469F05F894AF4079B993BE05A18272B9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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


namespace LibraryApp {
    
    
    /// <summary>
    /// Sorting
    /// </summary>
    public partial class Sorting : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\replacingBooks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox CallNumbersListBox;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\replacingBooks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel NumberButtonsStackPanel;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\replacingBooks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SortButton;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\replacingBooks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Star1;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\replacingBooks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Star2;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\replacingBooks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Star3;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\replacingBooks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Star4;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\replacingBooks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Star5;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\replacingBooks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox SortedCallNumbersListBox;
        
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
            System.Uri resourceLocater = new System.Uri("/MyPoe;component/replacingbooks.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\replacingBooks.xaml"
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
            
            #line 15 "..\..\replacingBooks.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GenerateRandomCallNumbers_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.CallNumbersListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 3:
            this.NumberButtonsStackPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 4:
            this.SortButton = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\replacingBooks.xaml"
            this.SortButton.Click += new System.Windows.RoutedEventHandler(this.SortButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Star1 = ((System.Windows.Controls.Image)(target));
            
            #line 40 "..\..\replacingBooks.xaml"
            this.Star1.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Star_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Star2 = ((System.Windows.Controls.Image)(target));
            
            #line 41 "..\..\replacingBooks.xaml"
            this.Star2.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Star_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Star3 = ((System.Windows.Controls.Image)(target));
            
            #line 42 "..\..\replacingBooks.xaml"
            this.Star3.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Star_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Star4 = ((System.Windows.Controls.Image)(target));
            
            #line 43 "..\..\replacingBooks.xaml"
            this.Star4.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Star_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Star5 = ((System.Windows.Controls.Image)(target));
            
            #line 44 "..\..\replacingBooks.xaml"
            this.Star5.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Star_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.SortedCallNumbersListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

