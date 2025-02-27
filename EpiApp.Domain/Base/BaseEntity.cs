namespace EpiApp.Domain.Base
{
    public class BaseEntity<TID> : IBaseEntity
    {
        public BaseEntity()
        {
            
        }
        public BaseEntity(TID id)
        {
            Id = id;
        }
        
        public TID? Id { get; set; }
    }
}