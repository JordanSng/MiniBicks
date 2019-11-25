using System.Windows;

namespace Jordan.MiniBicks.UI
{
    /// <summary>
    /// Logique d'interaction pour CreateUser.xaml
    /// </summary>
    public partial class CreateUser : Window
    {
        public CreateUser()
        {
            InitializeComponent();
        }

        private void CrUser_OnClick(object sender, RoutedEventArgs e)
        {
            if (Mdp.Password == ConfMdp.Password)
            {
                new MiniBicks.Lib.UserFunction().CreateUser(Nom.Text, Prenom.Text, Login.Text,Address.Text,Mdp.Password);
                MessageBox.Show("Utilisateur Enregistré");
            }
            else
            {
                MessageBox.Show("Les mots de passes ne sont pas identiques");

            }
        }


    }
}
