using oop_lesson_4_parking.Models;
using System;

namespace oop_lesson_4_parking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******************* Parking Application *******************");

            Driver driver = new Driver();

            driver.CreateClasses();
            driver.PopulateCarPark();


        }
    }
}
