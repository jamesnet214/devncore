using System.Windows;
using System.Windows.Controls;

namespace DevNcore.WPF.Controls
{
    public abstract class DevNcoreContent : ContentControl
    {
        public DevNcoreContent()
        {
            DataContextChanged += DevNcoreContent_DataContextChanged;    
        }

        private void DevNcoreContent_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

            if (DataContext is IDevNcoreObservablePresentater vm)
            {
                OnRegistElement();
            }
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
