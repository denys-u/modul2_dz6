namespace Modul2_dz6.models
{
    using Modul2_dz6.Enums;
    using System;
    using System.Collections.Generic;
    using System.Text;
    public abstract class Car
    {
        protected Car(double price, CreatedCountry country, CarBrands carBrand)
        {
            Price = price;
            Country = country;
        }
        public double Price { get; }
        public CreatedCountry Country { get; }
    }
}
