using MauiAppNet6.Data;

namespace MauiAppNet6;

public partial class App : Application
{	
	public static UtilizatorRepository UtilizatorRepository { get; set; }
	public static ComenziRepository ComenziRepository { get; set; }
	public App(UtilizatorRepository utilizatorRepository,ComenziRepository comenziRepository)
	{
		InitializeComponent();

		MainPage = new AppShell();
        UtilizatorRepository = utilizatorRepository;
		ComenziRepository = comenziRepository;

    }
}
