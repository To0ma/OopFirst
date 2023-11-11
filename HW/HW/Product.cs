using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    //Sealed
    //allow creat object from class , but ont allow inherit everything from class
    sealed class Product : ProductInterface
    {
        //Access Modifier &  Fields
        //Private Know only of class defined it 
        private int ID;
        private string NameProduct;
        private int Price;
        private int Tax;
        private string NameSeller;


        //Properties(Encapslation)
        //to achieve a level of protection and control of access to data 
        int ProductInterface.ID
        {
            get { return ID; }
            set { ID = value; }
        }
        string ProductInterface.NameProduct
        {
            get { return NameProduct; }
            set { NameProduct = value; }
        }
        int ProductInterface.Price
        {
            get { return Price; }
            set { Price = value; }
        }
        int ProductInterface.Tax
        {
            get { return Tax; }
            set { Tax = value; }
        }
        string ProductInterface.NameSeller
        {
            get { return NameSeller; }
            set { NameSeller = value; }
        }


        //Constructor
        public Product(int id,string nameProduct,int price,int tax,string nameSeller)
        {
            this.ID = id;
            this.NameProduct = nameProduct;
            this.Price = price;
            this.Tax = tax;
            this.NameSeller=nameSeller;
        }



        //Method
        double ProductInterface.TotalPrice()
        {
            return this.Price + this.Tax;
        }
    }
}
