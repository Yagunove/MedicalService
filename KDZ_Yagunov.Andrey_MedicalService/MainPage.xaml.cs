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
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void buttonDoctor_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(Pages.DoctorPage);
        }

                    private void buttonPatient_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(Pages.PatientPage);
        
        }

        private void buttonMedicaments_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(Pages.MedicamentsPage);
        }
    }
    }

