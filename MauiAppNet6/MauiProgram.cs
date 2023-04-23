using MauiAppNet6.Data;
using System.Reflection;

namespace MauiAppNet6;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
        var path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
		path = Path.Combine(path, "travel.db");
        string dbpath = Path.Combine(Directory.GetCurrentDirectory(), "travel.db");
		builder.Services.AddSingleton(s => ActivatorUtilities.CreateInstance<UtilizatorRepository>(s, path));
        builder.Services.AddSingleton(s => ActivatorUtilities.CreateInstance<ComenziRepository>(s, path));


        return builder.Build();
	}
}
