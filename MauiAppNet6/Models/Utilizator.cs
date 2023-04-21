using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppNet6.Models
{
    [Table("utilizatori")]
    public class Utilizator
    {
        [PrimaryKey,AutoIncrement,Column("id")]
        public int id { get; set; }
        public string nume { get; set; }
        public string prenume { get; set; }
        public string username { get; set; }
        public string password { get; set; }

        public Utilizator( string nume, string prenume, string username, string password)
        {
            this.nume = nume;
            this.prenume = prenume;
            this.username = username;
            this.password = password;
        }

        public Utilizator()
        {
            id = -1;
            nume = "null";
            prenume = "null";
            username = "null";
            password = "null"; 
        }
    }
}
