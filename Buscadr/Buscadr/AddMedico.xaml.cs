using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Buscadr.Models;
using Buscadr.Net;

namespace Buscadr
{
    public partial class AddMedico : PhoneApplicationPage
    {
        Mongo<Comentario> mongo;
         
        public AddMedico()
        {
           
            InitializeComponent();
            mongo = new Mongo<Comentario>("ppZxpAloVZB2iYVatT1rEz_6_bXUf0RJ","listadrpop", "");
        }

        private void SaveDr(object sender, RoutedEventArgs e)
        {
            Comentario c = new Comentario()
            {
                Institucion = institucion.Text,
                Especialidad = especialidad.Text,
                Medico = medico.Text,
                Direccion = direccion.Text
            };

            mongo.insertDocument(c);
        }
    }
}