using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TiltaMacro2.Properties;

namespace TiltaMacro2
{
    /// <summary>
    /// Interação lógica para UserControlLimpar.xam
    /// </summary>
    public partial class UserControlLimpar : UserControl
    {
        public UserControlLimpar()
        {
            InitializeComponent();
        }

        private void ButtonNao_OnClick(object sender, RoutedEventArgs e)
        {
            Global.GlobalGridPrincipal.Children.Clear();
            Global.GlobalGridPrincipal.Children.Add(new UserControlConfig());
            Global.StatusConfigurando = false;

            Global.EngrenagemButton.Visibility = Visibility.Hidden;
            Global.CasinhaButton.Visibility = Visibility.Visible;
        }

        private void ButtonSim_OnClick(object sender, RoutedEventArgs e)
        {
            Settings.Default.Reset();
            Settings.Default.Save();

            Global.GlobalGridPrincipal.Children.Clear();
            Global.GlobalGridPrincipal.Children.Add(new Salvo());
            Global.StatusConfigurando = false;

            Global.EngrenagemButton.Visibility = Visibility.Visible;
            Global.CasinhaButton.Visibility = Visibility.Hidden;
        }
    }
}
