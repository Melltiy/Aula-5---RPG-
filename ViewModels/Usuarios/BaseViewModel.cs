using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AppRpgEtec.viewModel.Usuarios
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
            // mudanças de propriedades daVM para o FrontEnd. - feita uma vz

        }
    }
}