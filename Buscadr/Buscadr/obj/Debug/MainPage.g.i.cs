﻿#pragma checksum "C:\Users\User\documents\visual studio 2013\Projects\Buscadr\Buscadr\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "43BEF6F5271F6DF97E569B43B23414BA"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.34209
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace Buscadr {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.StackPanel search;
        
        internal System.Windows.Controls.StackPanel coment;
        
        internal System.Windows.Controls.StackPanel importa;
        
        internal System.Windows.Controls.StackPanel categories;
        
        internal Microsoft.Phone.Controls.LongListSelector longlistselector;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/Buscadr;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.search = ((System.Windows.Controls.StackPanel)(this.FindName("search")));
            this.coment = ((System.Windows.Controls.StackPanel)(this.FindName("coment")));
            this.importa = ((System.Windows.Controls.StackPanel)(this.FindName("importa")));
            this.categories = ((System.Windows.Controls.StackPanel)(this.FindName("categories")));
            this.longlistselector = ((Microsoft.Phone.Controls.LongListSelector)(this.FindName("longlistselector")));
        }
    }
}

