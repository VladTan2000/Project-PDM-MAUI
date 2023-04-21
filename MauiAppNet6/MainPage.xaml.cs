using MainAppNet6.Views;

namespace MauiAppNet6;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
        Routing.RegisterRoute("PachetView", typeof(PachetView));


    }

    private void OnCounterClicked(object sender, EventArgs e)
	{

		
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

