using System.Windows;

namespace DevNcore.UI.Foundation.Mvvm
{
    public class ObservableElement<T> : ObservableObject
    {
        protected new T View { get; private set; }

        protected override void OnInitializedComponent(FrameworkElement view)
        {
            View = (T)(object)view;
            view.Loaded += OnLoaded;
        }
    }
}
