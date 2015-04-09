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
using Buscadr.Net;
using Buscadr.Models;




namespace Buscadr
{
    public partial class Busqueda : PhoneApplicationPage, Mongo<Busca>.Imongo
    {
        Mongo<Busca> mongo;

        public Busqueda()
        {
            InitializeComponent();
            mongo = new Mongo<Busca>("ppZxpAloVZB2iYVatT1rEz_6_bXUf0RJ", "listadrpop", "drpopayan");
            mongo.findAllDocuments(this);
        }

        public void loadDocuments(List<Busca> documents)
        {
            DataModel dataM = Application.Current.Resources["dataModel"] as DataModel;

            for (int i = 0; i < documents.Count; i++)
            {
                dataM.Data.Add(documents.ElementAt(i));
            }
        }

        private void Gopage(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Final.xaml", UriKind.Relative));
        }

        



    }
}