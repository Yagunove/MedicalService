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
    /// Логика взаимодействия для PatientPage.xaml
    /// </summary>
    public partial class PatientPage : Page
    {
        List<Patient> _patient = new List<Patient>();
        public PatientPage()
        {
            InitializeComponent();
        }
        public void NewPatientAdded(Patient patient)
        {
            _patient.Add(patient);
            listBoxPatient.Items.Add($"NAME: {patient.Name}   AGE: {patient.Age}   DIAGNOSIS: {patient.Diagnosis}");
        }

        private void buttonRemovePatient_Click(object sender, RoutedEventArgs e)
        {

            {
                listBoxPatient.Items.Remove(listBoxPatient.SelectedItem);



            }
        }

        private void buttonMain2_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(Pages.MainPage);
        }
        private void buttonAddPatient_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(Pages.AddPatientPage);
        }
    }
}
