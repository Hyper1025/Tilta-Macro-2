using System;
using System.Windows;
using AutoUpdaterDotNET;
using MaterialDesignThemes.Wpf;
using Application = System.Windows.Application;

namespace TiltaMacro2
{
    /// <summary>
    /// Interação lógica para UserControlUpdate.xam
    /// </summary>
    public partial class UserControlUpdate
    {
        public UserControlUpdate()
        {
            InitializeComponent();
        }

        private void UserControlUpdate_OnLoaded(object sender, RoutedEventArgs e)
        {
            AutoUpdater.CheckForUpdateEvent += AutoUpdaterOnCheckForUpdateEvent;

            AutoUpdater.Start("https://raw.githubusercontent.com/Hyper1025/Tilta-Macro-2/master/Update.xml");
        }

        private void AutoUpdaterOnCheckForUpdateEvent(UpdateInfoEventArgs args)
        {
            if (args != null)
            {
                if (args.IsUpdateAvailable)
                {
                    Label1.Content = "ATUALIZAÇÃO";
                    Label1.Content = "ENCONTRADA";
                    Icon.Kind = PackIconKind.FileFindOutline;
                    
                    if (args.Mandatory)
                    {
                        //  Mandatory = True
                        //  Atualização requerida
                        MessageBox.Show("Atualização obrigatória encontrada, o download irá inciar assim que você clicar em OK, ou fechar essa mensagem.",
                            "Update obrigatório", MessageBoxButton.OK, MessageBoxImage.Information);
                        Atualizar();
                    }
                    else
                    {
                        //  Mandatory = False
                        //  Atualização opcional

                    }

                    StackPanelUpdate.Visibility = Visibility.Visible;
                }
                else
                {
                    //  Não tem atualização disponível
                    Icon.Kind = PackIconKind.HandOkay;
                    Label1.Content = "PARABÉNS";
                    Label2.Content = "TUDO ATUALIZADO";
                    StackPanelSemUpdate.Visibility = Visibility.Visible;
                }
            }
            else
            {
                //  Ocorreu um problema ao alcançar o servidor de atualizações, verifique sua conexão com a Internet e tente novamente mais tarde.
            }
        }

        private void UserControlUpdate_OnUnloaded(object sender, RoutedEventArgs e)
        {
            Global.AtualizacaoButton.Visibility = Visibility.Visible;
        }

        private void Atualizar()
        {
            Label1.Content = "BAIXANDO";
            Label2.Visibility = Visibility.Collapsed;

            Icon.Kind = PackIconKind.FileDownloadOutline;
            StackPanelUpdate.Visibility = Visibility.Collapsed;

            try
            {
                if (AutoUpdater.DownloadUpdate())
                {
                    Application.Current.Shutdown();
                }
            }
            catch (Exception exception)
            {
                //  Erro ao realizar update
                Icon.Kind = PackIconKind.ErrorOutline;
                Label1.Content = "ERRO";
                Label2.Visibility = Visibility.Collapsed;
                MessageBox.Show(exception.ToString(), "ERRO", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            Application.Current.Shutdown();
        }

        private void ButtonNao_OnClick(object sender, RoutedEventArgs e)
        {
            Global.GlobalGridPrincipal.Children.Clear();
            Global.GlobalGridPrincipal.Children.Add(new UserControlRodando());
        }

        private void ButtonSim_OnClick(object sender, RoutedEventArgs e)
        {
            Atualizar();
        }

        private void ButtonSemUpdate_OnClick(object sender, RoutedEventArgs e)
        {
            Global.GlobalGridPrincipal.Children.Clear();
            Global.GlobalGridPrincipal.Children.Add(new UserControlRodando());
        }
    }
}
