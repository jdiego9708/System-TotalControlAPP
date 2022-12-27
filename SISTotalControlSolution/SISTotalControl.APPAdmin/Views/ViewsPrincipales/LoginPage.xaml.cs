using SISTotalControl.APPAdmin.Views.ViewsPrincipales.ViewsGeneral;

namespace SISTotalControl.APPAdmin.Views.ViewsPrincipales;

public partial class LoginPage
{
    public LoginPage()
    {
        InitializeComponent();

        //Routing.RegisterRoute(nameof(PrincipalPage), typeof(PrincipalPage));
        //Routing.RegisterRoute(nameof(FlyoutGeneralPage), typeof(FlyoutGeneralPage));
        //Routing.RegisterRoute(nameof(FlyoutChandozosPage), typeof(FlyoutChandozosPage));
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        //Application.Current.MainPage.Navigation.PushAsync(new PrincipalPage(), true);
        Application.Current.MainPage = new PrincipalPage();

        //Shell.Current.GoToAsync(nameof(PrincipalPage), true);
    }
}