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



        private void BuildLocalizedApplicationBar()
        {
            // Establecer ApplicationBar de la página en una nueva instancia de ApplicationBar.
            ApplicationBar = new ApplicationBar();

            // Crear un nuevo botón y establecer el valor de texto en la cadena traducida de AppResources.
            ApplicationBarIconButton addButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
            addButton.Text = AppResources.AppBarButtonText;
            addButton.Click += action_Click;


            ApplicationBar.Buttons.Add(addButton);

            // Crear un nuevo elemento de menú con la cadena traducida de AppResources.
            ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
         
        }

        void action_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/AddMedico.xaml", UriKind.Relative));
        }
    }
}