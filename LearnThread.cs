using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ControlConsole
{
    public class ListItems
    {
        public int ProductId { get; set; }
        public string EmplooyesName { get; set; }
    }
    public class LearnThread
    {
        List<ListItems> ListItem = new()
        {
            new ListItems() {ProductId = 1, EmplooyesName = "Ahmet"},
            new ListItems() {ProductId = 2, EmplooyesName = "Ahmet"},
            new ListItems() {ProductId = 3, EmplooyesName = "Osman"},
            new ListItems() {ProductId = 4, EmplooyesName = "Ahmet"},
            new ListItems() {ProductId = 5, EmplooyesName = "Kamil"},
        };
        public delegate void DelegateInheritance();
        public List<ListItems> Filter(Func<ListItems, bool> func)
        {
            List<ListItems> myList = new();
            foreach (var item in ListItem)
            {
                if (func(item))
                {
                    myList.Add(item);
                }
            }
            return myList;
        }
        public string Main(int a, int b)
        {
            return FilterTest((x, y) =>
            {
                return $"{a + b}";
            });
        }
        public string FilterTest(Func<int, int, string> func)
        {
            var anonymousMethod = (Func<int, int, string> anonymousFunc) =>
            {
                return $"İşlem Sonucunuz : {anonymousFunc(10, 20)}";
            };
            return anonymousMethod((x, y) => func(x, y));
        }

    }
}
