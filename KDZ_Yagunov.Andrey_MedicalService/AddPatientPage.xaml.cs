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
    /// Логика взаимодействия для AddPatientPage.xaml
    /// </summary>
    public partial class AddPatientPage : Page
    {
        Patient patient;

        public AddPatientPage()
        {
            InitializeComponent();
        }

        public void buttonAddPatient_Click(object sender, RoutedEventArgs e)
        {
            int age;
            if (!int.TryParse(textBoxPatientAge.Text, out age))
            {
                MessageBox.Show("Некорректное значение возраста");
                textBoxPatientAge.Focus();
                return;
            }
            if (age < 0 || age > 146)
            {
                MessageBox.Show("Он не может быть настолько старым! Рекорд по продолжительности жизни - 146 лет");
                textBoxPatientAge.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxPatientName.Text))
            {
                MessageBox.Show("Необходимо ввести имя");
                textBoxPatientName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxPatientDiagnosis.Text))
            {
                MessageBox.Show("Необходимо ввести диагноз");
                textBoxPatientDiagnosis.Focus();
                return;
            }

            patient = new Patient(textBoxPatientName.Text, age, textBoxPatientDiagnosis.Text);
            textBoxPatientName.Text = "";
            textBoxPatientAge.Text = "";
            textBoxPatientDiagnosis.Text = "";
            Pages.PatientPage.NewPatientAdded(patient);
            NavigationService.GoBack();

        } 
        private void buttonBackToPatientPage_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(Pages.PatientPage);
        }

        private void textBoxDoctorRating_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }

}

