using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DevNcore.UI.Foundation.Mvvm
{
    public class ObservableModel : INotifyPropertyChanged 
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
