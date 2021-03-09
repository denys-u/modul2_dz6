namespace modul2_dz6.models.Cars
{
    using Modul2_dz6.Enums;
    using Modul2_dz6.models;
    using Modul2_dz6.models.Enums;
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Peugeot: Engine 
    {
        public Peugeot(string name, double price, CreatedCountry country, CarBrands brand, ClassofCar carClass)
            : base(name, price, country, brand, carClass)
        {

        }

        public CreatedCountry CreatedCountry => CreatedCountry.France;
        public ClassofCar ClassofCar => ClassofCar.D;
        public override string Name => "Peugeot";
        public override double Price => 490000;
        public CarBrands CarBrands => CarBrands.Peugeot_Soren;
    }
}
