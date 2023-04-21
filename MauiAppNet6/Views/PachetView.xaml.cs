using System.ComponentModel;

namespace MainAppNet6.Views;

[QueryProperty(nameof(Pachet),"pachet")]
public partial class PachetView : ContentPage,IQueryAttributable,INotifyPropertyChanged
{
    public Pachet pachet { get; set; }


    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        pachet = query["pachet"] as Pachet;
        OnPropertyChanged(nameof(pachet));
    }

    public PachetView()
    {
        InitializeComponent();
        BindingContext = this;
    }

    public async void CumparaBtn(object sender, EventArgs e) {
        var navigationParams = new Dictionary<string, object>
            {
                { "pachet", pachet }
            };
        await Shell.Current.GoToAsync("PaginaCumparare", navigationParams);
    }

}