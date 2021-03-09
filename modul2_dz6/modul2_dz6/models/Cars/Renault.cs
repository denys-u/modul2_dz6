namespace Modul2_dz6.models.Cars
{
    using Modul2_dz6.Enums;
    using Modul2_dz6.models;
    using Modul2_dz6.models.Enums;
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Renault: Engine
    {
        public Renault(string name, double price, CreatedCountry country, CarBrands brand, ClassofCar carClass)
            : base(name, price, country, brand, carClass)
        {

        }

        public CreatedCountry CreatedCountry => CreatedCountry.France;
        public ClassofCar ClassofCar => ClassofCar.B;
        public override string Name => "Renault";
        public override double Price => 213400;
        public CarBrands CarBrands => CarBrands.Renault_Logan;
    }
}
