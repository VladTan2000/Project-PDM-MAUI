using MauiAppNet6.Data;
using MauiAppNet6.Models;
using Microsoft.Maui;

namespace MauiAppNet6.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

	public async void verificareParola(object sender, EventArgs e) {
		Utilizator utilizatorLocal;
		utilizatorLocal=App.UtilizatorRepository.passwordCheck(utilizator.Text, parola.Text);
		if (utilizatorLocal == null) {
            await DisplayAlert("Logare Failed", "Date de logare incorecte, va rugam incercati din nou", "Ok");
			return;
        }
		var navigationParams=new Dictionary<string, object>
		{
			{"utilizator",utilizatorLocal }
		};
        await Shell.Current.GoToAsync("PaginaMeniu",navigationParams);

    }


    private async void RegistrareUtilizator(object sender, EventArgs e)
    {

            await Shell.Current.GoToAsync("RegistrarePage");
	}
}