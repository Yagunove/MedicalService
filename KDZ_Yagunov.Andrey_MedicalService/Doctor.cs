using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDZ_Yagunov.Andrey_MedicalService
{

    public class Doctor
    {
        public string Name { get; set; }
        public string Specialty { get; set; }
        public int Rating { get; set; }
 

        public Doctor(string name, string specialty, int rating)
        {
            Name = name;
            Specialty = specialty;
            Rating = rating;

        }
    }
}
