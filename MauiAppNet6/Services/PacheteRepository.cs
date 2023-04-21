using MainAppNet6;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppNet6.Services
{
    public interface PacheteRepository
    {
        public Task<ObservableCollection<Pachet>> LoadPachet();
    }
}
