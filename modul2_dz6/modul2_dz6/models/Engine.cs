namespace Modul2_dz6.models
{
    using Modul2_dz6.Enums;
    using Modul2_dz6.models;
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Engine : Car
    {
        protected Engine(double price, CreatedCountry country, CarBrands brand)
            :base(price, country, brand)
        { 
        }
    }
}
