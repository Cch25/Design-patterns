using FluentQuery.FluentQueryBuilder;
using FluentQueryBuilder;
using FluentQueryBuilder.FluentQuery;
using System;
using System.Linq.Expressions;

namespace CoreBuilder.FluentQueryBuilder
{
    public class QueryBuilder<T> : IQueryBuilder<T>
    {
        protected Query Query = new Query();
        public BaseQuery<T> Select(params string[] parameters) => new BaseQuery<T>(Query, parameters);
        public BaseQuery<T> SelectAll => new BaseQuery<T>(Query);
        public Where<TWhere> Where<TWhere>(Expression<Func<TWhere, dynamic>> expression) => new Where<TWhere>(Query, expression);
        public InnerJoin<Table> InnerJoin<Table>() => new InnerJoin<Table>(Query, typeof(Table).Name);
        public InnerJoin<Table> InnerJoin<Table>(string table) => new InnerJoin<Table>(Query, table);

        public static implicit operator Query(QueryBuilder<T> qb) => qb.Query;
    }
}
