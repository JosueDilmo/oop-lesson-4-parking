using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lesson_4_parking.Models
{
    public class Driver
    {

        public Driver()
        {
            Console.WriteLine("Starting Driver Class");
        }

        public void CreateClasses()
        {

            Carpark carpark = new Carpark();
            Console.WriteLine(carpark.ToString());

            Customer customer = new Customer("D2020", 3);
            Console.WriteLine(customer.ToString());

            CarparkCharge carparkcharge = new CarparkCharge();
            Console.WriteLine(carparkcharge.ToString());
        }



        public void PopulateCarPark()
        {
            Console.WriteLine("PopulateCarPark");
            Carpark carpark = new Carpark();

            Customer c1 = new Customer("D2020", 2);
            Customer c2 = new Customer("C2020", 4);
            Customer c3 = new Customer("E2020", 6);
            Customer c4 = new Customer("F2020", 8);
            Customer c5 = new Customer("G2020", 10);

            carpark.listOfCustomers.Add(c1);
            carpark.listOfCustomers.Add(c2);
            carpark.listOfCustomers.Add(c3);
            carpark.listOfCustomers.Add(c4);
            carpark.listOfCustomers.Add(c5);

            carpark.CalculateCharges();

        }
    }
}