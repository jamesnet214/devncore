using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace DevNcore.WPF.Controls
{
    public class NcoreTreeControl : TreeView
    {
        public static readonly DependencyProperty CommandProperty = DependencyProperty.Register("Command", typeof(ICommand), typeof(NcoreTreeControl));
        public static readonly DependencyProperty DoubleClickCommandProperty = DependencyProperty.Register("DoubleClickCommand", typeof(ICommand), typeof(NcoreTreeControl));

        public ICommand Command
        {
            get { return (ICommand)this.GetValue(CommandProperty); }
            set { this.SetValue(CommandProperty, value); }
        }

        public ICommand DoubleClickCommand
        {
            get { return (ICommand)this.GetValue(DoubleClickCommandProperty); }
            set { this.SetValue(DoubleClickCommandProperty, value); }
        }
    }
}
