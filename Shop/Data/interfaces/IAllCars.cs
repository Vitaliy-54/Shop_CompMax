using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> Cars { get; }//возвращает список
        IEnumerable<Car> getFavCars { get; }
        Car getobjectCar(int carId);
        //возвращает один обьект на основе класса Car
    }
}
