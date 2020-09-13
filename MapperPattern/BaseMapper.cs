namespace MapperPattern
{
    public abstract class BaseMapper<TEntity, TTransformed> : IMapper<TEntity, TTransformed>
        where TEntity : class
        where TTransformed : class
    {
        public abstract TTransformed Map(TEntity entity, TTransformed entityTransformed);
    }
}
