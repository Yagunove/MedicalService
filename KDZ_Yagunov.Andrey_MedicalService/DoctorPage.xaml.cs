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
    /// Логика взаимодействия для DoctorPage.xaml
    /// </summary>
    public partial class DoctorPage : Page
    {
        List<Doctor> _doctorPeople = new List<Doctor>();
        public DoctorPage()
        {
            InitializeComponent();
        }
        public void NewDoctorAdded(Doctor doctor)
        {
            _doctorPeople.Add(doctor);
            listBoxDoctorPeople.ItemsSource = null;
            listBoxDoctorPeople.ItemsSource = _doctorPeople;
        }

        private void buttonMain1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(Pages.MainPage);
        }

        private void buttonAddDoctor_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(Pages.AddDoctorPage);
        }
    }



}
