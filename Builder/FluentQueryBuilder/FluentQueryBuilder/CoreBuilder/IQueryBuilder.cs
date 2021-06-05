using FluentQuery.FluentQueryBuilder;

namespace CoreBuilder.FluentQueryBuilder
{
    public interface IQueryBuilder<T>
    {
        BaseQuery<T> SelectAll { get; }

        InnerJoin<Table> InnerJoin<Table>();
        InnerJoin<Table> InnerJoin<Table>(string table);
        BaseQuery<T> Select(params string[] parameters);
        Where<TWhere> Where<TWhere>(System.Linq.Expressions.Expression<System.Func<TWhere, dynamic>> expression);
    }
}