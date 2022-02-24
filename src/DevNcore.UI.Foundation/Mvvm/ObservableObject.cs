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
            RegistElement = OnInitializeComponent;
        }

        protected void OnInitializeComponent(FrameworkElement view)
        {
            View = view;
            view.Loaded += OnLoaded;
        }

        protected virtual void OnLoaded(object sender, RoutedEventArgs e)
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
