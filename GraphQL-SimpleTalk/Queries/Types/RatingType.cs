using GraphQL.Types;
using GraphQL_SimpleTalk.Entities;
namespace GraphQL_SimpleTalk.Queries.Types
{
    public class RatingType : ObjectGraphType<Rating>
    {
        public RatingType()
        {
            Field(x => x.Count);
            Field(x => x.Percent);
        }
    }
}