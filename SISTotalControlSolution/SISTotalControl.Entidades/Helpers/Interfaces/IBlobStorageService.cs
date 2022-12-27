using SISTotalControl.Entidades.ModelosBindeo.ModelosConfiguracion.ConfiguracionSISTotalControl;

namespace SISTotalControl.Entidades.Helpers.Interfaces
{
    public interface IBlobStorageService
    {
        BlobResponse DescargarArchivoContainerBlobStorage(string nombreArchivo, string contenedor);
        BlobResponse SubirArchivoContainerBlobStorage(Stream inputStream, string nombreArchivo, string contenedor, string contentType = "image/jpeg");
    }
}
