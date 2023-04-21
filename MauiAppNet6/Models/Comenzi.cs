using MainAppNet6;
using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppNet6.Models
{
    public class Comenzi
    {
        [PrimaryKey,AutoIncrement,Column("id")]
        public int id { get; set; }
        [OneToOne(CascadeOperations=CascadeOperation.All)]
        public Pachet pachet { get; set; }
        [OneToOne(CascadeOperations = CascadeOperation.All)]
        public Utilizator utilizator { get; set; }
        public DateOnly inceperePachet { get; set; }
        public DateOnly terminarePachet { get; set; }
    }
}
