﻿#pragma checksum "..\..\..\FrmPrincipal.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6083932E389BEA7A72A336CE6168B8F7"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.34209
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
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
using System.Windows.Forms.Integration;
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


namespace Pry_Histodontolgy.Presentacion {
    
    
    /// <summary>
    /// FrmPrincipal
    /// </summary>
    public partial class FrmPrincipal : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 100 "..\..\..\FrmPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid LayoutRoot;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\..\FrmPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle Rectangulo_Contenedor;
        
        #line default
        #line hidden
        
        
        #line 147 "..\..\..\FrmPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAbajo;
        
        #line default
        #line hidden
        
        
        #line 167 "..\..\..\FrmPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Menu MenuItem;
        
        #line default
        #line hidden
        
        
        #line 168 "..\..\..\FrmPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem ItemSalir;
        
        #line default
        #line hidden
        
        
        #line 170 "..\..\..\FrmPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem ItmPacientes;
        
        #line default
        #line hidden
        
        
        #line 171 "..\..\..\FrmPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem ItmCitas;
        
        #line default
        #line hidden
        
        
        #line 172 "..\..\..\FrmPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem itemUsuario;
        
        #line default
        #line hidden
        
        
        #line 174 "..\..\..\FrmPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem ItemReporte;
        
        #line default
        #line hidden
        
        
        #line 176 "..\..\..\FrmPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSalir;
        
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
            System.Uri resourceLocater = new System.Uri("/Pry_Histodontolgy.Presentacion;component/frmprincipal.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\FrmPrincipal.xaml"
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
            this.Rectangulo_Contenedor = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 3:
            this.btnAbajo = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.MenuItem = ((System.Windows.Controls.Menu)(target));
            return;
            case 5:
            this.ItemSalir = ((System.Windows.Controls.MenuItem)(target));
            
            #line 168 "..\..\..\FrmPrincipal.xaml"
            this.ItemSalir.Click += new System.Windows.RoutedEventHandler(this.ItemSalir_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ItmPacientes = ((System.Windows.Controls.MenuItem)(target));
            
            #line 170 "..\..\..\FrmPrincipal.xaml"
            this.ItmPacientes.Click += new System.Windows.RoutedEventHandler(this.ItmPacientes_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ItmCitas = ((System.Windows.Controls.MenuItem)(target));
            
            #line 171 "..\..\..\FrmPrincipal.xaml"
            this.ItmCitas.Click += new System.Windows.RoutedEventHandler(this.ItmCitas_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.itemUsuario = ((System.Windows.Controls.MenuItem)(target));
            
            #line 172 "..\..\..\FrmPrincipal.xaml"
            this.itemUsuario.Click += new System.Windows.RoutedEventHandler(this.itemUsuario_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.ItemReporte = ((System.Windows.Controls.MenuItem)(target));
            
            #line 174 "..\..\..\FrmPrincipal.xaml"
            this.ItemReporte.Click += new System.Windows.RoutedEventHandler(this.ItemReporte_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnSalir = ((System.Windows.Controls.Button)(target));
            
            #line 176 "..\..\..\FrmPrincipal.xaml"
            this.btnSalir.Click += new System.Windows.RoutedEventHandler(this.btnSalir_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

