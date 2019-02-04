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
        internal string LinkNote;

        public UserControlUpdate()
        {
            InitializeComponent();
        }

        //  Ao carregar o UserControlUpdate
        private void UserControlUpdate_OnLoaded(object sender, RoutedEventArgs e)
        {
            //  Reescrevemos o evento de checar update
            AutoUpdater.CheckForUpdateEvent += AutoUpdaterOnCheckForUpdateEvent;

            //  Passamos o link do XML pra pegarmos as informações atualizadas
            AutoUpdater.Start("https://raw.githubusercontent.com/Hyper1025/Tilta-Macro-2/master/Update.xml");

            //  Escondemos os botões do topo
            Global.AtualizacaoButton.Visibility = Visibility.Hidden;
            Global.EngrenagemButton.Visibility = Visibility.Hidden;
            Global.CasinhaButton.Visibility = Visibility.Hidden;
        }

        //  Reescrevemos o evento de checar update
        private void AutoUpdaterOnCheckForUpdateEvent(UpdateInfoEventArgs args)
        {
            //  Verificamos se a resposta foi diferente de nula
            if (args != null)
            {

                Icon.Visibility = Visibility.Visible;
                ProgressBar.Visibility = Visibility.Collapsed;

                //  Caso seja uma resposta diferente de nula, proseguimos

                //  Verificamos se existe uma atualização disponível
                if (args.IsUpdateAvailable)
                {
                    //  Se sim

                    //  Alteramos as label`s
                    Label1.Content = $"V {args.CurrentVersion}";
                    Label2.Content = "ENCONTRADA";
                    //  Alteramos o icone do centro
                    Icon.Kind = PackIconKind.FileFindOutline;

                    //  Verificamos se é uma atualização obrigatória
                    if (args.Mandatory)
                    {
                        //  Se for obrigatória, avisamos
                        MessageBox.Show("Atualização obrigatória encontrada, o download irá inciar assim que você clicar em OK, ou fechar essa mensagem.\tTambém irei abrir as notas de update, para você",
                            "Update obrigatório", MessageBoxButton.OK, MessageBoxImage.Information);
                        //  Chamamos a atualização

                        Global.Notificar("Iniciando Update");
                        System.Diagnostics.Process.Start(LinkNote);
                        Atualizar();
                    }

                    //  Mostramos o StackPanel de Update
                    StackPanelUpdate.Visibility = Visibility.Visible;
                    //  Passamos o link para o botão
                    LinkNote = args.ChangelogURL;
                }
                else
                {
                    //  Não tem atualização disponível
                    Icon.Kind = PackIconKind.HandOkay;
                    Label1.Content = "PARABÉNS";
                    Label2.Content = "TUDO ATUALIZADO";

                    Global.Notificar("Tudo está atualizado", "#555555");

                    // <removi isso no update 3.0.1.2
                    //StackPanelSemUpdate.Visibility = Visibility.Visible;

                    //  Criamos um timer
                    //  Ele servirá para apresentarmos a janela de atualização por mais tempo

                    //  Limpamos s grip principal
                    Global.GlobalGridPrincipal.Children.Clear();
                    //  Adicionamos um painel novo a grid
                    Global.GlobalGridPrincipal.Children.Add(Global.UltimoUserControl);
                    //  Mostramos novamente o botão de update
                    Global.AtualizacaoButton.Visibility = Visibility.Visible;

                    //  Isso é só uma verificação pra saber se devemos ou não mostrar o botão de engrenagem
                    //  Ele é necessário caso não já não estejamos na tela de configuração
                    //  Pois iremos voltar a ela, e não faz sentido termos o botão de ir pra config, se já estamos lá .-.
                    if (!Global.UltimoUserControl.ToString().Contains("UserControlConfig"))
                    {
                        Global.EngrenagemButton.Visibility = Visibility.Visible;
                    }
                }
            }
            else
            {
                //  Ocorreu um problema ao alcançar o servidor de atualizações, verifique sua conexão com a Internet e tente novamente mais tarde.
            }
        }

        private void UserControlUpdate_OnUnloaded(object sender, RoutedEventArgs e)
        {
            //  Ao descarregarmos esse painel, mostramos novamente o botão de update
            Global.AtualizacaoButton.Visibility = Visibility.Visible;
        }

        //  Void de atualização
        private void Atualizar()
        {
            //  Avisamos que o download está em execução
            //  E escondemos a label 2
            Label1.Content = "BAIXANDO";
            Label2.Visibility = Visibility.Collapsed;

            //  Mudamos o icone para o icone de download
            Icon.Kind = PackIconKind.FileDownloadOutline;

            //  Escondemos o painel de update (o com as opções para aceitar ou não, o update...)
            StackPanelUpdate.Visibility = Visibility.Collapsed;

            //  Tentamos baixar o update
            try
            {
                //  Baixamos o update, e ao concluir, fecharmos o programa
                if (AutoUpdater.DownloadUpdate())
                {
                    Application.Current.Shutdown();
                }
            }
            catch (Exception exception)
            {
                //  Erro ao realizar update

                //  Mudamos o icone para o iconde de erro
                Icon.Kind = PackIconKind.ErrorOutline;
                //  Alteramos o texto da label 1
                Label1.Content = "ERRO";
                //  Esondemos a label 2
                Label2.Visibility = Visibility.Collapsed;

                //  Informamos o erro
                MessageBox.Show(exception.Message, exception.GetType().ToString(), MessageBoxButton.OK, MessageBoxImage.Error);
            }

            //  Fecha o programa
            Application.Current.Shutdown();
        }

        //  Botão ao não aceitar o update
        private void ButtonNao_OnClick(object sender, RoutedEventArgs e)
        {
            //  Limpamos a grid
            Global.GlobalGridPrincipal.Children.Clear();
            //  Voltamos para onde o usuário estava
            Global.GlobalGridPrincipal.Children.Add(Global.UltimoUserControl);
        }

        //  Botão ao aceitar o update
        private void ButtonSim_OnClick(object sender, RoutedEventArgs e)
        {
            //  Atualizamos
            Atualizar();
        }

        //private void ButtonSemUpdate_OnClick(object sender, RoutedEventArgs e)
        //{
        //    Global.GlobalGridPrincipal.Children.Clear();
        //    Global.GlobalGridPrincipal.Children.Add(new UserControlRodando());
        //}


        //  Botão changelog
        private void ButtonUpdateNote_OnClick(object sender, RoutedEventArgs e)
        {
            Global.Notificar("Notas de atualização", "#73C2FB");
            System.Diagnostics.Process.Start(LinkNote);
        }
    }
}
