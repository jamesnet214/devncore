using System;
using System.Windows;

namespace DevNcore.UI.Foundation.Mvvm
{
    public interface IDevNcoreObservablePresentater
    {
        Action<FrameworkElement> RegistElement { get; internal set; }
    }
}
