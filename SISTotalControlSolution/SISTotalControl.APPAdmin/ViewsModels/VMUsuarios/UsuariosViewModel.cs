using SISTotalControl.Entidades.Modelos;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using SISTotalControl.Entidades.Helpers;
using System.Windows.Input;
using SISTotalControl.Entidades.Helpers.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Data;
using SISWallet.APP.ViewModels.VMPrincipales;

namespace SISTotalControl.ViewModels.VMUsuarios
{
    public class UsuariosViewModel : BaseViewModel
    {
        #region CONSTRUCTOR
        private readonly IRestHelper RestHelper;
        public UsuariosViewModel(IRestHelper RestHelper)
        {
            this.RestHelper = RestHelper;
        }
        #endregion

        #region MÉTODOS

        #endregion

        #region COMANDOS

        #endregion

        #region PROPIEDADES

        #endregion
    }
}
