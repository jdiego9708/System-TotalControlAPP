using SISTotalControl.Entidades.ModelosBindeo.ModelosConfiguracion.ConfiguracionSISTotalControl;

namespace SISTotalControl.Entidades.Helpers.Interfaces
{
    public interface IRestHelper
    {
        RestResponseModel CallMethodPost(string controller, string data, string token = "");
        bool ValidateJSON(string s);
    }
}
