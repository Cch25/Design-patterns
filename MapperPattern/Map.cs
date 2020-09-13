using System;
namespace MapperPattern
{
    public class MapperExample
    {
        public void Map()
        {
            XEntity entity = new XEntity() { Age = 28, Name = "Culai" };
            XEntityMapper mapper = new XEntityMapper();
            
            YEntity mapped  = mapper.Map(entity, new YEntity());
            Console.WriteLine($"Name {mapped.PersonName} of age {mapped.PersonAge}");
        }
    }
}
