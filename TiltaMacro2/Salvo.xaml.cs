using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;

namespace TiltaMacro2
{
    /// <summary>
    /// Interação lógica para Salvo.xam
    /// </summary>
    public partial class Salvo
    {
        private int _time = 1;
        private DispatcherTimer _timer;

        public Salvo()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            _timer = new DispatcherTimer {Interval = new TimeSpan(0, 0, 0, 0, 800)};
            _timer.Tick += TimerOnTick;
            _timer.Start();
        }

        private void TimerOnTick(object sender, EventArgs e)
        {
            if (_time == 0)
            {
                _time--;
            }
            else
            {
                Global.GlobalGridPrincipal.Children.Clear();
                Global.GlobalGridPrincipal.Children.Add(new UserControlRodando());

                Global.EngrenagemButton.Visibility = Visibility.Visible;
                Global.CasinhaButton.Visibility = Visibility.Hidden;

                _timer.Stop();
            }
        }
    }
}
