using Shop.Data.interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Repository
{
    public class OrdersRepository : IAllOrders
    {
        private readonly AppDBContent appDBContent;
        private readonly ShopCart shopCart;
        public OrdersRepository(AppDBContent appDBContent, ShopCart shopCart)
        {//конструктор для задания значений этих переменных
            this.appDBContent = appDBContent;
            this.shopCart = shopCart;
        }
        public void createOrder(Order order)
        {
            order.orderTime = DateTime.Now;
            // устанавливаем время то какое во время заказа
            appDBContent.Order.Add(order);
            var items = shopCart.listShopItems;
            //перепенная содержащая все товары которые выбрал покупатель
            foreach (var el in items)
            {
                var orderDetail = new OrderDetail()
                {//перебираем все характеристики(class OrderDetail)
                    CarID = el.car.id,
                    orderID = order.id,
                    price = el.car.price,
                    order = order
                };
                appDBContent.OrderDetail.Add(orderDetail);
            }
            appDBContent.SaveChanges();
            //сохраняем в базу данных все изменения
        }
    }
}