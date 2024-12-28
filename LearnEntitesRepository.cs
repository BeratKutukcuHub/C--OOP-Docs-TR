using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlConsole
{
    public class LearnEntitesRepository
    {
        IRepositoryMain<ProductEntity> _repositoryMain;
        public LearnEntitesRepository(RepositoryMain<ProductEntity> repositoryMain)
        {
            _repositoryMain = repositoryMain;
        }
        public void LearnFuncActionEntitiesMain()
        {
            _repositoryMain.Add(new ProductEntity()
            {
                firstEmplooyesName = "Ahmet",
                secondEmplooyesName = "Mehmet",
                ProductId = 1
            });
            Console.WriteLine($"{_repositoryMain.GetEntity(1).firstEmplooyesName}");
        }
    }
    public interface WantToEntityInfo
    {
        int ProductId { get; set; }
    }
    public class ProductEntity : WantToEntityInfo
    {
        public int ProductId { get; set; }
        public string firstEmplooyesName { get; set; }
        public string secondEmplooyesName { get; set; }
    }
    public class ContextEntities<T>
    {
        public List<T> ContextList { get; set; } = new List<T>();
    }
    public interface IRepositoryMain<T>
    {
        void Remove(T context);
        void Add(T entity);
        void Update(T entity);
        T GetEntity(int entityId);
        List<T> GetEntities();
    }
    public class RepositoryMain<T> : IRepositoryMain<T> where T : WantToEntityInfo
    {
        ContextEntities<T> _contextEntities;
        public RepositoryMain(ContextEntities<T> contextEntities)
        {
            _contextEntities = contextEntities;
        }
        public void Add(T entity)
        {
            _contextEntities.ContextList.Add(entity);
        }

        public List<T> GetEntities()
        {
            return _contextEntities.ContextList;
        }

        public T GetEntity(int entityId)
        {
            return _contextEntities.ContextList.FirstOrDefault(x => x.ProductId == entityId);
        }

        public void Remove(T context)
        {
            _contextEntities.ContextList.Remove(context);
        }

        public void Update(T entity)
        {
            T entityInfo = GetEntity(entity.ProductId);
            Remove(entityInfo);
            _contextEntities.ContextList.Add(entity);
        }

    }
}
