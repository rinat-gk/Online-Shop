using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Interfaces
{
    interface IAllCars
    {
        IEnumerable<Car> Cars { get; set; }

        IEnumerable<Car> getFavCars { get; set; }


    }
}
