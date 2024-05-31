

namespace UstamYolda.Core.Aggregates.Entities.Base
{
    public class BaseClass
    {
        public Guid Id { get;  set; }
        public DateTime CreateDate { get; private set; }    
        public DateTime DeletedDate { get; private set; }    
        public bool IsDelete { get; private set; }  
        
        public void IsDalete()
        {
            IsDelete = true;
        }
    }
}
