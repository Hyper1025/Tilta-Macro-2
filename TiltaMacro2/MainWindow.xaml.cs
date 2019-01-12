using System.Windows;
using System.Windows.Input;
using TiltaMacro2.Properties;

namespace TiltaMacro2
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow
    {
        //  Carrega o user controll Rodando
        public MainWindow()
        {
            InitializeComponent();
            Global.GlobalGridPrincipal = GridPrincipal;
            Global.CasinhaButton = ButtonHome;
            Global.EngrenagemButton = ButtonConfig;
            Global.AtualizacaoButton = ButtonUpdate;

            GridPrincipal.Children.Add(new UserControlRodando());
        }

        //  Mover 
        private void DegradeTopo_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        //  Fechar
        private void ButtonFechar_OnClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        //  Configs
        private void ButtonConfig_OnClick(object sender, RoutedEventArgs e)
        {
            GridPrincipal.Children.Clear();
            GridPrincipal.Children.Add(new UserControlConfig());
            Global.StatusConfigurando = true;

            ButtonConfig.Visibility = Visibility.Hidden;
            ButtonHome.Visibility = Visibility.Visible;
        }

        //  Minimizar
        private void ButtonMinimizar_OnClick(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        //  Abrir YouTube
        private void YouTubeIcon_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UC0iyCfiJ9MUzJCUfbZdtrFA");
        }

        //  Abrir Discord
        private void DiscordIcon_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            System.Diagnostics.Process.Start("https://discordapp.com/invite/desceproplay");
        }

        //  Home
        private void ButtonHome_OnClick(object sender, RoutedEventArgs e)
        {
            Settings.Default.Reload();
            GridPrincipal.Children.Clear();
            GridPrincipal.Children.Add(new UserControlRodando());
            Global.StatusConfigurando = false;

            ButtonConfig.Visibility = Visibility.Visible;
            ButtonHome.Visibility = Visibility.Hidden;
        }

        private void ButtonUpdate_OnClick(object sender, RoutedEventArgs e)
        {
            ButtonUpdate.Visibility = Visibility.Hidden;
            GridPrincipal.Children.Clear();
            GridPrincipal.Children.Add(new UserControlUpdate());
        }
    }
}
