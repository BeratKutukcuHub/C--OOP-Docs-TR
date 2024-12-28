using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlConsole
{
    public class Order
    {
        public int OrderId { get; set; }
        public string OrderName { get; set; }
        public bool IsCompleted { get; set; }
    }
    public class LearnRecursive
    {
        int field;
        List<Order> orders = new List<Order>()
        {
            new Order(){OrderId = 1, OrderName = "Litvanya", IsCompleted = true},
            new Order(){OrderId = 2, OrderName = "Arnavutluk", IsCompleted = false},
            new Order(){OrderId = 3, OrderName = "Slovenya", IsCompleted = false},
            new Order(){OrderId = 4, OrderName = "Cezayir", IsCompleted = false},
            new Order(){OrderId = 5, OrderName = "Fas", IsCompleted = true},
            new Order(){OrderId = 6, OrderName = "Türkiye", IsCompleted = true},
        };
        public void LearnRecursiveMain()
        {
            field = orders.Count;
            object[] list = new object[field];
            
            for (int i = 0; i < list.Length; i++)
            {
                list[i] = (object)MyForeach(orders);
                if (list[i] != null)
                {
                    Order currentOrder = (Order)list[i];
                    Console.WriteLine($"SiparişId: {currentOrder.OrderId}, Sipariş Bölgesi: {currentOrder.OrderName}, Sonuç: {currentOrder.IsCompleted}");
                }
            }
        }
        private T MyForeachItem<T>(T items)
        {
            return items;
        }
        private T MyForeachGet<T>(T item, List<T> list)
        {
            MyForeachItem(item);
            list.RemoveAt(list.Count - 1);
            if (list.Count == 0)
                return item;
            return MyForeach(list);
        }
        private T MyForeach<T>(List<T> list)
        {
            if (list.Count == 0)
                return default;
            T lastItem = list[list.Count - 1];
            return MyForeachGet(lastItem, list);
        }
    }


}
