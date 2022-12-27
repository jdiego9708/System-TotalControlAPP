using CommunityToolkit.Mvvm.Input;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using SISTotalControl.Entidades.Helpers.Interfaces;
using System.Collections.ObjectModel;
using System.Windows.Input;
using SISTotalControl.Entidades.ModelosBindeo;
using SISTotalControl.APP.ViewModels.VMPrincipales;
using SISTotalControl.Entidades.Helpers;
using SISWallet.APP.ViewModels.VMPrincipales;

namespace SISTotalControl.APPAdmin.ViewsModels.VMProductos.ViewsProductos
{
    public class ProductosViewModel : BaseViewModel
    {
        #region CONSTRUCTOR
        private readonly IRestHelper RestHelper;
        private readonly MainViewModel MainViewModel;
        public ProductosViewModel(IRestHelper IRestHelper,
            MainViewModel MainViewModel)
        {
            this.RestHelper = IRestHelper;
            this.MainViewModel = MainViewModel;
        }
        #endregion

        #region MÉTODOS
        public void LoadProductos(string tipo_busqueda, string texto_busqueda)
        {
            try
            {
                BusquedaBindingModel busqueda = new()
                {
                    Tipo_busqueda = tipo_busqueda,
                    Texto_busqueda1 = texto_busqueda,
                    Texto_busqueda2 = this.MainViewModel.LoginDataModel.CobroDefault.Id_cobro.ToString()
                };

                RestResponseModel response = this.RestHelper.CallMethodPost("/BuscarProductos", JsonConvert.SerializeObject(busqueda));

                if (!response.Success)
                    throw new Exception(response.Message);

                JToken jtoken = JToken.Parse(response.Message);

                List<ProductoItemViewModel> productos =
                    JsonConvert.DeserializeObject<List<ProductoItemViewModel>>(jtoken.ToString());

                this.ProductosList = new ObservableCollection<ProductoItemViewModel>(productos);

                this.ProductosVistaList = this.ProductosList;

                this.OnProductosListRefresh?.Invoke(this.ProductosVistaList, null);
            }
            catch (Exception)
            {

            }
        }
        public void FiltrarXNombre(string nombre)
        {
            if (this.ProductosList == null)
                return;

            if (this.ProductosList.Count < 1)
                return;

            this.ProductosVistaList?.Clear();

            this.ProductosVistaList =
                new(this.ProductosList.Where(x => x.Nombre_producto.ToLower().StartsWith(nombre.ToLower())));

            this.OnProductosListRefresh?.Invoke(this.ProductosVistaList, null);
        }
        #endregion

        #region COMANDOS
        public ICommand SearchCommand
        {
            get
            {
                return new RelayCommand
                    (
                        () =>
                        {
                            if (!string.IsNullOrEmpty(this.Filter))
                                FiltrarXNombre(this.Filter);
                        }
                    );
            }
        }
        public ICommand LoadProductosCommand
        {
            get
            {
                return new RelayCommand
                    (
                        () =>
                        {
                            this.LoadProductos("COMPLETO INVENTARIO", string.Empty);
                        }
                    );
            }
        }
        #endregion

        #region PROPIEDADES
        public event EventHandler OnProductosListRefresh;
        public ObservableCollection<ProductoItemViewModel> ProductosList { get; set; }
        public ObservableCollection<ProductoItemViewModel> ProductosVistaList { get; set; }

        private string _filter;
        private bool _isEnabled;
        private bool _isRefreshing;
        public string Filter
        {
            get => _filter;
            set
            {
                _filter = value;
                OnPropertyChanged("Filter");
            }
        }
        public bool IsEnabled
        {
            get => _isEnabled;
            set
            {
                _isEnabled = value;
                OnPropertyChanged("IsEnabled");
            }
        }
        public bool IsRefreshing
        {
            get => _isRefreshing;
            set
            {
                _isRefreshing = value;
                OnPropertyChanged("IsRefreshing");
            }
        }
        #endregion
    }
}
