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
        private ObservableCollection<Busca> data;
        public ObservableCollection<Busca> Data
        {
            get
            {
                if (data == null)
                    data = new ObservableCollection<Busca>();

                    return data;
            }
                    set{
                        data = value;


                    }


        }
    }
}
