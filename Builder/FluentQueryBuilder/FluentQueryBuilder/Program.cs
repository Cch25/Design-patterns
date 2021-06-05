using CoreBuilder.FluentQueryBuilder;
using FluentQueryBuilder.FluentQuery;
using Models.FluentQueryBuilder;
using System;
using System.Text;

namespace FluentQueryBuilder
{
    class Program
    {
        /// <summary>
        /// SELECT * FROM Users 
        /// INNER JOIN UserGrade ON User.Id=UserGrade.UserId 
        /// WHERE User.Name='Culai' 
        /// or User.Name='Chiritoiu' 
        /// and User.Age>29 
        /// and UserGrade.Math>5
        /// </summary>
        static void Main()
        {
            QueryBuilder<User> qb = new QueryBuilder<User>();
            Query res = qb.SelectAll.From("Users")
                .InnerJoin<UserGrade>().On<User>(x => x.Id, y => y.UserId)
                .Where<User>(x => x.Name)
                .EqualTo("Culai").Or<User>(x => x.Name).EqualTo("Chiritoiu")
                .And<User>(x => x.Age).GreaterOrEqualTo(29)
                .And<UserGrade>(x => x.Math).GreaterOrEqualTo(5);
            Console.WriteLine(res);
        }
    }
  
}
