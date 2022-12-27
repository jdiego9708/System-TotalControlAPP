using CommunityToolkit.Maui;
using SISTotalControl.APPAdmin.Views.ViewsPrincipales;
using SISTotalControl.APPAdmin.Views.ViewsProductos;
using SISTotalControl.APPAdmin.Views.ViewsTurnos;

namespace SISTotalControl.APPAdmin;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>().UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

        builder.Services.AddSingleton<ResumenTurnoGeneral>();
        builder.Services.AddSingleton<ResumenTurnoChandozos>();
        builder.Services.AddSingleton<PrincipalPage>();
        builder.Services.AddSingleton<LoginPage>(); 
        builder.Services.AddSingleton<ProductosPage>();

        return builder.Build();
	}
}
