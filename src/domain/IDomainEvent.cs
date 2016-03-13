namespace thrownewexception.com.domain
{
    using System;
    
    public interface IDomainEvent
    {
        int Version { get; }
        
        DateTime CreatedOnUtc { get; }
    }
}