using DevNcore.UI.Foundation.Mvvm;
using System.Windows;
using System.Windows.Controls;

namespace DevNcore.WPF.Controls
{
    public class DevNcoreContent : ContentControl
    {
        public DevNcoreContent()
        {
            Loaded += DevNcoreContent_Loaded;
        }

        private void DevNcoreContent_Loaded(object sender, RoutedEventArgs e)
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
