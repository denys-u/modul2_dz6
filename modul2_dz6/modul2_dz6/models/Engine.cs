namespace Modul2_dz6.Models
{
    using Modul2_dz6.Enums;

    public class Engine : Car
    {
        protected Engine(string name, double price, CreatedCountry country, CarBrands brand, ClassofCar carClass)
            : base(name, price, country, brand, carClass)
        {
        }

        public virtual double FuelConsumption { get; }
    }
}
