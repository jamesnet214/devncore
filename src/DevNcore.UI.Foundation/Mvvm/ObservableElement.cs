using System.Windows;

namespace DevNcore.UI.Foundation.Mvvm
{
    public class ObservableElement : ObservableModel
    {
        protected FrameworkElement View { get; private set; }

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
