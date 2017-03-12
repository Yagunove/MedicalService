using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDZ_Yagunov.Andrey_MedicalService
{
    public class Medicaments
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _type;

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        // должно быть >0
        private int _quantity;

        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        public string Info
        {
            get
            {
                return $"{_name} - {_type} - {_quantity}";
            }
        }

        public Medicaments(string name, string type, int quantity)
        {
            _name = name;
            _type = type;
            _quantity = quantity;

        }
    }
}