using MauiAppNet6.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppNet6.Data
{
    public class UtilizatorRepository
    {
        string _dbPath { get; set; }
        private SQLiteConnection conn;
        public UtilizatorRepository(string dbPath)
        {
            _dbPath = dbPath;
        }
        public void Init()
        {
            conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<Utilizator>();
      
        }
        public void Add(Utilizator utilizator)
        {
            conn = new SQLiteConnection(_dbPath);
            conn.Insert(utilizator);
            
        }

        public void Update(Utilizator utilizator) {
            conn = new SQLiteConnection(_dbPath);
            conn.Update(utilizator);
        }

        public Utilizator passwordCheck(String username,String password)
        {
            conn = new SQLiteConnection(_dbPath);
            List<Utilizator> utilizators = conn.Table<Utilizator>().ToList();
            return utilizators.FirstOrDefault(utilizator => utilizator.password.Equals(password) && utilizator.username.Equals(username));
        }

    }
}
