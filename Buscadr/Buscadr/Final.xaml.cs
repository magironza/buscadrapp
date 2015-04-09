using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Buscadr.Net;
using Buscadr.Models;
using Microsoft.Phone.Maps.Controls;
using System.Device.Location;

namespace Buscadr
{
    public partial class Final : PhoneApplicationPage, Mongo<Busca>.Imongo
    {

        Mongo<Busca> mongo;
        public Final()
        {
             
            InitializeComponent();
     
          
            mongo = new Mongo<Busca>("ppZxpAloVZB2iYVatT1rEz_6_bXUf0RJ", "listadrpop" , "drpopayan");
            mongo.findAllDocuments(this);
        }

        public void loadDocuments(List<Busca> documents)
        {
            DataModel dataM = Application.Current.Resources["dataModel"] as DataModel;

            for (int i = 0; i < documents.Count; i++)
            {
                dataM.Data.Add(documents.ElementAt(i));
            }



            Map mapa = new Map();
            mapa.ZoomLevel = 6;
            Mapas.Children.Add(mapa);


        }

       
    }
    
}