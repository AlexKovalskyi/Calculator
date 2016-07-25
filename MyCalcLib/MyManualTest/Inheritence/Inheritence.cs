using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedCodeSnippets.Inheritence
{
    public static class Inheritence
    {
        public static void Run()
        {
            Car lada = new Car()
            {
                Name = "Lada",
                Speed = 120,
                Cost = 9000
            };

            Car lada2 = new Car()
            {
                Name = "Lada",
                Speed = 120,
                Cost = 9000
            };

            bool isEqual = lada.Equals(lada2);
            Console.WriteLine($"Is equal {isEqual}");
            object someObj = lada;

            Console.WriteLine(someObj);

            Car bmw = new Car()
            {
                Name = "BMW",
                Speed = 180,
                Cost = 35000
            };

            Car opel = new Car()
            {
                Name = "Opel",
                Speed = 150,
                Cost = 13000
            };

            Truck renoTruck = new Truck()
            {
                Name = "RENO",
                Cost = 22000,
                Speed = 140,
                Сarrying = 22
            };

            Miniwan miniwan = new Miniwan()
            {
                Name = "Rex",
                Cost = 12000,
                Passenger = 10,
                Speed = 110
            };

            Car[] abroadCars = { lada, bmw, opel, miniwan, renoTruck };
            Store store = new Store();
            foreach (var car in abroadCars)
            {
                store.AddCar(car);
            }

            Car boxedTruck = renoTruck; // Boxing 
            Truck unboxedTruck = (Truck)renoTruck; //Unboxing

            store.RemoveCar(renoTruck);

            store.ShowAllCars();
        }

    }
}
