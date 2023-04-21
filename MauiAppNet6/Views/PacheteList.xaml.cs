using MainAppNet6;
using CommunityToolkit.Mvvm;
using System.Collections.Specialized;
using MauiAppNet6.Models;

namespace MauiAppNet6.Views;

public partial class PacheteList : ContentPage, IQueryAttributable,INotifyCollectionChanged
{
    Utilizator utilizator { get; set; }
	public PacheteList()
	{
		InitializeComponent();
		BindingContext = new Models.AllPachete();
	}

    public event NotifyCollectionChangedEventHandler CollectionChanged;

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        utilizator = query["utilizator"] as Utilizator;
        OnPropertyChanged(nameof(utilizator));
    }

    async void pacheteCollection_SelectionChanged(System.Object sender, Microsoft.Maui.Controls.SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.Count != 0)
        {
            Pachet pachet = e.CurrentSelection.FirstOrDefault() as Pachet;
            var navigationParams = new Dictionary<string, object>
            {
                { "pachet", pachet }
            };
            await Shell.Current.GoToAsync("PachetView", navigationParams);

            productsCollection.SelectedItem = null;
        }
    }
}