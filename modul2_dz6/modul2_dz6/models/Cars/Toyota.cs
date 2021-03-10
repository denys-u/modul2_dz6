namespace Modul2_dz6.Models.Cars
{
    using Modul2_dz6.Enums;
    using Modul2_dz6.models;
    using Modul2_dz6.models.Enums;

    public class Toyota : Engine
    {
        public Toyota(string name, double price, CreatedCountry country, CarBrands brand, ClassofCar carClass)
            : base(name, price, country, brand, carClass)
        {
        }

        public CreatedCountry CreatedCountry => CreatedCountry.Japan;

        public ClassofCar ClassofCar => ClassofCar.С;

        public override string Name => "Toyota";

        public override double Price => 760900;

        public CarBrands CarBrands => CarBrands.Toyota_Corolla;
    }
}
