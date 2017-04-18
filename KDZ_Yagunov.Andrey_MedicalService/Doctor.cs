using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDZ_Yagunov.Andrey_MedicalService
{

    public class Doctor
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _specialty;
       //Хирург, стоматолог, проктолог и т.д.
        public string Specialty
        {
            get { return _specialty; }
            set { _specialty = value; }
        }
        
        private int _rating;

        public int Rating
        {
            get { return _rating; }
            set { _rating = value; }
        }

        public string Information
        {
            get
            {
                return $"{_name} - {_specialty} - {_rating}";
            }
        }

        public Doctor(string name, string specialty, int rating)
        {
            _name = name;
            _specialty = specialty;
            _rating = rating;

        }
    }
}
