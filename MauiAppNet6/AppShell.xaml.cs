using MainAppNet6.Views;
using MauiAppNet6.Views;

namespace MauiAppNet6;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute("PachetView", typeof(PachetView));
        Routing.RegisterRoute("PacheteList", typeof(PacheteList));
        Routing.RegisterRoute("PaginaCumparare", typeof(PaginaCumparare));
		Routing.RegisterRoute("LoginPage", typeof(LoginPage));
		Routing.RegisterRoute("RegistrarePage", typeof(RegistrarePage));

    }
}
