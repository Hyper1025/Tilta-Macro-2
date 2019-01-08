﻿using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using TiltaMacro2.Properties;

namespace TiltaMacro2
{
    /// <summary>
    /// Interação lógica para UserControlRodando.xam
    /// </summary>
    public partial class UserControlRodando : UserControl
    {
        private LowLevelKeyboardListener _listener;

        //  Carrega o pegador
        public UserControlRodando()
        {
            InitializeComponent();
        }

        //  Evento tecla pressionada
        //  Passa para a execução
        void _listener_OnKeyPressed(object sender, KeyPressedArgs e)
        {
            ExecutarMacro(e);
        }

        //  Função de execução da macro
        private static void ExecutarMacro(KeyPressedArgs teclaArgs)
        {
            switch (teclaArgs.KeyPressed)
            {
                case Key.F1:
                    if (Settings.Default.F1 == "") return;
                    System.Windows.Forms.SendKeys.SendWait("{ENTER}");
                    if (Settings.Default.F1All)
                    {
                        System.Windows.Forms.SendKeys.SendWait("/all ");
                    }
                    System.Windows.Forms.SendKeys.SendWait(Settings.Default.F1);
                    System.Windows.Forms.SendKeys.SendWait("{ENTER}");
                    break;

                case Key.F2:
                    if (Settings.Default.F2 == "") return;
                    System.Windows.Forms.SendKeys.SendWait("{ENTER}");
                    if (Settings.Default.F2All)
                    {
                        System.Windows.Forms.SendKeys.SendWait("/all ");
                    }
                    System.Windows.Forms.SendKeys.SendWait(Settings.Default.F2);
                    System.Windows.Forms.SendKeys.SendWait("{ENTER}");
                    break;

                case Key.F3:
                    if (Settings.Default.F3 == "") return;
                    System.Windows.Forms.SendKeys.SendWait("{ENTER}");
                    if (Settings.Default.F3All)
                    {
                        System.Windows.Forms.SendKeys.SendWait("/all ");
                    }
                    System.Windows.Forms.SendKeys.SendWait(Settings.Default.F3);
                    System.Windows.Forms.SendKeys.SendWait("{ENTER}");
                    break;

                case Key.F4:
                    if (Settings.Default.F4 == "") return;
                    System.Windows.Forms.SendKeys.SendWait("{ENTER}");
                    if (Settings.Default.F4All)
                    {
                        System.Windows.Forms.SendKeys.SendWait("/all ");
                    }
                    System.Windows.Forms.SendKeys.SendWait(Settings.Default.F4);
                    System.Windows.Forms.SendKeys.SendWait("{ENTER}");
                    break;

                case Key.F5:
                    if (Settings.Default.F5 == "") return;
                    System.Windows.Forms.SendKeys.SendWait("{ENTER}");
                    if (Settings.Default.F5All)
                    {
                        System.Windows.Forms.SendKeys.SendWait("/all ");
                    }
                    System.Windows.Forms.SendKeys.SendWait(Settings.Default.F5);
                    System.Windows.Forms.SendKeys.SendWait("{ENTER}");
                    break;

                case Key.F6:
                    if (Settings.Default.F6 == "") return;
                    System.Windows.Forms.SendKeys.SendWait("{ENTER}");
                    if (Settings.Default.F6All)
                    {
                        System.Windows.Forms.SendKeys.SendWait("/all ");
                    }
                    System.Windows.Forms.SendKeys.SendWait(Settings.Default.F6);
                    System.Windows.Forms.SendKeys.SendWait("{ENTER}");
                    break;
                case Key.F7:
                    if (Settings.Default.F7 == "") return;
                    System.Windows.Forms.SendKeys.SendWait("{ENTER}");
                    if (Settings.Default.F7All)
                    {
                        System.Windows.Forms.SendKeys.SendWait("/all ");
                    }
                    System.Windows.Forms.SendKeys.SendWait(Settings.Default.F7);
                    System.Windows.Forms.SendKeys.SendWait("{ENTER}");
                    break;

                case Key.F8:
                    if (Settings.Default.F8 == "") return;
                    System.Windows.Forms.SendKeys.SendWait("{ENTER}");
                    if (Settings.Default.F8All)
                    {
                        System.Windows.Forms.SendKeys.SendWait("/all ");
                    }
                    System.Windows.Forms.SendKeys.SendWait(Settings.Default.F8);
                    System.Windows.Forms.SendKeys.SendWait("{ENTER}");
                    break;

                case Key.F9:
                    if (Settings.Default.F9 == "") return;
                    System.Windows.Forms.SendKeys.SendWait("{ENTER}");
                    if (Settings.Default.F9All)
                    {
                        System.Windows.Forms.SendKeys.SendWait("/all ");
                    }
                    System.Windows.Forms.SendKeys.SendWait(Settings.Default.F9);
                    System.Windows.Forms.SendKeys.SendWait("{ENTER}");
                    break;

                case Key.F10:
                    if (Settings.Default.F10 == "") return;
                    System.Windows.Forms.SendKeys.SendWait("{ENTER}");
                    if (Settings.Default.F10All)
                    {
                        System.Windows.Forms.SendKeys.SendWait("/all ");
                    }
                    System.Windows.Forms.SendKeys.SendWait(Settings.Default.F10);
                    System.Windows.Forms.SendKeys.SendWait("{ENTER}");
                    break;
                case Key.F11:
                    if (Settings.Default.F11 == "") return;
                    System.Windows.Forms.SendKeys.SendWait("{ENTER}");
                    if (Settings.Default.F11All)
                    {
                        System.Windows.Forms.SendKeys.SendWait("/all ");
                    }
                    System.Windows.Forms.SendKeys.SendWait(Settings.Default.F11);
                    System.Windows.Forms.SendKeys.SendWait("{ENTER}");
                    break;
                case Key.F12:
                    if (Settings.Default.F12 == "") return;
                    System.Windows.Forms.SendKeys.SendWait("{ENTER}");
                    if (Settings.Default.F12All)
                    {
                        System.Windows.Forms.SendKeys.SendWait("/all ");
                    }
                    System.Windows.Forms.SendKeys.SendWait(Settings.Default.F12);
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
