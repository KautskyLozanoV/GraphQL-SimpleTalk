using GraphQL.Types;
using GraphQL_SimpleTalk.Entities;
namespace GraphQL_SimpleTalk.Queries.Types
{
    public class SocialNetworkType : ObjectGraphType<SocialNetwork>
    {
        public SocialNetworkType()
        {
            Field(x => x.NickName);
            Field<EnumerationGraphType<SNType>>("type");
            Field(x => x.Url);
            Field<AuthorType>("author");
        }
    }
}