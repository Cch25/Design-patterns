using System;
using System.Linq.Expressions;

namespace Helpers.FluentQueryBuilder
{
    public static class Extensions
    {
        public static string GetCorrectPropertyName<T>(this Expression<Func<T, object>> expression)
        {
            if (expression.Body is MemberExpression)
            {
                return ((MemberExpression)expression.Body).Member.Name;
            }
            else
            {
                var op = ((UnaryExpression)expression.Body).Operand;
                return ((MemberExpression)op).Member.Name;
            }
        }
    }
}
