using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDZ_Yagunov.Andrey_MedicalService
{
    public class Patient
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _age;

        public string Age
        {
            get { return _age; }
            set { _age = value; }
        }
        //оценка состояния здоровоья от 1 до 10
        //сделать проверку ввода в рамках данных значений
        private int _status;

        public int Status
        {
            get { return _status; }
            set { _status = value; }
        }
        private string _diagnosis;

        public string Diagnosis
        {
            get { return _diagnosis; }
            set { _diagnosis = value; }
        }
        public Patient(string name, string age, int status, string diagnosis)
        {
            _name = name;
            _age = age;
            _status = status;
            _diagnosis = diagnosis;

        }
    }
}