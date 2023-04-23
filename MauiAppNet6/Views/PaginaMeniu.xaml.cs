using MauiAppNet6.Models;
using System.Collections.Specialized;

namespace MauiAppNet6.Views;

public partial class PaginaMeniu : ContentPage,IQueryAttributable,INotifyCollectionChanged
{
    Utilizator utilizator;
	public PaginaMeniu()
	{
		InitializeComponent();
	}

    public event NotifyCollectionChangedEventHandler CollectionChanged;

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        utilizator = query["utilizator"] as Utilizator;
        OnPropertyChanged(nameof(utilizator));
    }

    public async void Btn_Pachete(object sender, EventArgs e) {
        var navigationParams = new Dictionary<string, object>
        {
            {"utilizator",utilizator }
        };
        await Shell.Current.GoToAsync("PacheteList",navigationParams);
    }
    public async void Btn_Comenzi(object sender, EventArgs e)
    {
        var navigationParams = new Dictionary<string, object>
        {
            {"utilizator",utilizator }
        };
        await Shell.Current.GoToAsync("ComenziView",navigationParams);
    }
    public async void Btn_Date(object sender, EventArgs e)
    {
        var navigationParams = new Dictionary<string, object>
        {
            {"utilizator",utilizator }
        };
        await Shell.Current.GoToAsync("DatePersView",navigationParams);
    }
}