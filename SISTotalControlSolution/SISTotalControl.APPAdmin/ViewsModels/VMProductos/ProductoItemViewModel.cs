using CommunityToolkit.Mvvm.Input;
using SISTotalControl.Entidades.Helpers;
using SISTotalControl.Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SISTotalControl.APPAdmin.ViewsModels.VMProductos.ViewsProductos
{
    public class ProductoItemViewModel : Productos
    {
        public ProductoItemViewModel()
        {

        }
        public ProductoItemViewModel(DataRow row)
        {
            try
            {
                this.Id_producto = ConvertValueHelper.ConvertirNumero(row["Id_producto"]);
                this.Id_tipo_producto = ConvertValueHelper.ConvertirNumero(row["Id_tipo_producto"]);
                this.Nombre_producto = ConvertValueHelper.ConvertirCadena(row["Nombre_producto"]);
                this.Precio_producto = ConvertValueHelper.ConvertirDecimal(row["Precio_producto"]);
                this.Descripcion_producto = ConvertValueHelper.ConvertirCadena(row["Descripcion_producto"]);
                this.Estado_producto = ConvertValueHelper.ConvertirCadena(row["Estado_producto"]);
            }
            catch (Exception)
            {
                
            }
        }
        public ICommand SelectProductoCommand
        {
            get
            {
                return new RelayCommand(SelectProducto);
            }
        }
        private void SelectProducto()
        {

        }

    }
}
