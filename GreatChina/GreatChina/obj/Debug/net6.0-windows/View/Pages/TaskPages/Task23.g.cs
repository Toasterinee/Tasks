﻿#pragma checksum "..\..\..\..\..\..\View\Pages\TaskPages\Task23.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43E56C60CBEC246EBBC5E8F87731BA8B08F06F63"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using GreatChina.View.Pages.TaskPages;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace GreatChina.View.Pages.TaskPages {
    
    
    /// <summary>
    /// Task23
    /// </summary>
    public partial class Task23 : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\..\..\..\..\View\Pages\TaskPages\Task23.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBd;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\..\..\View\Pages\TaskPages\Task23.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBy;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\..\..\View\Pages\TaskPages\Task23.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN23;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\..\..\View\Pages\TaskPages\Task23.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnBack;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.2.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/GreatChina;component/view/pages/taskpages/task23.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\View\Pages\TaskPages\Task23.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.TBd = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.TBy = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.BTN23 = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\..\..\..\View\Pages\TaskPages\Task23.xaml"
            this.BTN23.Click += new System.Windows.RoutedEventHandler(this.BTN23_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BtnBack = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\..\..\..\..\View\Pages\TaskPages\Task23.xaml"
            this.BtnBack.Click += new System.Windows.RoutedEventHandler(this.BtnBack_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

