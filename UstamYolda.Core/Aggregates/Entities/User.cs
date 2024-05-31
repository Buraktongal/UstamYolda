
using UstamYolda.Core.Aggregates.Entities.Base;

namespace UstamYolda.Core.Aggregates.Entities
{
    public class User:BaseClass
    {
        public User(string name)
        {
            Id=Guid.NewGuid();
            name = Name;
        }
        public string Name { get; private set; }

        public void Update(string name)
        {
            name = Name;
        }
    }
}
