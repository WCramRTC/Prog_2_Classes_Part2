using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Prog_2_Classes_Part2
{
    public class Bass // Change Access Modifer To Public
    {

        // Fields
        string _brand;
        string _name;
        string _numberOfStrings;
        decimal _price;
        string _color;
        int _count;

        // Constructor - That enforces that any new bass will have AT LEAST a brand, name, number of strings, color
        public Bass(string brand, string name, string numberOfStrings, string color) // Default Constructor
        {
            _brand = brand;
            _name = name;
            _numberOfStrings = numberOfStrings;
            _color = color;
        }

        //// Default Constuctor
        //public Bass()
        //{

        //}

        // Properties - Is A method that gives / restricts acccess to a field
        // access modifer - return type ( same type on field ) , name of the field, no underscore Upper Case
        public string Brand
        {
            // get; set; 
            get
            {
                return _brand;
            }
            set
            {
                _brand = value;
            }
            //set
            //{
            //    _brand = value;
            //}
        }

        public string Name { get => _name; set => _name = value; }
        public string NumberOfStrings { get => _numberOfStrings; set => _numberOfStrings = value; }
        public decimal Price { get => _price; set => _price = value; }
        public string Color { get => _color; set => _color = value; }
        public int Count { get => _count; set => _count = value; }

        // Methods

        public decimal CalculateCost()
        {
            return _count * _price;
        }

    }
}
