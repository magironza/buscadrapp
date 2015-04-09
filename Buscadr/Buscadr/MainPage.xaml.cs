using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Buscadr.Resources;

namespace Buscadr
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Código de ejemplo para traducir ApplicationBar
            //BuildLocalizedApplicationBar();
        }











       

        private void gotopage1(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Busqueda.xaml", UriKind.Relative));
        }

        private void gotopage2(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Final.xaml", UriKind.Relative));
        }

        private void gotopage3(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Categoria.xaml", UriKind.Relative));
        }

        private void gotopage4(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Filtros.xaml", UriKind.Relative));
        }



        protected override void OnBackKeyPress(System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult x = MessageBox.Show("Desea salir de la Aplicación?","", MessageBoxButton.OKCancel);

            if (x == MessageBoxResult.OK)
            {
                NavigationService.RemoveBackEntry();
            }
            else
            {
                e.Cancel = true;
            }


        }

       
    }
}