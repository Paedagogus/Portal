namespace Paedagogus.Domain.Posts.Tests
{
    using System;
    using Xunit;
    using Paedagogus.Domain.Posts;
    
    public class PostTests
    {
        [Fact]
        public void CreatingAPost_GetsTheRightStateOnTheInstance()
        {
            var postId = new PostId(Guid.NewGuid().ToString());
            
            var post = new Post(postId, "title", "description");
            Assert.Equal(postId, post.PostId);
            Assert.Equal("title", post.Title);
            Assert.Equal("description", post.Description);
        }
    }
}