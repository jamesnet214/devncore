using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DevNcore.UI.Foundation.Mvvm
{
    public interface IDevNcoreObservablePresentater
    {
        Action<FrameworkElement> RegistElement { get; internal set; }
    }
}
