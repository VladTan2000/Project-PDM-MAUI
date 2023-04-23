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
        string dbpath ="C:\\Users\\dead1\\source\\repos\\MauiAppNet6\\MauiAppNet6\\travel.db";
		builder.Services.AddSingleton(s => ActivatorUtilities.CreateInstance<UtilizatorRepository>(s, dbpath));
        builder.Services.AddSingleton(s => ActivatorUtilities.CreateInstance<ComenziRepository>(s, dbpath));


        return builder.Build();
	}
}
