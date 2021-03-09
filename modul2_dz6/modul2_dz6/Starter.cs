namespace Modul2_dz6
{
    using modul2_dz6.Helpers.Extentions;
    using Modul2_dz6.Enums;
    using Modul2_dz6.Helpers;
    using Modul2_dz6.Services;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Starter
    {
        private readonly ITaxiService taxiService;
        public Starter()
        {
            taxiService = new TaxiService();
        }

        public void Run()
        {
            TaxiPark();
        }

        private void TaxiPark()
        {
            var taxipark = taxiService.ShowTaxiPark();
            Array.Sort(taxipark.Cars, new CarComparer());

            for (int i = 0; i < taxipark.Cars.Length; i++)
            {
                Console.WriteLine($"Name: {taxipark.Cars[i].Name}");
            }

            Console.WriteLine($"Fuel  Consumption of Car: ");

            var cars = taxipark.FindCars(CarBrands.Peugeot_Soren, 330000, 490000);

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine($"Name: ");
            }
        }
    }
}
