using System.Text;

namespace FluentQueryBuilder.FluentQuery
{
    public class Query
    {
        public StringBuilder BuiltQuery { get; set; }
        public Query()
        {
            BuiltQuery = new StringBuilder();
        }
        public override string ToString()
        {
            return BuiltQuery.ToString();
        }
    }
}
