namespace Modul2_dz6.Services
{
    using Modul2_dz6.models;
    using Modul2_dz6.models.Cars;
    using Modul2_dz6.Result;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class TaxiService: ITaxiService
    {
        public TaxiService()
        {
        }

        public TaxiPark ShowTaxiPark()
        {
            var car = new Car[]
            {
                new Peugeot("Peugeot", 490000, Enums.CreatedCountry.France, Enums.CarBrands.Peugeot_Soren, models.Enums.ClassofCar.D),
                new Renault("Renault", 213400, Enums.CreatedCountry.France, Enums.CarBrands.Renault_Logan, models.Enums.ClassofCar.B),
                new Toyota("Toyota", 760900, Enums.CreatedCountry.Japan, Enums.CarBrands.Toyota_Corolla, models.Enums.ClassofCar.С),
                new Volkswagen("Volkswagen", 430000, Enums.CreatedCountry.Germany, Enums.CarBrands.Volkswagen_Golf, models.Enums.ClassofCar.С),
            };
        }
    }
}
