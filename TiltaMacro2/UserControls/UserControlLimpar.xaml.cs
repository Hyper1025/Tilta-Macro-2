using System.Windows;
using TiltaMacro2.Properties;
using TiltaMacro2.Utils;

namespace TiltaMacro2.UserControls
{
    /// <summary>
    /// Interação lógica para UserControlLimpar.xam
    /// </summary>
    public partial class UserControlLimpar
    {
        public UserControlLimpar()
        {
            InitializeComponent();
        }

        private void ButtonNao_OnClick(object sender, RoutedEventArgs e)
        {
            Global.GlobalGridPrincipal.Children.Clear();
            Global.GlobalGridPrincipal.Children.Add(new UserControlConfig());

            Global.EngrenagemButton.Visibility = Visibility.Hidden;
            Global.CasinhaButton.Visibility = Visibility.Visible;
        }

        private void ButtonSim_OnClick(object sender, RoutedEventArgs e)
        {
            Settings.Default.Reset();
            Settings.Default.Save();

            Global.Notificar("Configurações redefinidas");

            Global.GlobalGridPrincipal.Children.Clear();
            Global.Salvo(false);
        }

        private void UserControlLimpar_OnLoaded(object sender, RoutedEventArgs e)
        {
            Global.UltimoUserControl = new UserControlLimpar();
        }
    }
}
