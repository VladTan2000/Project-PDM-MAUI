using MauiAppNet6.Services;
using System.Collections.ObjectModel;
using MainAppNet6;
using MuaiAppNet6.Services;

namespace MauiAppNet6.Models
{
    public class AllPachete
    {
        public ObservableCollection<Pachet> Pachete { get; set; } = new ObservableCollection<Pachet>();
        readonly PacheteRepository ProductsRepository = new ServiciuRestPachet();

        public AllPachete() => LoadPachet();


        public async void LoadPachet()
        {
            ObservableCollection<Pachet> temp = await ProductsRepository.LoadPachet();
            for (int i = 0; i < temp.Count; i++)
            {
                Pachete.Add(temp[i]);
            }
        }
    }
}

