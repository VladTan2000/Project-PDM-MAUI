namespace MauiAppNet6.Views;

public partial class RegistrarePage : ContentPage
{
	public RegistrarePage()
	{
		InitializeComponent();
	}

    private void RegistrareBtn(object sender, EventArgs e)
    {
		App.UtilizatorRepository.Init();
		App.UtilizatorRepository.Add(new Models.Utilizator(nume.Text, prenume.Text, utilizator.Text, parola.Text));
        DisplayAlert("Inregisrare Reusita", "Inregistrarea a fost efecutata cu succes", "Ok");
    }

	
	
}