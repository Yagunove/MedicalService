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
    /// Логика взаимодействия для AddDoctorPage.xaml
    /// </summary>
    public partial class AddDoctorPage : Page
    {
        Doctor doctor;

        public AddDoctorPage()
        {
            InitializeComponent();
        }

        public void buttonAddDoctor_Click(object sender, RoutedEventArgs e)
        {
            int rating;
            if (!int.TryParse(textBoxDoctorRating.Text, out rating))
            {
                MessageBox.Show("Некорректное значение рейтинга");
                textBoxDoctorRating.Focus();
                return;
            }
            if (rating < 0 || rating > 10)
            {
                MessageBox.Show("Рейтинг должен быть от 0 до 10 включительно");
                textBoxDoctorRating.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxDoctorName.Text))
            {
                MessageBox.Show("Необходимо ввести имя");
                textBoxDoctorName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxDoctorSpecialty.Text))
            {
                MessageBox.Show("Необходимо ввести специальность");
                textBoxDoctorName.Focus();
                return;
            }

            doctor = new Doctor(textBoxDoctorName.Text, textBoxDoctorSpecialty.Text, rating);
            textBoxDoctorName.Text = "";
            Pages.DoctorPage.NewDoctorAdded(doctor);
            NavigationService.GoBack();
        }

        private void buttonBackToDoctorPage_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(Pages.DoctorPage);
        }

        private void textBoxDoctorRating_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }

}
