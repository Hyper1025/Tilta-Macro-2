using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using TiltaMacro2.Properties;

namespace TiltaMacro2
{
    /// <summary>
    /// Interação lógica para UserControlConfig.xam
    /// </summary>
    public partial class UserControlConfig : UserControl
    {
        private LowLevelKeyboardListener _listener;

        //  Carrega o pegador
        public UserControlConfig()
        {
            InitializeComponent();
            Global.EditandoKey = Key.None;
        }

        private void UserControlConfig_OnLoaded(object sender, RoutedEventArgs e)
        {
            _listener = new LowLevelKeyboardListener();
            _listener.OnKeyPressed += _listener_OnKeyPressed;

            _listener.HookKeyboard();
        }

        private void UserControlConfig_OnUnloaded(object sender, RoutedEventArgs e)
        {
            _listener.UnHookKeyboard();
        }

        private void ButtonSalvar_OnClick(object sender, RoutedEventArgs e)
        {
            LabelTop.Content = "SALVO";
            LabelF.Content = "F_";
            Global.EditandoKey = Key.None;
            TextBoxTextoMacro.IsEnabled = false;
            ButtonSalvar.IsEnabled = false;
            CheckBoxAll.IsEnabled = false;
            Settings.Default.Save();

            Global.GlobalGridPrincipal.Children.Clear();
            Global.GlobalGridPrincipal.Children.Add(new Salvo());
        }

        private void _listener_OnKeyPressed(object sender, KeyPressedArgs e)
        {
            if(e.KeyPressed.Equals(Key.F1) || e.KeyPressed.Equals(Key.F2) || e.KeyPressed.Equals(Key.F3) || e.KeyPressed.Equals(Key.F4) || e.KeyPressed.Equals(Key.F5) || e.KeyPressed.Equals(Key.F6) || e.KeyPressed.Equals(Key.F7) || e.KeyPressed.Equals(Key.F8) || e.KeyPressed.Equals(Key.F9) || e.KeyPressed.Equals(Key.F10) || e.KeyPressed.Equals(Key.F11) || e.KeyPressed.Equals(Key.F12))
            {
                LabelF.Content = e.KeyPressed.ToString();
                Global.EditandoKey = e.KeyPressed;

                TextBoxTextoMacro.IsEnabled = true;
                ButtonSalvar.IsEnabled = true;
                CheckBoxAll.IsEnabled = true;
                TextBoxTextoMacro.Focus();
            }


            switch (Global.EditandoKey)
                {
                    case Key.F1:
                        TextBoxTextoMacro.Text = Settings.Default.F1;
                        CheckBoxAll.IsChecked = Settings.Default.F1All;
                    break;
                    case Key.F2:
                        TextBoxTextoMacro.Text = Settings.Default.F2;
                        CheckBoxAll.IsChecked = Settings.Default.F2All;
                    break;

                    case Key.F3:
                        TextBoxTextoMacro.Text = Settings.Default.F3;
                        CheckBoxAll.IsChecked = Settings.Default.F3All;
                    break;

                    case Key.F4:
                        TextBoxTextoMacro.Text = Settings.Default.F4;
                        CheckBoxAll.IsChecked = Settings.Default.F4All;
                    break;

                    case Key.F5:
                        TextBoxTextoMacro.Text = Settings.Default.F5;
                        CheckBoxAll.IsChecked = Settings.Default.F5All;
                    break;

                    case Key.F6:
                        TextBoxTextoMacro.Text = Settings.Default.F6;
                        CheckBoxAll.IsChecked = Settings.Default.F6All;
                    break;
                    case Key.F7:
                        TextBoxTextoMacro.Text = Settings.Default.F7;
                        CheckBoxAll.IsChecked = Settings.Default.F7All;
                    break;

                    case Key.F8:
                        TextBoxTextoMacro.Text = Settings.Default.F8;
                        CheckBoxAll.IsChecked = Settings.Default.F8All;
                    break;

                    case Key.F9:
                        TextBoxTextoMacro.Text = Settings.Default.F9;
                        CheckBoxAll.IsChecked = Settings.Default.F9All;
                    break;

                    case Key.F10:
                        TextBoxTextoMacro.Text = Settings.Default.F10;
                        CheckBoxAll.IsChecked = Settings.Default.F10All;
                    break;
                case Key.F11:
                    TextBoxTextoMacro.Text = Settings.Default.F11;
                    CheckBoxAll.IsChecked = Settings.Default.F11All;
                    break;
                    case Key.F12:
                        TextBoxTextoMacro.Text = Settings.Default.F12;
                        CheckBoxAll.IsChecked = Settings.Default.F12All;
                    break;
            }
        }

