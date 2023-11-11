using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    //Interface (Polymorphism)
    internal interface ProductInterface
    {
        //Fields
        int ID { get; set; }
        string NameProduct { get; set; }
        int Price { get; set; }
        int Tax { get; set; }
        string NameSeller { get; set; }


        //Method
        double TotalPrice();
    }
}
