namespace Modul2_dz6.Models.Cars
{
    using Modul2_dz6.Enums;
    using Modul2_dz6.models;
    using Modul2_dz6.models.Enums;

    public class Volkswagen : Engine
    {
        public Volkswagen(string name, double price, CreatedCountry country, CarBrands brand, ClassofCar carClass)
            : base(name, price, country, brand, carClass)
        {
        }

        public CreatedCountry CreatedCountry => CreatedCountry.Germany;

        public ClassofCar ClassofCar => ClassofCar.С;

        public override string Name => "Volkswagen";

        public override double Price => 430000;

        public CarBrands CarBrands => CarBrands.Volkswagen_Golf;
    }
}
