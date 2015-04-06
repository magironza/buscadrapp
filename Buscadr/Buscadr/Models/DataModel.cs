using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buscadr.Models
{
    public class DataModel
    {
        private ObservableCollection<Comentario> data;
        public ObservableCollection<Comentario> Data
        {
            get
            {
                if (data == null)
                    data = new ObservableCollection<Comentario>();

                    return data;
            }
                    set{
                        data = value;


                    }


        }
    }
}
