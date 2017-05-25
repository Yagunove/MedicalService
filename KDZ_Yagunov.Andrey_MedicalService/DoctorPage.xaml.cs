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
using System.IO;


namespace KDZ_Yagunov.Andrey_MedicalService
{
    /// <summary>
    /// Логика взаимодействия для DoctorPage.xaml
    /// </summary>
    public partial class DoctorPage : Page
    {
        const string FileName = "Doctors.txt";
        List<Doctor> _doctorPeople = new List<Doctor>();
        public DoctorPage()


        {
            InitializeComponent();
            
        }
        private void SaveData()
        {
            using (var sw = new StreamWriter(FileName))
            {
                foreach (var doctor in _doctorPeople)
                {
                    sw.WriteLine($"{doctor.Name}:{doctor.Specialty}:{doctor.Rating}");
                }
            }
        }
        public void NewDoctorAdded(Doctor doctor)
        {
            _doctorPeople.Add(doctor);
            listBoxDoctorPeople.Items.Add($"NAME: {doctor.Name}   SPECIALTY: {doctor.Specialty}   RATING: {doctor.Rating}");
        }




        private void buttonMain1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(Pages.MainPage);


        }

        private void buttonAddDoctor_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(Pages.AddDoctorPage);
                SaveData();
        }

        //   class WriteTextFile
        // {
    //    public void WriteFile(Doctor doctor)
     //   {
       //     string text = $"{doctor.Name}, {doctor.Specialty}, {doctor.Rating}";
        //    System.IO.File.WriteAllText(@"C:\Users\yagunove\Downloads\KDZ_Yagunov.Andrey_MedicalService\KDZ_Yagunov.Andrey_MedicalService\bin\Debug\doctors.txt", text);
       // }

        //     private void RefreshListBox()
        //    {
        //         listBoxDoctorPeople.ItemsSource = null;
        //       listBoxDoctorPeople.ItemsSource = _doctorPeople;
        //    }

        private void buttonRemoveDoctor_Click(object sender, RoutedEventArgs e)
        {

            {
                listBoxDoctorPeople.Items.Remove(listBoxDoctorPeople.SelectedItem);



            }
            SaveData();
        }

        //   private void listBoxLecturers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //   {
        // If selected index = -1, we set IsEnabled to false
        //     buttonRemoveDoctor.IsEnabled = listBoxDoctorPeople.SelectedIndex != -1;
        // }
        
    }
}
    
