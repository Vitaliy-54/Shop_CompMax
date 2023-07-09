using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop.Data.Models;

namespace Shop.ViewModels
{
    public class CarsListViewModel
    {
        public IEnumerable<Car> allCars { get; set; }//получает все товары
        public string currCategory { get; set; }//переменная, в нее помещаем категорию с которой сейчас работаем

    }
}
