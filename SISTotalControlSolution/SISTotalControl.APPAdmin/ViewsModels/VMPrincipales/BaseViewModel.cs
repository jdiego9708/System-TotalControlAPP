using System.ComponentModel;

namespace SISWallet.APP.ViewModels.VMPrincipales
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this ?? new BaseViewModel(), new PropertyChangedEventArgs(propertyName));
        }
    }
}
