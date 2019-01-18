using GraphQL.Types;
using GraphQL_SimpleTalk.Entities;
namespace GraphQL_SimpleTalk.Queries.Types
{
    public class CommentType : ObjectGraphType<Comment>
    {
        public CommentType()
        {
            Field(x => x.Count);
            Field(x => x.Description);
            Field(x => x.Url);
        }
    }
}