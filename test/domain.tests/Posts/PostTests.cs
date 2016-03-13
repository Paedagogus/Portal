namespace thrownewexception.com.domain.tests
{
    using System;
    using Xunit;
    using thrownewexception.com.domain.posts;
    
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