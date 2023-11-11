using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Buyer buyer = new Buyer();
            buyer.ID_Property = 1;
            Console.WriteLine("================================");
            Console.WriteLine("Welcom *-*!");

            Console.Write("Enter name : ");
            string name = Console.ReadLine();

            Console.Write("Enter address : ");
            string address = Console.ReadLine();

            Console.Write("Enter age : ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter number : ");
            string number = Console.ReadLine();

            Console.WriteLine("================================");

            bool isDataValid = buyer.ValidateData(name, number, age);

            if (isDataValid)
            {
                Console.WriteLine("Data is valid.");
                buyer.Name_Property = name;
                buyer.Address_Property = address;
                buyer.Age_Property = age;
                buyer.Phone_Property = int.Parse(number);
                Console.WriteLine("Data added successfully");
            }
            else
            {
                Console.WriteLine("Data is not valid.");
            }
            Console.WriteLine("================================");

            Console.ReadKey();
        }
    }
}
