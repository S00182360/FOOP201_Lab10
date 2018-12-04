using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOOP201_Lab10
{
    class Bike
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Gender { get; set; }

        public Bike(int productID, string name, decimal price, string gender)
        {
            ProductID = productID;
            Name = name;
            Price = price;
            Gender = gender;
        }

        public override string ToString()
        {
            return string.Format("{0}\t{1}\t€{2:0.00}\t{3}", ProductID, Name, Price, Gender);
        }
    }
}
