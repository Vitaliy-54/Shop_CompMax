using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Shop.Data
{
    public class DBobjects
    {//все функции будут статические, что бы к ним можно было обращаться просто по имени функции из 
        // других классов
        public static void Initial(AppDBContent content)
        {
            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));
            //добавляем все необходимые объекты товаров
            if (!content.Car.Any())
            {
                content.AddRange(
                     new Car
                     {
                         name = "Видеокарта MSI GeForce GTX 1660 Super Ventus XS OC",
                         shortDesc = "6 ГБ GDDR6, 1530 МГц / 1815 МГц, 1408sp, 192 бит, 2 слота, питание 8 pin, HDMI, DisplayPort",
                         img = "/img/1660s.jpg",
                         price = 799,
                         isFavourite = true,
                         available = true,
                         Category = Categories["Видеокарты"]
                     },
                     new Car
                     {
                    name = "Материнская плата Gigabyte B550 Gaming X V2",
                         shortDesc = "6 ГБ GDDR6, 1530 МГц / 1815 МГц, 1408sp, 192 бит, 2 слота, питание 8 pin, HDMI, DisplayPort",
                         img = "/img/Gigabyte B550 Gaming X V2.jpg",
                         price = 396,
                         isFavourite = true,
                         available = true,
                         Category = Categories["Материнские платы"]
                     },
                     new Car
                     {
                         name = "Процессор Intel Core i5-12400F",
                         shortDesc = "Alder Lake, LGA1700, 6 ядер, частота 4.4/2.5 ГГц, кэш 7.5 МБ + 18 МБ, техпроцесс 10 нм, TDP 117W",
                         img = "/img/i5-12400F.jpg",
                         price = 518,
                         isFavourite = true,
                         available = true,
                         Category = Categories["Процессоры"]
                     },
                     new Car
                     {
                         name = "Оперативная память Kingston FURY Beast 2x8GB DDR4",
                         shortDesc = "16 ГБ, 2 модуля DDR4 DIMM по 8 ГБ, частота 3200 МГц, CL 16T, тайминги 16-18-18, 1.35 В",
                         img = "/img/kingston fury.jpg",
                         price = 144,
                         isFavourite = true,
                         available = true,
                         Category = Categories["Оперативная память"]
                     },
                     new Car
                         {
                         name = "Блок питания DeepCool PK800D",
                         shortDesc = "800 Вт, активная PFC, КПД 85%, бронзовый сертификат, вентилятор 1x120 мм, 12V 66.5 А",
                         img = "/img/DeepCool PK800D.jpg",
                         price = 230,
                         isFavourite = true,
                         available = true,
                         Category = Categories["Блоки питания"]
                         },
                     new Car
                     {
                         name = "Жесткий диск WD Caviar Blue 1TB (WD10EZEX)",
                         shortDesc = "3.5\", SATA 3.0 (6Gbps), 7200 об/мин, буфер 64 МБ, линейная скорость 150/150 МБ/с",
                         img = "/img/WD10EZEX.jpg",
                         price = 134,
                         isFavourite = true,
                         available = true,
                         Category = Categories["Жесткие диски"]
                     },
                     new Car
                     {
                         name = "SSD Kingston A400 480GB",
                         shortDesc = "480 ГБ, 2.5\", SATA 3.0, микросхемы 3D TLC NAND, последовательный доступ: 500/450 МБайт/с",
                         img = "/img/KingstonSSD.jpg",
                         price = 88,
                         isFavourite = true,
                         available = true,
                         Category = Categories["Твердотельные накопители"]
                     },
                     new Car
                     {
                         name = "Кулер для процессора PCCooler GI-X5B",
                         shortDesc = "кулер для процессора, алюминий, рассеивание до 160 Вт, шум 26.5 дБ, вентилятор 120 мм, 1800 об/мин, PWM",
                         img = "/img/PCCooler GI-X5B.jpg",
                         price = 61,
                         isFavourite = true,
                         available = true,
                         Category = Categories["Системы охлаждения"]
                     },
                     new Car
                     {
                         name = "Корпус AeroCool Cylon (черный)",
                         shortDesc = "Mid Tower, блок питания отсутствует, для плат ATX/micro-ATX/mini-ITX, 1 вентилятор, 2xUSB 2.0, 1xUSB 3.0, окно: акрил, цвет корпуса черный",
                         img = "/img/AeroCool Cylon.jpg",
                         price = 125,
                         isFavourite = true,
                         available = true,
                         Category = Categories["Корпуса"]
                     },
					 new Car
                     {
                         name = "Wi-Fi роутер TP-Link Archer C80",
                         shortDesc = "802.11ac (Wi-Fi 5), 2.4 ГГц/5 ГГц, до 1900 Mbps, WAN, 4xGigabit LAN",
                         img = "/img/Archer_C80.jpg",
                         price = 141,
                         isFavourite = true,
                         available = true,
                         Category = Categories["Маршрутизаторы"]
                     },
					 new Car
					 {
						 name = "Коммутатор TP-Link TL-SG108",
						 shortDesc = "неуправляемый, настольный/настенный, матрица 16 Гбит/с, green, 8xGbit",
						 img = "/img/TL-SG108.jpg",
						 price = 69,
						 isFavourite = true,
						 available = true,
						 Category = Categories["Коммутаторы"]
					 },
					 new Car
					 {
						 name = "Усилитель Wi - Fi Xiaomi Range Extender Pro",
						 shortDesc = "802.11n (Wi-Fi 4), 2.4 ГГц, до 300 Mbps",
						 img = "/img/Extender_Pro.jpg",
						 price = 42,
						 isFavourite = true,
						 available = true,
						 Category = Categories["Усилители Wi-Fi"]
					 },
					 new Car
					 {
						 name = "Bluetooth адаптер TP-Link UB500",
						 shortDesc = "USB 2.0 Type-A, Bluetooth 5.0, цвет черный",
						 img = "/img/UB500.jpg",
						 price = 31,
						 isFavourite = true,
						 available = true,
						 Category = Categories["Беспроводные адаптеры"]
					 },
					 new Car
					 {
						 name = "Кабель Cablexpert PP12-20M",
						 shortDesc = "кабель RJ45, серый, длина 20 м",
						 img = "/img/cable_20m.jpg",
						 price = 9,
						 isFavourite = true,
						 available = true,
						 Category = Categories["Сетевые кабели"]
					 },
					 new Car
					 {
						 name = "Точка доступа TP-Link CPE210",
						 shortDesc = "802.11n (Wi-Fi 4), 2.4 ГГц, до 300 Mbps, 1x100Mbit LAN",
						 img = "/img/TP-Link_CPE210.jpg",
						 price = 126,
						 isFavourite = true,
						 available = true,
						 Category = Categories["Точки доступа"]
					 }, 
					 new Car
					 {
						 name = "Игровая мышь Logitech G102 Lightsync",
						 shortDesc = "проводная USB, сенсор оптический 8000 dpi, 6 кнопок, колесо с нажатием",
						 img = "/img/g102.jpg",
						 price = 75,
						 isFavourite = true,
						 available = true,
						 Category = Categories["Мыши"]
					 },
					 new Car
					 {
						 name = "Клавиатура Redragon Anivia",
						 shortDesc = "игровая для ПК, механическая, Outemu Red, ход линейный, пластик, USB, подсветка",
						 img = "/img/Anivia.jpg",
						 price = 105,
						 isFavourite = true,
						 available = true,
						 Category = Categories["Клавиатуры"]
					 }, 
					 new Car
					 {
						 name = "Коврик для мыши HyperX Fury S Pro M",
						 shortDesc = "оптические мыши/лазерные мыши, ткань, 300x360 мм, цвет черный",
						 img = "/img/HyperX_Fury.jpg",
						 price = 49,
						 isFavourite = true,
						 available = true,
						 Category = Categories["Коврики для мыши"]
					 },
					  new Car
					  {
						  name = "Геймпад Sony DualShock 4 v2",
						  shortDesc = "для Sony PlayStation 4, 2 аналоговых стика, обратная связь, беспроводной",
						  img = "/img/DualShock_4.jpg",
						  price = 240,
						  isFavourite = true,
						  available = true,
						  Category = Categories["Игровые контроллеры"]
					  },
					   new Car
					   {
						   name = "Монитор LG 22MK600M-B",
						   shortDesc = "21.5\", 16:9, 1920x1080, IPS, 75 Гц, AMD FreeSync, интерфейсы HDMI+D-Sub (VGA)",
						   img = "/img/22mk600m-b.jpg",
						   price = 320,
						   isFavourite = true,
						   available = true,
						   Category = Categories["Мониторы"]
					   },
					   new Car
					   {
						   name = "МФУ HP Laser 135a",
						   shortDesc = "МФУ, лазерный, черно-белый, формат A4 (210x297 мм), скорость ч/б печати 20 стр/мин, разрешение 1200 dpi",
						   img = "/img/Laser_135a.jpg",
						   price = 700,
						   isFavourite = true,
						   available = true,
						   Category = Categories["Принтеры"]
					   },
					   new Car
					   {
						   name = "Проектор Wanbo X1 Pro",
						   shortDesc = "презентационный, LCD, WXGA (1280x720), яркость 350 лм, контраст 2000:1, расстояние 1.5-2.5 м",
						   img = "/img/x1.jpg",
						   price = 345,
						   isFavourite = true,
						   available = true,
						   Category = Categories["Проекторы"]
					   },
					   new Car
					   {
						   name = "Акустика Redragon Orpheus",
						   shortDesc = "настольная/полочная, 2.0, мощность (RMS) 6 Вт, 300-20000 Гц, пластик, подсветка",
						   img = "/img/Orpheus.jpg",
						   price = 65,
						   isFavourite = true,
						   available = true,
						   Category = Categories["Колонки"]
					   },
					   new Car
					   {
						   name = "Наушники Redragon Themis",
						   shortDesc = "наушники с микрофоном, мониторные (охватывающие), геймерские, 20-20000 Гц, кабель 2 м",
						   img = "/img/sound_2.jpg",
						   price = 59,
						   isFavourite = true,
						   available = true,
						   Category = Categories["Наушники"]
					   }
					);
            }
            content.SaveChanges();
        }

        //переменная
        private static Dictionary<string, Category> category;
        //ключи с типом данных, второй параметр тип данных для значений переменных
        public static Dictionary<string, Category> Categories
        // метод
        {
            get
            {
                if (category == null)
                //внутри переменной ничего не записано
                {
                    var list = new Category[]
                    {


                        new Category { categoryName = "Видеокарты" },
                        new Category { categoryName = "Материнские платы" },
                        new Category { categoryName = "Процессоры" },
                        new Category { categoryName = "Оперативная память" },
                        new Category { categoryName = "Блоки питания" },
                        new Category { categoryName = "Жесткие диски" },
                        new Category { categoryName = "Твердотельные накопители" },
                        new Category { categoryName = "Системы охлаждения" },
                        new Category { categoryName = "Корпуса" },
						new Category { categoryName = "Маршрутизаторы" },
						new Category { categoryName = "Коммутаторы" },
						new Category { categoryName = "Усилители Wi-Fi" },
						new Category { categoryName = "Беспроводные адаптеры" },
						new Category { categoryName = "Сетевые кабели" },
						new Category { categoryName = "Точки доступа" },
						new Category { categoryName = "Мыши" },
						new Category { categoryName = "Клавиатуры" },
						new Category { categoryName = "Коврики для мыши" },
						new Category { categoryName = "Игровые контроллеры" },
						new Category { categoryName = "Мониторы" },
						new Category { categoryName = "Принтеры" },
						new Category { categoryName = "Проекторы" },
						new Category { categoryName = "Колонки" },
						new Category { categoryName = "Наушники" },

					};
                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                        category.Add(el.categoryName, el);
                    //создаем переменную el(за каждую иттерацию добавляем элемент)
                }
                return category;
            }
        }
    }
}