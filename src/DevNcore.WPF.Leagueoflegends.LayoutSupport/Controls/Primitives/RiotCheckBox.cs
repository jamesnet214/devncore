using System.Windows;
using System.Windows.Controls;

namespace DevNcore.WPF.Leagueoflegends.LayoutSupport.Controls.Primitives
{
    public class RiotCheckBox : CheckBox
    {
        #region DefaultStyleKey

        static RiotCheckBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(RiotCheckBox), new FrameworkPropertyMetadata(typeof(RiotCheckBox)));
        }
        #endregion
    }
}
