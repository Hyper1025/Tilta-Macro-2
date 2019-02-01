using System.Reflection;
using System.Windows;
using System.Windows.Input;
using MaterialDesignThemes.Wpf;
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
            Global.UltimoUserControl = new UserControlRodando();

            LabelVersion.Content = $"v {Assembly.GetEntryAssembly().GetName().Version}";
            GridPrincipal.Children.Clear();
            GridPrincipal.Children.Add(new UserControlUpdate());
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
        private void ButtonYouTube_OnClick(object sender, RoutedEventArgs e)
        {
            IconNotifica.Kind = PackIconKind.Heart;
            LabelNotifica.Content = "Aproveite, e se inscreva no canal";
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UC0iyCfiJ9MUzJCUfbZdtrFA");
        }

        //  Abrir Github
        private void ButtonGithub_OnClick(object sender, RoutedEventArgs e)
        {
            IconNotifica.Kind = PackIconKind.GithubCircle;
            LabelNotifica.Content = "Sim... somos open-source";
            System.Diagnostics.Process.Start("https://github.com/Hyper1025/Tilta-Macro-2");
        }

        //  Abrir Discord
        private void ButtonDiscord_OnClick(object sender, RoutedEventArgs e)
        {
            IconNotifica.Kind = PackIconKind.Discord;
            LabelNotifica.Content = "Boas vindas a nossa comunidade";
            System.Diagnostics.Process.Start("https://discord.gg/cAy4pqk");
        }

        //  Botão compartilhar
        private void ButtonShare_OnClick(object sender, RoutedEventArgs e)
        {
            IconNotifica.Kind = PackIconKind.ShareVariant;
            LabelNotifica.Content = "Copiado para sua área de transferência";
            Clipboard.SetText("http://bit.ly/TiltaMacroInvite");
        }

        //  Botão PayPal
        private void ButtonPayPal_OnClick(object sender, RoutedEventArgs e)
        {
            IconNotifica.Kind = PackIconKind.Paypal;
            LabelNotifica.Content = "Obrigado por cojitar uma doação";
            System.Diagnostics.Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=VVNYNKR2NA9U2&source=url");
        }

        //  Botão informação
        private void ButtonInfo_OnClick(object sender, RoutedEventArgs e)
        {
            IconNotifica.Kind = PackIconKind.InformationVariant;
            LabelNotifica.Content = "Abrindo informações no Gith";
            System.Diagnostics.Process.Start("https://github.com/Hyper1025/Tilta-Macro-2/blob/master/Info.md");
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

        //  Botão atualização
        private void ButtonUpdate_OnClick(object sender, RoutedEventArgs e)
        {
            ButtonUpdate.Visibility = Visibility.Hidden;
            GridPrincipal.Children.Clear();
            GridPrincipal.Children.Add(new UserControlUpdate());
        }
    }
}
