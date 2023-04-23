using MauiAppNet6.Models;
using System.Collections.Specialized;

namespace MauiAppNet6.Views;

public partial class ComenziView : ContentPage,IQueryAttributable,INotifyCollectionChanged
{
	public Utilizator utilizator;
	public ComenziView()
	{
        
		InitializeComponent();

    }

    public event NotifyCollectionChangedEventHandler CollectionChanged;

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        utilizator = query["utilizator"] as Utilizator;
        OnPropertyChanged(nameof(utilizator));
        BindingContext = new Models.AllComenzi(utilizator);


    }
}