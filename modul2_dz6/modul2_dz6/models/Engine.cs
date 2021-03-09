namespace Modul2_dz6.models
{
    using Modul2_dz6.Enums;
    using Modul2_dz6.models;
    using Modul2_dz6.models.Enums;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Engine : Car
    {
        protected Engine(string name, double price, CreatedCountry country, CarBrands brand, ClassofCar carClass)
            :base(name, price, country, brand, carClass)
        { 
        }

        public virtual double FuelConsumption { get; }
    }
}
