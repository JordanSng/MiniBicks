using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Jordan.MiniBicks.Lib;

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
                new MiniBicks.Lib.UserFunction().CreateUser(Nom.Text, Prenom.Text,Mdp.Password);
                MessageBox.Show("Utilisateur Enregistré");
            }
        }


    }
}
