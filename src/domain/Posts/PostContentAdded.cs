namespace thrownewexception.com.domain.posts.events
{
    using System;
    
    public class PostContentAdded : IDomainEvent
    {
        public PostContentAdded(PostId postId, string content)
        {
            this.PostId = PostId;
            this.Content = content;
            this.CreatedOnUtc = DateTime.UtcNow;
        }
        
        public PostId PostId { get; private set; }
        
        public string Content { get; private set; }
        
        public int Version { get; set; }
        
        public DateTime CreatedOnUtc { get; set; }
    }
}