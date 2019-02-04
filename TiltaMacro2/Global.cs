using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using MaterialDesignThemes.Wpf;

namespace TiltaMacro2
{
    internal class Global
    {
        //  Misc
        public static Random Rng { get; set; } = new Random();
        public static UserControl UltimoUserControl { get; set; }

        //  Grid
        public static Grid GlobalGridPrincipal { get; set; }

        //  Key
        public static Key EditandoKey { get; set; } = Key.None;
        public static Key UltimaKey { get; set; } = Key.None;

        //  Button
        public static Button EngrenagemButton { get; set; }
        public static Button CasinhaButton { get; set; }
        public static Button AtualizacaoButton { get; set; }

        //  Barra notificação  
        internal static Snackbar BarraNotifica { get; set; }

        public static void Notificar(string texto, string corHex = null)
        {
            if (corHex == null)
            {
                corHex = "#FFC34545";
            }

            BarraNotifica.Background = HexToColorBrushConverter(corHex);

            var filaMsg = BarraNotifica.MessageQueue;
            Task.Factory.StartNew(() => filaMsg.Enqueue(texto));
        }

        public static SolidColorBrush HexToColorBrushConverter(string hex)
        {
            var cor = (SolidColorBrush)(new BrushConverter().ConvertFrom(hex));
            return cor;
        }

        //  Salvo
        public static void Salvo(bool notificar)
        {
            GlobalGridPrincipal.Children.Clear();
            GlobalGridPrincipal.Children.Add(new UserControlRodando());

            EngrenagemButton.Visibility = Visibility.Visible;
            CasinhaButton.Visibility = Visibility.Hidden;

            if (notificar)
            {
                Notificar("Tudo salvo", "#83AE9B");
            }
        }
    }
}
