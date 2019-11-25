using System;
using System.Windows;

namespace Jordan.MiniBicks.UI
{
    /// <summary>
    /// Logique d'interaction pour MenuPrincipal.xaml
    /// </summary>
    public partial class MenuPrincipal : Window
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void ButtonAbs_OnClick(object sender, RoutedEventArgs e)
        {
            CreateAbs createAbs = new CreateAbs();
            createAbs.UserId.Text = UserId.Text;
            createAbs.Show();
            Close();
        }

        private void ButtonRemb_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
