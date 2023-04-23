using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAppNet6
{
    public class Pachet
    {
        public int id { get; set; }
        public int locuri { get; set; }
        public string locatie { get; set; }
        public int numarZile { get; set; }
        public double pret { get; set; }
        public int numarPers { get; set; }
        public string descriere { get; set; }
        public List<String> imageURL { get; set; }
        public string thumbnail { get; set; }
        public DateTime minDate { get; set; }
        public DateTime maxDate { get; set;}
    }

    public class Pachete
    {
        public ObservableCollection<Pachet> pachete { get; set; }
    }
}
