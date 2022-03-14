using DevNcore.UI.Foundation.Mvvm;
using System.Windows;
using System.Windows.Controls;

namespace DevNcore.WPF.Controls
{
    public abstract class DevNcoreContent : ContentControl
    {
        public DevNcoreContent()
        {
            
        }

        protected override void OnContentChanged(object oldContent, object newContent)
        {
            base.OnContentChanged(oldContent, newContent);

            if (newContent is IDevNcoreObservablePresentater vm) 
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
