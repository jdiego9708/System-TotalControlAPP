using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using Microsoft.Extensions.Configuration;
using SISTotalControl.Entidades.ModelosBindeo.ModelosConfiguracion.ConfiguracionSISTotalControl;
using RestSharp;
using SISTotalControl.Entidades.Helpers.Interfaces;
using SISTotalControl.Entidades.Modelos;
using System.Net;

namespace SISTotalControl.Entidades.Helpers
{
    public class RestHelper : IRestHelper
    {
        public IConfiguration Configuration { get; set; }
        private readonly ConfiguracionSISTotalControl ConfiguracionSISTotalControl;
        public RestHelper(IConfiguration Configuration)
        {
            this.Configuration = Configuration;

            var settings = this.Configuration.GetSection("ConfiguracionSISTotalControl");
            this.ConfiguracionSISTotalControl = settings.Get<ConfiguracionSISTotalControl>();
        }
        public RestResponseModel CallMethodPost(string controller, string data, string token = "")
        {
            try
            {
                string url = this.ConfiguracionSISTotalControl.URLApiDesarrollo;

                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                RestClient client = new(url);
                RestRequest request = new()
                {
                    Method = Method.Post
                };

                request.AddHeader("Content-Type", "application/json");

                request.AddJsonBody(data);

                RestResponse result = client.Execute(request);

                if (result == null)
                    throw new Exception("Error llamando al servidor");

                string content = result.Content.ToString();

                if (string.IsNullOrEmpty(content))
                    throw new Exception("Error con el contenido de la respuesta");

                if (!result.IsSuccessful)
                    throw new Exception(content);

                if (result.IsSuccessful)
                {
                    return new RestResponseModel
                    {
                        Success = true,
                        Message = result.Content,
                    };
                }
                else
                {
                    return new RestResponseModel
                    {
                        Success = false,
                        Message = result.Content,
                    };
                }
            }
            catch (Exception ex)
            {
                return new RestResponseModel
                {
                    Success = false,
                    Message = ex.Message,
                };
            }
        }
        public bool ValidateJSON(string s)
        {
            try
            {
                JToken.Parse(s);
                return true;
            }
            catch (JsonReaderException)
            {
                return false;
            }
        }
    }
}
