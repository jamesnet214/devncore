using DevNcore.UI.Foundation.Mvvm;
using System.Windows;
using System.Windows.Controls;

namespace DevNcore.WPF.Controls
{
    public abstract class DevNcoreContent : ContentControl
    {
        public DevNcoreContent()
        {
            OnRegistElement();
        }

        protected virtual void OnRegistElement()
        {
            if (DataContext is IDevNcoreObservablePresentater vm)
            {
                vm.RegistElement(this);
            }
        }
    }
}
