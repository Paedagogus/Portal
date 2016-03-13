namespace Paedagogus.Domain.Posts
{
    using Paedagogus.Domain.Posts.Events;

    public class Post : Aggregate
    {
        public PostId PostId { get; private set; }

        public string Title { get; private set; }

        public string Description { get; private set; }

        public string Content { get; private set; }

        public Post()
        {
            Register<PostCreated>(Apply);
            Register<PostContentAdded>(Apply);
        }

        public Post(PostId postId, string title, string description)
           : this()
        {
            var postCreated = new PostCreated(postId, title, description);
            RaiseEvent(postCreated);
        }
        
        public void AddContent(string content)
        {
            var postContentAdded = new PostContentAdded(this.PostId, this.Content);
            RaiseEvent(postContentAdded);
        }

        private void Apply(PostContentAdded @event)
        {
            this.Content = @event.Content;
        }

        private void Apply(PostCreated @event)
        {
            this.PostId = @event.PostId;
            this.Title = @event.Title;
            this.Description = @event.Description;
        }
    }
}