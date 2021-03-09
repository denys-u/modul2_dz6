namespace Modul2_dz6.Helpers
{
    using Modul2_dz6.models;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    public class CarComparer: IComparer
    {
        public int Compare(object first, object second)
        {
            var x = first as Car;
            var y = second as Car;

            if (x.Name.Length > y.Name.Length)
            {
                return 1;
            }
            else if (x.Name.Length < y.Name.Length)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
