using CoreBuilder.FluentQueryBuilder;
using FluentQueryBuilder;
using FluentQueryBuilder.FluentQuery;
using Helpers.FluentQueryBuilder;
using System;
using System.Linq.Expressions;

namespace FluentQuery.FluentQueryBuilder
{
    public class Where<T> : QueryBuilder<T>
    {
        public Where(Query query, Expression<Func<T, dynamic>> expression)
        {
            Query = query;
            string name = expression.GetCorrectPropertyName();
            Query.BuiltQuery.Append($" WHERE {typeof(T).Name}.{name}");
        }

        public Where<T> And<TAnd>(Expression<Func<TAnd, dynamic>> expression) => AndOr(expression, "and");

        public Where<T> GreaterThan(int value)
        {
            Query.BuiltQuery.Append($">{value}");
            return this;
        }
        public Where<T> GreaterOrEqualTo(int value)
        {
            Query.BuiltQuery.Append($">{value}");
            return this;
        }
        public Where<T> Or<TOr>(Expression<Func<TOr, dynamic>> expression) => AndOr(expression, "or");

        public Where<T> EqualTo(dynamic value)
        {
            Type unknown = value.GetType();
            if (unknown == typeof(string) || unknown == typeof(Guid))
            {
                Query.BuiltQuery.Append($"='{value}'");
                return this;
            }
            Query.BuiltQuery.Append($"={value}");
            return this;
        }

        private Where<T> AndOr<TAndOr>(Expression<Func<TAndOr, dynamic>> expression, string andOr)
        {
            string name = expression.GetCorrectPropertyName();
            Query.BuiltQuery.Append($" {andOr} {typeof(TAndOr).Name}.{name}");
            return this;
        }

    }
}
