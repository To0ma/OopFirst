using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    //Inheritance
    //reuse,code reduction,regularization,dealing with similarities
    internal class Seller:Person
    {
        //Access Modifier &  Fields
        //Private Know only of class defined it 
        private string ProductName;

        //Properties(Encapslation)
        //to achieve a level of protection and control of access to data 
        public string ProductName_Property
        {
            get { return ProductName; }
            set { ProductName = value; }
        }

        //Constructors 
        //2.Giveing initial values to properties
        public Seller(int id, string name, string address, int age, double phone,string productName):base()
        {
            this.ID_Property = id;
            this.Name_Property = name;
            this.Address_Property = address;
            this.Age_Property = age;
            this.Phone_Property = phone;
            this.ProductName_Property = productName;
        }

        //Override Method
        public override void show()
        {
            //Message from main class
            base.show();

            //Message from dreived class
            Console.WriteLine("Customer Product Name is :{0}\n", ProductName_Property);
        }
    }
}
