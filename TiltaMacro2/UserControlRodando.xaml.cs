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
                    if (Settings.Default.F1 == string.Empty) return;
                    //  Verificamos se devemos enviar no all
                    if (Settings.Default.F1All)
                    {
                        //  Caso verdadeiro
                        System.Windows.Forms.SendKeys.SendWait("{ENTER}/all " + Settings.Default.F1.Replace("<nmsg>", "{ENTER}{ENTER}/all "));
                    }
                    else
                    {
                        //  Caso falso
                        System.Windows.Forms.SendKeys.SendWait("{ENTER}" + Settings.Default.F1.Replace("<nmsg>", "{ENTER}{ENTER}"));
                    } 
                    System.Windows.Forms.SendKeys.SendWait("{ENTER}");
                    break;

                case Key.F2:
                    if (Settings.Default.F2 == string.Empty) return;
                    //  Verificamos se devemos enviar no all
                    if (Settings.Default.F2All)
                    {
                        //  Caso verdadeiro
                        System.Windows.Forms.SendKeys.SendWait("{ENTER}/all " + Settings.Default.F2.Replace("<nmsg>", "{ENTER}{ENTER}/all "));
                    }
                    else
                    {
                        //  Caso falso
                        System.Windows.Forms.SendKeys.SendWait("{ENTER}" + Settings.Default.F2.Replace("<nmsg>", "{ENTER}{ENTER}"));
                    }
                    System.Windows.Forms.SendKeys.SendWait("{ENTER}");
                    break;

                case Key.F3:
                    if (Settings.Default.F3 == string.Empty) return;
                    //  Verificamos se devemos enviar no all
                    if (Settings.Default.F3All)
                    {
                        //  Caso verdadeiro
                        System.Windows.Forms.SendKeys.SendWait("{ENTER}/all " + Settings.Default.F3.Replace("<nmsg>", "{ENTER}{ENTER}/all "));
                    }
                    else
                    {
                        //  Caso falso
                        System.Windows.Forms.SendKeys.SendWait("{ENTER}" + Settings.Default.F3.Replace("<nmsg>", "{ENTER}{ENTER}"));
                    }
                    System.Windows.Forms.SendKeys.SendWait("{ENTER}");
                    break;

                case Key.F4:
                    if (Settings.Default.F4 == string.Empty) return;
                    //  Verificamos se devemos enviar no all
                    if (Settings.Default.F4All)
                    {
                        //  Caso verdadeiro
                        System.Windows.Forms.SendKeys.SendWait("{ENTER}/all " + Settings.Default.F4.Replace("<nmsg>", "{ENTER}{ENTER}/all "));
                    }
                    else
                    {
                        //  Caso falso
                        System.Windows.Forms.SendKeys.SendWait("{ENTER}" + Settings.Default.F4.Replace("<nmsg>", "{ENTER}{ENTER}"));
                    }
                    System.Windows.Forms.SendKeys.SendWait("{ENTER}");
                    break;

                case Key.F5:
                    if (Settings.Default.F5 == string.Empty) return;
                    //  Verificamos se devemos enviar no all
                    if (Settings.Default.F5All)
                    {
                        //  Caso verdadeiro
                        System.Windows.Forms.SendKeys.SendWait("{ENTER}/all " + Settings.Default.F5.Replace("<nmsg>", "{ENTER}{ENTER}/all "));
                    }
                    else
                    {
                        //  Caso falso
                        System.Windows.Forms.SendKeys.SendWait("{ENTER}" + Settings.Default.F5.Replace("<nmsg>", "{ENTER}{ENTER}"));
                    }
                    System.Windows.Forms.SendKeys.SendWait("{ENTER}");
                    break;

                case Key.F6:
                    if (Settings.Default.F6 == string.Empty) return;
                    //  Verificamos se devemos enviar no all
                    if (Settings.Default.F6All)
                    {
                        //  Caso verdadeiro
                        System.Windows.Forms.SendKeys.SendWait("{ENTER}/all " + Settings.Default.F6.Replace("<nmsg>", "{ENTER}{ENTER}/all "));
                    }
                    else
                    {
                        //  Caso falso
                        System.Windows.Forms.SendKeys.SendWait("{ENTER}" + Settings.Default.F6.Replace("<nmsg>", "{ENTER}{ENTER}"));
                    }
                    System.Windows.Forms.SendKeys.SendWait("{ENTER}");
                    break;
                case Key.F7:
                    if (Settings.Default.F7 == string.Empty) return;
                    //  Verificamos se devemos enviar no all
                    if (Settings.Default.F7All)
                    {
                        //  Caso verdadeiro
                        System.Windows.Forms.SendKeys.SendWait("{ENTER}/all " + Settings.Default.F7.Replace("<nmsg>", "{ENTER}{ENTER}/all "));
                    }
                    else
                    {
                        //  Caso falso
                        System.Windows.Forms.SendKeys.SendWait("{ENTER}" + Settings.Default.F7.Replace("<nmsg>", "{ENTER}{ENTER}"));
                    }
                    System.Windows.Forms.SendKeys.SendWait("{ENTER}");
                    break;

                case Key.F8:
                    if (Settings.Default.F8 == string.Empty) return;
                    //  Verificamos se devemos enviar no all
                    if (Settings.Default.F8All)
                    {
                        //  Caso verdadeiro
                        System.Windows.Forms.SendKeys.SendWait("{ENTER}/all " + Settings.Default.F8.Replace("<nmsg>", "{ENTER}{ENTER}/all "));
                    }
                    else
                    {
                        //  Caso falso
                        System.Windows.Forms.SendKeys.SendWait("{ENTER}" + Settings.Default.F8.Replace("<nmsg>", "{ENTER}{ENTER}"));
                    }
                    System.Windows.Forms.SendKeys.SendWait("{ENTER}");
                    break;

                case Key.F9:
                    if (Settings.Default.F9 == string.Empty) return;
                    //  Verificamos se devemos enviar no all
                    if (Settings.Default.F9All)
                    {
                        //  Caso verdadeiro
                        System.Windows.Forms.SendKeys.SendWait("{ENTER}/all " + Settings.Default.F9.Replace("<nmsg>", "{ENTER}{ENTER}/all "));
                    }
                    else
                    {
                        //  Caso falso
                        System.Windows.Forms.SendKeys.SendWait("{ENTER}" + Settings.Default.F9.Replace("<nmsg>", "{ENTER}{ENTER}"));
                    }
                    System.Windows.Forms.SendKeys.SendWait("{ENTER}");
                    break;

                case Key.F10:
                    if (Settings.Default.F10 == string.Empty) return;
                    //  Verificamos se devemos enviar no all
                    if (Settings.Default.F10All)
                    {
                        //  Caso verdadeiro
                        System.Windows.Forms.SendKeys.SendWait("{ENTER}/all " + Settings.Default.F10.Replace("<nmsg>", "{ENTER}{ENTER}/all "));
                    }
                    else
                    {
                        //  Caso falso
                        System.Windows.Forms.SendKeys.SendWait("{ENTER}" + Settings.Default.F10.Replace("<nmsg>", "{ENTER}{ENTER}"));
                    }
                    System.Windows.Forms.SendKeys.SendWait("{ENTER}");
                    break;
                case Key.F11:
                    if (Settings.Default.F11 == string.Empty) return;
                    //  Verificamos se devemos enviar no all
                    if (Settings.Default.F11All)
                    {
                        //  Caso verdadeiro
                        System.Windows.Forms.SendKeys.SendWait("{ENTER}/all " + Settings.Default.F11.Replace("<nmsg>", "{ENTER}{ENTER}/all "));
                    }
                    else
                    {
                        //  Caso falso
                        System.Windows.Forms.SendKeys.SendWait("{ENTER}" + Settings.Default.F11.Replace("<nmsg>", "{ENTER}{ENTER}"));
                    }
                    System.Windows.Forms.SendKeys.SendWait("{ENTER}");
                    break;
                case Key.F12:
                    if (Settings.Default.F12 == string.Empty) return;
                    //  Verificamos se devemos enviar no all
                    if (Settings.Default.F12All)
                    {
                        //  Caso verdadeiro
                        System.Windows.Forms.SendKeys.SendWait("{ENTER}/all " + Settings.Default.F12.Replace("<nmsg>", "{ENTER}{ENTER}/all "));
                    }
                    else
                    {
                        //  Caso falso
                        System.Windows.Forms.SendKeys.SendWait("{ENTER}" + Settings.Default.F12.Replace("<nmsg>", "{ENTER}{ENTER}"));
                    }
                    System.Windows.Forms.SendKeys.SendWait("{ENTER}");
                    break;
                case Key.NumPad0:
                    if (Settings.Default.NumPad0 == string.Empty) return;
                    //  Verificamos se devemos enviar no all
                    if (Settings.Default.NumPad0All)
                    {
                        //  Caso verdadeiro
                        System.Windows.Forms.SendKeys.SendWait("{ENTER}/all " + Settings.Default.NumPad0.Replace("<nmsg>", "{ENTER}{ENTER}/all "));
                    }
                    else
                    {
                        //  Caso falso
                        System.Windows.Forms.SendKeys.SendWait("{ENTER}" + Settings.Default.NumPad0.Replace("<nmsg>", "{ENTER}{ENTER}"));
                    }
                    System.Windows.Forms.SendKeys.SendWait("{ENTER}");
                    break;
                case Key.NumPad1:
                    if (Settings.Default.NumPad1 == string.Empty) return;
                    //  Verificamos se devemos enviar no all
                    if (Settings.Default.NumPad1All)
                    {
                        //  Caso verdadeiro
                        System.Windows.Forms.SendKeys.SendWait("{ENTER}/all " + Settings.Default.NumPad1.Replace("<nmsg>", "{ENTER}{ENTER}/all "));
                    }
                    else
                    {
                        //  Caso falso
                        System.Windows.Forms.SendKeys.SendWait("{ENTER}" + Settings.Default.NumPad1.Replace("<nmsg>", "{ENTER}{ENTER}"));
                    }
                    System.Windows.Forms.SendKeys.SendWait("{ENTER}");
                    break;
                case Key.NumPad2:
                    if (Settings.Default.NumPad2 == string.Empty) return;
                    //  Verificamos se devemos enviar no all
                    if (Settings.Default.NumPad2All)
                    {
                        //  Caso verdadeiro
                        System.Windows.Forms.SendKeys.SendWait("{ENTER}/all " + Settings.Default.NumPad2.Replace("<nmsg>", "{ENTER}{ENTER}/all "));
                    }
                    else
                    {
                        //  Caso falso
                        System.Windows.Forms.SendKeys.SendWait("{ENTER}" + Settings.Default.NumPad2.Replace("<nmsg>", "{ENTER}{ENTER}"));
                    }
                    System.Windows.Forms.SendKeys.SendWait("{ENTER}");
                    break;
                case Key.NumPad3:
                    if (Settings.Default.NumPad3 == string.Empty) return;
                    //  Verificamos se devemos enviar no all
                    if (Settings.Default.NumPad3All)
                    {
                        //  Caso verdadeiro
                        System.Windows.Forms.SendKeys.SendWait("{ENTER}/all " + Settings.Default.NumPad3.Replace("<nmsg>", "{ENTER}{ENTER}/all "));
                    }
                    else
                    {
                        //  Caso falso
                        System.Windows.Forms.SendKeys.SendWait("{ENTER}" + Settings.Default.NumPad3.Replace("<nmsg>", "{ENTER}{ENTER}"));
                    }
                    System.Windows.Forms.SendKeys.SendWait("{ENTER}");
                    break;
                case Key.NumPad4:
                    if (Settings.Default.NumPad4 == string.Empty) return;
                    //  Verificamos se devemos enviar no all
                    if (Settings.Default.NumPad4All)
                    {
                        //  Caso verdadeiro
                        System.Windows.Forms.SendKeys.SendWait("{ENTER}/all " + Settings.Default.NumPad4.Replace("<nmsg>", "{ENTER}{ENTER}/all "));
                    }
                    else
                    {
                        //  Caso falso
                        System.Windows.Forms.SendKeys.SendWait("{ENTER}" + Settings.Default.NumPad4.Replace("<nmsg>", "{ENTER}{ENTER}"));
                    }
                    System.Windows.Forms.SendKeys.SendWait("{ENTER}");
                    break;
                case Key.NumPad5:
                    if (Settings.Default.NumPad5 == string.Empty) return;
                    //  Verificamos se devemos enviar no all
                    if (Settings.Default.NumPad5All)
                    {
                        //  Caso verdadeiro
                        System.Windows.Forms.SendKeys.SendWait("{ENTER}/all " + Settings.Default.NumPad5.Replace("<nmsg>", "{ENTER}{ENTER}/all "));
                    }
                    else
                    {
                        //  Caso falso
                        System.Windows.Forms.SendKeys.SendWait("{ENTER}" + Settings.Default.NumPad5.Replace("<nmsg>", "{ENTER}{ENTER}"));
                    }
                    System.Windows.Forms.SendKeys.SendWait("{ENTER}");
                    break;
                case Key.NumPad6:
                    if (Settings.Default.NumPad6 == string.Empty) return;
                    //  Verificamos se devemos enviar no all
                    if (Settings.Default.NumPad6All)
                    {
                        //  Caso verdadeiro
                        System.Windows.Forms.SendKeys.SendWait("{ENTER}/all " + Settings.Default.NumPad6.Replace("<nmsg>", "{ENTER}{ENTER}/all "));
                    }
                    else
                    {
                        //  Caso falso
                        System.Windows.Forms.SendKeys.SendWait("{ENTER}" + Settings.Default.NumPad6.Replace("<nmsg>", "{ENTER}{ENTER}"));
                    }
                    System.Windows.Forms.SendKeys.SendWait("{ENTER}");
                    break;
                case Key.NumPad7:
                    if (Settings.Default.NumPad7 == string.Empty) return;
                    //  Verificamos se devemos enviar no all
                    if (Settings.Default.NumPad7All)
                    {
                        //  Caso verdadeiro
                        System.Windows.Forms.SendKeys.SendWait("{ENTER}/all " + Settings.Default.NumPad7.Replace("<nmsg>", "{ENTER}{ENTER}/all "));
                    }
                    else
                    {
                        //  Caso falso
                        System.Windows.Forms.SendKeys.SendWait("{ENTER}" + Settings.Default.NumPad7.Replace("<nmsg>", "{ENTER}{ENTER}"));
                    }
                    System.Windows.Forms.SendKeys.SendWait("{ENTER}");
                    break;
                case Key.NumPad8:
                    if (Settings.Default.NumPad8 == string.Empty) return;
                    //  Verificamos se devemos enviar no all
                    if (Settings.Default.NumPad8All)
                    {
                        //  Caso verdadeiro
                        System.Windows.Forms.SendKeys.SendWait("{ENTER}/all " + Settings.Default.NumPad8.Replace("<nmsg>", "{ENTER}{ENTER}/all "));
                    }
                    else
                    {
                        //  Caso falso
                        System.Windows.Forms.SendKeys.SendWait("{ENTER}" + Settings.Default.NumPad8.Replace("<nmsg>", "{ENTER}{ENTER}"));
                    }
                    System.Windows.Forms.SendKeys.SendWait("{ENTER}");
                    break;
                case Key.NumPad9:
                    if (Settings.Default.NumPad9 == string.Empty) return;
                    //  Verificamos se devemos enviar no all
                    if (Settings.Default.NumPad9All)
                    {
                        //  Caso verdadeiro
                        System.Windows.Forms.SendKeys.SendWait("{ENTER}/all " + Settings.Default.NumPad9.Replace("<nmsg>", "{ENTER}{ENTER}/all "));
                    }
                    else
                    {
                        //  Caso falso
                        System.Windows.Forms.SendKeys.SendWait("{ENTER}" + Settings.Default.NumPad9.Replace("<nmsg>", "{ENTER}{ENTER}"));
                    }
                    System.Windows.Forms.SendKeys.SendWait("{ENTER}");
                    break;
            }
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
