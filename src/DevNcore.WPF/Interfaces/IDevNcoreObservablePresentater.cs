using System;
using System.Windows;

namespace DevNcore.WPF.Controls
{
    public interface IDevNcoreObservablePresentater
    {
        Action<FrameworkElement> RegistElement { get; internal set; }
    }
}
