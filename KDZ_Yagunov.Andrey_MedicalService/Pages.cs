using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDZ_Yagunov.Andrey_MedicalService
{

    // Singleton

    // Этот класс может использоваться всеми остальными для навигации
    // Так как в нем только статические элементы, можем сделать сам класс static
    static class Pages
    {
        // Создаем каждую страницу один раз на все время запуска программы
        // Для этого используем static
        private static MainPage _mainPage = new MainPage();
        private static LoginPage _loginPage = new LoginPage();
        private static WhyPage _whyPage = new WhyPage();
        private static DoctorPage _doctorPage = new DoctorPage();
        private static PatientPage _patientPage = new PatientPage();
        private static MedicamentsPage _medicamentsPage = new MedicamentsPage();
        private static AddDoctorPage _addDoctorPage = new AddDoctorPage();
        private static AddPatientPage _addPatientPage = new AddPatientPage();
        private static AddMedicamentsPage _addMedicamentsPage = new AddMedicamentsPage();

        public static LoginPage LoginPage
        {
            get
            {
                return _loginPage;
            }
        }

        public static MainPage MainPage
        {
            get
            {
                return _mainPage;
            }
        }

        public static WhyPage WhyPage
        {
            get
            {
                return _whyPage;
            }
        }
        public static DoctorPage DoctorPage
        {
            get
            {
                return _doctorPage;
            }
        }

        public static PatientPage PatientPage {
            get
            {
                return _patientPage;
            }
        }
        public static MedicamentsPage MedicamentsPage
        {
            get
            {
                return _medicamentsPage;
            }
        }
        public static AddDoctorPage AddDoctorPage
        {
            get
            {
                return _addDoctorPage;
            }
        }
        public static AddPatientPage AddPatientPage
        {
            get
            {
                return _addPatientPage;
            }
        }
        public static AddMedicamentsPage AddMedicamentsPage
        {
            get
            {
                return _addMedicamentsPage;
            }
        }
    }
}
