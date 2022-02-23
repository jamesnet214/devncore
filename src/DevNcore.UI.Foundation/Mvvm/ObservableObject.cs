using System;
using System.Windows;

namespace DevNcore.UI.Foundation.Mvvm
{
    internal abstract class ObservableObject : ObservableModel, IDevNcoreObservablePresentater
    {
        protected FrameworkElement View { get; private set; }
        public Action<FrameworkElement> RegistElement { get; set; }

        public ObservableObject()
        {
            RegistElement = Initialize;
        }

        private void Initialize(FrameworkElement view)
        {
            View = view;
            InitializedComponont();
            OnLoaded();
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
