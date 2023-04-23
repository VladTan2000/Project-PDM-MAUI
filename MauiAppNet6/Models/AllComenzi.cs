using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppNet6.Models
{
    public class AllComenzi
    {
        public ObservableCollection<Comanda> Comenzi { get; set; } = new ObservableCollection<Comanda>();

        public AllComenzi() => LoadComenzi();
        public AllComenzi(Utilizator utilizator) => LoadComenzi(utilizator);

        public void LoadComenzi() {
            ObservableCollection<Comanda> temp = App.ComenziRepository.GetAllPerUtilizator();
            for (int i = 0; i < temp.Count; i++)
            {
                Comenzi.Add(temp[i]);
            }
        }
        public void LoadComenzi(Utilizator utilizator)
        {
            ObservableCollection<Comanda> temp = App.ComenziRepository.GetAllPerUtilizator(utilizator);
            for (int i = 0; i < temp.Count; i++)
            {
                Comenzi.Add(temp[i]);
            }
        }
    }
}
