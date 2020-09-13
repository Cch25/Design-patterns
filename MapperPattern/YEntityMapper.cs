namespace MapperPattern
{
    public class YEntityMapper : BaseMapper<YEntity, XEntity>
    {
        public YEntityMapper()
        {

        }
        public override XEntity Map(YEntity entity, XEntity entityTransformed)
        {
            entityTransformed.Age = entity.PersonAge;
            entityTransformed.Name = entity.PersonName;
            return entityTransformed;
        }
    }
}