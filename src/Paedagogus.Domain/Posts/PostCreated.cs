namespace Paedagogus.Domain.Posts.Events
{
    using System;
    
    public class PostCreated : IDomainEvent
    {
        public PostCreated(PostId postId, string title, string description)
        {
            this.PostId = postId;
            this.Title = title;
            this.Description = description;
            this.CreatedOnUtc = DateTime.UtcNow;
        }
        
        public PostId PostId { get; private set; }
        
        public string Title { get; private set; }
        
        public string Description { get; private set; }
        
        public int Version { get; set; }
        
        public DateTime CreatedOnUtc { get; set; }
    }
}