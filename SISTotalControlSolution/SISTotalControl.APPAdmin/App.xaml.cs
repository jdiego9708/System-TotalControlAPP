using SISTotalControl.APPAdmin.Views.ViewsPrincipales;

namespace SISTotalControl.APPAdmin;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new LoginPage();
	}
}
