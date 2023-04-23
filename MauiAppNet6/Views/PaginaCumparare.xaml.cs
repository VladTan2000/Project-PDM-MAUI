using MainAppNet6;
using MauiAppNet6.Models;
using System.Collections.Specialized;

namespace MauiAppNet6.Views;

public partial class PaginaCumparare : ContentPage,IQueryAttributable,INotifyCollectionChanged
{
	public Pachet pachet { get; set; }
	public Utilizator utilizator { get; set; }
	public PaginaCumparare()
	{
		InitializeComponent();
	}

    public event NotifyCollectionChangedEventHandler CollectionChanged;

    private void CumparBtn_Clicked(object sender, EventArgs e)
    {
		Comanda comanda = new Comanda(utilizator.id,pachet.id,utilizator,inceperePachet.Date,inceperePachet.Date.AddDays(pachet.numarZile));
		App.ComenziRepository.Init();
		App.ComenziRepository.Add(comanda, utilizator);
        DisplayAlert("Success", "Comanda a fost facuta cu succes,aceasta poate fi verificata in pagina de comenzi personale", "Ok");

    }

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        utilizator = query["utilizator"] as Utilizator;
		pachet = query["pachet"] as Pachet;
        OnPropertyChanged(nameof(utilizator));
        OnPropertyChanged(nameof(pachet));

    }
}