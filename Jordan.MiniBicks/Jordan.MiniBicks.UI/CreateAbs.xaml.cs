using System;
using System.Data;
using System.Windows;
using Jordan.MiniBicks.Lib;

namespace Jordan.MiniBicks.UI
{
    /// <summary>
    /// Logique d'interaction pour CreateAbs.xaml
    /// </summary>
    public partial class CreateAbs : Window
    {
        public CreateAbs()
        {
            InitializeComponent();
            FillComboBox();
        }

        public void FillComboBox()
        {
            DataTable data = new AbsFonction().ListAbsences();

            Categorie.ItemsSource = data.DefaultView;
            Categorie.DisplayMemberPath = "Libelle";
            Categorie.SelectedValuePath = "AbsenceId";
        }

        private void CreerUneAbsence_OnClick(object sender, RoutedEventArgs e)
        {
            int userId = Int32.Parse(UserId.Text);
            int absenceId = Int32.Parse(Categorie.SelectedValue.ToString());
            new UserFunction().CreateAbs(userId, Justificatif.Text,absenceId);
            MessageBox.Show("Absence Crée");
        }
    }
}
