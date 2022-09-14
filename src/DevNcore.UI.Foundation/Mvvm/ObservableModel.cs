using System.Collections.Generic;
using System;
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

        protected virtual void SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(storage, value)) return ;

            storage = value;
            OnPropertyChanged(propertyName);

            return;
        }

        protected virtual void SetProperty<T>(ref T storage, T value, Action onChanged, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(storage, value)) return;

            storage = value;
            onChanged?.Invoke();
            OnPropertyChanged();

            return;
        }

        protected virtual void SetProperty<T>(ref T storage, T value, Action<T> onChanged, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(storage, value)) return;

            storage = value;
            onChanged?.Invoke(value);
            OnPropertyChanged();

            return;
        }
    }
}
