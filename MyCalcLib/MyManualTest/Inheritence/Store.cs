using System;
using System.Collections.Generic;

namespace SharedCodeSnippets.Inheritence
{
    public class Store
    {
        private List<Car> allCars = new List<Car>(); 

        public void AddCar(Car car)
        {
            allCars.Add(car);
        }

        public void RemoveCar(Car car)
        {
            allCars.Remove(car);
        }

        public void ShowAllCars()
        {
            foreach (var car in allCars)
            {
                Console.WriteLine(car.Name);
            }
        }
    }
}