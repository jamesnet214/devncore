using DevNcore.WPF.Controls;
using System;
using System.Windows;

namespace DevNcore.UI.Foundation.Mvvm
{
    public abstract class ObservableObject : ObservableModel, IDevNcoreObservablePresentater
    {
        protected FrameworkElement View { get; private set; }

        public Action<FrameworkElement> RegistElement { get; set; }

        public ObservableObject()
        {
            RegistElement = OnInitializedComponent;
        }

        protected virtual void OnInitializedComponent(FrameworkElement view)
        {
            View = view;
            view.Loaded += OnLoaded;
        }

        protected virtual void OnLoaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
