namespace Modul2_dz6.models
{
    using Modul2_dz6.Enums;
    using Modul2_dz6.models.Enums;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class Car
    {
        protected Car(string name, double price, CreatedCountry country, CarBrands brand, ClassofCar carClass)
        {
            Name = name;
            Price = price;
            Country = country;
            Brand = brand;
            CarClass = carClass;
        }

        public virtual string Name { get; }
        public virtual double Price { get; }
        public CreatedCountry Country { get; }
        public CarBrands Brand { get; }
        public ClassofCar CarClass { get; }
    }
}