        private void TextBoxTextoMacro_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            LabelTop.Content = "CONFIGURANDO";

            switch (Global.EditandoKey)
            {
                case Key.F1:
                    Settings.Default.F1 = TextBoxTextoMacro.Text;
                    break;
                case Key.F2:
                    Settings.Default.F2 = TextBoxTextoMacro.Text;
                    break;

                case Key.F3:
                    Settings.Default.F3 = TextBoxTextoMacro.Text;
                    break;

                case Key.F4:
                    Settings.Default.F4 = TextBoxTextoMacro.Text;
                    break;

                case Key.F5:
                    Settings.Default.F5 = TextBoxTextoMacro.Text;
                    break;

                case Key.F6:
                    Settings.Default.F6 = TextBoxTextoMacro.Text;
                    break;
                case Key.F7:
                    Settings.Default.F7 = TextBoxTextoMacro.Text;
                    break;

                case Key.F8:
                    Settings.Default.F8 = TextBoxTextoMacro.Text;
                    break;

                case Key.F9:
                    Settings.Default.F9 = TextBoxTextoMacro.Text;
                    break;

                case Key.F10:
                    Settings.Default.F10 = TextBoxTextoMacro.Text;
                    break;
                case Key.F11:
                    Settings.Default.F11 = TextBoxTextoMacro.Text;
                    break;
                case Key.F12:
                    Settings.Default.F12 = TextBoxTextoMacro.Text;
                    break;
            }
        }

        //  Ao clicar no botão, passa isso para as configurações, porém não salva
        private void CheckBoxAll_OnClick(object sender, RoutedEventArgs e)
        {
            switch (Global.EditandoKey)
            {
                case Key.F1:
                    if (CheckBoxAll.IsChecked != null) Settings.Default.F1All = CheckBoxAll.IsChecked.Value;
                    break;
                case Key.F2:
                    if (CheckBoxAll.IsChecked != null) Settings.Default.F2All = CheckBoxAll.IsChecked.Value;
                    break;

                case Key.F3:
                    if (CheckBoxAll.IsChecked != null) Settings.Default.F3All = CheckBoxAll.IsChecked.Value;
                    break;

                case Key.F4:
                    if (CheckBoxAll.IsChecked != null) Settings.Default.F4All = CheckBoxAll.IsChecked.Value;
                    break;

                case Key.F5:
                    if (CheckBoxAll.IsChecked != null) Settings.Default.F5All = CheckBoxAll.IsChecked.Value;
                    break;

                case Key.F6:
                    if (CheckBoxAll.IsChecked != null) Settings.Default.F6All = CheckBoxAll.IsChecked.Value;
                    break;
                case Key.F7:
                    if (CheckBoxAll.IsChecked != null) Settings.Default.F7All = CheckBoxAll.IsChecked.Value;
                    break;

                case Key.F8:
                    if (CheckBoxAll.IsChecked != null) Settings.Default.F8All = CheckBoxAll.IsChecked.Value;
                    break;

                case Key.F9:
                    if (CheckBoxAll.IsChecked != null) Settings.Default.F9All = CheckBoxAll.IsChecked.Value;
                    break;

                case Key.F10:
                    if (CheckBoxAll.IsChecked != null) Settings.Default.F10All = CheckBoxAll.IsChecked.Value;
                    break;
                case Key.F11:
                    if (CheckBoxAll.IsChecked != null) Settings.Default.F11All = CheckBoxAll.IsChecked.Value;
                    break;
                case Key.F12:
                    if (CheckBoxAll.IsChecked != null) Settings.Default.F12All = CheckBoxAll.IsChecked.Value;
                    break;
            }
        }

        //  Limpa todas as configs
        private void ButtonLimparTudo_OnClick(object sender, RoutedEventArgs e)
        {
            Global.GlobalGridPrincipal.Children.Clear();
            Global.GlobalGridPrincipal.Children.Add(new UserControlLimpar());
        }
    }
}
