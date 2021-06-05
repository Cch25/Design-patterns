using CoreBuilder.FluentQueryBuilder;
using FluentQueryBuilder;
using FluentQueryBuilder.FluentQuery;
using Helpers.FluentQueryBuilder;
using System;
using System.Linq.Expressions;

namespace FluentQuery.FluentQueryBuilder
{
    public class InnerJoin<T> : QueryBuilder<T>
    {
        private readonly string currTable;

        public InnerJoin(Query query, string table)
        {
            Query = query;
            Query.BuiltQuery.Append($" INNER JOIN {table}");
            this.currTable = table;
        }
        public InnerJoin<T> On<Table>(Expression<Func<Table, dynamic>> tableLeft, Expression<Func<T, dynamic>> tableRight)
        {
            string nameLeft = tableLeft.GetCorrectPropertyName();
            string nameRight = tableRight.GetCorrectPropertyName();
            Query.BuiltQuery.Append($" ON {typeof(Table).Name}.{nameLeft}={currTable}.{nameRight}");
            return this;
        }
    }
}
