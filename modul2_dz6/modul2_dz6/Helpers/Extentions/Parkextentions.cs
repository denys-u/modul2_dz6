namespace Modul2_dz6.Helpers.Extentions
{
    using Modul2_dz6.models;
    using Modul2_dz6.models.Enums;
    using Modul2_dz6.Result;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public static class Parkextentions
    {
        public static Car[] FindCars(this TaxiPark taxipark, ClassofCar carClass, double minPrice, double maxPrice)
        {
            var temp = new Car[taxipark.Cars.Length];

            for (var i=0; i < temp.Length; i++)
            {
                var item = taxipark.Cars[i];
                if (item.ClassofCar == carClass && item.Price > minPrice && item.Price < maxPrice)
                {
                    temp[i] = taxipark.Cars[i];
                }
            }

            var tempResult = ArrayHelper.CleanCapasity(temp);

            var result = new Car[tempResult.Length];

            for (var i = 0; i < result.Length; i++)
            {
                result[i]= tempResult[i] as Car;
            }

            return result;
        }
    }
}
