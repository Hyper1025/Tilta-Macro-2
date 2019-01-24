using System.Windows;
using System.Windows.Input;
using TiltaMacro2.Properties;

namespace TiltaMacro2
{
    /// <summary>
    /// Interação lógica para UserControlRodando.xam
    /// </summary>
    public partial class UserControlRodando
    {
        private LowLevelKeyboardListener _listener;

        //  Carrega o pegador
        public UserControlRodando()
        {
            InitializeComponent();
        }

        //  Evento tecla pressionada
        //  Passa para a execução
        private static void _listener_OnKeyPressed(object sender, KeyPressedArgs e)
        {
            ExecutarMacro(e);
        }

        //  Função de execução da macro
        private static void ExecutarMacro(KeyPressedArgs teclaArgs)
        {
            //  <nmsg> = {ENTER}{ENTER}/all 
            //  Hit or miss<nmsg>
            //  I guess they never miss, huh?<nmsg>
            //  You got a boyfriend, I bet he doesn't kiss ya<nmsg>
            //  He gon' find another girl and he won't miss ya<nmsg>
            //  He gon' skrrt and hit the dab like Wiz Khalifa

            switch (teclaArgs.KeyPressed)
            {
                case Key.F1:
                    Digitar(Settings.Default.F1All, Settings.Default.F1);
                    break;

                case Key.F2:
                    Digitar(Settings.Default.F2All, Settings.Default.F2);
                    break;

                case Key.F3:
                    Digitar(Settings.Default.F3All, Settings.Default.F3);
                    break;

                case Key.F4:
                    Digitar(Settings.Default.F4All, Settings.Default.F4);
                    break;

                case Key.F5:
                    Digitar(Settings.Default.F5All, Settings.Default.F5);
                    break;

                case Key.F6:
                    Digitar(Settings.Default.F6All, Settings.Default.F6);
                    break;
                case Key.F7:
                    Digitar(Settings.Default.F7All, Settings.Default.F7);
                    break;

                case Key.F8:
                    Digitar(Settings.Default.F8All, Settings.Default.F8);
                    break;

                case Key.F9:
                    Digitar(Settings.Default.F9All, Settings.Default.F9);
                    break;

                case Key.F10:
                    Digitar(Settings.Default.F10All, Settings.Default.F10);
                    break;
                case Key.F11:
                    Digitar(Settings.Default.F11All, Settings.Default.F11);
                    break;
                case Key.F12:
                    Digitar(Settings.Default.F12All, Settings.Default.F12);
                    break;
                case Key.NumPad0:
                    Digitar(Settings.Default.NumPad0All, Settings.Default.NumPad0);
                    break;
                case Key.NumPad1:
                    Digitar(Settings.Default.NumPad1All, Settings.Default.NumPad1);
                    break;
                case Key.NumPad2:
                    Digitar(Settings.Default.NumPad2All, Settings.Default.NumPad2);
                    break;
                case Key.NumPad3:
                    Digitar(Settings.Default.NumPad3All, Settings.Default.NumPad3);
                    break;
                case Key.NumPad4:
                    Digitar(Settings.Default.NumPad4All, Settings.Default.NumPad4);
                    break;
                case Key.NumPad5:
                    Digitar(Settings.Default.NumPad5All, Settings.Default.NumPad5);
                    break;
                case Key.NumPad6:
                    Digitar(Settings.Default.NumPad6All, Settings.Default.NumPad6);
                    break;
                case Key.NumPad7:
                    Digitar(Settings.Default.NumPad7All, Settings.Default.NumPad7);
                    break;
                case Key.NumPad8:
                    Digitar(Settings.Default.NumPad8All, Settings.Default.NumPad8);
                    break;
                case Key.NumPad9:
                    Digitar(Settings.Default.NumPad9All, Settings.Default.NumPad9);
                    break;
            }
        }

        //  Fiz essa função pra além de economizar código
        //  Facilita caso eu queira implementar algo novo kkkk
        private static void Digitar(bool enviarAll, string fraseMacro)
        {
            //  Verifica se a string passada tem algo
            if (string.IsNullOrEmpty(fraseMacro)) return;

            if (fraseMacro.Contains("|"))
            {
                var opcoes = fraseMacro.Split('|');
                var selecionado = opcoes[Global.Rng.Next(0, opcoes.Length)];

                fraseMacro = selecionado;
            }

            //  Verificamos se devemos enviar no all
            if (enviarAll)
            {
                //  Caso verdadeiro
                System.Windows.Forms.SendKeys.SendWait("{ENTER}/all " + fraseMacro.Replace("<nmsg>", "{ENTER}{ENTER}/all "));
            }
            else
            {
                //  Caso falso
                System.Windows.Forms.SendKeys.SendWait("{ENTER}" + fraseMacro.Replace("<nmsg>", "{ENTER}{ENTER}"));
            }
            System.Windows.Forms.SendKeys.SendWait("{ENTER}");
        }

        private void UserControlRodando_OnLoaded(object sender, RoutedEventArgs e)
        {
            _listener = new LowLevelKeyboardListener();
            _listener.OnKeyPressed += _listener_OnKeyPressed;

            _listener.HookKeyboard();
        }

        private void UserControlRodando_OnUnloaded(object sender, RoutedEventArgs e)
        {
            _listener.UnHookKeyboard();
        }
    }
}
