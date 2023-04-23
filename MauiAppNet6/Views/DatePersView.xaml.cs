using MauiAppNet6.Models;
using System.Collections.Specialized;

namespace MauiAppNet6.Views;

public partial class DatePersView : ContentPage, IQueryAttributable, INotifyCollectionChanged
{
    public Utilizator utilizator { get; set; }
    public DatePersView()
    {
        InitializeComponent();
        BindingContext = this;
    }

    public event NotifyCollectionChangedEventHandler CollectionChanged;

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        utilizator = query["utilizator"] as Utilizator;
        OnPropertyChanged(nameof(utilizator));
    }

    private void Update_Btn(object sender, EventArgs e)
    {
        utilizator.nume=entryNume.Text;
        utilizator.prenume=entryPrenume.Text;
        utilizator.username = entryUser.Text;
        utilizator.password=entryPass.Text;
        App.UtilizatorRepository.Update(utilizator);
    }
}
