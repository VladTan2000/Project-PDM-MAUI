using MauiAppNet6.Models;
using System.ComponentModel;

namespace MainAppNet6.Views;

[QueryProperty(nameof(Pachet),"pachet")]
public partial class PachetView : ContentPage,IQueryAttributable,INotifyPropertyChanged
{
    public Pachet pachet { get; set; }
    public Utilizator utilizator { get; set; }


    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        pachet = query["pachet"] as Pachet;
        utilizator = query["utilizator"] as Utilizator;
        OnPropertyChanged(nameof(pachet));
        OnPropertyChanged(nameof(utilizator));

    }

    public PachetView()
    {
        InitializeComponent();
        BindingContext = this;
    }

    public async void CumparaBtn(object sender, EventArgs e) {
        var navigationParams = new Dictionary<string, object>
            {
                { "pachet", pachet },
                { "utilizator",utilizator}
            };
        await Shell.Current.GoToAsync("PaginaCumparare", navigationParams);
    }

}