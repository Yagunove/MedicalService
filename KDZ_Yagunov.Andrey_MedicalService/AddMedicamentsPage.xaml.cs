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
    /// Логика взаимодействия для AddMedicamentsPage.xaml
    /// </summary>
    public partial class AddMedicamentsPage : Page
    {
        Medicaments medicaments;
        public AddMedicamentsPage()
        {
            InitializeComponent();
        }

        public void buttonAddMedicaments_Click(object sender, RoutedEventArgs e)
        {
            int quantity;
            if (!int.TryParse(textBoxMedicamentsQuantity.Text, out quantity))
            {
                MessageBox.Show("Некорректное значение количества");
                textBoxMedicamentsQuantity.Focus();
                return;
            }
            if (quantity < 0)
            {
                MessageBox.Show("Количество должно быть больше 0");
                textBoxMedicamentsQuantity.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxMedicamentsName.Text))
            {
                MessageBox.Show("Необходимо ввести название");
                textBoxMedicamentsName.Focus();
                return;
            }

            medicaments = new Medicaments(textBoxMedicamentsName.Text, quantity);
            textBoxMedicamentsName.Text = "";
            textBoxMedicamentsQuantity.Text = "";
            Pages.MedicamentsPage.NewMedicamentsAdded(medicaments);
            NavigationService.GoBack();
        }

        private void buttonBackToMedicamentsPage_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(Pages.MedicamentsPage);
        }

        private void textBoxMedicamentsQuantity_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }

}
