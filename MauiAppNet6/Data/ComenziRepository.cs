using MainAppNet6;
using MauiAppNet6.Models;
using MuaiAppNet6.Services;
using SQLite;
using SQLiteNetExtensions.Extensions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppNet6.Data
{
    public class ComenziRepository
    {
        string _dbPath { get; set; }
        ObservableCollection<Pachet> pachets;
        private SQLiteConnection conn;
        public ComenziRepository(string dbPath)
        {
            _dbPath = dbPath;
            this.loadPachete();
        }
        public void Init()
        {
            conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<Comanda>();

        }
        public void Add(Comanda comenzi,Utilizator utilizator)
        {
            conn = new SQLiteConnection(_dbPath);
            conn.Insert(comenzi);
            comenzi.utilizator = utilizator;
            conn.UpdateWithChildren(comenzi);
        }

        public void Delete(int id) {
        conn=  new SQLiteConnection(_dbPath);
            conn.Delete(new { Id=id});
        }

        public ObservableCollection<Comanda> GetAllPerUtilizator()
        {
            ObservableCollection<Comanda> temp= new ObservableCollection<Comanda>(); 
            conn=new SQLiteConnection(_dbPath);
            List<Comanda> comenzis = new List<Comanda>();
            comenzis = conn.GetAllWithChildren<Comanda>();
            List<Comanda> returnComanda = new List<Comanda>();
            for (int i = 0; i < comenzis.Count; i++) {
                    returnComanda.Add(comenzis[i]);
            }
            for(int i=0;i<comenzis.Count;i++)
            {
                temp.Add(comenzis[i]);
            }
            return temp;
        }

        public async void loadPachete()
        {
            ServiciuRestPachet serviciuRest = new ServiciuRestPachet();
            pachets = await serviciuRest.LoadPachet();

        }

        public  ObservableCollection<Comanda> GetAllPerUtilizator(Utilizator utilizator)
        {
            ObservableCollection<Comanda> temp = new ObservableCollection<Comanda>();
            conn = new SQLiteConnection(_dbPath);
            List<Comanda> comenzis = new List<Comanda>();
            comenzis = conn.GetAllWithChildren<Comanda>();
            List<Comanda> returnComanda = new List<Comanda>();
            for (int i = 0; i < comenzis.Count; i++)
            {
                if (comenzis[i].utilizator.id==utilizator.id)
                {
                    comenzis[i].pachet = pachets.FirstOrDefault(pac => pac.id == comenzis[i].idpachet);
                    returnComanda.Add(comenzis[i]);
                }
            }
            for (int i = 0; i < returnComanda.Count; i++)
            {
                temp.Add(returnComanda[i]);
            }
            return temp;
        }

    }
}
