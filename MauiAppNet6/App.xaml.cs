using MauiAppNet6.Data;

namespace MauiAppNet6;

public partial class App : Application
{	
	public static UtilizatorRepository UtilizatorRepository { get; set; }
	public App(UtilizatorRepository utilizatorRepository)
	{
		InitializeComponent();

		MainPage = new AppShell();

        UtilizatorRepository = utilizatorRepository;

    }
}
