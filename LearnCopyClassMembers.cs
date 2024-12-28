using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlConsole
{
    internal class LearnCopyClassMembers
    {
        IRepository<ProductDetail> _repository;

        public LearnCopyClassMembers(Repository<ProductDetail> repository)
        {
            _repository = repository;
        }

        public void LeaLearnCopyClassMembersMain()
        {
            _repository.AddValue(new ProductDetail()
            {
                ProductId = 1,
                ProductInfo = "Ahmet Konanç sevilmezdir...!"
            }); _repository.AddValue(new ProductDetail()
            {
                ProductId = 2,
                ProductInfo = "Mehmet Konanç sevimlidir!"
            });

        }
    }
    public class ProductClass
    {
        public int ProductId { get; set; }
        public string EmplooyesName { get; set; }
        public string Description { get; set; }
        public string ProductInfo { get; set; }
    }
    public class ProductDetail
    {
        public int ProductId { get; set; }
        public string ProductInfo { get; set; }
    }
    public class ContextEntity<T>
    {
        public List<T> ProductList { get; set; } = new();
    }
    public interface IRepository<T>
    {
        ContextEntity<T> _contextEntity { get; set; }
        public IEnumerable<T> GetValues();
        public void AddValue(T value);
    }
    public class Repository<T> : IRepository<T> where T : new()
    {
        public ContextEntity<T> _contextEntity { get; set; }
        public Repository(ContextEntity<T> contextEntity)
        {
            _contextEntity = contextEntity;
        }
        public void AddValue(T value)
        {
            _contextEntity.ProductList.Add(value);
        }
        public IEnumerable<T> GetValues()
        {
            foreach (var item in _contextEntity.ProductList)
            {
                yield return item;
            }
        }
    }
}
