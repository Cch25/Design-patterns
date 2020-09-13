namespace MapperPattern
{
    public interface IMapper<TEntity, TTransformed>
    {
        TTransformed Map(TEntity entity, TTransformed entityTransformed);
    }
}
