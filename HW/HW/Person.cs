using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    //Abstraction
    //ont allow creat object from class , but allow inherit everything from class
    abstract class Person
    {
        //Static Fields
        //Static use without creat object from class
        static public string NameClass = "Customer Class";

        //Access Modifier &  Fields
        //Private Know only of class defined it 
        private int ID;
        private string Name;
        private string Address;
        private int Age;
        private double Phone;

        //Properties(Encapslation)
        //to achieve a level of protection and control of access to data 
        public int ID_Property
        {
            get { return ID; }
            set { ID = value; }
        }
        public string Name_Property
        {
            get { return Name; }
            set { Name = value; }
        }
        public string Address_Property
        {
            get { return Address; }
            set { Address = value; }
        }
        public int Age_Property
        {
            get { return Age; }
            set { Age = value; }
        }
        public double Phone_Property
        {
            get { return Phone; }
            set { Phone = value; }
        }
        //Constructors Overloading
        //1.Default
        public Person() { }
        //2.Giveing initial values to properties
        public Person(int id,string name,string address,int age,double phone)
        {
            this.ID_Property = id;
            this.Name_Property = name;
            this.Address_Property = address;
            this.Age_Property = age;
            this.Phone_Property= phone;
        }

        //Virtual Method
        //redefine in dreived class
        virtual public void show()
        {
            Console.WriteLine("Customer ID is :{0}\nCustomer Name is:{1}\nCustomer Address is:{2}\nCustomer Age is:{3}\nCustomer Phone is:{4}",ID_Property,Name_Property,Address_Property,Age_Property,Phone_Property);
        }

        //Method Validation
        public bool ValidateData(string name, string number, int age)
        {
            bool isNameValid = IsAlphabetic(name);
            bool isAgeValid = IsNumeric(age.ToString()) && IsAgeAvrage(age);
            bool isNumberValid = IsNumeric(number) && IsNineNumeric(number);


            return isNameValid && isNumberValid && isAgeValid;
        }

        static bool IsAlphabetic(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsLetter(c))
                {
                    Console.WriteLine("Enter the name letters only");
                    return false;
                }
            }

            return true;
        }

        static bool IsNumeric(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsDigit(c))
                {
                    Console.WriteLine("Enter phone number numbers only");
                    return false;
                }
            }

            return true;
        }
        static bool IsNineNumeric(string input)
        {
            if (input.Length < 9)
            {
                Console.WriteLine("A number of less than nine digits");
                return false;
            }
            return true;
        }
        static bool IsAgeAvrage(int input)
        {
            if (input >= 120)
            {
                Console.WriteLine("Age over 120");
                return false;
            }
            return true;
        }

    }
}
