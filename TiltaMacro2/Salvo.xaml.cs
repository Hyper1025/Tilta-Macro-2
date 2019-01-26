using System;
using System.Windows;
using System.Windows.Threading;

namespace TiltaMacro2
{
    /// <summary>
    /// Interação lógica para Salvo.xam
    /// </summary>
    public partial class Salvo
    {
        public Salvo()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            var timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(1) };
            timer.Tick += delegate
            {
                timer.Stop();
                Global.GlobalGridPrincipal.Children.Clear();
                Global.GlobalGridPrincipal.Children.Add(new UserControlRodando());

                Global.EngrenagemButton.Visibility = Visibility.Visible;
                Global.CasinhaButton.Visibility = Visibility.Hidden;
                Global.CasinhaButton.IsEnabled = true;
                Global.CasinhaButton.Opacity = 0.2;


            };
            timer.Start();
            Global.CasinhaButton.IsEnabled = false;
            Global.CasinhaButton.Opacity = 0.05;

            Global.UltimoUserControl = new Salvo();
        }
    }
}
