namespace Paedagogus.Domain.Posts
{
    public class PostId : Identity
    {
        public PostId() { /* empty ctor */ }

        public PostId(string id) 
            : base(id)
        {
            /* empty ctor */
        }
    }
}