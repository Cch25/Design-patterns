namespace MapperPattern
{
    public class XEntityMapper : BaseMapper<XEntity, YEntity>
    {
        public XEntityMapper()
        {

        }
        public override YEntity Map(XEntity entity, YEntity entityTransformed)
        {
            entityTransformed.PersonAge = entity.Age;
            entityTransformed.PersonName = entity.Name;
            return entityTransformed;
        }
    }
}