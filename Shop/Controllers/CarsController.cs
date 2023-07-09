using Microsoft.AspNetCore.Mvc;
using Shop.Data.interfaces;
using Shop.Data.Models;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class CarsController : Controller
    {
        // это результат который идет в виде html странички
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;
        //конструктор
        public CarsController(IAllCars iAllCars, ICarsCategory iCarsCat)
        {
            _allCars = iAllCars;
            _allCategories = iCarsCat;

        }

        [Route("Cars/List")]
        [Route("Cars/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Car> cars = null;
            string currCategory = "";
            if (string.IsNullOrEmpty(category))
            {
                cars = _allCars.Cars.OrderBy(i => i.id);
            }
            else
            {
                if (string.Equals("videocard", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Видеокарты")).OrderBy(i => i.id);
                    currCategory = "Видеокарты";
                }
                if (string.Equals("motherboard", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Материнские платы")).OrderBy(i => i.id);
                    currCategory = "Материнские платы";
                }
                if (string.Equals("cpu", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Процессоры")).OrderBy(i => i.id);
                    currCategory = "Процессоры";
                }
                if (string.Equals("dram", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Оперативная память")).OrderBy(i => i.id);
                    currCategory = "Оперативная память";
                }
                if (string.Equals("powersupply", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Блоки питания")).OrderBy(i => i.id);
                    currCategory = "Блоки питания";
                }
                if (string.Equals("hdd", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Жесткие диски")).OrderBy(i => i.id);
                    currCategory = "Жесткие диски";
                }
                if (string.Equals("ssd", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Твердотельные накопители")).OrderBy(i => i.id);
                    currCategory = "Твердотельные накопители (SSD)";
                }
                if (string.Equals("fan", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Системы охлаждения")).OrderBy(i => i.id);
                    currCategory = "Системы охлаждения";
                }
                if (string.Equals("case", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Корпуса")).OrderBy(i => i.id);
                    currCategory = "Корпуса";
                }
				if (string.Equals("router", category, StringComparison.OrdinalIgnoreCase))
				{
					cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Маршрутизаторы")).OrderBy(i => i.id);
					currCategory = "Маршрутизаторы";
				}
				if (string.Equals("switch", category, StringComparison.OrdinalIgnoreCase))
				{
					cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Коммутаторы")).OrderBy(i => i.id);
					currCategory = "Коммутаторы";
				}
				if (string.Equals("amplifier", category, StringComparison.OrdinalIgnoreCase))
				{
					cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Усилители Wi-Fi")).OrderBy(i => i.id);
					currCategory = "Усилители Wi-Fi";
				}
				if (string.Equals("wirelessadapter", category, StringComparison.OrdinalIgnoreCase))
				{
					cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Беспроводные адаптеры")).OrderBy(i => i.id);
					currCategory = "Беспроводные адаптеры";
				}
				if (string.Equals("cable", category, StringComparison.OrdinalIgnoreCase))
				{
					cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Сетевые кабели")).OrderBy(i => i.id);
					currCategory = "Сетевые кабели";
				}
				if (string.Equals("wirelessap", category, StringComparison.OrdinalIgnoreCase))
				{
					cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Точки доступа")).OrderBy(i => i.id);
					currCategory = "Точки доступа";
				}
				if (string.Equals("mouse", category, StringComparison.OrdinalIgnoreCase))
				{
					cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Мыши")).OrderBy(i => i.id);
					currCategory = "Мыши";
				}
				if (string.Equals("keyboards", category, StringComparison.OrdinalIgnoreCase))
				{
					cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Клавиатуры")).OrderBy(i => i.id);
					currCategory = "Клавиатуры";
				}
				if (string.Equals("mousepad", category, StringComparison.OrdinalIgnoreCase))
				{
					cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Коврики для мыши")).OrderBy(i => i.id);
					currCategory = "Коврики для мыши";
				}
				if (string.Equals("controllers", category, StringComparison.OrdinalIgnoreCase))
				{
					cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Игровые контроллеры")).OrderBy(i => i.id);
					currCategory = "Игровые контроллеры";
				}
				if (string.Equals("display", category, StringComparison.OrdinalIgnoreCase))
				{
					cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Мониторы")).OrderBy(i => i.id);
					currCategory = "Мониторы";
				}
				if (string.Equals("printers", category, StringComparison.OrdinalIgnoreCase))
				{
					cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Принтеры")).OrderBy(i => i.id);
					currCategory = "Принтеры";
				}
				if (string.Equals("projectors", category, StringComparison.OrdinalIgnoreCase))
				{
					cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Проекторы")).OrderBy(i => i.id);
					currCategory = "Проекторы";
				}
				if (string.Equals("sound", category, StringComparison.OrdinalIgnoreCase))
				{
					cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Колонки")).OrderBy(i => i.id);
					currCategory = "Колонки";
				}
				if (string.Equals("headphones", category, StringComparison.OrdinalIgnoreCase))
				{
					cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Наушники")).OrderBy(i => i.id);
					currCategory = "Наушники";
				}


			}
			var carobj = new CarsListViewModel
            {
                allCars = cars,
                currCategory = currCategory
            };

            ViewBag.Title = "Магазин компьютерных комплектующих CompMax";
            return View(carobj);
        }

    }
}
