using CommunityToolkit.Maui;
using SISTotalControl.APPAdmin.Views.ViewsPrincipales.ViewsGeneral;

namespace SISTotalControl.APPAdmin.Views.ViewsPrincipales;

public partial class PrincipalPage
{
	public PrincipalPage()
	{
		InitializeComponent();
	}

    private void ChandozosButton_Clicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new FlyoutChandozosPage();
    }

    private void GeneralButton_Clicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new FlyoutGeneralPage();
    }
}