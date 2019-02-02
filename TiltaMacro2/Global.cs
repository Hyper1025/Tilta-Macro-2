using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using MaterialDesignThemes.Wpf;

namespace TiltaMacro2
{
    public class Global
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

        //  Itens Notificação
        internal static Storyboard Sb { get; set; }
        internal static Label LabelNotifica { get; set; }
        internal static PackIcon IconNotifica { get; set; }

        //  Barra notificação  
        internal static Snackbar BarraNotifica { get; set; }

        //  Exibe uma notificação
        //public static void Notificar(PackIconKind icone, string texto)
        //{
        //    LabelNotifica.Content = texto;
        //    IconNotifica.Kind = icone;
        //    Sb.Begin();
        //}

        public static void Notificar2(string texto, string corHex = null)
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
                Notificar2("Tudo salvo", "#83AE9B");
            }          
        }
    }
}
