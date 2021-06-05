using CoreBuilder.FluentQueryBuilder;
using FluentQueryBuilder;
using FluentQueryBuilder.FluentQuery;

namespace FluentQuery.FluentQueryBuilder
{
    public class BaseQuery<T> : QueryBuilder<T>
    {
        public BaseQuery(Query query, params string[] param)
        {
            Query = query;
            query.BuiltQuery.Append("SELECT ");

            Query.BuiltQuery.Append(string.Join(", ", param));
        }
        public BaseQuery(Query query)
        {
            Query = query;
            query.BuiltQuery.Append("SELECT *");
        }
        public BaseQuery<T> From(string from)
        {
            Query.BuiltQuery.Append($" FROM {from}");
            return this;
        }
    }
}
