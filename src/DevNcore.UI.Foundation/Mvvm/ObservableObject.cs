using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace DevNcore.UI.Foundation.Mvvm
{
    public class ObservableObject : INotifyPropertyChanged
    {
        protected FrameworkElement View { get; private set; }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public void ForceLoaded(FrameworkElement view)
        {
            View = view;
            InitializedComponont();

            OnLoaded();
        }

        public void ForceViewLoaded(FrameworkElement view)
        {
            View = view;
            InitializedComponont();

            OnViewLoaded();
        }

        private void InitializedComponont()
        {
            OnInitializedComponent();
        }

        protected virtual void OnLoaded()
        {

        }

        protected virtual void OnViewLoaded()
        {

        }

        protected virtual void OnInitializedComponent()
        {

        }
    }
}
