using MainAppNet6;
using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppNet6.Models
{
    [Table("Comenzi")]
    public class Comanda
    {
        [PrimaryKey,AutoIncrement,Column("id")]
        public int id { get; set; }
        public int  idpachet { get; set; }
        [OneToOne(CascadeOperations = CascadeOperation.All)]
        public Utilizator utilizator { get; set; }
        [ForeignKey(typeof(Utilizator))]
        public int idUtilizator { get; set; }
        [Ignore]
        public Pachet pachet { get; set; }
        public DateTime inceperePachet { get; set; }
        public DateTime terminarePachet { get; set; }

        public Comanda( int idUtilizator,int idpachet, Utilizator utilizator, DateTime inceperePachet, DateTime terminarePachet)
        {
            this.idUtilizator = idUtilizator;
            this.idpachet = idpachet;
            this.utilizator = utilizator;
            this.inceperePachet = inceperePachet;
            this.terminarePachet = terminarePachet;
            this.pachet = new Models.AllPachete().Pachete.FirstOrDefault(pachet => pachet.id == idpachet);
        }
        public Comanda() { }
    }

    public class Comenzi {
        ObservableCollection<Comanda> comenzi { get; set; }

    }
}
