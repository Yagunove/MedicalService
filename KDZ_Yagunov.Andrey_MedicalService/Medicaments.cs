using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDZ_Yagunov.Andrey_MedicalService
{
    public class Medicaments
    {
        public string Name { get; set; }
        public int Quantity { get; set; }


        public Medicaments(string name, int quantity)
        {
            Name = name;
            Quantity = quantity;

        }
    }
}