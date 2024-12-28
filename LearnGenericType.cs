using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlConsole
{
     public class Product
     { 
        public int ProductId { get; set; }
        public string EmplooyesName { get; set; }
     }
     public static class Context<T> where T : Product
     {
       public static List<T> ListForEntities { get; set; } = new List<T>();
     }
    public class LearnGenericType
    {
        IAllFunctions<Product> _allFunctions;

        public LearnGenericType(ProductRepository allFunctions)
        {
            _allFunctions = allFunctions;
            _allFunctions.ListForAdd(new Product { ProductId = 2332145, EmplooyesName = "Robot Süpürge" });
            _allFunctions.ListForAdd(new Product { ProductId = 2231344, EmplooyesName = "Buzdolabı" });
            _allFunctions.ListForAdd(new Product { ProductId = 2231223, EmplooyesName = "Bulaşık Makinası" });
            _allFunctions.ListForAdd(new Product { ProductId = 2231335, EmplooyesName = "Çamaşır Makinası" });
            _allFunctions.ListForAdd(new Product { ProductId = 2313378, EmplooyesName = "Derin Dondurucu" });
            _allFunctions.ListForAdd(new Product { ProductId = 2123408, EmplooyesName = "Masaüstü Bilgisayar" });
            _allFunctions.ListForAdd(new Product { ProductId = 2125663, EmplooyesName = "Dizüstü Bilgisayar" });
            _allFunctions.ListForAdd(new Product { ProductId = 2108423, EmplooyesName = "Akıllı Telefon" });
            _allFunctions.ListForAdd(new Product { ProductId = 2192120, EmplooyesName = "Mikser (Mutfak Robotu)" });
            _allFunctions.ListForAdd(new Product { ProductId = 2210032, EmplooyesName = "Davlumbaz" });
            _allFunctions.ListForAdd(new Product { ProductId = 2210033, EmplooyesName = "Aspirator" });
        }

        public void LearnGenericTypeMain()
        {
            foreach(var item in _allFunctions.ListForAllGet())
            {
                Console.WriteLine($"** [{item.ProductId}] Numaralı [{item.EmplooyesName}] Adında Ürünümüz Bulunmaktadır...");
            }
        }
    }
    public interface IAllFunctions<T>
    {
        void ListForAdd(T Entity);
        void ListForRemove(int Index);
        T ListForGet(int Index);
        List<T> ListForAllGet();
    }
    public class AllFunctions<T> : IAllFunctions<T> where T : Product
    {
        public void ListForAdd(T Entity) 
        {
            Context<Product>.ListForEntities.Add(Entity);
        }

        public List<T> ListForAllGet()
        {
            return Context<T>.ListForEntities;
        }

        public T ListForGet(int Index)
        {
            return Context<T>.ListForEntities.FirstOrDefault(x => x.ProductId == Index);
        }

        public void ListForRemove(int Index)
        {
            var productInfo = Context<T>.ListForEntities.FirstOrDefault(x => x.ProductId == Index);
            Context<T>.ListForEntities.Remove(productInfo);
        }
    }
        public interface IProductRepository : IAllFunctions<Product>
        {

        }
        public class ProductRepository : AllFunctions<Product>, IProductRepository
        {
            
            
        }
    
}
