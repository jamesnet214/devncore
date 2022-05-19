using System.Windows;

namespace DevNcore.WPF.Controls
{
    public abstract class DevNcoreWindow : Window
    {
        public DevNcoreWindow()
        {
            DataContextChanged += DevNcoreWindow_DataContextChanged;    
        }

        private void DevNcoreWindow_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
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
