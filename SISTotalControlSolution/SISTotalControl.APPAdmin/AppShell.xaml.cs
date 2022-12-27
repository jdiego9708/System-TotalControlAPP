using SISTotalControl.APPAdmin.Views.ViewsPrincipales;
using SISTotalControl.APPAdmin.Views.ViewsPrincipales.ViewsGeneral;

namespace SISTotalControl.APPAdmin;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute(nameof(FlyoutGeneralPage), typeof(FlyoutGeneralPage));
        Routing.RegisterRoute(nameof(FlyoutChandozosPage), typeof(FlyoutChandozosPage));

    }
}
