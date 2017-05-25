using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KDZ_Yagunov.Andrey_MedicalService
{
    /// <summary>
    /// Логика взаимодействия для MedicamentsPage.xaml
    /// </summary>
    public partial class MedicamentsPage : Page
    {
        List<Medicaments> _meds = new List<Medicaments>();

        public MedicamentsPage()
        {
            InitializeComponent();
        }

        public void NewMedicamentsAdded(Medicaments medicaments)
        {
            _meds.Add(medicaments);
            listBoxMedicaments.Items.Add($"NAME: {medicaments.Name}   QUANTITY: {medicaments.Quantity}");
        }


        private void buttonMain3_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(Pages.MainPage);
        }

        private void buttonAddMedicaments_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(Pages.AddMedicamentsPage);
        }


        private void buttonRemoveMedicaments_Click(object sender, RoutedEventArgs e)
        {

            {
                listBoxMedicaments.Items.Remove(listBoxMedicaments.SelectedItem);



            }
        }
    }
}