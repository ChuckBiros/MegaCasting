﻿#pragma checksum "..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71A1935F26E4514FA7BEF0555BAE8C24E650AF13"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using MegaCasting.WPF;
using MegaCasting.WPF.Views;
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


namespace MegaCasting.WPF {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 39 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonMinimize;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonMaximize;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonExit;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonAnnouncer;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonOffers;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonContactType;
        
        #line default
        #line hidden
        
        
        #line 150 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel dockPanelMain;
        
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
            System.Uri resourceLocater = new System.Uri("/MegaCasting.WPF;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            
            #line 37 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.MainBar_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.buttonMinimize = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\MainWindow.xaml"
            this.buttonMinimize.Click += new System.Windows.RoutedEventHandler(this.ButtonMinimize_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.buttonMaximize = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\MainWindow.xaml"
            this.buttonMaximize.Click += new System.Windows.RoutedEventHandler(this.ButtonMaximize_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.buttonExit = ((System.Windows.Controls.Button)(target));
            
            #line 69 "..\..\MainWindow.xaml"
            this.buttonExit.Click += new System.Windows.RoutedEventHandler(this.ButtonExit_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.buttonAnnouncer = ((System.Windows.Controls.Button)(target));
            
            #line 83 "..\..\MainWindow.xaml"
            this.buttonAnnouncer.Click += new System.Windows.RoutedEventHandler(this.ButtonAnnouncer_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.buttonOffers = ((System.Windows.Controls.Button)(target));
            
            #line 102 "..\..\MainWindow.xaml"
            this.buttonOffers.Click += new System.Windows.RoutedEventHandler(this.ButtonOffers_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.buttonContactType = ((System.Windows.Controls.Button)(target));
            
            #line 121 "..\..\MainWindow.xaml"
            this.buttonContactType.Click += new System.Windows.RoutedEventHandler(this.ButtonContactType_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 135 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.MainBar_MouseDown);
            
            #line default
            #line hidden
            return;
            case 9:
            this.dockPanelMain = ((System.Windows.Controls.DockPanel)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

