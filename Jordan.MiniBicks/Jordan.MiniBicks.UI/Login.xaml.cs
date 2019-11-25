using System.Windows;
using Jordan.MiniBicks.Lib;

namespace Jordan.MiniBicks.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_OnClick(object sender, RoutedEventArgs e)
        {
            if (new UserFunction().Login(Username.Text, Password.Password))
            {
                var menuPrincipal = new MenuPrincipal();
                int userId = new UserFunction().GetUserId(Username.Text, Password.Password);
                menuPrincipal.UserId.Text = userId.ToString();
                menuPrincipal.Username.Text = Username.Text;
                menuPrincipal.Show();
                Close();
            }

        }
    }
}
