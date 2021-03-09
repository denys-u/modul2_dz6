using Modul2_dz6.models;
using Modul2_dz6.models.Cars;
using Modul2_dz6.Result;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modul2_dz6.Services
{
    public class TaxiService: ITaxiServise
    {
        public TaxiService()
        {
        }

        public TaxiPark ShowTaxiPark()
        {
            var car = new Car[]
            {
                new Peugeot(),
            };
        }
    }
}
