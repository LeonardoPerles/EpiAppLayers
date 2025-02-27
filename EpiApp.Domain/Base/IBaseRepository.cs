namespace EpiApp.Domain.Base
{
    public interface IBaseRepository<TEntity>
        where TEntity : IBaseEntity
    {
        void ClearChangeTracker();
        void AttachObject(object obj);
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(object id);
        //GetAll
        IList<TEntity> Select(bool tracking = true, IList<string>? includes = null);
        //FindById
        TEntity Select(object id, bool tracking = true, IList<string>? includes = null);
    }
}
